using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadFinder.Winforms.classes
{
    public class Eigenaar
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
    }
}
