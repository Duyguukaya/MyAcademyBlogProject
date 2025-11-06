using Blogy.Business.DTOs.BlogDtos;
using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Blogy.Entity.Entities;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =Roles.Admin)]
    public class BlogController(IBlogService _blogService, ICategoryService _categoryService,UserManager<AppUser> _userManager) : Controller
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
            var blogs = await _blogService.GetAllAsync();
            return View(blogs);
        }

        [HttpGet]
        public async Task<IActionResult> CreateBlog()
        {
            await GetCategoriesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto blogDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View(blogDto);
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            blogDto.WriterId = user.Id;
            await _blogService.CreateAsync(blogDto);
            return RedirectToAction("Index");
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
