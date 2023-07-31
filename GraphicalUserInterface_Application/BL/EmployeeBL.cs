using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.BL
{
    class EmployeeBL
    {
       private string EmployeeID;
       private string Name;
       private string Position;
       private string Email;
       private string Contact_Number;
       private string Address;

        public UserBL UserBL
        {
            get => default;
            set
            {
            }
        }

        public string getEmployeeID()
       {
           return EmployeeID;
       }
        public bool setEmployeeID(string EmployeeID)
        {
            if (EmployeeID.Length == 13)
            {
                this.EmployeeID = EmployeeID;
                return true;
            }
            return false;

        }


    }
}
