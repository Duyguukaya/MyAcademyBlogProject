using AutoMapper;
using Blogy.Business.DTOs.UserDtos;
using Blogy.Entity.Entities;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    public class ProfileController(UserManager<AppUser> _userManager,IMapper _mapper) : Controller
    {
        [Area(Roles.Admin)]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var editUser = _mapper.Map<EditProfileDto>(user);

            return View(editUser);
        }

        
    }
}
