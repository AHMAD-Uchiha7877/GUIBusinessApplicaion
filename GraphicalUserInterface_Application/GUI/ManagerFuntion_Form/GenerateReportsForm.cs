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
    public partial class GenerateReportsForm : Form
    {
        public GenerateReportsForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public static string pathReport = "Reports.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string date = textBox1.Text;
            string borrowBooks = textBox3.Text;
            string loansStr = textBox4.Text;
            string lostBooks = textBox5.Text;

            MonthyReportBL report = new MonthyReportBL();


            if (!report.SetLostBooks(lostBooks) || !report.SetDate(date) || !report.SetBorrowBooks(borrowBooks) || !report.SetLoans(loansStr))
            {
                MessageBox.Show("Invalid Input. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Manager_BL.AddReportsIntoList(report);
            MonthlyReportDL.StoreDataReportsInFile(pathReport, report);
            label8.Visible = true;
        }


        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new FormMangerMenu();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
