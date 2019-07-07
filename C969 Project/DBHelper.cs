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
        public static string dataString = "server=52.206.157.109;database=U05lxQ;uid=U05lxQ;pwd=53688540778; convert zero datetime=True";


        public static string getDataString() {
            return dataString;
        }
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

        public static DataTable dashboard(string filter, bool week) {

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            //Week filter where end date and start date are less than a week away
            //Month filter where end date and start date are less than a month away
            string query = week ? $"SELECT customerId as 'Customer ID',  start as 'Start Time', end as 'End Time', location as 'Location', title as 'Title' FROM appointment where start < '{filter}' and end < '{filter}' and createdBy = '{DBHelper.getCurrentUserId()}' order by start;"
                : $"SELECT  customerId as 'Customer ID', start as 'Start Time', end as 'End Time', location as 'Location', title as 'Title' FROM appointment where start < '{filter}' and end < '{filter}' and createdBy = '{DBHelper.getCurrentUserId()}' order by start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //Converts the time to localtime from utc in DB
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row);
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }

            conn.Close();
            return dt;
            /*

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(query, conn);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            sqlDataAdap.Update(dtRecord);
            conn.Close();

            //Converts the time to localtime from utc in DB
            foreach (DataRow row in dtRecord.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }

            Console.WriteLine(dtRecord);
            return dtRecord;
            */
        }

        public static int userCheck(string user, string pass)
        {

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT userId, userName FROM user where userName = '{user}' AND password = '{pass}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
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

        public static string dateSQLFormat(DateTime dateValue)
        {
            string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm");

            return formatForMySql;
        }


        //Creates customer record
        public static void createCustomer(int id, string name, int addressId, int active, DateTime dateTime, string user)
        {

            string sqlDate = dateSQLFormat(dateTime);
            Console.WriteLine(dateTime);
            Console.WriteLine(sqlDate);

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();

            MySqlTransaction transaction = conn.BeginTransaction();
            

            var query = "INSERT into customer (customerId, customerName, addressId,active, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{id}', '{name}',  '{addressId}', '{active}', '{dateSQLFormat(dateTime)}', '{user}', '{user}')";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
        }

        //This grabs the max id from table and returns it
        public static int getID(string table, string id)
        {

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query = $"SELECT max({id}) FROM {table}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

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

            int countryID = getID("country", "countryID") + 1;
            string user = getCurrentUserName();
            DateTime utc = getDateTime();


            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();

            MySqlTransaction transaction = conn.BeginTransaction();

            var query = "INSERT into country (countryID, country, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{countryID}', '{country}', '{dateSQLFormat(utc)}','{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();

            return countryID;
        }

        //Creates city record
        public static int createCity(int countryID, string city)
        {
            int cityID = getID("city", "cityId") + 1;
            string user = getCurrentUserName();
            DateTime utc = getDateTime();

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();

            MySqlTransaction transaction = conn.BeginTransaction();

            var query = "INSERT into city (cityId, city, countryId, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{cityID}', '{city}', '{countryID}', '{dateSQLFormat(utc)}','{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();

            return cityID;

        }
        
        //Creates address record
        public static int createAddress(int cityID, string address, string postalCode, string phone)
        {

            int addressID = getID("address", "addressId") + 1;
            string user = getCurrentUserName();
            DateTime utc = getDateTime();

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();

            MySqlTransaction transaction = conn.BeginTransaction();

            var query = "INSERT into address (addressId, address, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{addressID}', '{address}', '{cityID}', '{postalCode}', '{phone}', '{dateSQLFormat(utc)}','{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
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
            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query = $"SELECT * FROM customer WHERE customerId = {customerID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
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

                var query2 = $"SELECT * FROM address WHERE addressId = {addressID}";
                cmd.CommandText = query2;
                cmd.Connection = conn;
                MySqlDataReader rdr2 = cmd.ExecuteReader();
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

                var query3 = $"SELECT * FROM city WHERE cityId = {cityID}";
                cmd.CommandText = query3;
                cmd.Connection = conn;
                MySqlDataReader rdr3 = cmd.ExecuteReader();
                if (rdr3.HasRows)
                {
                    rdr3.Read();
                    list.Add(new KeyValuePair<string, object>("city", rdr3[1]));
                    list.Add(new KeyValuePair<string, object>("countryId", rdr3[2]));
                    rdr3.Close();
                }

                //Get country info now that we have countryId
                var countryID = list.First(kvp => kvp.Key == "countryId").Value;

                var query4 = $"SELECT * FROM country WHERE countryId = {countryID}";
                cmd.CommandText = query4;
                cmd.Connection = conn;
                MySqlDataReader rdr4 = cmd.ExecuteReader();
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

        //Lookup appoint info and return it as a list
        public static List<KeyValuePair<string, object>> searchAppointment(int appointmentID)
        {
            var list = new List<KeyValuePair<string, object>>();
            //Get customer Table info
            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query = $"SELECT * FROM appointment WHERE appointmentId = {appointmentID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.HasRows)
                {
                    rdr.Read();
                    list.Add(new KeyValuePair<string, object>("appointmentId", rdr[0]));
                    list.Add(new KeyValuePair<string, object>("customerId", rdr[1]));
                    list.Add(new KeyValuePair<string, object>("title", rdr[2]));
                    list.Add(new KeyValuePair<string, object>("description", rdr[3]));
                    list.Add(new KeyValuePair<string, object>("location", rdr[4]));
                    list.Add(new KeyValuePair<string, object>("contact", rdr[5]));
                    list.Add(new KeyValuePair<string, object>("type", rdr[6]));
                    list.Add(new KeyValuePair<string, object>("contact", rdr[7]));
                    list.Add(new KeyValuePair<string, object>("start", rdr[8]));
                    list.Add(new KeyValuePair<string, object>("end", rdr[9]));
                    rdr.Close();
                }
                else
                {
                    MessageBox.Show("No Appointment found with the ID: " + appointmentID, "Please try again");
                    return null;
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

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            var query = $"UPDATE country" +
                $" SET country = '{dictionary["country"]}', lastUpdateBy = '{user}'" +
                $" WHERE countryId = '{dictionary["countryId"]}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a city transaction.
            transaction = conn.BeginTransaction();
            var query2 = $"UPDATE city" +
                $" SET city = '{dictionary["city"]}', lastUpdateBy = '{user}'" +
                $" WHERE cityId = '{dictionary["cityId"]}'";
            cmd.CommandText = query2;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a address transaction.
            transaction = conn.BeginTransaction();
            var query3 = $"UPDATE address" +
                $" SET address = '{dictionary["address"]}', lastUpdateBy = '{user}', postalCode = '{dictionary["postalCode"]}', phone = '{dictionary["phone"]}'" +
                $" WHERE addressId = '{dictionary["addressId"]}'";
            cmd.CommandText = query3;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a customer transaction.
            transaction = conn.BeginTransaction();
            var query4 = $"UPDATE customer" +
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
            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query4= $"DELETE FROM customer" +
               $" WHERE customerId = '{dictionary["customerId"]}'";
            MySqlCommand cmd = new MySqlCommand(query4, conn);
            MySqlTransaction transaction = conn.BeginTransaction();
           
            cmd.CommandText = query4;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            

            // Start a address transaction.
            transaction = conn.BeginTransaction();
            var query3 = $"DELETE FROM address" +
                $" WHERE addressId = '{dictionary["addressId"]}'";
            cmd.CommandText = query3;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a city transaction.
            transaction = conn.BeginTransaction();
            var query2 = $"DELETE FROM city" +
                $" WHERE cityId = '{dictionary["cityId"]}'";
            cmd.CommandText = query2;
            cmd.Connection = conn;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a country transaction.
            transaction = conn.BeginTransaction();
            var query = $"DELETE FROM country" +
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

            int appointID = getID("appointment", "appointmentId") + 1;
            Console.WriteLine(appointID);
            int userID = 1;
            
            DateTime utc = getDateTime();

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction(); ;
            // Start a local transaction.
            var query = "INSERT into appointment (appointmentId, customerId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{appointID}', '{custID}', '{title}', '{description}', '{location}', '{contact}', '{type}', '{custID}', '{dateSQLFormat(start)}','{dateSQLFormat(endTime)}','{dateSQLFormat(utc)}','{userID}','{userID}')";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
            
        }
    }


}

