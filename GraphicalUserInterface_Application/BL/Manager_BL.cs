using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication.DL;
namespace Buisnessapplication.BL
{
    internal class Manager_BL : UserBL
    {

        string Id, position, contactNumber, Gender;
        //Location
        private static List<Books_LocationBL> locationsList = new List<Books_LocationBL>();
        public static void addLocationIntoList(Books_LocationBL l)
        {
            locationsList.Add(l);
        }
        public static List<Books_LocationBL> GetLocationBook()
        {
            return locationsList;
        }
        //...Budget
        private static List<BudgetBL> budgetList = new List<BudgetBL>();
        public static List<BudgetBL> GetBudgetList()
        {
            return budgetList;
        }
        public static void addBudgetInToList(BudgetBL b)
        {
            budgetList.Add(b);
        }
        //Inventory
        private static List<IventoryBL> inventoryList = new List<IventoryBL>();
        public static List<IventoryBL> GetInventoryList()
        {
            return inventoryList;
        }
        public static void AddInventoryIntoList(IventoryBL i)
        {
            inventoryList.Add(i);
        }
        //...Events
        private static List<Manager_EventsBL> eventsList = new List<Manager_EventsBL>();
        public static void AddEventsIntoList(Manager_EventsBL events)
        {
            eventsList.Add(events);
        }

        public static List<Manager_EventsBL> GetEventsList()
        {
            return eventsList;
        }
        //...staff
        private static List<Manager_LibraryStaff_BL> staffList = new List<Manager_LibraryStaff_BL>();
        public static List<Manager_LibraryStaff_BL> GetstaffList()
        {
            return staffList;
        }
        public static void AddStaffIntoList(Manager_LibraryStaff_BL staff)
        {
            staffList.Add(staff);
        }
        //...MEETINGS
        public static List<MeetingBL> meetingsList = new List<MeetingBL>();
        public static List<MeetingBL> GetMeetingList()
        {
            return meetingsList;
        }
        public static void AddMeetingsIntoList(MeetingBL m)
        {
            meetingsList.Add(m);
        }
        //REPORTS
        public static List<MonthyReportBL> reportsList = new List<MonthyReportBL>();
        public static  List<MonthyReportBL> GetReports()
        {
            return reportsList;
        }
        public static void AddReportsIntoList(MonthyReportBL m)
        {
            reportsList.Add(m);
        }
        public Manager_BL(string name, string password, string role, string id, string position, string contactNumber, string gender) : base(name, password, role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            Id = id;
            this.position = position;
            this.contactNumber = contactNumber;
            Gender = gender;
        }
        public Manager_BL() { }
        public string getId()
        {
            return Id;
        }
        public string getPosition()
        {
            return position;
        }

        public string getContact()
        {
            return contactNumber;
        }
        public string getGender()
        {
            return Gender;
        }
        public bool setId(string id)
        {
            if (id.Length <= 13 && !string.IsNullOrEmpty(id))
            {
                return true;
            }
            return false;
        }


        public bool setgender(string gender)
        {
            if (gender.Length < 7 && !string.IsNullOrEmpty(gender))
            {
                return true;
            }
            return false;
        }

        public bool setContactNo(string number)
        {
            if (number.Length <= 11 && !string.IsNullOrEmpty(number))
            {
                return true;
            }
            return false;
        }

        public bool setPosition(string position)
        {
            if (position != "admin" && !string.IsNullOrEmpty(position))
            {
                return true;
            }
            return false;
        }
    }
}
