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
    public partial class ViewBudgetList : Form
    {
        public ViewBudgetList()
        {
            InitializeComponent();
        }

        private void ViewBudgetList_Load(object sender, EventArgs e)
        {
            List<BudgetBL> budgetList = Manager_BL.GetBudgetList();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Date", "Date");

            dataGridView1.Columns["Name"].Width = 170;
            dataGridView1.Columns["Price"].Width = 180;
            dataGridView1.Columns["Date"].Width = 170;

            foreach (BudgetBL budget in budgetList)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = budget.GetName();
                row.Cells.Add(nameCell);

                DataGridViewCell priceCell = new DataGridViewTextBoxCell();
                priceCell.Value = budget.GetPrice();
                row.Cells.Add(priceCell);

                DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                dateCell.Value = budget.GetDate();
                row.Cells.Add(dateCell);

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ReadOnly = true;

            
            decimal totalBudget = BudgetDL.CalculateTotalBudget(budgetList);

            // Display the total budget in a label
            label1.Text = "Total Budget: " + totalBudget.ToString();
        }







        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new BudgetForm();
            f.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
