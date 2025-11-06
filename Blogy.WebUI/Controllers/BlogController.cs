using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogy.WebUI.Controllers
{
    public class BlogController(IBlogService _blogService, ICategoryService _categoryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var blogs = _blogService.GetAllAsync();
            return View();
        }

        public async Task<IActionResult> GetBlogsByCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            ViewBag.categoryName = category.Name;
            var blogs = await _blogService.GetBlogsByCategoryIdAsync(id);
            return View(blogs);
        }


    }
}
