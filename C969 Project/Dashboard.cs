using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class Dashboard : Form
    {

        public static string dataString = DBHelper.getDataString();
        public Dashboard()
        {
            InitializeComponent();
            this.FormClosing += Dashboard_FormClosing;
            Dashboard_Load(weekViewRadio.Checked);
        }

        private void createCusButton_Click(object sender, EventArgs e)
        {
            Form createCust = new CreateCustomer();
            createCust.Owner = this;
            createCust.Show();
            this.Hide();
        }

        private void updateCusButton_Click(object sender, EventArgs e)
        {
            Form updateCust = new UpdateCustomer();
            updateCust.Owner = this;
            updateCust.Show();
            this.Hide();
        }

        private void deleteCusButton_Click(object sender, EventArgs e)
        {
            Form deleteCust = new DeleteCustomer();
            deleteCust.Owner = this;
            deleteCust.Show();
            this.Hide();
        }

        private void numApptButton_Click(object sender, EventArgs e)
        {

        }

        private void schedButton_Click(object sender, EventArgs e)
        {

        }

        private void cusReportButton_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.signOut(DBHelper.getCurrentUserName());
        }

        private void AddApptButton_Click(object sender, EventArgs e)
        {
            Form addPoint = new AddAppoint();
            addPoint.Owner = this;
            addPoint.Show();
            this.Hide();
        }

        private void Dashboard_Load(bool week)
        {
        
            DateTime filter = week ? calcDateFilter("week") : calcDateFilter("month");

            DataTable dtRecord = DBHelper.dashboard(filter, week);
            dataGridView.DataSource = dtRecord;
        }

        private void WeekViewRadio_CheckedChanged(object sender, EventArgs e)
        {
            Dashboard_Load(weekViewRadio.Checked);
        }


        public DateTime calcDateFilter(string type)
        {
            if (type == "week")
            {
                DateTime week = DateTime.Now.AddDays(7);
                return week;
            }
            else
            {
                DateTime month = DateTime.Now.AddMonths(1);
                return month;
            }
        }


        private Timer timer;
        public void InitTimer()
        {
            if (timer != null)
            {
                timer.Stop();
            }
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 60000; // in miliseconds
            timer.Start();
            reminder();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            reminder();
        }

        private void reminder()
        {
            try
            {
                Console.WriteLine("Checking Appointments");
                DateTime logTime = DateTime.Now;
                logTime = TimeZone.CurrentTimeZone.ToLocalTime(logTime);
                //Look at if we have an appointment 15min away 
                var row = this.dataGridView.Rows[0];
                string end = row.Cells["End Time"].Value.ToString();
                DateTime endTime = Convert.ToDateTime(end);
                //Math
                TimeSpan span = endTime.Subtract(logTime);
                int min = (int)Math.Round(span.TotalMinutes);

                if (min == 15)
                {
                    MessageBox.Show("You have an appoinment in 15 Min");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
          
        }

    }
}
