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
        public static string dataString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Mason\Documents\GitHub\C969-Project\C969 Project\Database.mdf';Integrated Security=True";
        //public static string dataString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Database.mdf;Integrated Security=True";



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


        //Creates customer record
        public static void createCustomer(int id, string name, int addressId, int active, DateTime dateTime, string user)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();

            SqlTransaction transaction;
            transaction = conn.BeginTransaction();

            var query = "INSERT into [dbo].[Customer] (customerId, customerName, addressId,active, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{id}', '{name}',  '{addressId}', '{active}', '{dateTime}', '{user}', '{user}')";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
        }

        //This grabs the max id from table and returns it
        public static int getID(string table, string id)
        {

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

                    return 0;
                }


                return Convert.ToInt32(rdr[0]); ;


            }

            return 0;
        }

        //Creates Country record
        public static int createCountry(string country)
        {

            int countryID = getID("Country", "countryID") + 1;
            string user = getCurrentUserName();
            DateTime utc = getDateTime();


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

        //Creates city record
        public static int createCity(int countryID, string city)
        {
            int cityID = getID("City", "cityId") + 1;
            string user = getCurrentUserName();
            DateTime utc = getDateTime();

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

        //Creates address record
        public static int createAddress(int cityID, string address, string postalCode, string phone)
        {

            int addressID = getID("Address", "addressId") + 1;
            string user = getCurrentUserName();
            DateTime utc = getDateTime();

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

        //Lookup customer info and return it as a list
        public static List<KeyValuePair<string, object>> searchCustomer(int customerID)
        {
            var list = new List<KeyValuePair<string, object>>();
            //Get customer Table info
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();
            var cmd = new System.Data.SqlClient.SqlCommand();

            var query = $"SELECT * FROM Customer WHERE customerId = {customerID}";
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.HasRows)
                {
                    rdr.Read();
                    list.Add(new KeyValuePair<string, object>("customerId", rdr[0]));
                    list.Add(new KeyValuePair<string, object>("customerName", rdr[1]));
                    list.Add(new KeyValuePair<string, object>("addressId", rdr[2]));
                    list.Add(new KeyValuePair<string, object>("active", rdr[3]));
                    rdr.Close();
                }
                else
                {
                    MessageBox.Show("No Customer found with the ID: " + customerID, "Please try again");
                    return null;
                }

                //Get Address info now that we have addressID
                var addressID = list.First(kvp => kvp.Key == "addressId").Value;

                var query2 = $"SELECT * FROM Address WHERE addressId = {addressID}";
                cmd.CommandText = query2;
                cmd.Connection = conn;
                SqlDataReader rdr2 = cmd.ExecuteReader();
                if (rdr2.HasRows)
                {
                    rdr2.Read();
                    list.Add(new KeyValuePair<string, object>("address", rdr2[1]));
                    list.Add(new KeyValuePair<string, object>("cityId", rdr2[3]));
                    list.Add(new KeyValuePair<string, object>("postalCode", rdr2[4]));
                    list.Add(new KeyValuePair<string, object>("phone", rdr2[5]));
                    rdr2.Close();
                }

                //Get city info now that we have cityID
                var cityID = list.First(kvp => kvp.Key == "cityId").Value;

                var query3 = $"SELECT * FROM City WHERE cityId = {cityID}";
                cmd.CommandText = query3;
                cmd.Connection = conn;
                SqlDataReader rdr3 = cmd.ExecuteReader();
                if (rdr3.HasRows)
                {
                    rdr3.Read();
                    list.Add(new KeyValuePair<string, object>("city", rdr3[1]));
                    list.Add(new KeyValuePair<string, object>("countryId", rdr3[2]));
                    rdr3.Close();
                }

                //Get country info now that we have countryId
                var countryID = list.First(kvp => kvp.Key == "countryId").Value;

                var query4 = $"SELECT * FROM Country WHERE countryId = {countryID}";
                cmd.CommandText = query4;
                cmd.Connection = conn;
                SqlDataReader rdr4 = cmd.ExecuteReader();
                if (rdr4.HasRows)
                {
                    rdr4.Read();
                    list.Add(new KeyValuePair<string, object>("country", rdr4[1]));
                    rdr4.Close();
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        //Updates the database of all values assoicated with updating customer record
        /*
            Key = customerId, Value = 2
            Key = customerName, Value = Mason
            Key = addressId, Value = 3
            Key = active, Value = 1
            Key = address, Value = Ivory Dr
            Key = cityId, Value = 6
            Key = postalCode, Value = 33573
            Key = phone, Value = 7275973188
            Key = city, Value = Ruskin
            Key = countryId, Value = 14
            Key = country, Value = USA
        */

        public static void updateCustomer(IDictionary<string, object> dictionary)
        {
            string user = getCurrentUserName();
            DateTime utc = getDateTime();

            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();
            SqlTransaction transaction;

            // Start a country transaction.
            transaction = conn.BeginTransaction();
            var query = $"UPDATE country" +
                $" SET country = '{dictionary["country"]}', lastUpdateBy = '{user}'" +
                $" WHERE countryId = '{dictionary["countryId"]}'";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a city transaction.
            transaction = conn.BeginTransaction();
            var query2 = $"UPDATE City" +
                $" SET city = '{dictionary["city"]}', lastUpdateBy = '{user}'" +
                $" WHERE cityId = '{dictionary["cityId"]}'";
            cmd.CommandText = query2;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a address transaction.
            transaction = conn.BeginTransaction();
            var query3 = $"UPDATE Address" +
                $" SET address = '{dictionary["address"]}', lastUpdateBy = '{user}', postalCode = '{dictionary["postalCode"]}', phone = '{dictionary["phone"]}'" +
                $" WHERE addressId = '{dictionary["addressId"]}'";
            cmd.CommandText = query3;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a customer transaction.
            transaction = conn.BeginTransaction();
            var query4 = $"UPDATE Customer" +
                $" SET customerName = '{dictionary["customerName"]}', lastUpdateBy = '{user}', active = '{dictionary["active"]}'" +
                $" WHERE customerId = '{dictionary["customerId"]}'";
            cmd.CommandText = query4;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
        }

        public static void deleteCustomer(IDictionary<string, object> dictionary)
        {
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();
            var cmd = new System.Data.SqlClient.SqlCommand();
            SqlTransaction transaction;

            // Start a customer transaction.
            transaction = conn.BeginTransaction();
            var query4 = $"DELETE FROM Customer" +
                $" WHERE customerId = '{dictionary["customerId"]}'";
            cmd.CommandText = query4;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            

            // Start a address transaction.
            transaction = conn.BeginTransaction();
            var query3 = $"DELETE FROM Address" +
                $" WHERE addressId = '{dictionary["addressId"]}'";
            cmd.CommandText = query3;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a city transaction.
            transaction = conn.BeginTransaction();
            var query2 = $"DELETE FROM City" +
                $" WHERE cityId = '{dictionary["cityId"]}'";
            cmd.CommandText = query2;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a country transaction.
            transaction = conn.BeginTransaction();
            var query = $"DELETE FROM Country" +
                $" WHERE countryId = '{dictionary["countryId"]}'";
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();


        }


        public static void createAppointment(int custID, string title, string description, string location, string contact, string type, DateTime start, DateTime endTime)
        {
            //Need to create Appointment record  -- int appointmentID, int customerID, int userId, varchar255 title, text description, text location,
            //text contact, text type, varchar 255 url, datetime start, datetime end, datetime createDate, varchar40 createdby, varchar 40 updatedby

            int appointID = getID("Appointment", "appointmentId") + 1;
            int userID = 1;
            DateTime utc = getDateTime();

            SqlConnection conn = new System.Data.SqlClient.SqlConnection(dataString);
            conn.Open();
            SqlTransaction transaction;
            // Start a local transaction.
            transaction = conn.BeginTransaction();
            var query = "INSERT into [dbo].[Appointment] (appointmentId, customerId, userI, title, description, location, contact, type, url, startTime, endTime, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{appointID}', '{custID}', '{userID}','{title}', '{description}', '{location}', '{contact}', '{type}','{custID}', '{start}','{endTime}','{utc}','{userID}','{userID}')";
            var cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
        }
    }


}

