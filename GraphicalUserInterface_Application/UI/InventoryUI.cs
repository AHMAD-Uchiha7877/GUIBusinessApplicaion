using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
using Buisnessapplication.DL;

namespace Buisnessapplication.UI
{
    public class InventoryUI
    {
      
        public static void AddStock()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║                Add Stock                   ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");

            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            bool bookFound = serchBookInventory(title);

            if (bookFound)
            {
                Console.Write("Enter quantity to add: ");
                string quantity = Console.ReadLine();
                Console.Write("Enter stock condition: ");
                string condition = Console.ReadLine();
                Console.Write("Enter stock location: ");
                string location = Console.ReadLine();

                IventoryBL inventory = new IventoryBL(title, quantity, condition, location);
                Manager_BL.AddInventoryIntoList(inventory);
               // InventoryDL.storeDataInventoryInFile(pathInventory, inventory);

                Console.WriteLine("Stock added successfully.");
            }
            else
            {
                Console.WriteLine("Book not found in inventory.");
            }
        }



        public static void ViewStocks()
        {

            if (Manager_BL.GetInventoryList().Count > 0)
            {
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║                               View Stocks                                      ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");

                foreach (IventoryBL stock in Manager_BL.GetInventoryList())
                {
                    Console.WriteLine("Title:  " + stock.GetTitleInventory());
                    Console.WriteLine("Quantity:" + stock.GetQuantity());
                    Console.WriteLine("Condition:" + stock.GetCondition());
                    Console.WriteLine("Location:" + stock.GetLocation());
                    Console.WriteLine("------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Inventory is empty. No stocks to display.");
            }
        }

        public static void ManageInventory()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║          Manage Inventory - Manager        ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Add Stock");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewStocks();

                        break;
                    case "2":
                        AddStock();
                        break;
                    //case "3":
                    //    DeleteStock();
                    //    break;

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

        public static bool serchBookInventory(string title)
        {
            foreach (BookBL b in Admin.GetBookList())
            {
                if (title == b.GetBookTitle())
                {
                    return true;
                }
            }
            return false;
        }
        //public static void DeleteStock()
        //{
        //    Console.Clear();
        //    Console.WriteLine("╔════════════════════════════════════════════╗");
        //    Console.WriteLine("║              Delete Stock                  ║");
        //    Console.WriteLine("╚════════════════════════════════════════════╝");

        //    Console.Write("Enter book title: ");
        //    string title = Console.ReadLine();
        //    Console.WriteLine("Enter The Aythor Name");
        //    string author= Console.ReadLine();
        //   bool found= serchBookInventory(title,author);
        //    if (found)
        //    {

        //        BookDL.DeleteBook(title,author,BookDL.booksList);
        //        Console.WriteLine("Stock deleted successfully.");
        //        InventoryDL.DeleteDataInventoryInFile(pathInventory, InventoryDL.inventoryListt);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Book not found in inventory.");
        //    }
        //}


    }
}
