using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FormsWithHttpPost.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "1 to 5 you fool!!!")]
        public int Rating { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}