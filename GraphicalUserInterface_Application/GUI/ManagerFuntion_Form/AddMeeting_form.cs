using Buisnessapplication.BL;
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
    public partial class AddMeeting_form : Form
    {
        public AddMeeting_form()
        {
            InitializeComponent();
        }
        public static string pathMeeting = "Meeting.txt";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string title = textBox1.Text;
            string date = textBox2.Text;
            string time = textBox3.Text;
            string location = textBox4.Text;
            string organizer = textBox5.Text;


            MeetingBL meeting = new MeetingBL();
            if (meeting.SetTitle(title) && meeting.SetDate(date) && meeting.SetTime(time) && meeting.SetLocation(location) && meeting.SetOrganizer(organizer))
            {

                Manager_BL.AddMeetingsIntoList(meeting);
                MeetingDL.StoreMeetings(pathMeeting);
                label8.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMeeting_form_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

            Form f = new MeetingsForm();
            f.Show();
            this.Hide();
        }
    }
}

