using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadFinder.API.DAL.ENT;

namespace BreadFinder.API.BLL
{
    public class EigenaarDTO : IEigenaarDTO
    {
        public int EigenaarId { get; set; }
        public string Naam { get; set; }
        public string Straat { get; set; }
        public string HuisNr { get; set; }
        public int PlaatsId { get; set; }
        public string PostCode { get; set; }
        public string Gemeente { get; set; }
        public string TelefoonNr { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }

        public EigenaarDTO ConvertToEigenaarDTO(Eigenaar eigenaar)
        {
            var eigenaarDTO = new EigenaarDTO
            {
                EigenaarId = eigenaar.Id,
                Naam = eigenaar.Naam,
                Straat = eigenaar.Straat,
                HuisNr = eigenaar.HuisNr,
                PlaatsId = eigenaar.PlaatsId,
                PostCode = eigenaar.Plaats.PostCode,
                Gemeente = eigenaar.Plaats.PlaatsNaam,
                TelefoonNr = eigenaar.Telefoon,
                Website = eigenaar.Website,
                Email = eigenaar.Email
            };
            return eigenaarDTO;
        }

        public Eigenaar ConvertToEigenaarENT(EigenaarDTO eigenaarDTO)
        {
            var eigenaar = new Eigenaar
            {
                Id = eigenaarDTO.EigenaarId,
                Naam = eigenaarDTO.Naam,
                Straat = eigenaarDTO.Straat,
                HuisNr = eigenaarDTO.HuisNr,
                PlaatsId = eigenaarDTO.PlaatsId,
                Telefoon = eigenaarDTO.TelefoonNr,
                Website = eigenaarDTO.Website,
                Email = eigenaarDTO.Email,
                Plaats = null,
                Automaat = null
            };
            return eigenaar;
        }
    }
}
