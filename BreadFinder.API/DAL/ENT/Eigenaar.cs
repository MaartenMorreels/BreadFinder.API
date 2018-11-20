using System;
using System.Collections.Generic;

namespace BreadFinder.API.DAL.ENT
{
    public partial class Eigenaar
    {
        public Eigenaar()
        {
            Automaat = new HashSet<Automaat>();
        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public string Straat { get; set; }
        public string HuisNr { get; set; }
        public int PlaatsId { get; set; }
        public string Telefoon { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }

        public Plaats Plaats { get; set; }
        public ICollection<Automaat> Automaat { get; set; }
    }
}
