using System;
using System.Collections.Generic;
using System.IO;
using Buisnessapplication.BL;

namespace Buisnessapplication.DL
{


    class BookDL
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
        public static bool ReadDataBook(string path, List<BookBL> booksList)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string title = ParseData(record, 1);
                    string author = ParseData(record, 2);
                    string isbn = ParseData(record, 3);
                    string edition = ParseData(record, 4);
                    string genre = ParseData(record, 5);
                    string quantity = ParseData(record, 6);
                    BookBL book = new BookBL(title, author, isbn, edition, genre, quantity);
                    booksList.Add(book);

                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        //...Store Data in File
        public static void storeDataBookInFile(string path, BookBL book)
        {
            StreamWriter file = new StreamWriter(path, true);//Write in the file
            file.WriteLine(book.GetBookTitle() + "," + book.GetBookAuthor() + "," + book.GetIsbnNumber() + "," + book.GetEdition() + "," + book.GetGenre() + "," + book.GetQuantity());
            file.Flush();
            file.Close();
        }
        //...Funtion For Update Books
        public static bool UpdateBooks(List<BookBL> booksList, string name, string author)
        {
            foreach (BookBL book in booksList)
            {
                if (name == book.GetBookTitle() && author == book.GetBookAuthor())
                {
                    bool updated = false;
                    string update;
                    do
                    {
                        Console.WriteLine("Enter what you want to update in the book (or 'exit' to finish): ");
                        update = Console.ReadLine();

                        if (update == "title")
                        {
                            Console.Write("Enter the New Title: ");
                            string newTitle = Console.ReadLine();
                            book.SetBooktitle(newTitle);
                            Console.WriteLine("Title Updated Successfully!");
                            updated = true;
                        }
                        else if (update == "author")
                        {
                            Console.Write("Enter the New Author: ");
                            string newAuthor = Console.ReadLine();
                            book.SetBookAuthor(newAuthor);
                            Console.WriteLine("Author Updated Successfully!");
                            updated = true;
                        }
                        else if (update == "isbn")
                        {
                            Console.Write("Enter the New ISBN: ");
                            string newISBN = Console.ReadLine();
                            book.SetBookIsbn(newISBN);
                            Console.WriteLine("ISBN Updated Successfully!");
                            updated = true;
                        }
                        else if (update == "edition")
                        {
                            Console.Write("Enter the New Edition: ");
                            string newEdition = Console.ReadLine();
                            book.SetBookEdition(newEdition);
                            Console.WriteLine("Edition Updated Successfully!");
                            updated = true;
                        }
                        else if (update == "quantity")
                        {
                            Console.Write("Enter the New Quantity: ");
                            string newQuantityStr = Console.ReadLine();
                            if (int.Parse(newQuantityStr) > 0)
                            {
                                book.SetBookQuantity(newQuantityStr);
                                Console.WriteLine("Quantity Updated Successfully!");
                                updated = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid quantity. Please enter a valid number.");
                            }
                        }
                        else if (update == "genre")
                        {
                            Console.Write("Enter the New Genre: ");
                            string newGenre = Console.ReadLine();
                            book.SetBookGenre(newGenre);
                            Console.WriteLine("Genre Updated Successfully!");
                            updated = true;
                        }

                    } while (!updated && update != "exit");

                    return updated;
                }

            }

            return false;
        }

        //...Funtion For Update From File
        public static void UpdateDataBookInFile(string path, List<BookBL> booksList)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (BookBL b in booksList)
            {
                file.WriteLine(b.GetBookTitle() + "," + b.GetBookAuthor() + "," + b.GetIsbnNumber() + "," + b.GetEdition() + "," + b.GetGenre() + "," + b.GetQuantity());
            }
            file.Flush();
            file.Close();
        }


        //...Funtion For delete Books
        public static bool DeleteBook(string name, string author, List<BookBL> booksList)
        {
            bool flag = false;
            //int count = -1;
            foreach (BookBL book in booksList)
            {
                if (name == book.GetBookTitle() && author == book.GetBookAuthor())
                {
                    //count++;
                    Console.WriteLine("Enter the quantity to delete: ");
                    string deleteQuantityStr = Console.ReadLine();
                    int deleteQuantity = int.Parse(deleteQuantityStr);
                    int currentQuantity = int.Parse(book.GetQuantity());
                    if (deleteQuantity <= currentQuantity)
                    {
                        int updatedQuantity = currentQuantity - deleteQuantity;
                        book.SetBookQuantity(updatedQuantity.ToString());

                        if (updatedQuantity == 0)
                        {
                            booksList.Remove(book); // Remove the book from the list

                        }
                        flag = true;
                        break;

                    }
                }

            }

            return flag;
        }

        //...Funtion from deleting Books in file

        public static void DeleteDataBookInFile(string path, List<BookBL> bookList)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (BookBL b in bookList)
            {
                file.WriteLine(b.GetBookTitle() + "," + b.GetBookAuthor() + "," + b.GetIsbnNumber() + "," + b.GetEdition() + "," + b.GetGenre() + "," + b.GetQuantity());
            }
            file.Flush();
            file.Close();
        }

        public static int BorrowBook(string name, string author, List<BookBL> bList)
        {
            foreach (BookBL b in bList)
            {
                if (name == b.GetBookTitle() && author == b.GetBookAuthor())
                {
                    int currentQuantity = int.Parse(b.GetQuantity());
                    int minusQuantity = currentQuantity - 1;
                    b.SetBookQuantity(minusQuantity.ToString());
                    return minusQuantity;
                }
            }
            return 0;
        }

        public static int ReturnBook(string name, string author, List<BookBL> bList)
        {
            foreach (BookBL b in bList)
            {
                if (name == b.GetBookTitle() && author == b.GetBookAuthor())
                {
                    int currentQuantity = int.Parse(b.GetQuantity());
                    int newQuantity = currentQuantity + 1;
                    b.SetBookQuantity(newQuantity.ToString());
                    return newQuantity;
                }
            }
            return 0;
        }


        public static bool serchBookByTitle(string title)
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

        public static bool serchBookByIsbn(string isbn)
        {
            foreach (BookBL b in Admin.GetBookList())
            {
                if (isbn == b.GetIsbnNumber())
                {
                    return true;
                }
            }
            return false;
        }

        public static int BuyBook(string name, string author, List<BookBL> bList)
        {
            foreach (BookBL b in bList)
            {
                if (name == b.GetBookTitle() && author == b.GetBookAuthor())
                {
                    int currentQuantity = int.Parse(b.GetQuantity());
                    int minusQuantity = currentQuantity - 1;
                    b.SetBookQuantity(minusQuantity.ToString());
                    return minusQuantity;
                }
            }
            return 0;
        }

    }
}