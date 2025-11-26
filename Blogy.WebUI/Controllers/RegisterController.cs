using Blogy.Business.DTOs.UserDtos;
using Blogy.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class RegisterController(UserManager<AppUser> _userManager) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new AppUser
            { 
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName
                
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return View(model);
            }
            await _userManager.AddToRoleAsync(user, "User");
            return RedirectToAction("Index", "Login");
        }
     
    }
}
