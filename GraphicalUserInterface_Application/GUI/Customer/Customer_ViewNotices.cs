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

namespace GraphicalUserInterface_Application.GUI.Customer
{
    public partial class Customer_ViewNotices : Form
    {
        public Customer_ViewNotices()
        {
            InitializeComponent();
        }

        private void Customer_ViewNotices_Load(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new CustomerFuntion_Form();
            f.Show();
            this.Hide();
        }
    }
}

