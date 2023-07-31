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
    public partial class Add_Manager : Form
    {
        public Add_Manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Manager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_BL manager = new Manager_BL();
            string name = textBox1.Text;
            string password = textBox2.Text;
            string Id = textBox3.Text;
            string position = textBox4.Text;
            string contact = textBox5.Text;
            string gender = textBox6.Text;
            if (manager.setName(name) && manager.setPassword(password) && manager.setId(Id) && manager.setPosition(position) && manager.setContactNo(contact) && manager.setgender(gender))
            {
                manager = new Manager_BL(name, password, "manager", Id, position, contact, gender);
                Admin.addUserIntoList(manager);
                UserDL.UserFile_Store(View_Customers.Userpath);
                label8.Visible = true;
            }
            else
            {
                label9.Visible = true;
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
    }
}
