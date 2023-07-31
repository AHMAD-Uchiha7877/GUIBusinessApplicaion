using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.BL
{

    class Manager_LibraryStaff_BL
    {
        private string librarian;
        private string libraryAssistant;
        private string libraryTechnician;
        private string libraryDirector;


        public Manager_LibraryStaff_BL()
        {
        }

        // Parameterized constructor
        public Manager_LibraryStaff_BL(string librarian, string libraryAssistant, string libraryTechnician, string libraryDirector)
        {
            this.librarian = librarian;
            this.libraryAssistant = libraryAssistant;
            this.libraryTechnician = libraryTechnician;
            this.libraryDirector = libraryDirector;

        }

        internal Manager_BL Manager_BL
        {
            get => default;
            set
            {
            }
        }

        public string GetLibrarian()
        {
            return librarian;
        }

        public bool SetLibrarian(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                librarian = name;
                return true;
            }
            return false;
        }

        public string GetLibraryAssistant()
        {
            return libraryAssistant;
        }

        public bool SetLibraryAssistant(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                libraryAssistant = name;
                return true;
            }
            return false;
        }

        public string GetLibraryTechnician()
        {
            return libraryTechnician;
        }

        public bool SetLibraryTechnician(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                libraryTechnician = name;
                return true;
            }
            return false;
        }

        public string GetLibraryDirector()
        {
            return libraryDirector;
        }

        public bool SetLibraryDirector(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                libraryDirector = name;
                return true;
            }
            return false;
        }
    }

}
