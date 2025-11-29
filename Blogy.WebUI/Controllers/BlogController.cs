using AutoMapper;
using Blogy.Business.DTOs.BlogDtos;
using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using System.Threading.Tasks;

namespace Blogy.WebUI.Controllers
{
    public class BlogController(IBlogService _blogService, ICategoryService _categoryService, IMapper _mapper) : Controller
    {
        public async Task<IActionResult> Index(int page = 1, int pageSize = 4)
        {
            var blogs = await _blogService.GetAllAsync();
            var values = new PagedList<ResultBlogDto>(blogs.AsQueryable(), page, pageSize);
            return View(values);
        }

        public async Task<IActionResult> GetBlogsByCategory(int id, int page = 1, int pageSize = 4)
        {
            var category = await _categoryService.GetByIdAsync(id);

            // Hata önlemi: Kategori bulunamazsa anasayfaya at
            if (category == null) return RedirectToAction("Index");

            // Property ismini kontrol edin (CategoryName mi Name mi?)
            ViewBag.categoryName = category.Name;

            var blogs = await _blogService.GetBlogsByCategoryIdAsync(id);
            var values = new PagedList<ResultBlogDto>(blogs.AsQueryable(), page, pageSize);

            // DÜZELTME: "Index" view'ini kullanarak verileri göster
            // Böylece yeni bir view (GetBlogsByCategory.cshtml) oluşturmana gerek kalmaz.
            return View("Index", values);
        }

        public async Task<IActionResult> BlogDetails(int id)
        {
            var blogs = await _blogService.GetSingleByIdAsync(id);
            return View(blogs);
        }
    }
}