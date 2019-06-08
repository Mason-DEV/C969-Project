using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969_Project
{
    class DBHelper
    {
        private static int userID;
        private static string userName;
        public static string dataString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + "\\Database.mdf; Integrated Security = True";


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

        public static int userCheck(string user, string pass)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();
            var query = "SELECT userId, userName FROM [dbo].[User] where userName = @userName AND password = @password";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@userName", user);
            cmd.Parameters.AddWithValue("@password", pass);

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                //Set currentID and currentUsername
                setCurrentUserId(Convert.ToInt32(rdr[0]));
                setCurrentUserName(Convert.ToString(rdr[1]));
                rdr.Close();
                conn.Close();
                return 1;
            }
            conn.Close();
            return 0;
        }

        public static string getTimestamp()
        {
            return DateTime.Now.ToString("u");
        }

        public static void createCustomer() {
           // customerID, name, adressID, active, create date, createdby, lastUpdate, updatedby
        }
    }
}
