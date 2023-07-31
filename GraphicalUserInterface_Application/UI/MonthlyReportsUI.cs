using Buisnessapplication.BL;
using Buisnessapplication.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.UI
{

    internal class MonthlyReportUI
    {
        public static string pathReport = "Reports.txt";
        public static void DisplayReports()
        {
            Console.Clear();
            if (Manager_BL.GetReports().Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                        Monthly Reports                                                                      ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
                Console.ResetColor();

                foreach (MonthyReportBL report in Manager_BL.GetReports())
                {
                    Console.WriteLine("Date: {0}", report.GetDate());
                    Console.WriteLine("Total Budget: {0}", report.GetTotalBudget());
                    Console.WriteLine("Borrowed Books: {0}", report.GetBorrowBooks());
                    Console.WriteLine("Loans: {0}", report.GetLoans());
                    Console.WriteLine("Lost Books: {0}", report.GetLostBooks());
                    Console.WriteLine("-------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No monthly reports available.");
            }
        }

        public  void  AddReport()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    Add Monthly Report                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════╝");

            Console.Write("Enter the date: ");
            string date = Console.ReadLine();

            Console.Write("Enter the total budget: ");
            string totalBudget = Console.ReadLine();

            Console.Write("Enter the number of borrowed books: ");
            string borrowBooks = Console.ReadLine();

            Console.Write("Enter the number of loans: ");
            string loans = Console.ReadLine();

            Console.Write("Enter the number of lost books: ");
            string lostBooks = Console.ReadLine();

         //   MonthyReportBL report = new MonthyReportBL(date, totalBudget, borrowBooks, loans, lostBooks);

          //  Manager_BL.AddReportsIntoList(report);
            //MonthlyReportDL.StoreDataReportsInFile(pathReport, report);

            Console.WriteLine("Monthly report added successfully.");
            //return report;
        }

        public static void ReportDelete()
        {
            Console.Write("Enter The Date Of The Report You Want To Remove:");
            string date = Console.ReadLine();
            bool check = MonthlyReportDL.DeleteReport(date);
            if (check)
            {
                Console.WriteLine("Report Cencelled Successfuly!");
                MonthlyReportDL.DeleteDataReportsInFile(pathReport, Manager_BL.GetReports());

            }
            else
            {
                Console.WriteLine("Don't Have Report Of That Name!");
            }
        }
    }
}

