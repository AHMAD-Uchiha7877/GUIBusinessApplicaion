using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicalUserInterface_Application.GUI.ManagerFuntion_Form;

namespace GraphicalUserInterface_Application.ManagerFuntion_Form
{
    public partial class FormMangerMenu : Form
    {
        public FormMangerMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new BudgetForm();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new ManagerStaff_Form();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form f = new EventsForm();
            f.Show();
            this.Hide();
        }

        private void FormMangerMenu_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form f = new InventoryForm();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Location_Form();
            f.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new MeetingsForm();
            f.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new GenerateReportsForm();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new View_Reports();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new DeleteReports_form();
            f.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Main_Form();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Remove_Manager();
            f.Show();
            this.Hide();
        }
    }
}
