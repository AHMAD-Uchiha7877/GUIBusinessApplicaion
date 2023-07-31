using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Buisnessapplication.BL;
using System.Security.Claims;

namespace Buisnessapplication.DL
{
    class UserDL
    {
        //public static List<UserBL> usersList = new List<UserBL>();

        //public static List<UserBL> GetUserList()
        //{
        //    return usersList;
        //}

        //public static List<UserBL> GetSortedList()
        //{
        //    List<UserBL> user = usersList.OrderBy(o => o.getName()).ToList();
        //    return user;
        //}


        //public static void addIntoList(UserBL u)
        //{
        //    usersList.Add(u);
        //}

        public static string parseData(string record, int field)
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
        public static bool ReadData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);

                    if (role == "admin")
                    {
                        UserBL admin = new UserBL(name, password, role);
                        Admin.addUserIntoList(admin);
                    }
                    else if (role == "customer")
                    {
                        string cnic = parseData(record, 4);
                        string mail = parseData(record, 5);
                        string address = parseData(record, 6);
                        string gender = parseData(record, 7);


                        CustomerBL customer = new CustomerBL(name, password, role, cnic, mail, address, gender);
                        Admin.addUserIntoList(customer);
                    }
                    else if (role == "manager")
                    {
                        string id = parseData(record, 4);
                        string position = parseData(record, 5);
                        string contact = parseData(record, 6);
                        string gender = parseData(record, 7);

                        Manager_BL emp = new Manager_BL(name, password, role, id, position, contact, gender);
                        Admin.addUserIntoList(emp);
                    }
                }

                fileVariable.Close();
                return true;
            }
            return false;
        }
       public static UserBL SignIn(UserBL user)
        {
            foreach (UserBL storedUser in Admin.GetUserList())
            {
                if (user.getName() == storedUser.getName() && user.getPassword() == storedUser.getPassword())
                {
                    if (storedUser is Manager_BL)
                    {
                        Manager_BL manager = (Manager_BL)storedUser;
                        return manager;
                    }
                    else if (storedUser is CustomerBL)
                    {
                        CustomerBL customer = (CustomerBL)storedUser;
                        return customer;
                    }
                    
                }
            }

            return null;
        }
        public static void UserFile_Store(string path)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                foreach (UserBL u in Admin.GetUserList())
                {
                    if (u is CustomerBL)
                    {
                        CustomerBL c = (CustomerBL)u;
                        file.WriteLine(c.getName() + "," + c.getPassword() + "," + c.getRole() + "," + c.GetCnic() + "," + c.GetGmail() + "," + c.GetAddress() + "," + c.GetGender());
                    }
                    else if (u is Manager_BL)
                    {
                        Manager_BL e = (Manager_BL)u;
                        file.WriteLine(e.getName() + "," + e.getPassword() + "," + e.getRole() + "," + e.getId() + "," + e.getPosition() + "," + e.getContact() + "," + e.getGender());
                    }
                }
            }
        }
        public static void UserFile_Remove(string path)
        {
            using (StreamWriter file = new StreamWriter(path, false))
            {
                foreach (UserBL u in Admin.GetUserList())
                {
                    if (u is CustomerBL)
                    {
                        CustomerBL c = (CustomerBL)u;
                        file.WriteLine(c.getName() + "," + c.getPassword() + "," + c.getRole() + "," + c.GetCnic() + "," + c.GetGmail() + "," + c.GetAddress() + "," + c.GetGender());
                    }
                    else if (u is Manager_BL)
                    {
                        Manager_BL e = (Manager_BL)u;
                        file.WriteLine(e.getName() + "," + e.getPassword() + "," + e.getRole() + "," + e.getId() + "," + e.getPosition() + "," + e.getContact() + "," + e.getGender());
                    }
                }
            }
        }
        public static bool RemoveUserFromList(string name)
        {
            bool flag = false;
            for (int i = 0; i < Admin.GetUserList().Count; i++)
            {
                UserBL u = Admin.GetUserList()[i];
                if (name == u.getName())
                {
                    if (u is CustomerBL || u is Manager_BL)
                    {
                        Admin.GetUserList().RemoveAt(i);
                        flag = true;
                        i--; // Decrement i to account for the removed element
                    }
                }
            }
            return flag;
        }

    }
}
