using Blogy.Business.DTOs.BlogDtos;
using Blogy.Business.Services.BlogServices;
using Blogy.Business.Services.CategoryServices;
using Blogy.Entity.Entities;
using Blogy.WebUI.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OpenAI.Chat; // OpenAI kütüphanesi eklendi

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Admin)]
    // 1. DEĞİŞİKLİK: IConfiguration parametresi eklendi
    public class BlogController(IBlogService _blogService, ICategoryService _categoryService, UserManager<AppUser> _userManager, IConfiguration _configuration) : Controller
    {
        private async Task GetCategoriesAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            ViewBag.categories = (from category in categories
                                  select new SelectListItem
                                  {
                                      Text = category.CategoryName,
                                      Value = category.Id.ToString()
                                  }).ToList();
        }

        public async Task<IActionResult> Index()
        {
            var blogs = await _blogService.GetAllAsync();
            return View(blogs);
        }

        [HttpGet]
        public async Task<IActionResult> CreateBlog()
        {
            await GetCategoriesAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto blogDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View(blogDto);
            }

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            blogDto.WriterId = user.Id;
            await _blogService.CreateAsync(blogDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _blogService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int id)
        {
            var blogs = await _blogService.GetByIdAsync(id);
            await GetCategoriesAsync();
            return View(blogs);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View(updateBlogDto);
            }
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            updateBlogDto.WriterId = user.Id;
            await _blogService.UpdateAsync(updateBlogDto);
            return RedirectToAction(nameof(Index));
        }

 
       
        [HttpPost]
        public async Task<IActionResult> GenerateArticleWithAI(string keywords, string prompt)
        {
            if (string.IsNullOrEmpty(keywords) || string.IsNullOrEmpty(prompt))
            {
                return Json(new { success = false, message = "Lütfen anahtar kelime ve konu giriniz." });
            }

            try
            {
                string apiKey = _configuration["OpenAI:ApiKey"];
                if (string.IsNullOrEmpty(apiKey))
                    return Json(new { success = false, message = "API anahtarı bulunamadı." });

                ChatClient client = new ChatClient(model: "gpt-4o-mini", apiKey: apiKey);

                // SİSTEM MESAJI: Genel rol tanımı
                string systemMessage = "Sen profesyonel bir blog yazarısın.";

                // KULLANICI MESAJI (PROMPT): Burayı düzelttik
                string userMessage = $@"
            Aşağıdaki bilgilere göre bir blog yazısı yaz.
            Konu: {prompt}
            Anahtar Kelimeler: {keywords}
            
            Kurallar:
            1. Makale yaklaşık 1000 karakter uzunluğunda olsun.
            2. ASLA HTML etiketi (<p>, <h3>, <strong> vb.) KULLANMA.
            3. Sadece düz metin (plain text) olarak çıktı ver.
            4. Paragraflar arasında bir satır boşluk bırak.
            5. Başlıkları büyük harfle veya belirgin yaz ama etiket içine alma.
            6. Anahtar kelimeleri doğal bir şekilde metne yedir.
        ";

                ChatCompletion completion = await client.CompleteChatAsync(
                    new SystemChatMessage(systemMessage),
                    new UserChatMessage(userMessage)
                );

                string generatedContent = completion.Content[0].Text;

                return Json(new { success = true, content = generatedContent });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Hata: " + ex.Message });
            }
        }
    }
}