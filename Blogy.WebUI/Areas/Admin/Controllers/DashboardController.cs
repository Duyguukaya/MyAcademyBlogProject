using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Blogy.Business.Services.TagServices;
using Blogy.Entity.Entities;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Admin)]
    public class DashboardController(UserManager<AppUser> _userManager,IBlogService _blogService,ICategoryService _categoryService,ITagService _tagService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var writers = await _userManager.GetUsersInRoleAsync("Writer");
            ViewBag.yazarlar = writers.Count;

            var blogs = await _blogService.GetAllAsync();
            ViewBag.blogs = blogs.Count;

            var categories = await _categoryService.GetAllAsync();
            ViewBag.categories = categories.Count;

            var tags = await _tagService.GetAllAsync();
            ViewBag.tags = tags.Count;

            var users = await _userManager.Users.CountAsync();
            ViewBag.users = users;

            var mostpopulerblog = blogs.OrderByDescending(x => x.Comments.Count).FirstOrDefault();
            if (mostpopulerblog != null)
            {
                ViewBag.EnPopulerBlog = mostpopulerblog.Tittle; 
            }
            else
            {
                ViewBag.EnPopulerBlog = "Henüz Blog Yok";
            }

            return View();
        }
    }
}
