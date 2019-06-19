﻿using System;
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
    public partial class DeleteCustomer : Form
    {
        public static List<KeyValuePair<string, object>> CustList;
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        public void setCustList(List<KeyValuePair<string, object>> list)
        {

            CustList = list;

        }

        public static List<KeyValuePair<string, object>> getCustList()
        {

            return CustList;
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
        private void enabling(bool status)
        {
            deleteButton.Enabled = status;
        }
        private void fillFields(List<KeyValuePair<string, object>> custList)
        {
            //Lambda
            nameTextbox.Text = custList.First(kvp => kvp.Key == "customerName").Value.ToString();
            phoneTextbox.Text = custList.First(kvp => kvp.Key == "phone").Value.ToString();
            addressTextbox.Text = custList.First(kvp => kvp.Key == "address").Value.ToString();
            cityTextbox.Text = custList.First(kvp => kvp.Key == "city").Value.ToString();
            zipTextbox.Text = custList.First(kvp => kvp.Key == "postalCode").Value.ToString();
            countryTextbox.Text = custList.First(kvp => kvp.Key == "country").Value.ToString();
            if (Convert.ToInt32(custList.First(kvp => kvp.Key == "active").Value) == 1)
            {
                yesRadio.Checked = true;
            }
            else
            {
                noRadio.Checked = true;
            }
        }

            private void SearchButton_Click(object sender, EventArgs e)
            {
                //Grabs ID
                int id = Convert.ToInt32(customerIdTextbox.Text);
                var custList = DBHelper.searchCustomer(id);
                setCustList(custList);
                //Calls db helper to get all customer results as object array
                //object[] custArray = null; //DBHelper.searchCustomer(id);
                //If we got a null array, don't continue
                if (custList != null)
                {
                    //Enable fields
                    enabling(true);
                    //Input data into text fields
                    fillFields(custList);
                }
            }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult youSure = MessageBox.Show("Are you sure you want to delete this customer?", "", MessageBoxButtons.YesNo);
            if (youSure == DialogResult.Yes)
            {
                //Delete the things
                try
                {
                    //Grab List & convert
                    var list = getCustList();
                    IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                    DBHelper.deleteCustomer(dictionary);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    ClearButton_Click(null, new EventArgs());
                    MessageBox.Show("Customer Record Deleted");
                }
                
            }
            
        }
    }
}
