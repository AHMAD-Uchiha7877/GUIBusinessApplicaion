using Buisnessapplication.BL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Buisnessapplication.DL.Book_LocationDL;

namespace Buisnessapplication.DL
{
    internal class Book_LocationDL
    {

       
        public static bool ReadDataLocation(string path, List<Books_LocationBL> locationList)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string Category = ParseData(record, 1);
                    string Location = ParseData(record, 2);
                    string Section = ParseData(record, 3);
                    string ShelfNumber = ParseData(record, 4);
                    string RackNumber = ParseData(record, 5);
                    Books_LocationBL l = new Books_LocationBL(Category, Location, ShelfNumber, Section, RackNumber);
                    locationList.Add(l);

                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
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

        public static void storeDataLaocationBook(string path, Books_LocationBL l)
        {
            StreamWriter file = new StreamWriter(path, true);//Write in the file
            file.WriteLine(l.GetBookCategory() + "," + l.GetLocation() + "," + l.GetSection() + "," + l.GetShelfNumber() + "," + l.GetRackNumber());
            file.Flush();
            file.Close();
        }
    }
}

