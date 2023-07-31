using System;

namespace Buisnessapplication.BL
{

    internal class MeetingBL
    {
        private string title;
        private string date;
        private string time;
        private string location;
        private string organizer;
        public MeetingBL() { }
        public MeetingBL(string title, string date, string time, string location, string organizer)
        {
            this.title = title;
            this.date = date;
            this.time = time;
            this.location = location;
            this.organizer = organizer;
        }

        internal Manager_BL Manager_BL
        {
            get => default;
            set
            {
            }
        }

        public string GetTitle()
        {
            return title;
        }
        public bool SetTitle(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                title = value;
                return true;
            }
            return false;
        }
        public string GetDate()
        {
            return date;
        }
        public bool SetDate(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                date = value;
                return true;
            }
            return false;
        }
        public string GetTime()
        {
            return time;
        }
        public bool SetTime(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                time = value;
                return true;
            }
            return false;
        }
        public string GetLocation()
        {
            return location;
        }
        public bool SetLocation(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                location = value;
                return true;
            }
            return false;
        }
        public string GetOrganizer()
        {
            return organizer;
        }

        public bool SetOrganizer(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                organizer = value;
                return true;
            }
            return false;
        }
    }
}
