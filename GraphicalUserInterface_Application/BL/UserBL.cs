using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisnessapplication.BL
{
    public class UserBL : Admin
    {
        protected string name;
        protected string password;
        protected string role;
        public UserBL(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public UserBL(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public UserBL()
        { }

        public bool setName(string name)
        {
            if (!string.IsNullOrEmpty(name) && name.Length < 20)
            {
                this.name = name;
                return true;
            }
            return false;
        }

        public bool setPassword(string password)
        {
            if (!string.IsNullOrEmpty(password) && password.Length >= 3)
            {
                this.password = password;
                return true;
            }
            return false;
        }
        public bool setRole(string role)
        {
            if (role != null && !string.IsNullOrEmpty(role))
            {
                this.role = role;
                return true;
            }
            return false;
        }
        public string getName()
        {

            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public string getRole()
        {
            return role;
        }
        public string CheckUser()
        {
            if (role == "admin")
            {
                return role;
            }
            else if (role == "manager")
            {
                return role;
            }
            else if (role == "Customer")
            {
                return role;
            }
            else
            {
                return "System does not has these users!";
            }
        }

    }
}
