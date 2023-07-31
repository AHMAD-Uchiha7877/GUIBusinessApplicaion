using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
using Buisnessapplication.DL;
using System.IO;
namespace Buisnessapplication.UI
{
    public class UserUI
    {

         
        public static string LoginMenu()
        {
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\tWelcome to the Login Menu");
            Console.WriteLine("\t\t-------------------------");
            Console.WriteLine("\t\t1. Login");
            Console.WriteLine("\t\t2. Exit");
            Console.ResetColor(); // Reset the color to the default
            Console.Write("\tEnter your choice: ");
            string option = Console.ReadLine();
            return option;
        }

        public static void AddAdmin()
        {
            UserBL admin = new UserBL("ahmad", "123", "admin");
            Admin.addUserIntoList(admin);
        }



        public static UserBL TakeInputForSignIn()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (name != null && password != null)
            {

                UserBL u = new UserBL(name, password);
                return u;
            }
            return null;
        }

        public static void errorMsg()
        {
            Console.WriteLine("Please enter valid input");
        }

        public static void InvalidErrorMsg()
        {
            Console.WriteLine("Invalid option");
        }

        public static void showSignUpSuccessful()
        {
            Console.WriteLine("SignUp Successfuly!");
        }

    }
}
