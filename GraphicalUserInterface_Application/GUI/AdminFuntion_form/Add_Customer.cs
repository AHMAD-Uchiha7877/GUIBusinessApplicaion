using Buisnessapplication.BL;
using Buisnessapplication.DL;
using Buisnessapplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface_Application
{
    public partial class Add_Customer : Form
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerBL customer = new CustomerBL();
            string name = textBox1.Text;
            string password = textBox2.Text;
            string cnic = textBox3.Text;
            string gmail = textBox4.Text;
            string address = textBox5.Text;
            string gender = textBox6.Text;
            if (customer.setName(name) && customer.setPassword(password))
            {
                customer = new CustomerBL(name, password, "customer", cnic, gmail, address, gender);
                Admin.addUserIntoList(customer);
                UserDL.UserFile_Store(View_Customers.Userpath);
                label8.Visible = true;
                label9.Visible = false;
            }
            else
            {
                label8.Visible = false;  // Hide the success label
                label9.Visible = true;   // Show the error label
            }
        }





        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Admin_form();
            f.Show();
            this.Hide();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}
