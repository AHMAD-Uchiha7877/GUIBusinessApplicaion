using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.BL
{
    public class NoticesBL
    {
        public string Title;
        public string Description;
        public string Date;
        public NoticesBL(string title, string description, string date)
        {
            Title = title;
            Description = description;
            Date = date;
        }
        public NoticesBL()
        { }

        public Admin Admin
        {
            get => default;
            set
            {
            }
        }

        // Getter functions
        public string getTitle()
        {
            return Title;
        }
        public string getDescription()
        {
            return Description;
        }
        public string getDate()
        {
            return Date;
        }
        // Setter functions
        public bool setTitle(string title)
        {
            if (title != null)
            {
                Title = title;
                return true;
            }
            return false;
        }
        public bool setDescription(string description)
        {
            if (description != null)
            {
                Description = description;
                return true;
            }
            return false;
        }
        public bool setDate(string date)
        {
            if (date != null)
            {
                Date = date;
                return true;

            }
            return false;
        }
    }
}