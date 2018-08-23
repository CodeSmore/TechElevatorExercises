using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace ProjectDB.DAL
{
    public class ProjectSqlDAL
    {
        private string connectionString;
        private const string SQL_GetAllProjects = "SELECT * FROM project;";
        private const string SQL_AssignEmployeeToProject = "INSERT INTO project_employee VALUES (@project_id, @employee_id);";
        private const string SQL_RemoveEmployeeFromProject = "DELETE FROM project_employee WHERE project_id = @project_id AND employee_id = @employee_id;";
        private const string SQL_CreateNewProject = "INSERT INTO project VALUES (@name, @from_date, @to_date);";

        // Single Parameter Constructor
        public ProjectSqlDAL(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Project> GetAllProjects()
        {
            List<Project> output = new List<Project>();

            //Always wrap connection to a database in a try-catch block
            try
            {
                //Create a SqlConnection to our database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SQL_GetAllProjects;
                    cmd.Connection = connection;

                    // Execute the query to the database
                    SqlDataReader reader = cmd.ExecuteReader();

                    // The results come back as a SqlDataReader. Loop through each of the rows
                    // and add to the output list
                    while (reader.Read())
                    {
                        Project p = new Project();

                        // Read in the value from the reader
                        // Reference by index or by column_name

                        p.ProjectId = Convert.ToInt32(reader["project_id"]);
                        p.Name = Convert.ToString(reader["name"]);
                        p.StartDate = Convert.ToDateTime(reader["from_date"]);
                        p.EndDate = Convert.ToDateTime(reader["to_date"]);

                        // Add the continent to the output list
                        output.Add(p);
                    }
                }
            }
            catch (SqlException ex)
            {
                // A SQL Exception Occurred. Log and throw to our application!!
                throw;
            }

            // Return the list of continents
            return output;
        }

        // an ammend to the project_employee table
        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
            bool employeeAdded = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_AssignEmployeeToProject, connection);

                    cmd.Parameters.AddWithValue("@project_id", projectId);
                    cmd.Parameters.AddWithValue("@employee_id", employeeId);

                    int count = cmd.ExecuteNonQuery();

                    if (count == 1)
                    {
                        employeeAdded = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return employeeAdded;
        }

        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            bool result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                 
                    SqlCommand cmd = new SqlCommand(SQL_RemoveEmployeeFromProject, connection);

                    cmd.Parameters.AddWithValue("@project_id", projectId);
                    cmd.Parameters.AddWithValue("@employee_id", employeeId);

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

        public bool CreateProject(Project newProject)
        {
            bool result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(SQL_CreateNewProject, connection);

                    cmd.Parameters.AddWithValue("@name", newProject.Name);
                    cmd.Parameters.AddWithValue("@from_date", newProject.StartDate);
                    cmd.Parameters.AddWithValue("@to_date", newProject.EndDate);

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
