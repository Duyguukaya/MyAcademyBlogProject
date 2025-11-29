using Blogy.Business.Services.BlogServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.AdminDashboard
{
    public class _BlogsComponent(IBlogService _blogService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var last6blogs = await _blogService.GetLast6BlogsAsync();
            return View(last6blogs);
        }
    }
}
