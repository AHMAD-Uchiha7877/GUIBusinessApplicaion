using System;
using BusinessApplication.DL;
using Buisnessapplication.BL;
using GraphicalUserInterface_Application;

namespace BusinessApplication.UI
{
    public class NoticesUI
    {

       
        public static void ShowNotices()
        {
            Console.WriteLine("Notice Board");
            Console.WriteLine("----------------------------------");

            var notices = Admin.GetNoticesList();

            if (notices.Count > 0)
            {
                foreach (NoticesBL notice in Admin.GetNoticesList())
                {
                    Console.WriteLine("Title:" + notice.getTitle());
                    Console.WriteLine("Description:" + notice.getDescription());
                    Console.WriteLine("Posted By:" + notice.getDate());

                    Console.WriteLine("----------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No notices available.");
            }
        }

        public static void AddNotice()
        {
            Console.WriteLine("Add Notice");
            Console.WriteLine("----------------------------------");

            Console.Write("Enter the title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the description: ");
            string description = Console.ReadLine();

            Console.Write("Enter the date (e.g., yyyy-mm-dd): ");
            string dateStr = Console.ReadLine();


            NoticesBL n = new NoticesBL();
            if (n.setTitle(title) && n.setDescription(description) && n.setDate(dateStr))
            {
                n = new NoticesBL(title, description, dateStr);
                Admin.AddNoticeList(n);
                NoticesDL.StoreDataNoticeInFile(View_Notices.pathNotice, n);
                Console.WriteLine("Notice added successfully!");
            }

            else
            {
                Console.WriteLine("Invalid date format. Notice not added.");
            }
        }


        public static void RemoveNotice()
        {
            Console.WriteLine("Remove Notice");
            Console.WriteLine("----------------------------------");

            Console.Write("Enter the title of the notice to remove: ");
            string title = Console.ReadLine();

            bool check = NoticesDL.RemoveNotice(title);
            if (check)
            {
                Console.WriteLine("Notice Deleted Successfuly! ");
            }
            else
            {
                Console.WriteLine("Notice not found.");
            }
        }

        public static void MainMenuNotices()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Notice Management System");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1. View Notices");
                Console.WriteLine("2. Add Notice");
                Console.WriteLine("3. Remove Notice");
                Console.WriteLine("4. Exit");
                Console.WriteLine("----------------------------------");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();


                if (choice == "1")
                {
                    ShowNotices();
                    Console.ReadKey();
                    break;
                }
                else if (choice == "2")
                {
                    AddNotice();


                    Console.ReadKey();
                    break;
                }
                else if (choice == "3")
                {
                    RemoveNotice();
                    NoticesDL.DeleteDataNoticeInFile(View_Notices.pathNotice, Admin.GetNoticesList());
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
