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

namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    public partial class AddBudget_form : Form
    {
        public AddBudget_form()
        {
            InitializeComponent();
        }
        public static string pathBudget = "Budget.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            BudgetBL budget = new BudgetBL();
            string item_name = textBox1.Text;
            string price = textBox2.Text;
            string date = textBox3.Text;

            if (budget.SetName(item_name) && budget.SetPrice(price))
            {
                budget = new BudgetBL(item_name, price, date);
                Manager_BL.addBudgetInToList(budget);
                BudgetDL.StoreDataBudgetInFile(pathBudget, budget);
                label8.Visible = true;
            }

            else
            {
                MessageBox.Show("Invalid Input. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddBudget_form_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new BudgetForm();
            this.Hide();
            f.Show();
        }
    }
}
