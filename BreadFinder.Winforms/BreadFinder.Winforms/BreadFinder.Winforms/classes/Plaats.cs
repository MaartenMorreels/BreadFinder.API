using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BreadFinder.Winforms.classes
{
    public class Plaats
    {
        public int PlaatsId { get; set; }
        public string PostCode { get; set; }
        public string PlaatsNaam { get; set; }
        public string Provincie { get; set; }
    }
}
