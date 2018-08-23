using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        private string SQL_GetAll = "SELECT * FROM reviews";
        private string SQL_SaveReview = "INSERT INTO reviews (username, rating, review_title, review_text, review_date) VALUES (@username, @rating, @review_title, @review_text, @review_date)";
        private string connectionstring;

        public ReviewSqlDAL(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }


        public List<Review> GetAllReviews()
        {
            List<Review> reviewList = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GetAll);
                    cmd.Connection = conn;

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Review reviews = new Review();

                        reviews.Id = Convert.ToInt32(reader["review_id"]);
                        reviews.Username = Convert.ToString(reader["username"]);
                        reviews.Rating = Convert.ToInt32(reader["rating"]);
                        reviews.Title = Convert.ToString(reader["review_title"]);
                        reviews.Message = Convert.ToString(reader["review_text"]);
                        reviews.ReviewDate = Convert.ToDateTime(reader["review_date"]);

                        reviewList.Add(reviews);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw;
            }

            return reviewList;
        }

        public bool SaveReview(Review newReview)
        {
            bool result;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_SaveReview);
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@username", newReview.Username);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_title", newReview.Title);
                    cmd.Parameters.AddWithValue("@review_text", newReview.Message);
                    cmd.Parameters.AddWithValue("@review_date", DateTime.Now);
                    

                    int num = cmd.ExecuteNonQuery();

                    if (num == 0)
                    {
                        result = false;
                    }
                    else
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