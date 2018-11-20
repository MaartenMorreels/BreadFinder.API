using System;
using System.Collections.Generic;

namespace BreadFinder.API.DAL.ENT
{
    public partial class Automaat
    {
        
        public int Id { get; set; }
        public string Straat { get; set; }
        public string HuisNr { get; set; }
        public int PlaatsId { get; set; }
        public int EigenaarId { get; set; }

        public Eigenaar Eigenaar { get; set; }
        public Plaats Plaats { get; set; }
    }
}
