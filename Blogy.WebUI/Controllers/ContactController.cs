using Blogy.Business.DTOs.MessageDtos;
using Blogy.Business.Services.MessageServices;
using Microsoft.AspNetCore.Mvc;
using OpenAI.Chat; // OpenAI kütüphanesi
using System.ClientModel; // OpenAI için gerekli olabilir

namespace Blogy.WebUI.Controllers
{
    // Primary Constructor yapısını koruyarak IConfiguration ekledik (Key okumak için)
    public class ContactController(IMessageService _messageService, IConfiguration _configuration) : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageDto createMessageDto)
        {
            if (ModelState.IsValid)
            {
                // 1. YAPAY ZEKA OTO-CEVAP OLUŞTURUYOR
                try
                {
                    // !!! OpenAI API Key'inizi Buraya Yazın !!!
                    // (veya appsettings.json'dan çekin: _configuration["OpenAI:ApiKey"])
                    string apiKey = "";

                    ChatClient client = new ChatClient(model: "gpt-4o-mini", apiKey: apiKey);

                    // SİSTEM MESAJI (PROMPT): Burası işin sırrı
                    string systemPrompt = @"
                        Sen global bir şirketin yardımsever müşteri temsilcisisin. Görevin şu:
                        1. Kullanıcının mesajının dilini otomatik olarak algıla (Türkçe, İngilizce, Japonca, Korece, Arapça vs. olabilir).
                        2. Algıladığın O DİLDE; nazik, kısa ve resmi bir 'Mesajınız alındı, en kısa sürede size dönüş yapacağız' mesajı yaz.
                        3. Başka hiçbir açıklama yapma, sadece o dildeki cevabı ver.";

                    string userPrompt = $"Kullanıcı Mesajı: {createMessageDto.Content}";

                    ChatCompletion completion = await client.CompleteChatAsync(
                        new SystemChatMessage(systemPrompt),
                        new UserChatMessage(userPrompt)
                    );

                    // AI'ın cevabını alıyoruz
                    string aiResponse = completion.Content[0].Text;

                    // DTO'ya ekliyoruz (Veritabanına gitmesi için)
                    createMessageDto.AutoReply = aiResponse;

                    // Kullanıcıya ekranda göstermek için TempData'ya atıyoruz
                    TempData["AutoReplyMessage"] = aiResponse;
                }
                catch (Exception)
                {
                    // AI hata verirse (internet yoksa vs.) boş geçelim, sistem durmasın
                    createMessageDto.AutoReply = "Mesajınız alındı. (Otomatik yanıt oluşturulamadı)";
                }

                // 2. VERİTABANINA KAYIT
                // Not: Service içindeki Map işleminde AutoReply alanının eşleştiğinden emin olun.
                await _messageService.CreateAsync(createMessageDto);

                return RedirectToAction("Index", "Contact");
            }

            return View(createMessageDto); // Hata varsa formu geri döndür
        }
    }
}