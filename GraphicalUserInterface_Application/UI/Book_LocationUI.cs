using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
using Buisnessapplication.DL;

namespace Buisnessapplication.UI
{
    internal class Book_LocationUI
    {
        public static string pathLocation = "BookDeatils.txt";

        public static void LocationMenuBooks()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║          Location Menu - Books             ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine("1. Add Location Details");
                Console.WriteLine("2. View Location Details");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddDetailsLocationOfBook();
                        break;
                    case "2":
                        ShowLocationBookDetails();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        public static Books_LocationBL AddDetailsLocationOfBook()
        {
            Console.WriteLine("Enter The Category Of The Book:");
            string cat = Console.ReadLine();
            Console.WriteLine("Enter the Location of the Book:");
            string location = Console.ReadLine();

            Console.WriteLine("Enter the Shelf Number:");
            string shelfNumber = Console.ReadLine();

            Console.WriteLine("Enter the Section:");
            string section = Console.ReadLine();

            Console.WriteLine("Enter the Rack Number:");
            string rackNumber = Console.ReadLine();
            Books_LocationBL locationBook = new Books_LocationBL(cat, location, shelfNumber, section, rackNumber);
            Manager_BL.addLocationIntoList(locationBook);
            Book_LocationDL.storeDataLaocationBook(pathLocation, locationBook);
            if (locationBook.SetLocation(location) && locationBook.SetShelfNumber(shelfNumber) && locationBook.SetSection(section) && locationBook.SetRackNumber(rackNumber))
            {
                return locationBook;
            }

            return null;
        }



        public static void ShowLocationBookDetails()
        {
            if (Manager_BL.GetLocationBook().Count > 0)
            {
                Console.WriteLine("\t\t\tLocation Book Details:");
                foreach (Books_LocationBL locationBook in Manager_BL.GetLocationBook())
                {
                    Console.WriteLine("Category:" + locationBook.GetBookCategory());
                    Console.WriteLine("Location of the Book: " + locationBook.GetLocation());
                    Console.WriteLine("Shelf Number: " + locationBook.GetShelfNumber());
                    Console.WriteLine("Section: " + locationBook.GetSection());
                    Console.WriteLine("Rack Number: " + locationBook.GetRackNumber());
                    Console.WriteLine("-------------------------");
                }
            }
            else
            {
                Console.WriteLine("No Location Book details available.");
            }


        }
    }
}

