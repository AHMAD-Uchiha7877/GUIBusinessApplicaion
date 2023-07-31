using GraphicalUserInterface_Application.ManagerFuntion_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    public partial class Location_Form : Form
    {
        public Location_Form()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new FormMangerMenu();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new AddLocation_Detail();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new ViewLocationDetail_Form();
            f.Show();
            this.Hide();
        }
    }
}
