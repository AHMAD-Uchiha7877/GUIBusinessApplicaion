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
    public partial class DeleteDutiesForm : Form
    {
        public DeleteDutiesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            bool check = Manager_LibraryStaff_DL.RemoveDuty(name);
            if (check)
            {
                label8.Visible = true;

            }
            else
            {
                MessageBox.Show("Not found. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new ManagerStaff_Form();
            f.Show();
            this.Hide();
        }

        private void DeleteDutiesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
