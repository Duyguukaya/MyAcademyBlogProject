using Blogy.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.AdminDashboard
{
    public class _WriterComponent(UserManager<AppUser> _userManager):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var writers = await _userManager.GetUsersInRoleAsync("Writer");
            return View(writers);
        }
    }
}
