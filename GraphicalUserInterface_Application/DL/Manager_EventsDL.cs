using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buisnessapplication.BL;
using System.IO;
using GraphicalUserInterface_Application.GUI.ManagerFuntion_Form;

namespace Buisnessapplication.DL
{
    class Manager_EventsDL
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

        public static bool ReadDataEvents(string path, List<Manager_EventsBL> eventsList)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = ParseData(record, 1);
                    string date = ParseData(record, 2);
                    string duration = ParseData(record, 3);
                    string Location = ParseData(record, 4);
                    Manager_EventsBL events = new Manager_EventsBL(name, date, duration, Location);
                    eventsList.Add(events);

                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        //...Store Data in File
        public static void storeDataEventsInFile(string path, Manager_EventsBL events)
        {
            StreamWriter file = new StreamWriter(path, true);//Write in the file
            file.WriteLine(events.getEventName() + "," + events.getEventDate() + "," + events.getEventDuration() + "," + events.getEventLocation());
            file.Flush();
            file.Close();
        }
        public static bool RemoveEvent(string eventName)
        {
            List<Manager_EventsBL> eventsList = Manager_BL.GetEventsList();
            Manager_EventsBL eventToRemove = null;

            foreach (Manager_EventsBL e in eventsList)
            {
                if (string.Equals(eventName, e.getEventName(), StringComparison.OrdinalIgnoreCase))
                {
                    eventToRemove = e;
                    break;
                }
            }

            if (eventToRemove != null)
            {
                eventsList.Remove(eventToRemove);
                Manager_EventsDL.DeleteDataEventsInFile(AddMeeting_form.pathMeeting, eventsList);
                return true;
            }

            return false;
        }

        public static void DeleteDataEventsInFile(string path, List<Manager_EventsBL> eList)
        {
            using (StreamWriter file = new StreamWriter(path, false))
            {
                foreach (Manager_EventsBL e in eList)
                {
                    file.WriteLine(e.getEventName() + "," + e.getEventDate() + "," + e.getEventDuration() + "," + e.getEventLocation());
                }
            }
        }



    }
}
