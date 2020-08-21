using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class BookRegistrationDB
    {
        public static bool RegisterBook(Customer custList, Book bookList, DateTime date)
        {
            SqlConnection dbConnection = DBHelper.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = dbConnection;
            addCommand.CommandText = "INSERT INTO Registration " +
            "(CustomerID, ISBN, RegDate) " +
        "VALUES" +
            "(@customerid, @isbn, @regdate)";

            addCommand.Parameters.AddWithValue("@customerid", custList.CustomerID);
            addCommand.Parameters.AddWithValue("@isbn", bookList.ISBN);
            addCommand.Parameters.AddWithValue("@regdate", date);

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
