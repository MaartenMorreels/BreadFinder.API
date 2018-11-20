using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadFinder.Winforms.forms
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        public static string UserRole { get; set; }

        private void userSectionButton_Click(object sender, EventArgs e)
        {
            AutomatenList userAutomatenList = new AutomatenList();
            UserRole = "user";
            userAutomatenList.Show();
            this.Hide();
        }

        private void adminSectionButton_Click(object sender, EventArgs e)
        {
            AutomatenList userAutomatenList = new AutomatenList();
            UserRole = "admin";
            userAutomatenList.Show();
            this.Hide();
        }
    }
}
