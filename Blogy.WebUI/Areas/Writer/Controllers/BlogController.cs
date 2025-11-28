using Blogy.Business.DTOs.BlogDtos;
using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Blogy.Entity.Entities;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles = Roles.Writer)]
    public class BlogController(UserManager<AppUser> _userManager, IBlogService _blogService,ICategoryService _categoryService) : Controller
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
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var blogs =await _blogService.GetListByWriter(user.Id);
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
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            updateBlogDto.WriterId = user.Id;
            await _blogService.UpdateAsync(updateBlogDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
