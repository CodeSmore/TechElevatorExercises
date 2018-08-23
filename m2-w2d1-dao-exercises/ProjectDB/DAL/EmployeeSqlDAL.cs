using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.DAL
{
    public class EmployeeSqlDAL
    {
        private string connectionString;
        private const string SQL_GetAllEmployees = "SELECT * FROM employee";
        private const string SQL_Search = "SELECT * FROM employee WHERE first_name = @first_name AND last_name = @last_name;";
        private const string SQL_GetEmployeesWithoutProjects = "SELECT * FROM employee e LEFT OUTER JOIN project_employee pe ON e.employee_id = pe.employee_id WHERE pe.employee_id IS NULL;";

        // Single Parameter Constructor
        public EmployeeSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> result = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAllEmployees, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee emp = new Employee();

                        // Read in the value from the reader
                        // Reference by index or by column_name
                        emp.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        emp.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        emp.FirstName = Convert.ToString(reader["first_name"]);
                        emp.LastName = Convert.ToString(reader["last_name"]);
                        emp.JobTitle = Convert.ToString(reader["job_title"]);
                        emp.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        emp.Gender = Convert.ToString(reader["gender"]);
                        emp.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        result.Add(emp);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return result;
        }

        public List<Employee> Search(string firstname, string lastname)
        {
            List<Employee> result = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_Search, conn);
                    cmd.Parameters.AddWithValue("@first_name", firstname);
                    cmd.Parameters.AddWithValue("@last_name", lastname);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee emp = new Employee();

                        emp.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        emp.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        emp.FirstName = Convert.ToString(reader["first_name"]);
                        emp.LastName = Convert.ToString(reader["last_name"]);
                        emp.JobTitle = Convert.ToString(reader["job_title"]);
                        emp.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        emp.Gender = Convert.ToString(reader["gender"]);
                        emp.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        result.Add(emp);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return result;
        }

        public List<Employee> GetEmployeesWithoutProjects()
        {
            List<Employee> result = new List<Employee>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetEmployeesWithoutProjects, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee emp = new Employee();

                        emp.EmployeeId = Convert.ToInt32(reader["employee_id"]);
                        emp.DepartmentId = Convert.ToInt32(reader["department_id"]);
                        emp.FirstName = Convert.ToString(reader["first_name"]);
                        emp.LastName = Convert.ToString(reader["last_name"]);
                        emp.JobTitle = Convert.ToString(reader["job_title"]);
                        emp.BirthDate = Convert.ToDateTime(reader["birth_date"]);
                        emp.Gender = Convert.ToString(reader["gender"]);
                        emp.HireDate = Convert.ToDateTime(reader["hire_date"]);

                        result.Add(emp);
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
