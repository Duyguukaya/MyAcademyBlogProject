using Blogy.Business.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.uı_footer
{
    public class _FooterComponent : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _FooterComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Admin panelinde AI ile oluşturduğumuz ID=1 olan kaydı getir
            var value = await _aboutService.GetByIdAsync(1);
            return View(value);
        }
    }
}
