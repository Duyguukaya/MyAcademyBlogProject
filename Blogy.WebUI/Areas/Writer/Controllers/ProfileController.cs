using AutoMapper;
using Blogy.Business.DTOs.UserDtos;
using Blogy.Entity.Entities;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO; 
using System; 

namespace Blogy.WebUI.Areas.Writer.Controllers
{
  
    [Area(Roles.Writer)]
    [Authorize(Roles = Roles.Writer)]
    public class ProfileController(UserManager<AppUser> _userManager, IMapper _mapper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var editUser = _mapper.Map<EditProfileDto>(user);

            return View(editUser);
        }

        [HttpPost]
      
        public async Task<IActionResult> Index(EditProfileDto model)
        {
          
            if (!ModelState.IsValid)
            {
         
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var passwordCorrect = await _userManager.CheckPasswordAsync(user, model.CurrentPassword);

            if (!passwordCorrect)
            {
                ModelState.AddModelError("", "Girilen mevcut şifreniz hatalı!");
                return View(model);
            }

            if (model.ImageFile is not null)
            {
                var currentDirectory = Directory.GetCurrentDirectory();

                var extension = Path.GetExtension(model.ImageFile.FileName); 

                var imageName = Guid.NewGuid() + extension;
                var saveLocation = Path.Combine(currentDirectory, "wwwroot/images", imageName);

                using (var stream = new FileStream(saveLocation, FileMode.Create))
                {
                    await model.ImageFile.CopyToAsync(stream);
                }
                user.ImageUrl = "/images/" + imageName;
            }

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.PhoneNumber = model.PhoneNumber;
            user.UserName = model.UserName;
            user.Title = model.Title;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
             
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }

            return RedirectToAction("Index", "Blog", new { area = Roles.Writer });
        }
    }
}
