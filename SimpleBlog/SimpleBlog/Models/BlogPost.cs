using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.Models
{
    public class BlogPost
    {
        public long BlogPostID { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime PostedDate { get; set; }
    }
}
