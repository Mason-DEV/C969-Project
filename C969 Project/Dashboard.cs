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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
          
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
    }
}
