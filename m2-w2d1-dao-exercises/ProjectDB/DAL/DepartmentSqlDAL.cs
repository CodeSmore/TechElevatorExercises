using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.DAL
{
    public class DepartmentSqlDAL
    {
        private string connectionString;
        private const string SQL_GetDepartments = "SELECT department_id, name FROM department;";
        private const string SQL_CreateDepartment = "INSERT INTO department VALUES (@name);";
        private const string SQL_UpdateDepartment = "UPDATE department SET name = @name WHERE department_id = @department_id;";

        // Single Parameter Constructor
        public DepartmentSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Department> GetDepartments()
        {
            List<Department> result = new List<Department>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetDepartments, conn);

                    // Execute the query to the database
                    SqlDataReader reader = cmd.ExecuteReader();

                    // The results come back as a SqlDataReader. Loop through each of the rows
                    // and add to the output list
                    while (reader.Read())
                    {
                        Department d = new Department();

                        // Read in the value from the reader
                        // Reference by index or by column_name

                        d.Id = Convert.ToInt32(reader["department_id"]);
                        d.Name = Convert.ToString(reader["name"]);

                        // Add the continent to the output list
                        result.Add(d);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return result;
        }

        public bool CreateDepartment(Department newDepartment)
        {
            bool result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_CreateDepartment, connection);

                    cmd.Parameters.AddWithValue(parameterName: "@name", value: newDepartment.Name);

                    int count = cmd.ExecuteNonQuery();

                    if (count == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return result;
        }

        public bool UpdateDepartment(Department updatedDepartment)
        {
            bool result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_UpdateDepartment, connection);

                    cmd.Parameters.AddWithValue("@department_id", updatedDepartment.Id);
                    cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);

                    int count = cmd.ExecuteNonQuery();

                    if (count == 1)
                    {
                        result = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return result;
        }

    }
}
