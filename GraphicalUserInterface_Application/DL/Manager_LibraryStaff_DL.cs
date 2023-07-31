using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
using Buisnessapplication.UI;
using System.IO;
using GraphicalUserInterface_Application.GUI.ManagerFuntion_Form;
namespace Buisnessapplication.DL
{
    class Manager_LibraryStaff_DL
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
        public static bool ReadDataStaff(string path, List<Manager_LibraryStaff_BL> staffsList)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string librarian = ParseData(record, 1);
                    string libraryAssistant = ParseData(record, 2);
                    string libraryTechnician = ParseData(record, 3);
                    string libraryDirector = ParseData(record, 4);
                    Manager_LibraryStaff_BL s = new Manager_LibraryStaff_BL(librarian, libraryAssistant, libraryTechnician, libraryDirector);
                    staffsList.Add(s);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        //...Store Data in File
        public static void storeDataStaffInFile(string path, Manager_LibraryStaff_BL s)
        {
            StreamWriter file = new StreamWriter(path, true);//Write in the file
            file.WriteLine(s.GetLibrarian() + "," + s.GetLibraryAssistant() + "," + s.GetLibraryTechnician() + "," + s.GetLibraryDirector());
            file.Flush();
            file.Close();
        }
        public static bool  RemoveDuty(string duty)
        {
            if (Manager_BL.GetstaffList().Count > 0)
            {
                bool dutyRemoved = false;

                foreach (Manager_LibraryStaff_BL staff in Manager_BL.GetstaffList())
                {
                    if (staff.GetLibrarian() == duty)
                    {
                        staff.SetLibrarian(" ");
                        dutyRemoved = true;
                        break;
                    }
                    else if (staff.GetLibraryAssistant() == duty)
                    {
                        staff.SetLibraryAssistant(" ");
                        dutyRemoved = true;
                        break;
                    }
                    else if (staff.GetLibraryTechnician() == duty)
                    {
                        staff.SetLibraryTechnician(" ");
                        dutyRemoved = true;
                        break;
                    }
                    else if (staff.GetLibraryDirector() == duty)
                    {
                        staff.SetLibraryDirector(" ");
                        dutyRemoved = true;
                        break;
                    }
                }
                if (dutyRemoved)
                {
                    
                    Manager_LibraryStaff_DL.DeleteDataStaffInFile(Manager_LibraryStaff_UI.pathStaff, Manager_BL.GetstaffList());
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static void DeleteDataStaffInFile(string path, List<Manager_LibraryStaff_BL> staffList)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (Manager_LibraryStaff_BL s in staffList)
            {
                file.WriteLine(s.GetLibrarian() + "," + s.GetLibraryAssistant() + "," + s.GetLibraryTechnician() + "," + s.GetLibraryDirector());
            }
            file.Flush();
            file.Close();

        }
    }
}
