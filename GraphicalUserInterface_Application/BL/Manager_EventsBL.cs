using System;

namespace Buisnessapplication.BL
{
    class Manager_EventsBL
    {
        private string Event_Name;
        private string Event_Date;
        private string Event_Duration;
        private string Event_Location;
        public Manager_EventsBL()
        {

        }

        public Manager_EventsBL(string Event_Name, string Event_Date, string Event_Duration, string Event_Location)
        {
            this.Event_Name = Event_Name;
            this.Event_Date = Event_Date;
            this.Event_Duration = Event_Duration;
            this.Event_Location = Event_Location;
        }

        internal Manager_BL Manager_BL
        {
            get => default;
            set
            {
            }
        }

        public string getEventName()
        {
            return Event_Name;
        }

        public bool setEventName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Event_Name = name;
                return true;
            }
            return false;
        }

        public string getEventDate()
        {
            return Event_Date;
        }

        public bool setEventDate(string date)
        {
            if (!string.IsNullOrEmpty(date))
            {
                Event_Date = date;
                return true;
            }
            return false;
        }

        public string getEventDuration()
        {
            return Event_Duration;
        }

        public bool setEventDuration(string duration)
        {
            if (!string.IsNullOrEmpty(duration))
            {
                Event_Duration = duration;
                return true;
            }
            return false;
        }

        public string getEventLocation()
        {
            return Event_Location;
        }

        public bool setEventLocation(string location)
        {
            if (!string.IsNullOrEmpty(location))
            {
                Event_Location = location;
                return true;
            }
            return false;
        }
    }
}
