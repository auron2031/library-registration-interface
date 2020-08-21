using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var cust = new Customer();

            cust.FirstName = txtFName.Text;
            cust.LastName = txtLName.Text;
            cust.DateOfBirth = DateTime.Parse(dteDOB.Value.ToShortTimeString());
            cust.Title = txtTitle.Text;

            if(CustomerDB.Add(cust))
            {
                MessageBox.Show("Customer Added!");
            }
            else
            {
                MessageBox.Show("Error! You dun goofed!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
