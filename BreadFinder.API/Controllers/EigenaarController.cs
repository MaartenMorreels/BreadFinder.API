using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BreadFinder.API.DAL.Repos;
using BreadFinder.API.BLL;
using BreadFinder.API.DAL.ENT;

namespace BreadFinder.API.Controllers
{
    [Produces("application/json")]
    [Route("api/eigenaars")]
    public class EigenaarController : Controller
    {
        private readonly IEigenaarRepository _eigenaarRepo;
        private readonly IEigenaarDTO _eigenaarMapper;

        public EigenaarController(IEigenaarRepository eigenaarRepo, IEigenaarDTO eigenaarMapper)
        {
            _eigenaarRepo = eigenaarRepo;
            _eigenaarMapper = eigenaarMapper;
        }

        // GET api/eigenaars
        [HttpGet("")]
        public IActionResult GetAll()
        {
            var eigenaars = _eigenaarRepo.GetAll();
            if (!eigenaars.Any())
            {
                return NotFound();
            }
            var eigenaarDTOs = eigenaars.Select(e => _eigenaarMapper.ConvertToEigenaarDTO(e));
            return Ok(eigenaarDTOs);
        }

        // GET api/eigenaars/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var eigenaar = _eigenaarRepo.GetEigenaarById(id);
            if (eigenaar == null)
            {
                return NotFound();
            }
            var eigenaarDTO = _eigenaarMapper.ConvertToEigenaarDTO(eigenaar);
            return Ok(eigenaarDTO);
        }

        //GET api/eigenaars/naam
        [HttpGet("{naam}")]
        public IActionResult GetByName(string naam)
        {
            var eigenaarsMetZelfdeNaam = _eigenaarRepo.GetEigenaarsByNaam(naam);
            if (!eigenaarsMetZelfdeNaam.Any())
            {
                return NotFound(); 
            }
            var eigenaarDTOs = eigenaarsMetZelfdeNaam.Select(e => _eigenaarMapper.ConvertToEigenaarDTO(e));
            return Ok(eigenaarDTOs);
        }

        //POST api/eigenaars/
        [HttpPost]
        public IActionResult Add(EigenaarDTO eigenaarDTO)
        {
            try
            {
                //to ensure no duplicate values are inserted
                if (_eigenaarRepo.GetAll().Any(e => e.Naam == eigenaarDTO.Naam
                && e.Straat == eigenaarDTO.Straat
                && e.HuisNr == eigenaarDTO.HuisNr
                && e.PlaatsId == eigenaarDTO.PlaatsId
                && e.Telefoon == eigenaarDTO.TelefoonNr
                && e.Email == eigenaarDTO.Email
                && e.Website == eigenaarDTO.Website))
                {
                    return BadRequest("a record with the same combination of property values already exists");
                }

                var eigenaar = _eigenaarMapper.ConvertToEigenaarENT(eigenaarDTO);
                _eigenaarRepo.Add(eigenaar);
                var nieuweEigenaarDTO = _eigenaarMapper.ConvertToEigenaarDTO(eigenaar);

                return Ok(nieuweEigenaarDTO);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        //PUT api/eigenaars
        [HttpPut]
        public IActionResult Update(EigenaarDTO eigenaarDTO)
        {
            try
            {
                //Bij een update worden automaatPlaatsId en eigenaarPlaatsId meegegeven(dropdown menu in de update tab) 
                var oudeEigenaar = _eigenaarRepo.GetEigenaarById(eigenaarDTO.EigenaarId);
                if (oudeEigenaar == null) return NotFound($"Kon geen automaat vinden met id {eigenaarDTO.EigenaarId}");

                //to ensure no duplicate values are inserted
                if (_eigenaarRepo.GetAll().Any(e => e.Naam == eigenaarDTO.Naam
                && e.Straat == eigenaarDTO.Straat
                && e.HuisNr == eigenaarDTO.HuisNr
                && e.PlaatsId == eigenaarDTO.PlaatsId
                && e.Telefoon == eigenaarDTO.TelefoonNr
                && e.Email == eigenaarDTO.Email
                && e.Website == eigenaarDTO.Website))
                {
                    return BadRequest("a record with the same combination of property values already exists");
                }

                oudeEigenaar.Straat = eigenaarDTO.Straat;
                oudeEigenaar.HuisNr = eigenaarDTO.HuisNr;
                oudeEigenaar.PlaatsId = eigenaarDTO.PlaatsId;
                oudeEigenaar.Telefoon = eigenaarDTO.TelefoonNr;
                oudeEigenaar.Email = eigenaarDTO.Email;
                oudeEigenaar.Website = eigenaarDTO.Website;
                oudeEigenaar.Plaats = null;
                oudeEigenaar.Automaat = null;

                _eigenaarRepo.Update(oudeEigenaar);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500, "internal server error");
            }
        }
        
    }
}