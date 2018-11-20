using System;
using System.Collections.Generic;

namespace BreadFinder.API.DAL.ENT
{
    public partial class Gebruiker
    {
        public int Id { get; set; }
        public int RolId { get; set; }
        public string VoorNaam { get; set; }
        public string FamilieNaam { get; set; }
        public string Straat { get; set; }
        public string HuisNr { get; set; }
        public int? PlaatsId { get; set; }
        public string Email { get; set; }

        public Plaats Plaats { get; set; }
        public Rol Rol { get; set; }
    }
}
