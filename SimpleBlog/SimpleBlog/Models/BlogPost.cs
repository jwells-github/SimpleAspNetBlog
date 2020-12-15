using System;

namespace SimpleBlog.Models
{
    public class BlogPost
    {
        public long BlogPostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
    }
}
