using Buisnessapplication.BL;
using Buisnessapplication.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Buisnessapplication.BL;
using System.Diagnostics.Eventing.Reader;
using GraphicalUserInterface_Application.ManagerFuntion_Form;

namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    public partial class AddDuties_Form : Form
    {
        public AddDuties_Form()
        {
            InitializeComponent();
        }
        public static string pathStaff = "STAFF.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_LibraryStaff_BL staff = new Manager_LibraryStaff_BL();
            string duties_Librarian = textBox1.Text;
            string duties_Assistant = textBox2.Text;
            string duties_Technician = textBox3.Text;
            string duties_Director = textBox4.Text;
            if (staff.SetLibrarian(duties_Librarian) && staff.SetLibraryAssistant(duties_Assistant) && staff.SetLibraryTechnician(duties_Technician) && staff.SetLibraryDirector(duties_Director))
            {
                staff = new Manager_LibraryStaff_BL(duties_Librarian, duties_Assistant, duties_Technician, duties_Director);
                Manager_LibraryStaff_DL.storeDataStaffInFile(pathStaff, staff);
                Manager_BL.AddStaffIntoList(staff);
                label8.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new ManagerStaff_Form();
            f.Show();
            this.Hide();
        }
    }
}
