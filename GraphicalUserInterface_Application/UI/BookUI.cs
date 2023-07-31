//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Buisnessapplication.BL;
//using Buisnessapplication.DL;
//namespace Buisnessapplication.UI
//{
//    class BookUI
//    {
       
//        //...AddBooks
//        public static BookBL AddBooks()
//        {
//            Console.Clear();
//            GeneralUI.logoBook();
//            BookBL book = new BookBL();
//            Console.Write("Enter book title: ");
//            string title = Console.ReadLine();
//            Console.Write("Enter book author: ");
//            string author = Console.ReadLine();
//            Console.Write("Enter book ISBN: ");
//            string isbn = Console.ReadLine();
//            Console.Write("Enter book edition: ");
//            string edition = Console.ReadLine();
//            Console.Write("Enter book genre: ");
//            string genre = Console.ReadLine();
//            Console.Write("Enter Quantity of the Book: ");
//            string quantity = Console.ReadLine();
//            if (book.SetBookQuantity(quantity) && book.SetBooktitle(title) && book.SetBookAuthor(author) && book.SetBookEdition(edition) && book.SetBookGenre(genre) && book.SetBookIsbn(isbn))
//            {

//                book = new BookBL(title, author, isbn, edition, genre, quantity);
//                return book;
//            }

//            return null;
//        }

//        //...Display message

//        public static void FunctionForNotFound()
//        {
//            Console.WriteLine("Book not found in the list .");
//        }
//        public static void errorMessageUser()
//        {
//            Console.WriteLine("Invalid User ");
//        }

//        public static void SuccessfullyAddedBook()
//        {
//            Console.WriteLine("\tBook Added Successfully!");
//        }

//        public static void funtionForInvalidInput()
//        {
//            Console.WriteLine("\tInvalid Input! Please try again.");
//        }

//        public static void functionForNotFound()
//        {
//            Console.WriteLine("Book Not Found! ");
//        }

//        //...UI For Delete Books
//        public static void DeleteBookUI(List<BookBL> bList)
//        {
//            Console.Clear();
//            Console.WriteLine("Enter The Title Of The Book You Want To Delete");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter The Author Of The Book  Want To Delete");
//            string author = Console.ReadLine();

//            bool deleteSuccess = BookDL.DeleteBook(name, author, bList);

//            if (deleteSuccess == true)
//            {
//                Console.WriteLine("Book deleted successfully!");
//                BookDL.DeleteDataBookInFile(pathBook, bList);
//            }
//            else
//            {
//                Console.WriteLine("Book not found !");
//            }
//        }



//        //...UI For Update Books 

//        public static void UpdateBooks(List<BookBL> booksList)
//        {
//            Console.Clear();
//            Console.WriteLine("Enter The Title Of The Book You Want To Update");
//            string name = Console.ReadLine();
//            Console.WriteLine("Enter The Author Of The Book You Want To Update");
//            string author = Console.ReadLine();


//            bool updated = BookDL.UpdateBooks(booksList, name, author);
//            if (updated)
//            {
//                BookDL.UpdateDataBookInFile(pathBook, booksList);
//            }

//            if (!updated)
//            {
//                FunctionForNotFound();

//            }
//            Console.ReadLine();
//        }
//        //...View Books UI
//        public static void ViewBooks()
//        {
//            Console.Clear();
//            if (Admin.GetBookList().Count > 0)
//            {
//                Console.ForegroundColor = ConsoleColor.Magenta;
//                Console.WriteLine("╔═════════════════╦════════════════╦═════════════╦═════════════╦════════════╦══════════╗");
//                Console.WriteLine("║      Title      ║     Author     ║    ISBN     ║   Edition   ║    Genre   ║ Quantity ║");
//                Console.WriteLine("╠═════════════════╬════════════════╬═════════════╬═════════════╬════════════╬══════════╣");
//                Console.ResetColor();

//                foreach (BookBL book in Admin.GetSortedBookList())
//                {
//                    Console.WriteLine("║ {0,-16} ║ {1,-14} ║ {2,-11} ║ {3,-11} ║ {4,-10} ║ {5,-9} ║",
//                        book.GetBookTitle(),
//                        book.GetBookAuthor(),
//                        book.GetIsbnNumber(),
//                        book.GetEdition(),
//                        book.GetGenre(),
//                        book.GetQuantity());
//                }

//                Console.ForegroundColor = ConsoleColor.Magenta;
//                Console.WriteLine("╚═════════════════╩════════════════╩═════════════╩═════════════╩════════════╩══════════╝");
//                Console.ResetColor();
//            }
//            else
//            {
//                Console.WriteLine("No books available.");
//            }
//        }



//        public static void BorrowBookUI()
//        {

//            Console.Write("Enter the Name Of The Book You Want To Borrow: ");
//            string borrowTitle = Console.ReadLine();
//            Console.Write("Enter the Name of the Author: ");
//            string borrowAuthor = Console.ReadLine();

   //         int temp = BookDL.(borrowTitle, borrowAuthor, Admin.GetBookList());
//            if (temp != 0)
//            {
//                Console.WriteLine("Book Borrowed Successfully");
//                BookDL.DeleteDataBookInFile(pathBook, Admin.GetBookList());

//            }
//            else
//            {
//                Console.WriteLine("Book Are are Not Avaibles !");
//            }
//        }

//        public static void BuyBookUI()
//        {

//            Console.Write("Enter the Name Of The Book You Want To Buy: ");
//            string BuyTitle = Console.ReadLine();
//            Console.Write("Enter the Name of the Author: ");
//            string BuyAuthor = Console.ReadLine();

//            int temp = BookDL.BuyBook(BuyTitle, BuyAuthor, Admin.GetBookList());
//            if (temp != 0)
//            {
//                Console.WriteLine("Book Bought Successfully");
//                BookDL.DeleteDataBookInFile(pathBook, Admin.GetBookList());

//            }
//            else
//            {
//                Console.WriteLine("Book Are are Not Avaibles !");
//            }
//        }

//        public static void ReturnBookUI()
//        {

//            Console.Write("Enter the Name Of The Book You Want To Return: ");
//            string BuyTitle = Console.ReadLine();
//            Console.Write("Enter the Name of the Author: ");
//            string BuyAuthor = Console.ReadLine();
//            BookBL b = new BookBL();
//            int temp = BookDL.ReturnBook(BuyTitle, BuyAuthor, Admin.GetBookList());
//            if (temp != 0)
//            {
//                Console.WriteLine("Book Returned Successfully");
//                BookDL.UpdateDataBookInFile(pathBook, Admin.GetBookList());

//            }
//            else
//            {
//                Console.WriteLine("Book Are are Not Avaibles !");
//            }
//        }


//        public static void SearchBook()
//        {
//            Console.Clear();
//            Console.WriteLine("1. Serch Book By Title");
//            Console.WriteLine("2. Serch Book By Isbn");
//            Console.WriteLine("3. Exit");
//            string choice = Console.ReadLine();
//            do
//            {
//                if (choice == "1")
//                {
//                    //funtion for search book by title
//                    Console.Write("Enter The title:");
//                    string title = Console.ReadLine();
//                    bool serchTitle = BookDL.serchBookByTitle(title);
//                    if (serchTitle)
//                    {
//                        Console.WriteLine("Yes! Book is Present In The Library");
//                        Console.ReadKey();
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Book Not Found!");
//                        Console.ReadKey();
//                        break;

//                    }
//                }

//                else if (choice == "2")
//                {
//                    //function for search book isbn
//                    Console.Write("Enter The Isbn Number:");
//                    string isbn = Console.ReadLine();
//                    bool searchIsbn = BookDL.serchBookByIsbn(isbn);
//                    if (searchIsbn)
//                    {
//                        Console.WriteLine("Yes! Book is Present In The Library");
//                        Console.ReadKey();
//                        break;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Book Not Found");
//                        Console.ReadKey();
//                        break;

//                    }


//                }
//            }
//            while (choice != "3");
//        }
//    }
//}


