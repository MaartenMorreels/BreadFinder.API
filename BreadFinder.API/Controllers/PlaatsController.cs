using BreadFinder.API.BLL;
using BreadFinder.API.DAL.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BreadFinder.API.Controllers
{
    [Produces("application/json")]
    [Route("api/plaatsen")]
    public class PlaatsController : Controller
    {
        private readonly IPlaatsRepository _plaatsRepo;
        private readonly IPlaatsDTO _plaatsMapper;

        public PlaatsController(IPlaatsRepository plaatsRepo, IPlaatsDTO plaatsMapper)
        {
            _plaatsRepo = plaatsRepo;
            _plaatsMapper = plaatsMapper;
        }

        // GET api/plaatsen
        [HttpGet("")]
        public IActionResult Get()
        {
            var plaatsen = _plaatsRepo.GetAll();
            var plaatsDTOs = plaatsen.Select(a => _plaatsMapper.ConvertToPlaatsDTO(a));
            return Ok(plaatsDTOs);
        }

        // GET api/plaatsen/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var plaats = _plaatsRepo.GetById(id);
            if (plaats == null)
            {
                return NotFound();
            }

            var plaatsDTO = _plaatsMapper.ConvertToPlaatsDTO(plaats);

            return Ok(plaatsDTO);
        }

        // GET api/plaatsen/Leuven
        [HttpGet("{plaatsnaam}")]
        public IActionResult GetByPlaatsNaam(string plaatsnaam)
        {
            var plaatsenMetZelfdeNaam = _plaatsRepo.GetByPlaatsNaam(plaatsnaam);
            if (!plaatsenMetZelfdeNaam.Any())
            {
                return NotFound();
            }
            var plaatsDTOs = plaatsenMetZelfdeNaam.Select(p => _plaatsMapper.ConvertToPlaatsDTO(p));
            return Ok(plaatsDTOs);
        }

        [HttpPost]
        public IActionResult Add(PlaatsDTO plaatsDTO)
        {
            var plaats = _plaatsMapper.ConvertToPlaatsENT(plaatsDTO);
            _plaatsRepo.Add(plaats);
            return Ok(plaats);
        }
    }
}