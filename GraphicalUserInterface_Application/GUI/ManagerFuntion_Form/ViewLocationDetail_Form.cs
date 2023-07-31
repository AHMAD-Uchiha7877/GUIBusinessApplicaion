using Buisnessapplication.BL;
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
    public partial class ViewLocationDetail_Form : Form
    {
        public ViewLocationDetail_Form()
        {
            InitializeComponent();
        }

        private void ViewLocationDetail_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Book_Category", "Book Category");
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("ShelfNumber", "Shelf Number");
            dataGridView1.Columns.Add("Section", "Section");
            dataGridView1.Columns.Add("RackNumber", "Rack Number");

            dataGridView1.Columns["Book_Category"].Width = 150;
            dataGridView1.Columns["Location"].Width = 150;
            dataGridView1.Columns["ShelfNumber"].Width = 150;
            dataGridView1.Columns["Section"].Width = 150;
            dataGridView1.Columns["RackNumber"].Width = 150;

            foreach (Books_LocationBL storedLocation in Manager_BL.GetLocationBook()) // Assuming BooksLocationList is a List<Books_LocationBL> containing the book location data
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell bookCategoryCell = new DataGridViewTextBoxCell();
                bookCategoryCell.Value = storedLocation.GetBookCategory();
                row.Cells.Add(bookCategoryCell);

                DataGridViewCell locationCell = new DataGridViewTextBoxCell();
                locationCell.Value = storedLocation.GetLocation();
                row.Cells.Add(locationCell);

                DataGridViewCell shelfNumberCell = new DataGridViewTextBoxCell();
                shelfNumberCell.Value = storedLocation.GetShelfNumber();
                row.Cells.Add(shelfNumberCell);

                DataGridViewCell sectionCell = new DataGridViewTextBoxCell();
                sectionCell.Value = storedLocation.GetSection();
                row.Cells.Add(sectionCell);

                DataGridViewCell rackNumberCell = new DataGridViewTextBoxCell();
                rackNumberCell.Value = storedLocation.GetRackNumber();
                row.Cells.Add(rackNumberCell);

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ReadOnly = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f=new Location_Form();
            f.Show();
            this.Hide();
        }
    }
}
