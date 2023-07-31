using Buisnessapplication.BL;
using Buisnessapplication.DL;
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
    public partial class AddLocation_Detail : Form
    {
        public AddLocation_Detail()
        {
            InitializeComponent();
        }
        public static string pathLocation = "Book_Location.txt";
        private void button1_Click(object sender, EventArgs e)
        {

            string cat = textBox1.Text;
            string floor = textBox2.Text;
            string section = textBox5.Text;
            string shelfNumber = textBox3.Text;
            string rack = textBox4.Text;

            Books_LocationBL b = new Books_LocationBL();
            if (b.SetLocation(floor) && b.SetShelfNumber(shelfNumber) && b.SetSection(section) && b.SetRackNumber(rack))
            {
                Manager_BL.addLocationIntoList(b);
                Book_LocationDL.storeDataLaocationBook(pathLocation, b);
                label8.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new FormMangerMenu();
            f.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
