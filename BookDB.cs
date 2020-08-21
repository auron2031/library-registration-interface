using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    static class BookDB
    {
        public static List<Book> GetAllBooks()
        {
            var selCommand = new SqlCommand();
            selCommand.Connection = DBHelper.GetConnection();
            selCommand.CommandText =
                "SELECT ISBN, Price, Title " +
                "FROM Book";

            try
            {
                selCommand.Connection.Open();
                SqlDataReader rdr = selCommand.ExecuteReader();
                var bookList = new List<Book>();
                while (rdr.Read())
                {
                    var book = new Book();
                    book.ISBN = (string)rdr["ISBN"];
                    book.Price = (decimal)rdr["Price"];
                    book.Title = (string)rdr["Title"];
                    bookList.Add(book);
                }
                return bookList;
            }
            finally
            {
                selCommand.Connection.Dispose();
            }
        }

        public static bool Add(Book newBook)
        {
            SqlConnection dbConnection = DBHelper.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = dbConnection;
            addCommand.CommandText = "INSERT INTO Book " +
            "(ISBN, Price, Title) " +
        "VALUES" +
            "(@isbn, @price, @title)";

            addCommand.Parameters.AddWithValue("@isbn", newBook.ISBN);
            addCommand.Parameters.AddWithValue("@price", newBook.Price);
            addCommand.Parameters.AddWithValue("@title", newBook.Title);

            try
            {
                dbConnection.Open();
                int rowsAffected = addCommand.ExecuteNonQuery();
                if(rowsAffected == 1)
                {
                    return true;
                }
                return false;
            }
            finally
            {
                dbConnection.Dispose();
            }
        }
    }
}