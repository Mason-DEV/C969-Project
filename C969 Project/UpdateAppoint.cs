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

            var appointList = DBHelper.searchAppointment(id);
            setAppointList(appointList);


            if (appointList != null)
            {
                //Enable fields
                enabling(true);
                //Input data into text fields
                fillFields(appointList);
                //Grabs customer assoicated with appointment
                fillCust(Convert.ToInt32(appointList.First(kvp => kvp.Key == "customerId").Value.ToString()));
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Locks fields
            enabling(false);
            //Lamba used for function to clear fields
            Action<Control.ControlCollection> clearIT = null;

            clearIT = (controls) =>
            {
                foreach (Control option in controls)
                    if (option is TextBox)
                        (option as TextBox).Clear();
                    else if (option is RadioButton)
                        (option as RadioButton).Checked = false;
                    else if (option is DateTimePicker)
                        (option as DateTimePicker).Value = DateTime.Now;
                    else if (option is ComboBox)
                        (option as ComboBox).SelectedIndex = -1;
                    else
                        clearIT(option.Controls);
            };

            clearIT(Controls);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bool pass = validator();
            if (pass)
            {
                DialogResult youSure = MessageBox.Show("Are you sure you want to update this Appointment?", "", MessageBoxButtons.YesNo);
                if (youSure == DialogResult.Yes)
                {
                    try
                    {
                        //Grab List & convert
                        var list = getAppointList();
                        IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                        //replace values for the keys in the form         
                        dictionary["appointmentId"] = AppointList.First(kvp => kvp.Key == "appointmentId").Value;
                        dictionary["customerId"] = customerComboBox.SelectedValue;
                        dictionary["title"] = titleTextbox.Text;
                        dictionary["description"] = descriptionTextbox.Text;
                        dictionary["location"] = locationTextbox.Text;
                        dictionary["contact"] = contactTextbox.Text;
                        dictionary["type"] = typeCombobox.SelectedItem.ToString();
                        dictionary["start"] = startDTP.Value;
                        dictionary["end"] = endDTP.Value;
                        dictionary["url"] = customerComboBox.SelectedValue;

                        //Pass the updated IDictionary to dbhelper to update the database
                        DBHelper.updateAppointment(dictionary);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error occured! " + ex);
                    }
                    finally
                    {
                        ClearButton_Click(null, new EventArgs());
                        MessageBox.Show("Customer Record Updated");
                        this.Owner.Show();
                        this.Close();
                    }
                }
            }
        }

            private void CancelButton_Click(object sender, EventArgs e)
            {
                this.Owner.Show();
                this.Close();
            }

            public void fillAppoint()
            {
                MySqlConnection conn = new MySqlConnection(DBHelper.getDataString());

                try
                {
                    string query = "select appointmentId, concat(appointmentId, (select  concat(' -- Customer: ', customerName) from customer where appointment.customerId = customer.customerId))  as Display from appointment where end > now();";
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
                    Console.WriteLine("Error occured! " + ex);
                }
            }

            public void fillCust(int custID)
            {
                MySqlConnection conn = new MySqlConnection(DBHelper.getDataString());

                try
                {
                    string query = $"SELECT customerId, concat(customerName, ' -- ID: ', customerId) as Display FROM customer;";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Cust");
                    customerComboBox.DisplayMember = "Display";
                    customerComboBox.ValueMember = "customerID";
                    customerComboBox.DataSource = ds.Tables["Cust"];
                    DataRowView drv = customerComboBox.SelectedItem as DataRowView;
                    customerComboBox.SelectedValue = custID;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occured! " + ex);
                }
            }

            private void enabling(bool status)
            {
                customerComboBox.Enabled = status;
                titleTextbox.Enabled = status;
                descriptionTextbox.Enabled = status;
                locationTextbox.Enabled = status;
                contactTextbox.Enabled = status;
                typeCombobox.Enabled = status;
                startDTP.Enabled = status;
                endDTP.Enabled = status;
                updateButton.Enabled = status;
            }

            private void fillFields(List<KeyValuePair<string, object>> AppointList)
            {
                // Lambda used to set text values from kvp
                titleTextbox.Text = AppointList.First(kvp => kvp.Key == "title").Value.ToString();
                descriptionTextbox.Text = AppointList.First(kvp => kvp.Key == "description").Value.ToString();
                locationTextbox.Text = AppointList.First(kvp => kvp.Key == "location").Value.ToString();
                contactTextbox.Text = AppointList.First(kvp => kvp.Key == "contact").Value.ToString();
                typeCombobox.SelectedIndex = typeCombobox.FindStringExact(AppointList.First(kvp => kvp.Key == "type").Value.ToString());
                string start = AppointList.First(kvp => kvp.Key == "start").Value.ToString();
                string end = AppointList.First(kvp => kvp.Key == "end").Value.ToString();
                startDTP.Value = Convert.ToDateTime(start).ToLocalTime();
                endDTP.Value = Convert.ToDateTime(end).ToLocalTime();

            }

        private bool validator()
        {

            if (emptyCheck() == false)
            {
                MessageBox.Show("Please complete all Appointment Information fields.");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(titleTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(titleLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(descriptionTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(descriptionLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(locationTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(locationLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(contactTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(contactLabel.Text);
                return false;
            }
            if (typeCombobox.SelectedIndex == -1)
            {
                showError(typeLabel.Text);
                return false;
            }
            if (customerComboBox.SelectedIndex == -1)
            {
                showError(customerLabel.Text);
                return false;
            }

            return true;
        }

        private void showError(string item)
        {
            MessageBox.Show("Please enter a valid information for " + item);

        }
        private bool emptyCheck()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
    }
