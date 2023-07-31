using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.DL;
using Buisnessapplication.BL;
using Buisnessapplication.UI;
using BusinessApplication.DL;
namespace Buisnessapplication.UI
{
    internal class Manager_UI
    {

        public static Manager_BL createManagerAccount()
        {
            Console.Write("Enter The Name Of The manager: ");
            string name = Console.ReadLine();

            Console.Write("Enter The Password Of The manager: ");
            string password = Console.ReadLine();

            Console.Write("Enter The Id Of The manager: ");
            string id = Console.ReadLine();

            Console.Write("Enter The Position Of The manager: ");
            string position = Console.ReadLine();

            Console.Write("Enter The Contact Number Of The manager: ");
            string no = Console.ReadLine();

            Console.Write("Enter The Gender Of The manager: ");
            string gender = Console.ReadLine();

            Manager_BL e = new Manager_BL();
            if (e.setName(name) && e.setPassword(password) && e.setId(id) && e.setContactNo(no) && e.setPosition(position) && e.setgender(gender))
            {
                e = new Manager_BL(name, password, "manager", id, position, no, gender);
                Admin.addUserIntoList(e);
                return e;
            }
            return null;
        }


        public static void addedEmployeeMsg()
        {
            Console.WriteLine("Created Manager Account! ");
        }

        public static void NotaddedEmployeeMsg()
        {
            Console.WriteLine("Inalid inputs ");
        }
        public static void View_Manager()
        {
            Console.Clear();
            if (Admin.GetUserList().Count > 0)
            {
                Console.WriteLine("Managers:");

                foreach (UserBL u in Admin.GetSortedUserList())
                {
                    if (u is Manager_BL)
                    {
                        Manager_BL manager = (Manager_BL)u;
                        Console.WriteLine("Name: {0}", manager.getName());
                        Console.WriteLine("ID: {0}", manager.getId());
                        Console.WriteLine("Contact Number: {0}", manager.getContact());
                        Console.WriteLine("Position: {0}", manager.getPosition());
                        Console.WriteLine("Gender: {0}", manager.getGender());
                        Console.WriteLine("----------------------------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine("No managers available.");
            }
        }





        public static void Delete_ManagerUI()
        {
            Console.Clear();
            Console.Write("Enter The Name Of The Manager: ");
            string name = Console.ReadLine();
            bool check = UserDL.RemoveUserFromList(name);
            if (check)
            {
                Console.WriteLine("Manager Delted SuccessFuly!");

            }

            else if (!check)
            {
                Console.WriteLine("Manager Not Found!");
            }
        }
    }
}
