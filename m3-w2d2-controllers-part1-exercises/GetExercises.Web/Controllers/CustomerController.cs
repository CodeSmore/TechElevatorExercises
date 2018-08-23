using GetExercises.Web.DAL.Interfaces;
using GetExercises.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetExercises.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerDAL dal;

        /// <summary>
        /// The MVC framework with the assistance of Ninject, automatically passes in a CustomerDAL.
        /// </summary>
        /// <param name="dal"></param>
        public CustomerController(ICustomerDAL dal)
        {
            this.dal = dal;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchResult(string name, int sortBy)
        {
            IList<Customer> returnList = dal.SearchForCustomers(name, sortBy);

            return View(returnList);
        }

    }
}