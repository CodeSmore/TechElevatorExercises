using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        IReviewDAL dal;

        public HomeController()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["SquirrelReviews"].ConnectionString;
            dal = new ReviewSqlDAL(connectionstring);
        }


        // GET: Home
        public ActionResult Index()
        {
            List<Review> list = dal.GetAllReviews();

            return View("Index", list);
        }

        // GET: Home/SubmitReview
        public ActionResult SubmitReview()
        {
            return View();
        }

        // POST: Home
        [HttpPost]
        public ActionResult PostSurvey(Review review)
        {
            dal.SaveReview(review);

            return RedirectToAction("Index");
        }
    }
}