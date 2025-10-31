using AutoMapper;
using Blogy.Business.DTOs.UserDtos;
using Blogy.Entity.Entities;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.IO; // Path ve FileStream için bu using'i eklemeyi unutmayın
using System; // Guid için bu using'i eklemeyi unutmayın

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    // Controller seviyesine taşındı, böylece hem GET hem POST için geçerli oldu.
    [Area(Roles.Admin)]
    [Authorize(Roles = Roles.Admin)]
    public class ProfileController(UserManager<AppUser> _userManager, IMapper _mapper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var editUser = _mapper.Map<EditProfileDto>(user);

            return View(editUser);
        }

        [HttpPost]
        // [Area] ve [Authorize] nitelemelerini buraya (veya class seviyesine) ekledim.
        public async Task<IActionResult> Index(EditProfileDto model)
        {
            // ModelState.IsValid kontrolü eklemek iyi bir pratiktir.
            if (!ModelState.IsValid)
            {
                // Hata varsa, modelle birlikte View'ı tekrar göster.
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
                // Identity'den gelen hataları ModelState'e ekleyebilirsiniz.
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }

            // Başarılı güncelleme sonrası yönlendirme
            return RedirectToAction("Index", "Blog", new { area = Roles.Admin });
        }
    }
}
