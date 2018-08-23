using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;
using ProjectDB.DAL;
using ProjectDB.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectDB.test.DAL
{
    [TestClass]
    public class ProjectSqlDALTest
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Projects;Integrated Security=True";
        private int sampleProjectID = 0;

        /*
        * INITIALIZE
        * Before adding the country, get the number of known countries in North America.
        * Create a fake country (ABC Country) into the country table.
        */
        [TestInitialize]
        public void Initialize()
        {
            tran = new TransactionScope();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd;
                connection.Open();


                cmd = new SqlCommand("INSERT INTO department VALUES ('Super_Department');", connection);
                cmd.ExecuteNonQuery();


                cmd = new SqlCommand("SELECT department_id FROM department WHERE name = 'Super_Department';", connection);
                sampleProjectID = (int)cmd.ExecuteScalar();
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetAllProjectsTest()
        {
            ProjectSqlDAL sqlproject = new ProjectSqlDAL(connectionString);

            List<Project> projects = sqlproject.GetAllProjects();

            Assert.IsNotNull(projects);
        }

        [TestMethod()]
        public void AssignEmployeeToProjectTest()
        {
            ProjectSqlDAL sqlProject = new ProjectSqlDAL(connectionString);

            bool result = sqlProject.AssignEmployeeToProject(1, 1);

            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void RemoveEmployeeFromProjectTest()
        {
            ProjectSqlDAL sqlProject = new ProjectSqlDAL(connectionString);

            bool result = sqlProject.RemoveEmployeeFromProject(1, 3);

            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void CreateNewProject()
        {
            ProjectSqlDAL sqlProject = new ProjectSqlDAL(connectionString);
            Project p = new Project();

            p.ProjectId = 12;
            p.Name = "SuperProject";
            p.StartDate = new DateTime(1999, 1, 1);
            p.EndDate = new DateTime(1999, 1, 2);

            bool result = sqlProject.CreateProject(p);

            Assert.AreEqual(true, result);
        }
    }
}
