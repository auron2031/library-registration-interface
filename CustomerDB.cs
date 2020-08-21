using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    static class CustomerDB
    {
        public static List<Customer> GetAllCustomers()
        {
            var selCommand = new SqlCommand();
            selCommand.Connection = DBHelper.GetConnection();
            selCommand.CommandText =
                "SELECT CustomerID, DateOfBirth, FirstName, LastName, Title " +
                "FROM Customer";

            try
            {
                selCommand.Connection.Open();
                SqlDataReader rdr = selCommand.ExecuteReader();
                var customerList = new List<Customer>();
                while (rdr.Read())
                {
                    var customer = new Customer();
                    customer.CustomerID = (int)rdr["CustomerID"];
                    customer.DateOfBirth = (DateTime)rdr["DateOfBirth"];
                    customer.FirstName = (string)rdr["FirstName"];
                    customer.LastName = (string)rdr["LastName"];
                    customer.Title = (string)rdr["Title"];
                    customerList.Add(customer);
                }
                return customerList;
            }
            finally
            {
                selCommand.Connection.Dispose();
            }
        }

        public static bool Add(Customer newCustomer)
        {
            SqlConnection dbConnection = DBHelper.GetConnection();

            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = dbConnection;
            addCommand.CommandText = "INSERT INTO Customer " +
            "(FirstName, LastName, DateOfBirth, Title) " +
        "VALUES" +
            "(@firstname, @lastname, @dateofbirth, @title)";

            addCommand.Parameters.AddWithValue("@firstname", newCustomer.FirstName);
            addCommand.Parameters.AddWithValue("@lastname", newCustomer.LastName);
            addCommand.Parameters.AddWithValue("@dateofbirth", newCustomer.DateOfBirth);
            addCommand.Parameters.AddWithValue("@title", newCustomer.Title);
            
            try
            {
                dbConnection.Open();
                int rowsAffected = addCommand.ExecuteNonQuery();
                if (rowsAffected == 1)
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
