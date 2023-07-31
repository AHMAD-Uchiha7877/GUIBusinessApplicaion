using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.BL
{
    class CommonBL
    {
        private static string adminOption;
        private static string loginOption;
        public static string adminMenu;
        public static string mangerOption;
        public static string CustomerOption;

        public static string GetCustomerMenu()
        {
            return CustomerOption;


        }

        public static void SetCustomerOption(string option)
        {
            CustomerOption = option;


        }


        public static string getMangerMenu()
        {
            return mangerOption;
        }

        public static void SetmangerOption(string option)
        {
            mangerOption = option;
        }
        public static string getAdminMenu()
        {
            return adminMenu;
        }
        public static void SetLoginOption(string option)
        {
            loginOption = option;
        }
        public static void SetAdminOption(string option)
        {
            adminOption = option;
        }

        public static string GetAdminOption()
        {
            return adminOption;
        }

        public static string GetLoginOption()
        {
            return loginOption;
        }
    }
}
