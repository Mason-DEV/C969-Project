using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Project
{
    class DBHelper
    {
        private static int userID;
        private static string userName;
        public static string conString = "@'Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=' + Application.StartupPath + '\\Database.mdf';Integrated Security=True";

        public static int getCurrentUserId()
        {
            return userID;
        }

        public static void setCurrentUserId(int currentUserId)
        {
            userID = currentUserId;
        }

        public static string getCurrentUserName()
        {
            return userName;
        }

        public static void setCurrentUserName(string currentUserName)
        {
            userName = currentUserName;
        }
    }
}
