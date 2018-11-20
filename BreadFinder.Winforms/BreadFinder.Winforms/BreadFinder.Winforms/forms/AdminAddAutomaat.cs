using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BreadFinder.Winforms.classes;

namespace BreadFinder.Winforms.forms
{
    public partial class AdminAddAutomaat : Form
    {
        //TO DO: return to adminautomatenlist link that reloads data & closes this form
        //          If user entered a placename in the adminlistautomaten form, the resultset should 
        //          show the automates in that place including the newly added automate.
        #region Fields
        private static string apiUrl = "http://localhost:5000/";
        #endregion Fields

        #region Constructor
        public AdminAddAutomaat()
        {
            InitializeComponent();
        }
        #endregion Constructor

        #region Private Methods
        private void addAutomaatButton_Click(object sender, EventArgs e)
        {
            //maak automaat object van form data
            var automaat = new Automaat
            {
                Straat = straatTextBox.Text,
                HuisNr = huisNrTextBox.Text,
                PlaatsId = Convert.ToInt32(plaatsIdTextBox.Text),
                EigenaarId = Convert.ToInt32(eigenaarIdTextBox.Text)
            };

            //converteer object => Json 
            var toeTeVoegenAutomaatJson = JsonConvert.SerializeObject(automaat);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsync(apiUrl + "api/automaten",
                    new StringContent(toeTeVoegenAutomaatJson, Encoding.UTF8, "application/json")).Result;
                if (response.IsSuccessStatusCode)
                {
                    var toegevoegdeAutomaatJson = response.Content.ReadAsStringAsync().Result;
                    var toegevoegdeAutomaat = JsonConvert.DeserializeObject<Automaat>(toegevoegdeAutomaatJson);
                    automaatIdLabel.Text = toegevoegdeAutomaat.Id.ToString();
                }
            }
        }

        private void plaatsIdButton_Click(object sender, EventArgs e)
        {
            var plaatsNaam = plaatsnaamTextBox.Text;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(apiUrl + "api/plaatsen/" + plaatsNaam).Result;
                //var responseStatusCode = response.StatusCode.ToString();

                if (response.IsSuccessStatusCode)
                {
                    var plaatsenJson = response.Content.ReadAsStringAsync().Result;
                    var plaatsen = JsonConvert.DeserializeObject<List<Plaats>>(plaatsenJson);
                    plaatsenDataGrid.DataSource = plaatsen;
                    plaatsenDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void eigenaarIdButton_Click(object sender, EventArgs e)
        {
            var eigenaarNaam = eigenaarTextBox.Text;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(apiUrl + "api/eigenaars/" + eigenaarNaam).Result;
                //var responseStatusCode = response.StatusCode.ToString();

                if (response.IsSuccessStatusCode)
                {
                    var eigenaarsJson = response.Content.ReadAsStringAsync().Result;
                    var eigenaars = JsonConvert.DeserializeObject<List<Eigenaar>>(eigenaarsJson);
                    eigenaarsDataGrid.DataSource = eigenaars;
                    eigenaarsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
        }
        #endregion Private Methods
    }
}