using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using BreadFinder.Winforms.classes;

namespace BreadFinder.Winforms.forms
{
    public partial class AutomatenList : Form
    {

        public AutomatenList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var plaatsNaam = textboxPlaatsnaam.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/automaten/" + plaatsNaam).Result;
                //var responseStatusCode = response.StatusCode.ToString();

                if (response.IsSuccessStatusCode)
                {
                    var automatenJson = response.Content.ReadAsStringAsync().Result;
                    var automaten = JsonConvert.DeserializeObject<List<AutomatenListItem>>(automatenJson);
                    dataGridView1.DataSource = automaten;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //enable admin functionality
            if (Start.UserRole == "admin")
            {
                this.addButton.Visible = true;
                this.editLabel.Visible = true;
            }

            //load all automates in datagrid
            //TO DO: limit resultset 
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/automaten").Result;
                //var responseStatusCode = response.StatusCode.ToString();

                if (response.IsSuccessStatusCode)
                {
                    var automatenJson = response.Content.ReadAsStringAsync().Result;
                    var automaten = JsonConvert.DeserializeObject<List<AutomatenListItem>>(automatenJson);
                    dataGridView1.DataSource = automaten;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AdminAddAutomaat addForm = new AdminAddAutomaat();
            //add this as parameter to showdialog in order to pass rowdata to addForm?
            addForm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //rowclick event fires only for admins
            if (Start.UserRole == "user")
                return;

            //get the row, the id from the first cell in this row and pass it to a newly opened adminEditForm object
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                //get the AutomaatId from first column
                var automaatId = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                AdminAutomaatHandler form = new AdminAutomaatHandler(automaatId); 
                form.Show();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox provincieCombox = sender as ComboBox;
            var provincie = provincieCombox.SelectedValue.ToString();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("api/automaten/" + provincie).Result;
                //var responseStatusCode = response.StatusCode.ToString();

                if (response.IsSuccessStatusCode)
                {
                    var automatenJson = response.Content.ReadAsStringAsync().Result;
                    var automaten = JsonConvert.DeserializeObject<List<AutomatenListItem>>(automatenJson);
                    dataGridView1.DataSource = automaten;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }
    }
}
