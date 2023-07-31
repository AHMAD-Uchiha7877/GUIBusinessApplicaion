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
    public partial class ViewEvents_Form : Form
    {
        public ViewEvents_Form()
        {
            InitializeComponent();
        }

        private void ViewEvents_Form_Load(object sender, EventArgs e)
        {
            List<Manager_EventsBL> eventList = Manager_BL.GetEventsList();
            dataGridView1.Columns.Add("Event_Name", "Event Name");
            dataGridView1.Columns.Add("Event_Date", "Event Date");
            dataGridView1.Columns.Add("Event_Duration", "Event Duration");
            dataGridView1.Columns.Add("Event_Location", "Event Location");

            dataGridView1.Columns["Event_Name"].Width = 150;
            dataGridView1.Columns["Event_Date"].Width = 150;
            dataGridView1.Columns["Event_Duration"].Width = 150;
            dataGridView1.Columns["Event_Location"].Width = 150;

            foreach (Manager_EventsBL storedEvent in Manager_BL.GetEventsList())
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell eventNameCell = new DataGridViewTextBoxCell();
                eventNameCell.Value = storedEvent.getEventName();
                row.Cells.Add(eventNameCell);

                DataGridViewCell eventDateCell = new DataGridViewTextBoxCell();
                eventDateCell.Value = storedEvent.getEventDate();
                row.Cells.Add(eventDateCell);

                DataGridViewCell eventDurationCell = new DataGridViewTextBoxCell();
                eventDurationCell.Value = storedEvent.getEventDuration();
                row.Cells.Add(eventDurationCell);

                DataGridViewCell eventLocationCell = new DataGridViewTextBoxCell();
                eventLocationCell.Value = storedEvent.getEventLocation();
                row.Cells.Add(eventLocationCell);

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ReadOnly = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new EventsForm();
            f.Show();
            this.Hide();
        }
    }
}
