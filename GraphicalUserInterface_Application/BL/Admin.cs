using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Buisnessapplication.BL
{
    public class Admin
    {

        private static List<BookBL> booksList = new List<BookBL>();
        public static void AddBooksIntoList(BookBL book)
        {
            booksList.Add(book);
        }
        public static List<BookBL> GetBookList()
        {
            return booksList;
        }
        public static List<BookBL> GetSortedBookList()
        {
            List<BookBL> sortedList = booksList.OrderBy(book => book.GetBookTitle()).ToList();
            return sortedList;
        }
        //users
        private static List<UserBL> usersList = new List<UserBL>();
        public static List<UserBL> GetUserList()
        {
            return usersList;
        }
        public static List<UserBL> GetSortedUserList()
        {
            List<UserBL> user = usersList.OrderBy(o => o.getName()).ToList();
            return user;
        }
        public static void addUserIntoList(UserBL u)
        {
            usersList.Add(u);
        }
        public static void StoreAdminCredentials(string path)
        {
            string adminName = "ahmad";
            string adminPassword = "123";
            string adminRole = "admin";

            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(adminName + "," + adminPassword + "," + adminRole);
            }
        }
        //...Notices
        private static List<NoticesBL> noticesList = new List<NoticesBL>();

        public static List<NoticesBL> GetNoticesList()
        {
            return noticesList;
        }
        public static void AddNoticeList(NoticesBL notice)
        {
            noticesList.Add(notice);
        }

    }
}
