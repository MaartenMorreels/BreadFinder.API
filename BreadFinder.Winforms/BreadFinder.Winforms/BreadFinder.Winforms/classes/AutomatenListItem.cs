using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BreadFinder.Winforms.classes
{
    public class AutomatenListItem
    {
        [DisplayName("Id")]
        public int AutomaatId { get; set; }
        [DisplayName("Straat")]
        public string AutomaatStraat { get; set; }
        [DisplayName("HuisNr")]
        public string AutomaatHuisNr { get; set; }
        [DisplayName("PostCode")]
        public string AutomaatPostCode { get; set; }
        [DisplayName("Gemeente")]
        public string AutomaatPlaatsNaam { get; set; }
        [DisplayName("Eigenaar")]
        public string EigenaarNaam { get; set; }
        [Browsable(false)]
        public string EigenaarStraat { get; set; }
        [Browsable(false)]
        public string EigenaarHuisNr { get; set; }
        [Browsable(false)]
        public string EigenaarPostCode { get; set; }
        [Browsable(false)]
        public string EigenaarPlaatsNaam { get; set; }
        [DisplayName("Telefoon")]
        public string EigenaarTelefoon { get; set; }
        [DisplayName("Website")]
        public string EigenaarWebsite { get; set; }
        [DisplayName("Email")]
        public string EigenaarEmail { get; set; }

    }
}
