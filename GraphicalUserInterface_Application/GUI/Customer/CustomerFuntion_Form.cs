using GraphicalUserInterface_Application.GUI.ManagerFuntion_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface_Application.GUI.Customer
{
    public partial class CustomerFuntion_Form : Form
    {
        public CustomerFuntion_Form()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f = new Customer_ViewBooksForm();
            f.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new Customer_ViewEvents();
            f.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form f = new Customer_ViewNotices();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Remove_Customer();
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form f = new BuyBooks_Form();
            f.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f = new BorrowBooks_Form();
            f.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Main_Form();
            f.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form f = new ReturnBook_Form();
            f.Show();
            this.Hide();
        }
    }
}
