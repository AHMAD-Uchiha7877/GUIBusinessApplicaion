using Buisnessapplication.BL;
using Buisnessapplication.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.UI
{
    internal class BudgetUI
    {
        public static string pathBudget = "Budget.txt";
        public static void budgetUI()
        {
          
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════════╗");
                Console.WriteLine("║           Budget Management Application      ║");
                Console.WriteLine("╚══════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("1. Add Budget");
                Console.WriteLine("2. View Budget List");
                Console.WriteLine("3. View Total Budget");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBudget();
                        break;
                    case "2":
                        ViewBudget();
                        break;
                    case "3":
                        ViewTotalBudget();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        public static void AddBudget()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║                Add Budget                     ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");

            // Get budget details from the user
            Console.Write("Enter budget name: ");
            string name = Console.ReadLine();
            Console.Write("Enter budget price: ");
            string priceStr = Console.ReadLine();
            Console.Write("Enter budget date: ");
            string date = Console.ReadLine();
            int price = int.Parse(priceStr);

            //BudgetBL budget = new BudgetBL(name, price, date);
            //Manager_BL.addBudgetInToList(budget);
            //BudgetDL.StoreDataBudgetInFile(pathBudget, budget);
            //Console.WriteLine("Budget added successfully.");
        }

        private static void ViewBudget()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║             Budget List                       ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");

            //if (Manager_BL.GetBudgetList().Count > 0)
            ////{
            ////    foreach (BudgetBL budget in Manager_BL.GetBudgetList())
            ////    {
            ////        Console.WriteLine($"Name: {budget.Name}, Price: {budget.Price}, Date: {budget.Date}");
            ////    }
            ////}
            //else
            //{
            //    Console.WriteLine("No budgets found.");
            //}
        }

        private static void ViewTotalBudget()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║             Total Budget                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");

            decimal totalBudget = BudgetDL.CalculateTotalBudget(Manager_BL.GetBudgetList());
            Console.WriteLine($"Total Budget: {totalBudget}");
        }
    }
}
