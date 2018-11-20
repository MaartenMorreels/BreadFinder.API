using System;
using System.Collections.Generic;

namespace BreadFinder.API.DAL.ENT
{
    public partial class Plaats
    {
        public Plaats()
        {
            Automaat = new HashSet<Automaat>();
            Eigenaar = new HashSet<Eigenaar>();
            Gebruiker = new HashSet<Gebruiker>();
        }

        public int Id { get; set; }
        public string PostCode { get; set; }
        public string PlaatsNaam { get; set; }
        public string Provincie { get; set; }

        public ICollection<Automaat> Automaat { get; set; }
        public ICollection<Eigenaar> Eigenaar { get; set; }
        public ICollection<Gebruiker> Gebruiker { get; set; }
    }
}
