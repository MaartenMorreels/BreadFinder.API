using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL.ENT;

namespace BreadFinder.API.BLL
{
    public class AutomaatDTO : IAutomaatDTO
    {
        public int Id { get; set; }
        public string Straat { get; set; }
        public string HuisNr { get; set; }
        public int PlaatsId { get; set; }
        public int EigenaarId { get; set; }

        public Automaat ConvertToEnt(AutomaatDTO automaatDTO)
        {
            var automaat = new Automaat
            {
                Id = automaatDTO.Id,
                Straat = automaatDTO.Straat,
                HuisNr = automaatDTO.HuisNr,
                PlaatsId = automaatDTO.PlaatsId,
                EigenaarId = automaatDTO.EigenaarId,
                Plaats = null,
                Eigenaar = null
            };
            return automaat;
        }

        public AutomaatDTO ConvertToDTO(Automaat automaat)
        {
            var automaatDTO = new AutomaatDTO
            {
                Id = automaat.Id,
                Straat = automaat.Straat,
                HuisNr = automaat.HuisNr,
                PlaatsId = automaat.PlaatsId,
                EigenaarId = automaat.EigenaarId
            };
            return automaatDTO;
        }
    }

    
}
