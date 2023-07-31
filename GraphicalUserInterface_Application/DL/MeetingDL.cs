using Buisnessapplication.BL;
using System;
using System.Collections.Generic;
using System.IO;

namespace Buisnessapplication.DL
{
    internal class MeetingDL
    {
      

        public static bool ReadMeetings(string path, List<MeetingBL> meeting)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;

                while ((record = file.ReadLine()) != null)
                {
                    string title = ParseData(record, 0);
                    string date = ParseData(record, 1);
                    string time = ParseData(record, 2);
                    string location = ParseData(record, 3);
                    string organizer = ParseData(record, 4);

                    MeetingBL m = new MeetingBL(title, date, time, location, organizer);
                    meeting.Add(m);
                }

                file.Close();
                return true;
            }

            return false;
        }
        public static bool DeleteMeeting(string name)
        {
            foreach(MeetingBL meeting in Manager_BL.GetMeetingList())
            {
                if(meeting.GetTitle()==name)
                {
                    Manager_BL.GetMeetingList().Remove(meeting);
                    return true;
                }
               
            }
            return false;
        }

        public static void DeleteMeetingFromFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);

            foreach (MeetingBL meeting in Manager_BL.GetMeetingList())
            {
                file.WriteLine($"{meeting.GetTitle()},{meeting.GetDate()},{meeting.GetTime()},{meeting.GetLocation()},{meeting.GetOrganizer()}");
            }

            file.Flush();
            file.Close();
        }
        public static void StoreMeetings( string path)
        {
            StreamWriter file = new StreamWriter(path,true);

            foreach (MeetingBL meeting in Manager_BL.GetMeetingList())
            {
                file.WriteLine($"{meeting.GetTitle()},{meeting.GetDate()},{meeting.GetTime()},{meeting.GetLocation()},{meeting.GetOrganizer()}");
            }

            file.Flush();
            file.Close();
        }

        public static string ParseData(string record, int field)
        {
            string[] fields = record.Split(',');
            if (field >= 0 && field < fields.Length)
            {
                return fields[field];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
