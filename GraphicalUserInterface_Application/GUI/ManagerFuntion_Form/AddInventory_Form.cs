using Buisnessapplication.BL;
using Buisnessapplication.DL;
using Buisnessapplication.UI;
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
    public partial class AddInventory_Form : Form
    {
        public AddInventory_Form()
        {
            InitializeComponent();
        }

        private void AddInventory_Form_Load(object sender, EventArgs e)
        {

        }
        public static string pathInventory = "Inventory.txt";
        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string quantity = textBox2.Text;
            string condition = textBox3.Text;
            string location = textBox4.Text;

            IventoryBL i = new IventoryBL();
            if (i.SetTitle(name) && i.SetCondition(condition) && i.SetLocation(location) && i.SetQuantity(quantity))
            {
                i = new IventoryBL(name, quantity, condition, location);
                Manager_BL.AddInventoryIntoList(i);
                InventoryDL.storeDataInventoryInFile(pathInventory, i);
                label8.Visible = true;
            }

            else
            {
                MessageBox.Show("Invalid input. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new FormMangerMenu();
            f.Show();
            this.Hide();
        }
    }
}
