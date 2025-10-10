using Blogy.Business.DTOs.BlogDtos;
using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController(IBlogService _blogService, ICategoryService _categoryService) : Controller
    {
        private async Task GetCategoriesAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            ViewBag.categories = (from category in categories
                                  select new SelectListItem
                                  {
                                      Text = category.CategoryName,
                                      Value = category.Id.ToString()
                                  }).ToList();
        }

        public async Task<IActionResult> Index()
        {
            var blogs = await _blogService.GetBlogWithCategoriesAsync();
            return View(blogs);
        }

        [HttpGet]
        public async Task<IActionResult> CreateBlog()
        {
            await GetCategoriesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto _createBlogDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View(_createBlogDto);
            }
            await _blogService.CreateAsync(_createBlogDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _blogService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int id)
        {
            var blogs = await _blogService.GetByIdAsync(id);
            await GetCategoriesAsync();
            return View(blogs);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View(updateBlogDto);
            }
            await _blogService.UpdateAsync(updateBlogDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
