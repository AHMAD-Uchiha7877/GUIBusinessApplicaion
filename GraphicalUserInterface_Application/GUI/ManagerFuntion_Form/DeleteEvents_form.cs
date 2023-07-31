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

namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    public partial class DeleteEvents_form : Form
    {
        public DeleteEvents_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            foreach(Manager_EventsBL events in Manager_BL.GetEventsList())
            {
                if(title==events.getEventName())
                {
                    Manager_BL.GetEventsList().Remove(events);
                    Manager_EventsDL.DeleteDataEventsInFile(AddEvents_Form.pathEvents, Manager_BL.GetEventsList());
                    label8.Visible = true;
                    break;
                }
                else
                {
                    MessageBox.Show("Not found. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }
           
           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
