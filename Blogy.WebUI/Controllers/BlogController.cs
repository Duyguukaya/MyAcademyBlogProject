using AutoMapper;
using Blogy.Business.DTOs.BlogDtos;
using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using System.Threading.Tasks;

namespace Blogy.WebUI.Controllers
{
    public class BlogController(IBlogService _blogService, ICategoryService _categoryService,IMapper _mapper) : Controller
    {
        public async Task<IActionResult> Index(int page=1,int pageSize=4 )
        {
            var blogs = await _blogService.GetAllAsync();

            var values = new PagedList<ResultBlogDto>(blogs.AsQueryable(), page, pageSize);

            return View(values);
        }

        public async Task<IActionResult> GetBlogsByCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            ViewBag.categoryName = category.Name;
            var blogs = await _blogService.GetBlogsByCategoryIdAsync(id);
            return View(blogs);
        }

        public async Task<IActionResult> BlogDetails(int id)
        {
            var blogs = await _blogService.GetSingleByIdAsync(id);
            return View(blogs);
        }


    }
}
