using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.BL
{
    public class CustomerBL : UserBL
    {

        private string Cnic;
        private string Gmail;
        private string address;
        private string Gender;

        public string GetCnic()
        {
            return Cnic;
        }
        public bool SetCnic(string cnic)
        {
            if (!string.IsNullOrEmpty(cnic) && cnic.Length == 13)
            {
                Cnic = cnic;
                return true;
            }
            return false;
        }
        public string GetGmail()
        {
            return Gmail;
        }
        public bool SetEmail(string email)
        {
            if (!string.IsNullOrEmpty(email) && email.Contains('@'))
            {
                Gmail = email;
                return true;
            }
            return false;
        }
        public string GetGender()
        {
            return Gender;
        }
        public bool SetGender(string gender)
        {
            if (!string.IsNullOrEmpty(gender))
            {
                Gender = gender;
                return true;
            }
            return false;
        }
        // Constructor parametrized
        public CustomerBL(string name, string password, string role, string cnic, string gmail, string address, string gender) : base(name, password, role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            Cnic = cnic;
            Gmail = gmail;
            this.address = address;
            Gender = gender;
        }
        public CustomerBL() : base()
        {

        }
        public bool SetAddress(string address)
        {
            if (!string.IsNullOrEmpty(address))
            {
                this.address = address;
                return true;
            }
            return false;
        }

        public string GetAddress()
        {
            return address;
        }
    }
}
