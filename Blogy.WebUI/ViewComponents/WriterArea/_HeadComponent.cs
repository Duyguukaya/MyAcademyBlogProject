using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.WriterArea
{
    public class _HeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
