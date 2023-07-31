using System;
using System.Collections.Generic;
using Buisnessapplication.BL;
using Buisnessapplication.UI;
using Buisnessapplication.DL;
using BusinessApplication.DL;
using System.IO;


namespace BusinessApplication.DL
{
    class NoticesDL
    {


        public static bool RemoveNotice(string notice)
        {
            foreach (NoticesBL n in Admin.GetNoticesList())
            {
                if (notice == n.getTitle())
                {
                    Admin.GetNoticesList().Remove(n);
                }
                return true;
            }
            return false;
        }
        public static string ParseData(string record, int field)
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
        public static bool ReadDataNotice(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string title = ParseData(record, 1);
                    string Description = ParseData(record, 2);
                    string date = ParseData(record, 3);

                    NoticesBL notice = new NoticesBL(title, Description, date);
                    Admin.AddNoticeList(notice);

                }
                fileVariable.Close();
                return true;
            }
            return false;


        }
        public static void StoreDataNoticeInFile(string path, NoticesBL notice)
        {

            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(notice.getTitle() + "," + notice.getDescription() + "," + notice.getDate());
            file.Flush();
            file.Close();

        }
        public static void DeleteDataNoticeInFile(string path, List<NoticesBL> noticeList)
        {
            StreamWriter file = new StreamWriter(path, false);
            foreach (NoticesBL notice in noticeList)
            {
                file.WriteLine(notice.getTitle() + "," + notice.getDescription() + "," + notice.getDate());
            }
            file.Flush();
            file.Close();
        }

    }
}
