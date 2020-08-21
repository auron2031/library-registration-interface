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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCustomerLists();
            PopulateBookLists();
        }

        private void PopulateBookLists()
        {
            cbxBookTitle.Items.Clear();
            List<Book> books = BookDB.GetAllBooks();
            foreach(Book b in books)
            {
                cbxBookTitle.Items.Add(b);
            }
        }

        private void PopulateCustomerLists()
        {
            cbxCustomerName.Items.Clear();

            List<Customer> customers = CustomerDB.GetAllCustomers();

            foreach (Customer c in customers)
            {
                cbxCustomerName.Items.Add(c);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            PopulateCustomerLists();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addBook = new AddBook();
            addBook.ShowDialog();
            PopulateBookLists();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Registration();
            Customer custObj = (Customer)cbxCustomerName.SelectedItem;
            Book bookISBN = (Book)cbxBookTitle.SelectedItem;
            

            register.CustomerID = (byte)custObj.CustomerID;
            register.ISBN = bookISBN.ISBN;
            register.RegDate = dtpDate.Value;

            if (BookRegistrationDB.RegisterBook(custObj, bookISBN, dtpDate.Value))
            {
                MessageBox.Show("Book registered to customer!");
                cbxCustomerName.SelectedIndex = -1;
                cbxBookTitle.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Nope");
            }
        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            cbxCustomerName.SelectedIndex = -1;
            cbxBookTitle.SelectedIndex = -1;
        }
    }
}
