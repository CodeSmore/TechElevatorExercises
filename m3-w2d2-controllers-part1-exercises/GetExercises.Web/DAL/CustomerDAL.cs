using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetExercises.Web.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        private string connectionString;

        public CustomerDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Customer> SearchForCustomers(string search, int sortBy)
        {
            IList<Customer> customer = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //BUGGED SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE (last_name LIKE @search_name OR first_name LIKE @search_name) ORDER BY @sortBy", conn);
                SqlCommand cmd = new SqlCommand("SELECT first_name, last_name, email, activebool FROM customer WHERE last_name LIKE @search_name OR first_name LIKE @search_name ORDER BY CASE @sortBy WHEN 1 THEN last_name WHEN 2 THEN email WHEN 3 THEN activebool END;", conn);
                cmd.Parameters.AddWithValue("@search_name", "%" + search + "%");
                cmd.Parameters.AddWithValue("@sortBy", sortBy);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customer.Add(MapRowToCustomer(reader));
                }
            }

            return customer;
        }

        private Customer MapRowToCustomer(SqlDataReader reader)
        {
            return new Customer()
            {
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
                Email = Convert.ToString(reader["email"]),
                IsActive = Convert.ToBoolean(reader["activebool"])
            };
        }
    }
}