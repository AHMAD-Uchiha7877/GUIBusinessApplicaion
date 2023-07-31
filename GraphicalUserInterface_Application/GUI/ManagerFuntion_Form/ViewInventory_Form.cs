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
using Buisnessapplication.BL;


namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    public partial class ViewInventory_Form : Form
    {
        public ViewInventory_Form()
        {
            InitializeComponent();
        }

        private void ViewInventory_Form_Load(object sender, EventArgs e)
        {
            List<IventoryBL> inventoryList = Manager_BL.GetInventoryList();
            dataGridView1.Columns.Add("Item_Name", "Item Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("Category", "Category");

            dataGridView1.Columns["Item_Name"].Width = 150;
            dataGridView1.Columns["Quantity"].Width = 150;
            dataGridView1.Columns["Location"].Width = 150;
            dataGridView1.Columns["Category"].Width = 150;

            foreach (IventoryBL storedItem in Manager_BL.GetInventoryList())
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell itemNameCell = new DataGridViewTextBoxCell();
                itemNameCell.Value = storedItem.GetTitleInventory();
                row.Cells.Add(itemNameCell);

                DataGridViewCell quantityCell = new DataGridViewTextBoxCell();
                quantityCell.Value = storedItem.GetQuantity();
                row.Cells.Add(quantityCell);

                DataGridViewCell locationCell = new DataGridViewTextBoxCell();
                locationCell.Value = storedItem.GetLocation();
                row.Cells.Add(locationCell);

                DataGridViewCell categoryCell = new DataGridViewTextBoxCell();
                categoryCell.Value = storedItem.GetCategory();
                row.Cells.Add(categoryCell);

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ReadOnly = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f=new InventoryForm();
            f.Show();
            this.Hide();



        }
    }
}
