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
    public partial class DeleteInVentory_Form : Form
    {
        public DeleteInVentory_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item=textBox1.Text;
            foreach(IventoryBL inventory in Manager_BL.GetInventoryList() )
            {
                if(item==inventory.GetTitleInventory())
                {
                    Manager_BL.GetInventoryList().Remove(inventory);
                    InventoryDL.DeleteDataInventoryInFile(AddInventory_Form.pathInventory, Manager_BL.GetInventoryList());
                    label8.Visible = true;
                    break;
                }
                else
                {
                    MessageBox.Show("Invalid Input. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }
    }
}
