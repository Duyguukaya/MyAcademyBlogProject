using Blogy.Business.Services.BlogServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController(IBlogService _blogService) : Controller
    {
        public  async Task<IActionResult> Index()
        {
            var blogs = await _blogService.GetBlogWithCategoriesAsync();
            return View(blogs);
        }
    }
}
