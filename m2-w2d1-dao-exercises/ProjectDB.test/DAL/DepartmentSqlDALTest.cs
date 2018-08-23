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
    public class DepartmentSqlDALTest
    {
        private TransactionScope tran;
        private string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Projects;Integrated Security=True";

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
                
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            tran.Dispose();
        }

        [TestMethod()]
        public void GetDepartmentsTest()
        {
            DepartmentSqlDAL departmentSqlDal = new DepartmentSqlDAL(connectionString);

            List<Department> d = departmentSqlDal.GetDepartments();

            Assert.IsNotNull(d);
            Assert.AreEqual(5, d.Count);
        }

        [TestMethod()]
        public void CreateDepartmentTest()
        {
            DepartmentSqlDAL departmentSqlDal = new DepartmentSqlDAL(connectionString);
            Department d = new Department();
           
            d.Name = "heyo";

            bool result = false;

            result = departmentSqlDal.CreateDepartment(d);

            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void UpdateDepartmentTest()
        {
            DepartmentSqlDAL departmentSqlDal = new DepartmentSqlDAL(connectionString);
            Department d = new Department();

            d.Id = 1;
            d.Name = "noname";

            bool result = departmentSqlDal.CreateDepartment(d);

            Assert.AreEqual(true, result);
        }
    }
}
