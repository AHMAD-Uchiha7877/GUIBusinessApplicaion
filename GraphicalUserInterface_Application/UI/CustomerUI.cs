using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
using Buisnessapplication.UI;
using Buisnessapplication.DL;
using BusinessApplication.DL;
namespace Buisnessapplication.UI
{
    class CustomerUI
    {
       

        public static CustomerBL CreateCustomer()
        {
            Console.Clear();
            Console.Write("Enter The Name of The Customer: ");
            string name = Console.ReadLine();

            Console.Write("Enter The Password Of The Customer: ");
            string password = Console.ReadLine();

            Console.Write("Enter The Cnic Number: ");
            string cnic = Console.ReadLine();

            Console.Write("Enter The Your Gamil Account: ");
            string mail = Console.ReadLine();

            Console.Write("Enter The Your Adress: ");
            string address = Console.ReadLine();

            Console.Write("Enter Your Gender: ");
            string gender = Console.ReadLine();

            CustomerBL customer = new CustomerBL(name, password, "customer", cnic, mail, address, gender);
            if (customer.setName(name) && customer.SetEmail(mail) && customer.SetCnic(cnic) && customer.SetGender(gender))
            {
                Admin.addUserIntoList(customer);
                return customer;
            }
            return null;
        }


        public static void ViewCustomers()
        {
            if (Admin.GetUserList().Count > 0)
            {
                foreach (UserBL user in Admin.GetSortedUserList())
                {
                    if (user is CustomerBL)
                    {
                        CustomerBL customer = (CustomerBL)user; // Explicit type casting
                        Console.WriteLine("Name: {0}", customer.getName());
                        Console.WriteLine("CNIC: {0}", customer.GetCnic());
                        Console.WriteLine("GMail: {0}", customer.GetGmail());
                        Console.WriteLine("Address: {0}", customer.GetAddress());
                        Console.WriteLine("Gender: {0}", customer.GetGender());

                        Console.WriteLine("------------------------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine("Customers List Empty!");
            }
        }


        public static void CustomerAddUI()
        {
            CustomerBL B = new CustomerBL();
            if (CreateCustomer() != null)
            {
                Admin.addUserIntoList(B);
                Console.WriteLine("Customer Account created successfuly! ");
            }
            else
            {
                Console.WriteLine("Customer Account Not created! ");
            }
        }

        public static void messageAddCustomer()
        {
            Console.WriteLine("Customer Added Successfuly! ");
            Console.Read();
        }

        public static void InvalidMessage()
        {
            Console.WriteLine("Invalid Input ! ");
            Console.Read();
        }


        public static void DeleteCustomerUI()
        {
            Console.Clear();
            CustomerBL customer = new CustomerBL();
            Console.Write("Enter The Name Of The Customer: ");
            string name = Console.ReadLine();
            bool check = UserDL.RemoveUserFromList(name);
            if (check)
            {
                Console.WriteLine("Data of Customer Deleted Successfuly! ");
            }
            else
            {
                Console.WriteLine("Customer Not Found!");
            }


        }
    }
}

