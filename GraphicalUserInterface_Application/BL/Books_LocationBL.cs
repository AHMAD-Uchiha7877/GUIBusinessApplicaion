using System;

namespace Buisnessapplication.BL
{
    class Books_LocationBL
    {
        private string Book_Category;
        private string Location;
        private string ShelfNumber;
        private string Section;
        private string RackNumber;
        public Books_LocationBL(string category, string location, string shelfNumber, string section, string rackNumber)
        {
            Book_Category = category;
            Location = location;
            ShelfNumber = shelfNumber;
            Section = section;
            RackNumber = rackNumber;
        }
        public Books_LocationBL()
        {

        }

        internal Manager_BL Manager_BL
        {
            get => default;
            set
            {
            }
        }

        public string GetBookCategory()
        {
            return Book_Category;
        }

        public bool SetBookCategory(string category)
        {
            if (!string.IsNullOrEmpty(category))
            {
                Book_Category = category;
                return true;
            }
            return false;
        }

        public string GetLocation()
        {
            return Location;
        }

        public bool SetLocation(string location)
        {
            if (!string.IsNullOrEmpty(location))
            {
                Location = location;
                return true;
            }
            return false;
        }

        public string GetShelfNumber()
        {
            return ShelfNumber;
        }

        public bool SetShelfNumber(string shelfNumber)
        {
            if (!string.IsNullOrEmpty(shelfNumber))
            {
                ShelfNumber = shelfNumber;
                return true;
            }
            return false;
        }

        public string GetSection()
        {
            return Section;
        }

        public bool SetSection(string section)
        {
            if (!string.IsNullOrEmpty(section))
            {
                Section = section;
                return true;
            }
            return false;
        }

        public string GetRackNumber()
        {
            return RackNumber;
        }

        public bool SetRackNumber(string rackNumber)
        {
            if (!string.IsNullOrEmpty(rackNumber))
            {
                RackNumber = rackNumber;
                return true;
            }
            return false;
        }
    }
}
