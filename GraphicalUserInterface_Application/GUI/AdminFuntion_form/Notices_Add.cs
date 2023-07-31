using Buisnessapplication.BL;
using BusinessApplication.DL;
using BusinessApplication.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface_Application
{
    public partial class Notices_Add : Form
    {
        public Notices_Add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NoticesBL notices = new NoticesBL();
            string title = textBox1.Text;
            string description = textBox2.Text;
            string date = textBox3.Text;
            if (notices.setTitle(title) && notices.setDescription(description) && notices.setDate(date))
            {
                notices = new NoticesBL(title, description, date);
                Admin.AddNoticeList(notices);
                NoticesDL.StoreDataNoticeInFile(View_Notices.pathNotice, notices);
                label8.Visible = true;

            }
            else
            {

                label9.Visible = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form form = new Notices();
            form.Show();
            this.Hide();

        }

        private void Notices_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
