using Buisnessapplication.BL;
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
    public partial class ViewDuties_form : Form
    {
        public ViewDuties_form()
        {
            InitializeComponent();
        }

        private void ViewDuties_form_Load(object sender, EventArgs e)
        {


            dataGridView1.Columns.Add("Librarian", "Librarian");
            dataGridView1.Columns.Add("Librarian_Assistent", "Librarian_Assistent");
            dataGridView1.Columns.Add("Technician", "Technician");
            dataGridView1.Columns.Add("Director", "Director");

            dataGridView1.Columns["Librarian"].Width = 150;
            dataGridView1.Columns["Librarian_Assistent"].Width = 150;
            dataGridView1.Columns["Technician"].Width = 150;
            dataGridView1.Columns["Director"].Width = 150;

            foreach (Manager_LibraryStaff_BL storedStaff in Manager_BL.GetstaffList())
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell Librarian_Cell = new DataGridViewTextBoxCell();
                Librarian_Cell.Value = storedStaff.GetLibrarian();
                row.Cells.Add(Librarian_Cell);

                DataGridViewCell Assistent_Cell = new DataGridViewTextBoxCell();
                Assistent_Cell.Value = storedStaff.GetLibraryAssistant();
                row.Cells.Add(Assistent_Cell);

                DataGridViewCell Technician_Cell = new DataGridViewTextBoxCell();
                Technician_Cell.Value = storedStaff.GetLibraryTechnician();
                row.Cells.Add(Technician_Cell);

                DataGridViewCell Director_Cell = new DataGridViewTextBoxCell();
                Director_Cell.Value = storedStaff.GetLibraryDirector();
                row.Cells.Add(Director_Cell);

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ReadOnly = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new ManagerStaff_Form();
            f.Show();
            this.Hide();
        }
    }
}
