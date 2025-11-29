using Blogy.Business.DTOs.AboutDtos;
using Blogy.Business.Services.AboutServices;
using Blogy.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blogy.WebUI.Controllers
{
    // Hem UserManager'ı hem de yeni yazdığımız IAboutService'i buraya ekledik
    public class AboutController(UserManager<AppUser> _userManager, IAboutService _aboutService) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // 1. Mevcut İşlem: Yazarları Getir
            var writers = await _userManager.GetUsersInRoleAsync("Writer");

            // 2. Yeni İşlem: Veritabanındaki Hakkımızda yazısını getir (ID=1)
            var aboutData = await _aboutService.GetByIdAsync(1);

            // Eğer veri varsa ViewBag'e at, yoksa boş kalsın
            ViewBag.FooterText = aboutData?.Description;

            return View(writers);
        }

        // --- YENİ EKLENEN: AI TETİKLEME METODU ---
        [HttpPost]
        public async Task<IActionResult> GenerateFooterWithAI()
        {
            // 1. Servise git, AI'dan yeni metni iste
            string aiText = await _aboutService.GenerateAboutTextWithAiAsync();

            // 2. Veritabanındaki ID=1 olan kaydı kontrol et
            var about = await _aboutService.GetByIdAsync(1);

            if (about == null)
            {
                // Kayıt hiç yoksa sıfırdan oluştur
                var createDto = new CreateAboutDto
                {
                    Description = aiText,
                    ImageUrl = "default.png" // Varsayılan resim
                };
                await _aboutService.CreateAsync(createDto);
            }
            else
            {
                // Kayıt varsa güncelle
                // UpdateDto'ya çevirip güncelleme yapıyoruz
                var updateDto = new UpdateAboutDto
                {
                    Id = about.Id,
                    ImageUrl = about.ImageUrl,
                    Description = aiText // Yeni AI yazısı
                };
                await _aboutService.UpdateAsync(updateDto);
            }

            // İşlem bitince sayfayı yenile
            return RedirectToAction("Index");
        }
    }
}