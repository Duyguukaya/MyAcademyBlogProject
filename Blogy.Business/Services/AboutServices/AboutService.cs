using AutoMapper;
using Blogy.Business.DTOs.AboutDtos;
using Blogy.DataAccess.Repositories.AbouRepositories;
using Blogy.Entity.Entities;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Blogy.Business.Services.AboutServices
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository _aboutDal;
        private readonly IMapper _mapper;

        public AboutService(IAboutRepository aboutDal, IMapper mapper)
        {
            _aboutDal = aboutDal;
            _mapper = mapper;
        }

        // 1. LİSTELEME
        public async Task<List<ResultAboutDto>> GetAllAsync()
        {
            var values = await _aboutDal.GetAllAsync();
            return _mapper.Map<List<ResultAboutDto>>(values);
        }

        // 2. EKLEME
        public async Task CreateAsync(CreateAboutDto createDto)
        {
            var entity = _mapper.Map<About>(createDto);
            await _aboutDal.CreateAsync(entity);
        }

       

        public async Task UpdateAsync(UpdateAboutDto updateDto)
        {
            // 1. Önce veritabanındaki (ve hafızada takip edilen) asıl kaydı çekiyoruz.
            var entity = await _aboutDal.GetByIdAsync(updateDto.Id);

            if (entity != null)
            {
                // 2. AutoMapper'ın şu özelliğini kullanıyoruz:
                // "Elimdeki updateDto verilerini, var olan 'entity' nesnesinin üzerine yaz."
                // Böylece yeni nesne oluşmaz, mevcut nesne güncellenir.
                _mapper.Map(updateDto, entity);

                // 3. Zaten takip edilen nesneyi güncelliyoruz. Hata vermez.
                await _aboutDal.UpdateAsync(entity);
            }
        }

        // 4. SİLME
        public async Task DeleteAsync(int id)
        {
            await _aboutDal.DeleteAsync(id);
        }

        // 5. ID'YE GÖRE GETİR (Update işlemi için UpdateDto döner)
        public async Task<UpdateAboutDto> GetByIdAsync(int id)
        {
            var entity = await _aboutDal.GetByIdAsync(id);
            return _mapper.Map<UpdateAboutDto>(entity);
        }

        // 6. ID'YE GÖRE GETİR (Görüntüleme işlemi için ResultDto döner)
        // Not: Interface'inizde GetSingleByIdAsync varsa bu kullanılır
        public async Task<ResultAboutDto> GetSingleByIdAsync(int id)
        {
            var entity = await _aboutDal.GetByIdAsync(id);
            return _mapper.Map<ResultAboutDto>(entity);
        }

        // 7. YAPAY ZEKA İLE METİN ÜRETME
        public async Task<string> GenerateAboutTextWithAiAsync()
        {
            string aiContent = "İçerik oluşturulamadı.";

            using (var client = new HttpClient())
            {
                // !!! BURAYA OPENAI API KEY !!!
                var apiKey = "";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                try
                {
                    var requestBody = new
                    {
                        model = "gpt-4o-mini",
                        messages = new[]
                        {
                            new { role = "system", content = "Sen profesyonel bir içerik yazarısın." },
                            new { role = "user", content = "Bir teknoloji blog sitesi için 'Hakkımızda' yazısı yaz. Samimi ve vizyoner olsun. Maksimum 3 cümle. Türkçe yaz." }
                        }
                    };

                    var content = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    using var doc = JsonDocument.Parse(responseString);
                    aiContent = doc.RootElement.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
                }
                catch (Exception)
                {
                    return "Yapay zeka servisine bağlanılamadı.";
                }
            }
            return aiContent;
        }
    }
}