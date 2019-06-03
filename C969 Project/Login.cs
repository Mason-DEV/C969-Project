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
    public partial class Login : Form
    {

        public string error = "The username and password entered are not valid.";

        public Login()
        {
            InitializeComponent();
            //Do something to lookup user location and translate log0in and error control messages; 
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form dash = new Dashboard();
            dash.Owner = this;
            dash.Show();
            this.Hide();
         
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure to exit this Application?", "Login",
                                   MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
