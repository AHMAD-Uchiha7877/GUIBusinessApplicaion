using Buisnessapplication.BL;
using Buisnessapplication.DL;
using System;
using System.Collections.Generic;

namespace Buisnessapplication.UI
{
    internal class MeetingUI
    {
       
        public static void ShowMenuMeeting()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║              Meeting Schedule              ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("1. Add Meeting");
                Console.WriteLine("2. Show Meetings");
                Console.WriteLine("3. Cancelled Meeting");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddMeeting();
                        break;
                    case "2":
                        ShowMeetings();
                        break;
                    case "3":
                        MeetingDelete();
                        Console.ReadLine();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }


        public static void MeetingDelete()
        {
            Console.Write("Enter The Title Of The meeting You Want To Remove:");
            string title = Console.ReadLine();
            bool check = MeetingDL.DeleteMeeting(title);
            if (check)
            {
                Console.WriteLine("Meeting Cencelled Successfuly!");
              //  MeetingDL.DeleteMeetingFromFile(pathMeeting);
            }
            else
            {
                Console.WriteLine("Don't Have Meeting Of The Name!");
            }
        }
        public static void ShowMeetings()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║              Meeting Schedule                                              ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");

            if (Manager_BL.GetMeetingList().Count > 0)
            {
                foreach (MeetingBL meeting in Manager_BL.GetMeetingList())
                {
                   

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Title: {0}", meeting.GetTitle());
                    Console.WriteLine("Date: {0}", meeting.GetDate());
                    Console.WriteLine("Time: {0}", meeting.GetTime());
                    Console.WriteLine("Location: {0}", meeting.GetLocation());
                    Console.WriteLine("Organizer: {0}", meeting.GetOrganizer());
                    Console.WriteLine("-------------------------------------------");
                    Console.ResetColor();
                }

            }
            else
            {
                Console.WriteLine("No meetings scheduled.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void AddMeeting()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║               Add Meeting                  ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");

            Console.Write("Enter meeting title: ");
            string title = Console.ReadLine();
            Console.Write("Enter meeting date: ");
            string date = Console.ReadLine();
            Console.Write("Enter meeting time: ");
            string time = Console.ReadLine();
            Console.Write("Enter meeting location: ");
            string location = Console.ReadLine();
            Console.Write("Enter meeting organizer: ");
            string organizer = Console.ReadLine();

            MeetingBL meeting = new MeetingBL(title, date, time, location, organizer);
            Manager_BL.AddMeetingsIntoList(meeting);
          //  MeetingDL.StoreMeetings( pathMeeting);

            Console.WriteLine("Meeting added successfully.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
