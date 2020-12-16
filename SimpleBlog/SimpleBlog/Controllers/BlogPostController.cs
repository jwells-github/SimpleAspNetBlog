using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SimpleBlog.Models;

namespace SimpleBlog.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly ILogger<BlogPostController> _logger;

        private BlogDbContext context;

        public BlogPostController(ILogger<BlogPostController> logger, BlogDbContext data)
        {
            context = data;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(context.BlogPosts);
        }

        public async Task<IActionResult> Detail (long id)
        {
            BlogPost bp = await context.BlogPosts.FirstOrDefaultAsync(bp => bp.BlogPostID == id); ;
            return View(bp);
        }

        public IActionResult Create()
        {
            return View("BlogEditor", new BlogPost());
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] BlogPost blogPost)
        {
            if (ModelState.IsValid)
            {
                blogPost.BlogPostID = default;
                blogPost.PostedDate = DateTime.Now;
                context.BlogPosts.Add(blogPost);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Detail), new { id = blogPost.BlogPostID });
            }
            return View("BlogEditor", blogPost);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
