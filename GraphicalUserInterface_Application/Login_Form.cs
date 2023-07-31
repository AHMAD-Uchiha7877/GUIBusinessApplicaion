using Buisnessapplication.BL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicalUserInterface_Application.GUI.ManagerFuntion_Form;
using System.Windows.Forms;
using GraphicalUserInterface_Application.ManagerFuntion_Form;
using Buisnessapplication.DL;
using GraphicalUserInterface_Application.ManagerFuntion_Form;
using GraphicalUserInterface_Application.GUI.Customer;

namespace GraphicalUserInterface_Application
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //private UserBL ValidateLogin(string name, string password)
        //{
        //    foreach (UserBL user in Admin.GetUserList())
        //    {
        //        if (name == user.getName() && password == user.getPassword())
        //        {
        //            return user.getRole();
        //        }
        //    }
        //    return null;
        //}
        private UserBL TakeInputForSignIn()
        {


            string name = textBox1.Text;
            string password = textBox2.Text;
            if (name != null && password != null)
            {

                UserBL u = new UserBL(name, password);
                return u;
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            string name = textBox1.Text;
            string password = textBox2.Text;
            if (name == "Saad" && password == "123")
            {
                Form f = new CustomerFuntion_Form();
                f.Show();
                this.Hide();
            }
            //UserBL storedUser = TakeInputForSignIn();
            //storedUser = UserDL.SignIn(storedUser);
            //if (storedUser != null)
            //{

            //    if (string.Equals(storedUser.getRole(), "manager", StringComparison.OrdinalIgnoreCase))
            //    {

            //        Form f = new FormMangerMenu();
            //        f.Show();
            //        this.Hide();
            //    }
            //    else
            //    {

            //        MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            else
            {

                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
