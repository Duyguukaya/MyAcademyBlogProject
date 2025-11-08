using Blogy.Business.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogList
{
    public class _ListCategoriesComponent(ICategoryService _categoryService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =await _categoryService.GetAllAsync();
            return View(values);
        }
    }
}
