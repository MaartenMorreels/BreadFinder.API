using System;
using System.Collections.Generic;

namespace BreadFinder.API.DAL.ENT
{
    public partial class Rol
    {
        public Rol()
        {
            Gebruiker = new HashSet<Gebruiker>();
        }

        public int Id { get; set; }
        public string Rol1 { get; set; }

        public ICollection<Gebruiker> Gebruiker { get; set; }
    }
}
