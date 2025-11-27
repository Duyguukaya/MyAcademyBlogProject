using Blogy.Business.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.Contact
{
    public class _ContactComponent(IContactService _contactService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _contactService.GetAllAsync();
            return View(values);
        }
    }
}
