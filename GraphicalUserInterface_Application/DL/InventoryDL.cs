using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Buisnessapplication.BL;

namespace Buisnessapplication.DL
{
    public class InventoryDL
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

        public static bool ReadDataInventory(string path, List<IventoryBL> iList)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string Title = ParseData(record, 1);
                    string quantity = ParseData(record, 2);
                    string condition = ParseData(record, 3);
                    string location = ParseData(record, 4);

                    IventoryBL i = new IventoryBL(Title, quantity, condition, location);
                    iList.Add(i);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        public static void storeDataInventoryInFile(string path, IventoryBL i)
        {
            StreamWriter file = new StreamWriter(path, true); // Write in the file
            file.WriteLine($"{i.GetTitleInventory()},{i.GetQuantity()},{i.GetCondition()},{i.GetLocation()}");
            file.Flush();
            file.Close();
        }


        public static void DeleteDataInventoryInFile(string path, List<IventoryBL> inventoryList)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (IventoryBL i in inventoryList.ToList())
            {
                file.WriteLine(i.GetTitleInventory() + "," + i.GetQuantity() + "," + i.GetCondition() + "," + i.GetLocation());
            }
            file.Flush();
            file.Close();
        }

        //public static bool DeleteBookStock(string title)
        //{
        //    foreach (IventoryBL i in inventoryListt)
        //    {
        //        if (title == i.GetTitleInventory())
        //        {
        //            Console.WriteLine("Enter the quantity to delete: ");
        //            string deleteQuantityStr = Console.ReadLine();
        //            if (!int.TryParse(deleteQuantityStr, out int deleteQuantity))
        //            {
        //                Console.WriteLine("Invalid quantity format. Please enter a valid integer quantity.");
        //                return false;
        //            }

        //            int currentQuantity = int.Parse(i.GetQuantity());
        //            if (deleteQuantity <= currentQuantity)
        //            {
        //                int updatedQuantity = currentQuantity - deleteQuantity;
        //                i.SetQuantity(updatedQuantity.ToString());

        //                if (updatedQuantity == 0)
        //                {
        //                    inventoryListt.Remove(i);
        //                }

        //                return true;
        //            }
        //        }
        //    }

        //    return false;
        //}
    }
}
