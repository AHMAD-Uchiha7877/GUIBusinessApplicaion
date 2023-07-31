using Buisnessapplication.BL;
using BusinessApplication.DL;
using Buisnessapplication.UI;
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
    public partial class Delete_Notices : Form
    {
        public Delete_Notices()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            if (!string.IsNullOrEmpty(title))
            {
                bool noticeFound = false;
                foreach (NoticesBL storedNotices in Admin.GetNoticesList())
                {
                    if (storedNotices.getTitle() == title)
                    {
                        Admin.GetNoticesList().Remove(storedNotices);
                        NoticesDL.DeleteDataNoticeInFile(View_Notices.pathNotice, Admin.GetNoticesList());
                        label3.Visible = true;
                        noticeFound = true;
                        break;
                    }
                }

                if (!noticeFound)
                {
                    label2.Visible = true;
                }
            }
            else
            {
                label2.Visible = true;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Notices_Load(object sender, EventArgs e)
        {

            List<NoticesBL> noticesList = Admin.GetNoticesList();
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Posted Date", "Posted Date");
            dataGridView1.Columns["Title"].Width = 200;
            dataGridView1.Columns["Description"].Width = 200;
            dataGridView1.Columns["Posted Date"].Width = 200;


            foreach (NoticesBL notice in noticesList)
            {

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = notice.getTitle();
                row.Cells.Add(nameCell);

                DataGridViewCell Description_CEll = new DataGridViewTextBoxCell();
                Description_CEll.Value = notice.getDescription();
                row.Cells.Add(Description_CEll);

                DataGridViewCell DateCell
                    = new DataGridViewTextBoxCell();
                DateCell
                    .Value = notice.getDate();
                row.Cells.Add(DateCell
                    );



                dataGridView1.Rows.Add(row);
            }


            dataGridView1.ReadOnly = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new Admin_form();
            f.Show();
            this.Hide();
        }
    }
}
