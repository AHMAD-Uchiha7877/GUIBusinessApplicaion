using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
using Buisnessapplication.DL;
namespace Buisnessapplication.UI
{
    class Manager_EventsUI
    {

    
        public static Manager_EventsBL AddEvents()
        {
            Console.Write("Enter The Name Of The Event: ");
            string name = Console.ReadLine();

            Console.Write("Set The Date {xx-yy-zzzz}: ");
            string date = Console.ReadLine();

            Console.Write("Enter The Duration Of The Event: ");
            string duration = Console.ReadLine();

            Console.Write("Enter The Location Of the Event: ");
            string location = Console.ReadLine();

            Manager_EventsBL eventObj = new Manager_EventsBL();
            if (eventObj.setEventDate(name) && eventObj.setEventDate(date) && eventObj.setEventDuration(duration) && eventObj.setEventLocation(location))
            {
                Manager_EventsBL eventDetails = new Manager_EventsBL(name, date, duration, location);
                
                return eventDetails;
            }

            return null;
        }
        public static void ShowEvents()
        {
            if (Manager_BL.GetEventsList().Count > 0)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("|     Event Name        |        Event Date         |  Event Duration   |     Event Location       |");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");

                foreach (Manager_EventsBL e in Manager_BL.GetEventsList())
                {
                    Console.WriteLine("| {0,-21} | {1,-25} | {2,-18} | {3,-21} |", e.getEventName(), e.getEventDate(), e.getEventDuration(), e.getEventLocation());
                }

                Console.WriteLine("---------------------------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("No events available.");
            }
        }




        public static void EventsUI()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\t\tEvents Management System");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1. Add Events");
                Console.WriteLine("2. View Events");
                Console.WriteLine("3. Remove Events");
                Console.WriteLine("4. Exit");
                Console.WriteLine("----------------------------------");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Manager_EventsBL e = AddEvents();
                    if (e != null)
                    {
                        Manager_BL.AddEventsIntoList(e);
                       
                      //  Manager_EventsDL.storeDataEventsInFile(pathEvents, e);
                        Console.WriteLine("Event Added Successfully!");
                    }

                    Console.ReadKey();
                }
                else if (choice == "2")
                {
                    ShowEvents();
                    Console.ReadKey();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter The Name Of The Event: ");
                    string name = Console.ReadLine();
                    bool removed = Manager_EventsDL.RemoveEvent(name);
                    if (removed)
                    {
                        Console.WriteLine("Event Removed Successfully!");
                        //Manager_EventsDL.DeleteDataEventsInFile(pathEvents,Manager_BL.GetEventsList());
                    }
                    else
                    {
                        Console.WriteLine("Event Not Found!");
                    }

                    Console.ReadKey();
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ReadKey();
                }
            }
        }



    }
}
