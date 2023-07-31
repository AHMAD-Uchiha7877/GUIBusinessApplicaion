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

namespace GraphicalUserInterface_Application.GUI.ManagerFuntion_Form
{
    public partial class CancelMeetings_form : Form
    {
        public CancelMeetings_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            bool check = MeetingDL.DeleteMeeting(title);
            if (check)
            {
                MeetingDL.DeleteMeeting(title);
                MeetingDL.DeleteMeetingFromFile(AddMeeting_form.pathMeeting);
                label8.Visible = true;
            }
            else
            {
                MessageBox.Show("Not found. Please try again.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void CancelMeetings_form_Load(object sender, EventArgs e)
        {

        }
    }
}
