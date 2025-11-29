using Blogy.Business.DTOs.CommentDtos;
using Blogy.Business.Services.CommentServices;
using Blogy.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Blogy.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentDto createCommentDto)
        {
            if (!User.Identity.IsAuthenticated) return RedirectToAction("Login", "Account");

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            createCommentDto.UserId = user.Id;
         

            using (var client = new HttpClient())
            {
                // !!! TOKEN'INI BURAYA YAPIŞTIR !!!
                var apiKey = "";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                bool isToxic = false;

                try
                {
                    // 1. ÇEVİRİ İŞLEMİ (Adres Güncellendi)
                    var translatePayload = new { inputs = createCommentDto.Content };
                    var translateContent = new StringContent(JsonSerializer.Serialize(translatePayload), Encoding.UTF8, "application/json");

                    // YENİ ADRES: router.huggingface.co
                    var translateResponse = await client.PostAsync("https://router.huggingface.co/hf-inference/models/Helsinki-NLP/opus-mt-tr-en", translateContent);
                    var translateString = await translateResponse.Content.ReadAsStringAsync();

                    string englishText = createCommentDto.Content;

                    // JSON Çözümleme
                    if (!string.IsNullOrEmpty(translateString) && translateString.TrimStart().StartsWith("["))
                    {
                        using var doc = JsonDocument.Parse(translateString);
                        englishText = doc.RootElement[0].GetProperty("translation_text").GetString();
                    }

                    // 2. TOKSİKLİK ANALİZİ (Adres Güncellendi)
                    var toxicPayload = new { inputs = englishText };
                    var toxicContent = new StringContent(JsonSerializer.Serialize(toxicPayload), Encoding.UTF8, "application/json");

                    // YENİ ADRES: router.huggingface.co
                    var toxicResponse = await client.PostAsync("https://router.huggingface.co/hf-inference/models/s-nlp/roberta_toxicity_classifier", toxicContent);
                    var toxicString = await toxicResponse.Content.ReadAsStringAsync();

                    // JSON Analizi
                    if (!string.IsNullOrEmpty(toxicString))
                    {
                        using var doc = JsonDocument.Parse(toxicString);
                        var root = doc.RootElement;
                        JsonElement items = root;

                        // İç içe array kontrolü
                        if (root.ValueKind == JsonValueKind.Array && root.GetArrayLength() > 0 && root[0].ValueKind == JsonValueKind.Array)
                        {
                            items = root[0];
                        }

                        if (items.ValueKind == JsonValueKind.Array)
                        {
                            foreach (var item in items.EnumerateArray())
                            {
                                if (item.TryGetProperty("label", out var labelProp) && item.TryGetProperty("score", out var scoreProp))
                                {
                                    string label = labelProp.GetString().ToLower();
                                    double score = scoreProp.GetDouble();

                                    // Roberta modelinde 'toxic' genelde 'label_1' dir.
                                    if ((label == "toxic" || label == "label_1" || label == "offensive") && score > 0.50)
                                    {
                                        isToxic = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // API hatası durumunda loglama yapılabilir: Console.WriteLine(ex.Message);
                }

                // 3. Sonuç
                if (isToxic)
                {
                    createCommentDto.IsApproved = false;
                    TempData["Message"] = "Yorumunuz topluluk kurallarına aykırı olduğu için incelemeye alınmıştır.";
                }
                else
                {
                    createCommentDto.IsApproved = true;
                    TempData["Message"] = "Yorumunuz başarıyla eklendi.";
                }

                await _commentService.CreateAsync(createCommentDto);
                return RedirectToAction("BlogDetails", "Blog", new { id = createCommentDto.BlogId });
            }
        }

        public async Task<IActionResult> MyComments()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return RedirectToAction("Login", "Account");

            var comments = (await _commentService.GetAllAsync())
                .Where(x => x.UserId == user.Id)
                .ToList();

            return View(comments);
        }
    }
}