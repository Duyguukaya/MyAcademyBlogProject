using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogList
{
    public class _BlogListComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
