using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using BreadFinder.Winforms.classes;

namespace BreadFinder.Winforms.forms
{
    public partial class AdminAutomaatHandler : Form
    {
        public AdminAutomaatHandler()
        {
            InitializeComponent();
        }

        public AdminAutomaatHandler(int id)
        {
            InitializeComponent();
            automaatId = id.ToString();
        }

        private string automaatId; //maybe this must be static

        private void AdminAutomaatHandler_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/automaten/" + automaatId).Result;
                //var responseStatusCode = response.StatusCode.ToString();

                if (response.IsSuccessStatusCode)
                {
                    var automaatJson = response.Content.ReadAsStringAsync().Result;
                    var automaatListItem = JsonConvert.DeserializeObject<AutomatenListItem>(automaatJson);
                    automaatIdTextBox.Text = automaatListItem.AutomaatId.ToString();
                    automaatStraatTextBox.Text = automaatListItem.AutomaatStraat;
                    automaatHuisNrTextBox.Text = automaatListItem.AutomaatHuisNr;
                    automaatPlaatsIdTextBox.Text = "666";

                }
            }
        }
    }
}
