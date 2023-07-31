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
    public partial class View_Customers : Form
    {
        public View_Customers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public static string Userpath = "FileForStoreUsers.txt";
        private void View_Customers_Load(object sender, EventArgs e)
        {


            List<UserBL> user_List = Admin.GetSortedUserList();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Password", "Password");
            dataGridView1.Columns.Add("Cnic", "Cnic");
            dataGridView1.Columns.Add("Mail", "Mail");
            dataGridView1.Columns.Add("Address", "Address"); // Fixed the column name from "Adress" to "Address"
            dataGridView1.Columns.Add("Gender", "Gender");

            dataGridView1.Columns["Name"].Width = 100;
            dataGridView1.Columns["Password"].Width = 100;
            dataGridView1.Columns["Cnic"].Width = 100;
            dataGridView1.Columns["Mail"].Width = 100;
            dataGridView1.Columns["Address"].Width = 100; // Fixed the column width
            dataGridView1.Columns["Gender"].Width = 100;

            foreach (UserBL user in user_List)
            {
                if (user is CustomerBL customer)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = customer.getName();
                    row.Cells.Add(nameCell);

                    DataGridViewCell passwordCell = new DataGridViewTextBoxCell();
                    passwordCell.Value = customer.getPassword();
                    row.Cells.Add(passwordCell);

                    DataGridViewCell cnicCell = new DataGridViewTextBoxCell();
                    cnicCell.Value = customer.GetCnic();
                    row.Cells.Add(cnicCell);

                    DataGridViewCell mailCell = new DataGridViewTextBoxCell();
                    mailCell.Value = customer.GetGmail();
                    row.Cells.Add(mailCell);

                    DataGridViewCell addressCell = new DataGridViewTextBoxCell();
                    addressCell.Value = customer.GetAddress();
                    row.Cells.Add(addressCell);

                    DataGridViewCell genderCell = new DataGridViewTextBoxCell();
                    genderCell.Value = customer.GetGender();
                    row.Cells.Add(genderCell);

                    dataGridView1.Rows.Add(row);
                }
            }

            dataGridView1.ReadOnly = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Admin_form();
            f.Show();
            this.Hide();
        }
    }
}


