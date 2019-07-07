using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class UpdateAppoint : Form
    {
        public static List<KeyValuePair<string, object>> AppointList;
        public UpdateAppoint()
        {
            InitializeComponent();
            fillAppoint();
        }

        public void setAppointList(List<KeyValuePair<string, object>> list)
        {

            AppointList = list;

        }

        public static List<KeyValuePair<string, object>> getAppointList()
        {

            return AppointList;
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Grabs ID
            DataRowView drv = appointComboBox.SelectedItem as DataRowView;
            int id = Convert.ToInt32(appointComboBox.SelectedValue);
            Console.WriteLine(id);
            
            var appointList = DBHelper.searchAppointment(id);
            setAppointList(appointList);
            Console.WriteLine(getAppointList());
            //Calls db helper to get all customer results as object array
            //object[] custArray = null; //DBHelper.searchCustomer(id);
            //If we got a null array, don't continue

            if (appointList != null)
            {
                //Enable fields
                enabling(true);
                //Input data into text fields
                fillFields(appointList);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Locks fields
            enabling(false);
            //Lamba function TODO: give reason why I used this; 
            Action<Control.ControlCollection> clearIT = null;

            clearIT = (controls) =>
            {
                foreach (Control option in controls)
                    if (option is TextBox)
                        (option as TextBox).Clear();
                    else if (option is RadioButton)
                        (option as RadioButton).Checked = false;
                    else
                        clearIT(option.Controls);
            };

            clearIT(Controls);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        public void fillAppoint()
        {
            MySqlConnection conn = new MySqlConnection(DBHelper.getDataString());

            try
            {
                //string query = "SELECT customerId, concat(customerName, ' -- ID: ', customerId) as Display FROM customer;";
                string query = "select appointmentId, concat(appointmentId, (select  concat(' -- Customer: ', customerName) from customer where appointment.customerId = customer.customerId))  as Display from appointment;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Appoint");
                appointComboBox.DisplayMember = "Display";
                appointComboBox.ValueMember = "appointmentId";
                appointComboBox.DataSource = ds.Tables["Appoint"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured! " + ex);
            }
        }

        private void enabling(bool status)
        {
            titleTextbox.Enabled = status;
            descriptionTextbox.Enabled = status;
            locationTextbox.Enabled = status;
            contactTextbox.Enabled = status;
            typeTextbox.Enabled = status;
            startDTP.Enabled = status;
            endDTP.Enabled = status;
            updateButton.Enabled = status;
        }

        private void fillFields(List<KeyValuePair<string, object>> AppointList)
        {
            //Lambda
            titleTextbox.Text = AppointList.First(kvp => kvp.Key == "title").Value.ToString();
            descriptionTextbox.Text = AppointList.First(kvp => kvp.Key == "description").Value.ToString();
            locationTextbox.Text = AppointList.First(kvp => kvp.Key == "location").Value.ToString();
            contactTextbox.Text = AppointList.First(kvp => kvp.Key == "contact").Value.ToString();
            typeTextbox.Text = AppointList.First(kvp => kvp.Key == "type").Value.ToString();

        }
    }
}
