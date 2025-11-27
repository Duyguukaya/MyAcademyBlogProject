using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.Contact
{
    public class _MessageComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
