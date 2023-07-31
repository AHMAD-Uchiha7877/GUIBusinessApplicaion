using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.DL;
using Buisnessapplication.BL;
 
namespace Buisnessapplication.UI
{
    class Manager_LibraryStaff_UI
    {
        public static string pathStaff = "STAFF.txt";
        public static Manager_LibraryStaff_BL AddDuties()
        {
            Console.Write("Enter the duties for the librarian today: ");
            string librarianDuties = Console.ReadLine();
            Console.Write("Enter the duties for the library assistant today: ");
            string assistantDuties = Console.ReadLine();
            Console.Write("Enter the duties for the library technician today: ");
            string technicianDuties = Console.ReadLine();
            Console.Write("Enter the duties for the library director today: ");
            string directorDuties = Console.ReadLine();
            Manager_LibraryStaff_BL staff = new Manager_LibraryStaff_BL();
            if (staff.SetLibrarian(librarianDuties) && staff.SetLibraryAssistant(assistantDuties) && staff.SetLibraryDirector(directorDuties) && staff.SetLibraryTechnician(technicianDuties))
            {
                staff = new Manager_LibraryStaff_BL(librarianDuties, assistantDuties, technicianDuties, directorDuties);
                Manager_BL.AddStaffIntoList(staff);
                Manager_LibraryStaff_DL.storeDataStaffInFile(pathStaff, staff);
                return staff;
            }
            return null;
        }
        public static void ShowDuties()
        {
            if (Manager_BL.GetstaffList().Count > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("╔════════════════════╦═══════════════════╦════════════════════╦══════════════════╗");
                Console.WriteLine("║    Library Staff   ║ Library Assistant ║ Library Technician ║ Library Director ║");
                Console.WriteLine("╠════════════════════╪═══════════════════╪════════════════════╪══════════════════╣");
                Console.ResetColor();

                foreach (Manager_LibraryStaff_BL staff in Manager_BL.GetstaffList())
                {
                    Console.WriteLine("║ {0,-19} │ {1,-18} │ {2,-19} │ {3,-18} ║",
                        staff.GetLibrarian(),
                        staff.GetLibraryAssistant(),
                        staff.GetLibraryTechnician(),
                        staff.GetLibraryDirector());
                }

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("╚════════════════════╧═══════════════════╧════════════════════╧══════════════════╝");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("No duties assigned to library staff.");
            }
        }



        public static void DeleteDutyUI()
        {
            Console.Write("Enter The Duty Name of The Staff Member you want to remove: ");
            string duty = Console.ReadLine();
            Manager_LibraryStaff_DL.RemoveDuty(duty);
        }

        public static void StaffUI()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\t\tStaff Management System");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1. View Duties");
                Console.WriteLine("2. Add Duties");
                Console.WriteLine("3. Remove Duty");
                Console.WriteLine("4. Exit");
                Console.WriteLine("----------------------------------");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();


                if (choice == "1")
                {
                    ShowDuties();
                    Console.ReadKey();

                }
                else if (choice == "2")
                {
                    AddDuties();
                    Console.WriteLine("Duties Added Successfuly!");
                    Console.ReadKey();

                }
                else if (choice == "3")
                {
                    DeleteDutyUI();

                    Console.ReadKey();

                }

                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }

            }
        }

    }

}

