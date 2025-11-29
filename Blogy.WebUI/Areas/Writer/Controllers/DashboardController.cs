using Blogy.DataAccess.Context;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize(Roles = Roles.Writer)]
    public class DashboardController : Controller
    {


        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userEmail = User.Identity.Name;

            // Kullanıcıyı bul
            var writerId = _context.Users
                                   .Where(x => x.UserName == userEmail)
                                   .Select(y => y.Id)
                                   .FirstOrDefault();

     
            var writer = _context.Users
                                .Where(x => x.UserName == userEmail)
                                .FirstOrDefault();

            // 2. Profil Kartı İçin Verileri ViewBag'e atıyoruz
            ViewBag.AdSoyad = writer.FirstName + " " + writer.LastName; // Ad ve Soyad birleştirildi
            ViewBag.Resim = writer.ImageUrl; // Profil resmi yolu
            ViewBag.Meslek = writer.Title; // Bu veri db'de yoksa sabit kalabilir

  

            // ViewBag İşlemleri
            ViewBag.v1 = _context.Blogs.Count(x => x.WriterId == writerId);
            ViewBag.v2 = _context.Comments.Count(x => x.Blog.WriterId == writerId);

   

            ViewBag.v3 = _context.Comments.Count(x => x.Blog.WriterId == writerId);

            // Tablo Listesi
            var last3Blogs = _context.Blogs
                                     .Include(x => x.Category) // Category tablosunu dahil et
                                     .Where(x => x.WriterId == writerId)
                                     .OrderByDescending(x => x.CreatedDate)
                                     .Take(3)
                                     .ToList();

            return View(last3Blogs);
        }
    }
}
