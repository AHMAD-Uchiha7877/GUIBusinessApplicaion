using System;
using Buisnessapplication.BL;
using System.Collections.Generic;
using System.IO;

namespace Buisnessapplication.DL
{
    internal class BudgetDL
    {
        public static bool ReadDataBudget(string path, List<BudgetBL> budgetList)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = ParseData(record, 1);
                    string priceStr = ParseData(record, 2);
                    string date = ParseData(record, 3);

                    try
                    {
                        BudgetBL budget = new BudgetBL(name, priceStr, date);
                        budgetList.Add(budget);
                    }
                    catch (FormatException)
                    {
                        // Handle parsing error
                        Console.WriteLine("Invalid price format for record: {0}", record);
                    }
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        public static void StoreDataBudgetInFile(string path, BudgetBL budget)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine($"{budget.Name},{budget.GetPrice()},{budget.Date}");
            file.Flush();
            file.Close();
        }

        public static void DeleteDataBudgetInFile(string path, List<BudgetBL> budgetList)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (BudgetBL budget in budgetList)
            {
                file.WriteLine($"{budget.Name},{budget.GetPrice()},{budget.Date}");
            }
            file.Flush();
            file.Close();
        }

        public static decimal CalculateTotalBudget(List<BudgetBL> budgetList)
        {
            decimal totalBudget = 0;
            foreach (BudgetBL budget in budgetList)
            {
                if (decimal.TryParse(budget.GetPrice(), out decimal priceValue))
                {
                    totalBudget += priceValue;
                }
            }
            return totalBudget;
        }

        public static void StoreTotalBudgetInFile(string path, List<BudgetBL> budgetList)
        {
            decimal totalBudget = CalculateTotalBudget(budgetList);
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine($"Total Budget: {totalBudget}");
            file.Flush();
            file.Close();
        }

        private static string ParseData(string record, int field)
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
    }
}
