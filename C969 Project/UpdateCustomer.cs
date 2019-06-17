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
    public partial class UpdateCustomer : Form
    {
        public static List<KeyValuePair<string, object>> CustList;

        public UpdateCustomer()
        {
            InitializeComponent();
        }

        public void setCustList(List<KeyValuePair<string, object>> list) {

            CustList = list;

        }

        public static List<KeyValuePair<string, object>> getCustList() {

            return CustList;
        }



            private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
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


        private void SearchButton_Click(object sender, EventArgs e)
        {
            //TODO:
            //Grab customer ID value
            //Search DBs with ID value
            //IF we get a single result, unlock fields and input info into text fields
            //Else display no match found warning


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


        private void enabling(bool status)
        {
            nameTextbox.Enabled = status;
            phoneTextbox.Enabled = status;
            addressTextbox.Enabled = status;
            cityTextbox.Enabled = status;
            zipTextbox.Enabled = status;
            countryTextbox.Enabled = status;
            yesRadio.Enabled = status;
            noRadio.Enabled = status;
            updateButton.Enabled = status;
        }

        private void fillFields(List<KeyValuePair<string, object>> custList)
        {
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
                noRadio.Checked = false;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            //grab all IDs
            //grab things that wont change
            var list = getCustList();
            Console.WriteLine(list.First(kvp => kvp.Key == "customerId").Value.ToString());
        }
    }
}
