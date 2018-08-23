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
    public class EmployeeSqlDALTest
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
        public void GetAllEmployeesTest()
        {
            EmployeeSqlDAL eSQL = new EmployeeSqlDAL(connectionString);

            List<Employee> e = eSQL.GetAllEmployees();

            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void SearchTest()
        {
            EmployeeSqlDAL eSQL = new EmployeeSqlDAL(connectionString);

            List<Employee> e = eSQL.Search("Matthew", "Duford");

            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void GetEmployeesWithoutProjects()
        {
            EmployeeSqlDAL eSQL = new EmployeeSqlDAL(connectionString);

            List<Employee> e = eSQL.GetEmployeesWithoutProjects();

            Assert.IsNotNull(e);
        }
    }
}
