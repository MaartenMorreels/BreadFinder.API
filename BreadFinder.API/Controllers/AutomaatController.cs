using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL;
using BreadFinder.API.DAL.Repos;
using BreadFinder.API.DAL.ENT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BreadFinder.API.BLL;

namespace BreadFinder.API.Controllers
{
    [Produces("application/json")]
    [Route("api/automaten")]
    public class AutomaatController : Controller
    {
        private readonly IAutomaatRepository _automaatRepo;
        private readonly IEigenaarRepository _eigenaarRepo;
        private readonly IAutomatenListItemDTO _automatenListItemMapper;
        private readonly IAutomaatDTO _automaatMapper;
        private readonly IEigenaarDTO _eigenaarMapper;

        public AutomaatController
            (IAutomaatRepository automaatRepo, 
            IEigenaarRepository eigenaarRepo, 
            IAutomatenListItemDTO automatenListItemMapper,
            IAutomaatDTO automaatMapper,
            IEigenaarDTO eigenaarMapper)
        {
            _automaatRepo = automaatRepo;
            _eigenaarRepo = eigenaarRepo;
            _automatenListItemMapper = automatenListItemMapper;
            _automaatMapper = automaatMapper;
            _eigenaarMapper = eigenaarMapper;
        }

        // GET api/automaten
        [HttpGet("")]
        public IActionResult Get()
        {
            var automaten = _automaatRepo.GetAll();
            var automatenListItemDTOs = automaten.Select(a => _automatenListItemMapper.ConvertToListItemDTO(a));
            return Ok(automatenListItemDTOs);
        }

        // GET api/automaten/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var automaat = _automaatRepo.GetById(id);
            if (automaat == null)
            {
                return NotFound();
            }

            var automatenListItemDTO = _automatenListItemMapper.ConvertToListItemDTO(automaat);

            return Ok(automatenListItemDTO);
        }

        // GET api/automaten/leuven
        [HttpGet("{gemeente}")]
        public IActionResult GetByGemeente(string gemeente)
        {
            var automaten = _automaatRepo.GetByGemeente(gemeente);

            if (!automaten.Any())
            {
                return NotFound();
            }

            var automatenListItemDTOs = automaten.Select(a => _automatenListItemMapper.ConvertToListItemDTO(a));

            return Ok(automatenListItemDTOs);
        }

        // GET api/automaten/antwerpen
        [HttpGet("{provincie}")]
        public IActionResult GetByProvincie(string provincie)
        {
            var automaten = _automaatRepo.GetByProvincie(provincie);

            if (!automaten.Any())
                return NotFound();

            var automatenListItemDTOs = automaten.Select(a => _automatenListItemMapper.ConvertToListItemDTO(a));

            return Ok(automatenListItemDTOs);
        }

        [HttpPost]
        public IActionResult Add([FromBody]AutomaatDTO automaatDTO)
        {
            try
            {
                //to ensure no duplicate values are inserted
                if (_automaatRepo.GetAll().Any(a => a.Straat == automaatDTO.Straat && a.HuisNr == automaatDTO.HuisNr && a.PlaatsId == automaatDTO.PlaatsId))
                {
                    return BadRequest("a record with the same combination of values for Straat/HuisNr/PlaatsId already exists");
                }

                var automaat = new Automaat
                {
                    Straat = automaatDTO.Straat,
                    HuisNr = automaatDTO.HuisNr,
                    PlaatsId = automaatDTO.PlaatsId,
                    EigenaarId = automaatDTO.EigenaarId,
                    Plaats = null,
                    Eigenaar = null
                };
                _automaatRepo.Add(automaat);
                var toegevoegdeAutomaat = _automaatMapper.ConvertToDTO(automaat);
                return Ok(toegevoegdeAutomaat);
            }
            catch(Exception)
            {
                return StatusCode(500);
            }
            
        }

        [HttpPut]
        public IActionResult Update([FromBody]AutomaatDTO automaatDTO)
        {
            try
            {
                //Bij een update worden automaatPlaatsId en eigenaarPlaatsId meegegeven(dropdown menu in de update tab) 
                var oudeAutomaat = _automaatRepo.GetById(automaatDTO.Id);
                if (oudeAutomaat == null) return NotFound($"Kon geen automaat vinden met id {automaatDTO.Id}");

                if (_automaatRepo.GetAll().Any(a => a.Straat == automaatDTO.Straat && a.HuisNr == automaatDTO.HuisNr && a.PlaatsId == automaatDTO.PlaatsId))
                {
                    return BadRequest("a record with the same combination of values for Straat/HuisNr/PlaatsId already exists");
                }
                oudeAutomaat.Straat = automaatDTO.Straat;
                oudeAutomaat.HuisNr = automaatDTO.HuisNr;
                oudeAutomaat.PlaatsId = automaatDTO.PlaatsId;
                oudeAutomaat.EigenaarId = automaatDTO.EigenaarId;
                oudeAutomaat.Plaats = null;
                oudeAutomaat.Eigenaar = null;

                _automaatRepo.Update(oudeAutomaat);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "internal server error");
            }
        }

        [HttpDelete("{Id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _automaatRepo.Delete(id);
                return Ok();
            }
            catch(Exception)
            {
                return StatusCode(400, "Er is geen automaat met deze Id in database");
            }
        }
    }
}