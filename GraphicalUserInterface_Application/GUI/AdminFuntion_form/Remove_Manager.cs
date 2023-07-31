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
using System.Xml.Linq;

namespace GraphicalUserInterface_Application
{
    public partial class Remove_Manager : Form
    {
        public Remove_Manager()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Admin_form();
            f.Show();
            this.Hide();
        }

        private void Remove_Manager_Load(object sender, EventArgs e)
        {

            List<UserBL> user_List = Admin.GetSortedUserList();
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("password", "Password");
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Contact Number", "Contact Number");
            dataGridView1.Columns.Add("Position", "Position");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns["Name"].Width = 100;
            dataGridView1.Columns["password"].Width = 100;
            dataGridView1.Columns["ID"].Width = 100;
            dataGridView1.Columns["Contact Number"].Width = 100;
            dataGridView1.Columns["Position"].Width = 100;
            dataGridView1.Columns["Gender"].Width = 100;

            foreach (UserBL user in user_List)
            {
                if (user is Manager_BL manager)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = manager.getName();
                    row.Cells.Add(nameCell);

                    DataGridViewCell passwordCell = new DataGridViewTextBoxCell();
                    passwordCell.Value = manager.getPassword();
                    row.Cells.Add(passwordCell);

                    DataGridViewCell Id_Cell = new DataGridViewTextBoxCell();
                    Id_Cell.Value = manager.getId();
                    row.Cells.Add(Id_Cell);

                    DataGridViewCell Contact_cell = new DataGridViewTextBoxCell();
                    Contact_cell.Value = manager.getContact();
                    row.Cells.Add(Contact_cell);

                    DataGridViewCell Position_Cell = new DataGridViewTextBoxCell();
                    Position_Cell.Value = manager.getPosition();
                    row.Cells.Add(Position_Cell);

                    DataGridViewCell genderCell = new DataGridViewTextBoxCell();
                    genderCell.Value = manager.getGender();
                    row.Cells.Add(genderCell);

                    dataGridView1.Rows.Add(row);
                }
            }

            dataGridView1.ReadOnly = true;
        }

        string name;
        bool ManagerFound = false;

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            ManagerFound = UserDL.RemoveUserFromList(name);

            if (ManagerFound)
            {
                UserDL.UserFile_Remove(View_Customers.Userpath);
                label2.Visible = true;
            }
            else
            {
                MessageBox.Show("Manager not found. Please try again.", "Manager Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
