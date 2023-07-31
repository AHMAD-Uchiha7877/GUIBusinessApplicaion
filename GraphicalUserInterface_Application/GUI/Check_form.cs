using Buisnessapplication.BL;
using Buisnessapplication.DL;
using BusinessApplication.DL;
using GraphicalUserInterface_Application.GUI.Customer;
using GraphicalUserInterface_Application.GUI.ManagerFuntion_Form;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GraphicalUserInterface_Application.GUI.AdminFuntion_form
{
    public partial class Check_form : Form
    {
        public Check_form()
        {
            InitializeComponent();
        }

        private void Check_form_Load(object sender, EventArgs e)
        {

            BookDL.ReadDataBook(View_Books.pathBook, Admin.GetBookList());
            UserDL.ReadData(View_Customers.Userpath);
            NoticesDL.ReadDataNotice(View_Notices.pathNotice);

            BudgetDL.ReadDataBudget(AddBudget_form.pathBudget, Manager_BL.GetBudgetList());
            Manager_LibraryStaff_DL.ReadDataStaff(AddDuties_Form.pathStaff, Manager_BL.GetstaffList());
            InventoryDL.ReadDataInventory(AddInventory_Form.pathInventory, Manager_BL.GetInventoryList());
            Manager_EventsDL.ReadDataEvents(AddEvents_Form.pathEvents, Manager_BL.GetEventsList());
            MeetingDL.ReadMeetings(AddMeeting_form.pathMeeting, Manager_BL.GetMeetingList());
            MonthlyReportDL.ReadDataReports(GenerateReportsForm.pathReport, Manager_BL.GetReports());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form f = new CustomerFuntion_Form();
            this.Hide();
            f.Show();
        }
    }
}
