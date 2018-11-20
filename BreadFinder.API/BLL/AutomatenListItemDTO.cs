using BreadFinder.API.DAL;
using BreadFinder.API.DAL.ENT;
using BreadFinder.API.DAL.Repos;
using System;
using System.Linq;

namespace BreadFinder.API.BLL
{
    public class AutomatenListItemDTO : IAutomatenListItemDTO 
    {
        public int AutomaatId { get; set; }
        public string AutomaatStraat { get; set; }
        public string AutomaatHuisNr { get; set; }
        public string AutomaatPostCode { get; set; }
        public string AutomaatPlaatsNaam { get; set; }
        public string EigenaarNaam { get; set; }
        public string EigenaarStraat { get; set; }
        public string EigenaarHuisNr { get; set; }
        public string EigenaarPostCode { get; set; }
        public string EigenaarPlaatsNaam { get; set; }
        public string EigenaarTelefoon { get; set; }
        public string EigenaarWebsite { get; set; }
        public string EigenaarEmail { get; set; }

        public AutomatenListItemDTO ConvertToListItemDTO(Automaat automaat)
        {
            var automatenListItemDTO = new AutomatenListItemDTO
            {
                AutomaatId = automaat.Id,
                AutomaatStraat = automaat.Straat,
                AutomaatHuisNr = automaat.HuisNr,
                AutomaatPostCode = automaat.Plaats.PostCode,
                AutomaatPlaatsNaam = automaat.Plaats.PlaatsNaam,
                EigenaarNaam = automaat.Eigenaar.Naam,
                EigenaarStraat = automaat.Eigenaar.Straat,
                EigenaarHuisNr = automaat.Eigenaar.HuisNr,
                EigenaarPostCode = automaat.Eigenaar.Plaats.PostCode,
                EigenaarPlaatsNaam = automaat.Eigenaar.Plaats.PlaatsNaam,
                EigenaarTelefoon = automaat.Eigenaar.Telefoon,
                EigenaarWebsite = automaat.Eigenaar.Website,
                EigenaarEmail = automaat.Eigenaar.Email
            };
            return automatenListItemDTO;
        }























        //private readonly BreadFinderContext _context;

        //public AutomaatDTO()
        //{
        //}

        //public AutomaatDTO(BreadFinderContext context)
        //{
        //    _context = context;
        //}

        //public string AutomaatStraat { get; set; }
        //public string AutomaatHuisNr { get; set; }
        //public int AutomaatPlaatsId { get; set; }
        //public string AutomaatPostCode { get; set; }
        //public string AutomaatPlaatsNaam { get; set; }
        //public string EigenaarNaam { get; set; }
        //public string EigenaarStraat { get; set; }
        //public string EigenaarHuisNr { get; set; }
        //public int EigenaarPlaatsId { get; set; }
        //public string EigenaarPostCode { get; set; }
        //public string EigenaarPlaatsNaam { get; set; }
        //public string EigenaarTelefoon { get; set; }
        //public string EigenaarWebsite { get; set; }
        //public string EigenaarEmail { get; set; }

        //public AutomaatDTO ConvertToDTO(Automaat automaat)
        //{
        //    if (automaat.Plaats == null)
        //    {
        //        var plaats = _context.Plaats.Find(automaat.PlaatsId);
        //        automaat.Plaats = plaats;
        //    }

        //    if (automaat.Eigenaar == null)
        //    {
        //        var eigenaar = _context.Eigenaar.Find(automaat.EigenaarId);
        //        automaat.Eigenaar = eigenaar;
        //    }

        //    if (automaat.Eigenaar.Plaats == null)
        //    {
        //        var eigenaarPlaats = _context.Plaats.Find(automaat.Eigenaar.PlaatsId);
        //        automaat.Eigenaar.Plaats = eigenaarPlaats;
        //    }

        //    return new AutomaatDTO()
        //    {
        //        AutomaatStraat = automaat.Straat,
        //        AutomaatHuisNr = automaat.HuisNr,
        //        AutomaatPlaatsId = null,
        //        AutomaatPostCode = automaat.Plaats.PostCode,
        //        AutomaatPlaatsNaam = automaat.Plaats.PlaatsNaam,
        //        EigenaarNaam = automaat.Eigenaar.Naam,
        //        EigenaarStraat = automaat.Eigenaar.Straat,
        //        EigenaarHuisNr = automaat.Eigenaar.HuisNr,
        //        EigenaarPlaatsId = null,
        //        EigenaarPostCode = automaat.Eigenaar.Plaats.PostCode,
        //        EigenaarPlaatsNaam = automaat.Eigenaar.Plaats.PlaatsNaam,
        //        EigenaarTelefoon = automaat.Eigenaar.Telefoon,
        //        EigenaarWebsite = automaat.Eigenaar.Website,
        //        EigenaarEmail = automaat.Eigenaar.Email
        //    };
        //}
    }
}