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
    public partial class ShowMeeting_Form : Form
    {
        public ShowMeeting_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowMeeting_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Location", "Location");
            dataGridView1.Columns.Add("Organizer", "Organizer");

            dataGridView1.Columns["Title"].Width = 150;
            dataGridView1.Columns["Date"].Width = 150;
            dataGridView1.Columns["Time"].Width = 150;
            dataGridView1.Columns["Location"].Width = 150;
            dataGridView1.Columns["Organizer"].Width = 150;

            foreach (MeetingBL storedMeeting in Manager_BL.GetMeetingList())
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell titleCell = new DataGridViewTextBoxCell();
                titleCell.Value = storedMeeting.GetTitle();
                row.Cells.Add(titleCell);

                DataGridViewCell dateCell = new DataGridViewTextBoxCell();
                dateCell.Value = storedMeeting.GetDate();
                row.Cells.Add(dateCell);

                DataGridViewCell timeCell = new DataGridViewTextBoxCell();
                timeCell.Value = storedMeeting.GetTime();
                row.Cells.Add(timeCell);

                DataGridViewCell locationCell = new DataGridViewTextBoxCell();
                locationCell.Value = storedMeeting.GetLocation();
                row.Cells.Add(locationCell);

                DataGridViewCell organizerCell = new DataGridViewTextBoxCell();
                organizerCell.Value = storedMeeting.GetOrganizer();
                row.Cells.Add(organizerCell);

                dataGridView1.Rows.Add(row);
            }

            dataGridView1.ReadOnly = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new MeetingsForm();
            f.Show();
            this.Hide();
        }
    }
}
