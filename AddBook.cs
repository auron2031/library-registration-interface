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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var book = new Book();

            book.ISBN = txtISBN.Text;
            book.Price = Convert.ToDecimal(txtPrice.Text);
            book.Title = txtTitle.Text;

            if(BookDB.Add(book))
            {
                MessageBox.Show("Book Added!");
            }
            else
            {
                MessageBox.Show("Error! Ya goof'd, son!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
