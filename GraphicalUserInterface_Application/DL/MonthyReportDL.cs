using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
using Buisnessapplication.UI;

namespace Buisnessapplication.DL
{

    internal class MonthlyReportDL
    {


        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        public static bool ReadDataReports(string path, List<MonthyReportBL> reportsList)
        {
            BudgetBL budget = new BudgetBL();
            string totalBudget = budget.GetTotalBudget();

            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string date = ParseData(record, 0);
                    string Budget = ParseData(record, 1);
                    string borrowBooks = ParseData(record, 2);
                    string loans = ParseData(record, 3);
                    string lostBooks = ParseData(record, 4);

                    MonthyReportBL report = new MonthyReportBL(date, Budget, borrowBooks, loans, lostBooks);
                    reportsList.Add(report);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        public static void StoreDataReportsInFile(string path, MonthyReportBL m)
        {
            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(m.GetDate() + "," + m.GetBorrowBooks() + "," + m.GetLoans() + "," + m.GetLostBooks());

            file.Flush();
            file.Close();
        }

        public static void DeleteDataReportsInFile(string path, List<MonthyReportBL> mr)

        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (MonthyReportBL m in mr)
            {
                file.WriteLine(m.GetDate() + "," + m.GetTotalBudget() + "," + m.GetBorrowBooks() + "," + m.GetLoans() + "," + m.GetLostBooks());
            }
            file.Flush();
            file.Close();
        }

        public static bool DeleteReport(string date)
        {
            foreach (MonthyReportBL report in Manager_BL.GetReports())
            {
                if (report.GetDate() == date)
                {
                    Manager_BL.GetReports().Remove(report);
                    return true;
                   
                }

            }
            return false;
        }
    }

}





