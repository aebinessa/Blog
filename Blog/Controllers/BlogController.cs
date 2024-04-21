using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new BloggingContext())
            {
                var blogs = context.Blogs.ToList();
                return View(blogs);
            }
        }
    }
}
