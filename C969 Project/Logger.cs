using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{


    class Logger
    {


        public static void signIn(string userName)
        {

            Dictionary<DateTime, string> dictionary = new Dictionary<DateTime, string>();
            dictionary.Add(DateTime.Now, userName);

            foreach (KeyValuePair<DateTime, string> keyValue in dictionary)
            {

                string log = string.Format("Login time = {0}, userName = {1}", keyValue.Key, keyValue.Value);
                Console.WriteLine(log);
                StringBuilder sb = new StringBuilder();
                sb.Append(log + Environment.NewLine);

                File.AppendAllText(Application.StartupPath + "_logins-logouts.txt", sb.ToString());
                sb.Clear();

            }
        }


        public static void signOut(string userName)
        {

            Dictionary<DateTime, string> dictionary = new Dictionary<DateTime, string>();
            dictionary.Add(DateTime.Now, userName);

            foreach (KeyValuePair<DateTime, string> keyValue in dictionary)
            {
                string log = string.Format("Logout time = {0}, userName = {1}", keyValue.Key, keyValue.Value);
                Console.WriteLine(log);
                StringBuilder sb = new StringBuilder();
                sb.Append(log + Environment.NewLine);

                File.AppendAllText(Application.StartupPath + "_logins-logouts.txt", sb.ToString());
                sb.Clear();

            }
        }

    }

}

