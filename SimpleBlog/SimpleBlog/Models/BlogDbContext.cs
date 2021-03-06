﻿using Microsoft.EntityFrameworkCore;

namespace SimpleBlog.Models
{
    public class BlogDbContext: DbContext 
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
