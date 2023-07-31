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
using GraphicalUserInterface_Application.ManagerFuntion_Form;

namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    public partial class AddEvents_Form : Form
    {
        public AddEvents_Form()
        {
            InitializeComponent();
        }
        public static string pathEvents = "Events.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string date = textBox2.Text;
            string duration = textBox3.Text;
            string location = textBox4.Text;
            Manager_EventsBL eventObj = new Manager_EventsBL();
            if (eventObj.setEventDate(name) && eventObj.setEventDate(date) && eventObj.setEventDuration(duration) && eventObj.setEventLocation(location))
            {
                eventObj = new Manager_EventsBL(name, date, duration, location);
                Manager_BL.AddEventsIntoList(eventObj);
                Manager_EventsDL.storeDataEventsInFile(pathEvents, eventObj);
                label8.Visible = true;
            }

            else
            {
                MessageBox.Show("Invalid Input. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new EventsForm();
            f.Show();
            this.Hide();
        }
    }
}
