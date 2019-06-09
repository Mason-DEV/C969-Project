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
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DBHelper.getID("User", "userID");


            bool pass = validator();
            if (pass)
            {
                Console.WriteLine("Creating");
                //TODO: Can we make create/update
                //TODO: UTC time? Then convert back based on time?
                //TODO: Create a DBhelper function that creates the unique ID for everything

                //Need to create country record
                //Need to create city record
                //Need to create address record
                //Need to create customer record  -- customerID, name, adressID, active, create date, createdby, lastUpdate, updatedby
               // DBHelper.createCustomer(1,nameTextbox.Text, 1, yesRadio.Checked, DateTime.Now, DBHelper.getCurrentUserId(), DBHelper.getTimestamp());
                
                
               
                

            }

        }

        private bool validator()
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(nameTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(nameLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(phoneTextbox.Text, "[^0-9-()]+$"))
            {
                showError(phoneLabel.Text);
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(zipTextbox.Text, "[^0-9]"))
            {
                showError(zipLabel.Text);
                return false;
            }
            /*
            if (emptyCheck() == false)
            {
                MessageBox.Show("Please complete all Customer Information fields.");
            }
            */

            return true;
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

        private void showError(string item)
        {
            Console.WriteLine("called");
            MessageBox.Show("Please enter a valid information for " + item);

        }
    }
}
