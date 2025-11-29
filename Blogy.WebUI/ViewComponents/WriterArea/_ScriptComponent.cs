using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.WriterArea
{
    public class _ScriptComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
