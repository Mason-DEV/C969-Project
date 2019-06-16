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
        public static string neat = Application.StartupPath;
        
       //public static string dataString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + Application.StartupPath + @"\Database.mdf; Integrated Security=True;";
        public static string dataString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Mason\Documents\GitHub\C969-Project\C969 Project\Database.mdf';Integrated Security=True";
       
        


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
            Console.WriteLine(neat);
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();
            var query = "SELECT userId, userName FROM [dbo].[Users] where userName = @userName AND password = @password";
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

        public static DateTime getDateTime()
        {
            return DateTime.Now.ToUniversalTime();
          
        }



        public static void createCustomer(int id, string name, int addressId, bool active, DateTime dateTime, int createId)
        {
            //1,nameTextbox.Text, addressTextbox.Text, yesRadio.Checked, DateTime.Now, DBHelper.getCurrentUserId(), DBHelper.getTimestamp()
            // customerID, name, adressID, active, create date, createdby, lastUpdate, updatedby
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();

            SqlTransaction transaction;
            // Start a local transaction.
            transaction = conn.BeginTransaction();

            var query = "INSERT into [dbo].[Customer] customerId, customerName, addressId,active, createDate, createdBy, lastUpdate, lastUpdateBy " +
                        $"VALUES ('{id}', '{name}',  '{addressId}', '{active}', '{dateTime}', '{createId}', '{timestamp}', '{createId}')";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
        }

        //This grabs the max id from table and returns it
        public static int getID(string table, string id) {

            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();
            var query = $"SELECT max({id}) FROM {table}";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            
            SqlDataReader rdr = cmd.ExecuteReader();
           
            if (rdr.HasRows)
            {
                rdr.Read();
                if (rdr[0] == DBNull.Value)
                {
                    conn.Close();
                    return 0;
                }
             
                conn.Close();
                return Convert.ToInt32(rdr[0]); ;
                
              
            }
            conn.Close();
            return 0;
        }

        public static int createCountry(string country)
        {
            //Int(10) countryID, varchar(50) country, Datetime createDate, varchar(40) createdBy, timestamp lastUpdate, varchar(40) lastUpdateBy;

            //Grab maxint of other crounties for countryID
            int countryID = getID("Country", "countryID") + 1;
            //Pass in country text from form
            //Grab datetime
            //grab usernane for createdby
            string user = getCurrentUserName();
            //grab timestamp for lastUpdate
            DateTime utc = getDateTime();
            //grab username for lastUpdatedBy

            //SQL 
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();

            SqlTransaction transaction;
            // Start a local transaction.
            transaction = conn.BeginTransaction();

            var query = "INSERT into [dbo].[Country] (countryID, country, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{countryID}', '{country}', '{utc}','{user}', '{user}')";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();

            return countryID;
        }

        public static int createCity(int countryID, string city)
        {
            //Int(10) cityID, varchar(50) city, int(10) countryID, Datetime createDate, varchar(40) createdBy, timestamp lastUpdate, varchar(40) lastUpdateBy;
            int cityID = getID("City", "cityId") + 1;
            string user = getCurrentUserName();
            DateTime utc = getDateTime();
 
            //SQL 
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();

            SqlTransaction transaction;
            // Start a local transaction.
            transaction = conn.BeginTransaction();

            var query = "INSERT into [dbo].[City] (cityId, city, countryId, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{cityID}', '{city}', '{countryID}', '{utc}','{user}', '{user}')";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();

            return cityID;

        }

        public static int createAddress(int cityID, string address, string postalCode, string phone) {
            //addressId INT(10) address VARCHAR(50) address2 VARCHAR(50) cityId INT(10) postalCode VARCHAR(10) phone VARCHAR(20)
            //createDate DATETIME createdBy VARCHAR(40) lastUpdate TIMESTAMP lastUpdateBy VARCHAR(40)

            int addressID = getID("Address", "addressId");
            string user = getCurrentUserName();
            DateTime utc = getDateTime();
            //SQL 
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();

            SqlTransaction transaction;
            // Start a local transaction.
            transaction = conn.BeginTransaction();

            var query = "INSERT into [dbo].[Address] (addressId, address, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{addressID}', '{address}', '{cityID}', '{postalCode}', '{phone}', '{utc}','{user}', '{user}')";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();

            return addressID;
        }
    }
}
