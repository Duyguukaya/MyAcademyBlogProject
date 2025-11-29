using Blogy.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.WriterArea
{
    public class _SidebarComponent:ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;

        public _SidebarComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        // Invoke yerine InvokeAsync kullanıyoruz
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var username = User.Identity.Name;
            var user = await _userManager.FindByNameAsync(username);
            return View(user);
        }
    }
}
