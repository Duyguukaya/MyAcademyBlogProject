# 📝 BLOGY – AI-Destekli Multi-Panel Blog Yönetim Sistemi

![License](https://img.shields.io/badge/license-MIT-blue.svg) ![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg) ![Status](https://img.shields.io/badge/Status-Completed-success.svg)

**BLOGY**; kullanıcıların içerik tükettiği, yazarların ürettiği ve yöneticilerin tüm sistemi kontrol ettiği; **Yapay Zeka (AI)** tabanlı moderasyon ve öneri sistemleriyle güçlendirilmiş, modern bir blog platformudur.

Proje; **ASP.NET Core 8.0**, **N-Katmanlı Mimari**, **Generic Repository Pattern** ve **OpenAI Entegrasyonları** kullanılarak kurumsal standartlarda geliştirilmiştir.

![Project Banner](https://via.placeholder.com/1000x400?text=BLOGY+Dashboard+Preview)
## 🚀 Proje Hakkında ve Öne Çıkanlar

BLOGY, klasik blog yönetiminden farklı olarak güvenliği ve kullanıcı deneyimini yapay zeka ile birleştirir.

* **🧠 AI Tabanlı Moderasyon:** Sistemdeki yorumlar **OpenAI Moderation API** ile gerçek zamanlı analiz edilir. Hakaret veya toksik içerik barındıran yorumlar otomatik olarak filtrelenir.
* **💡 AI Öneri Motoru:** Kullanıcının okuduğu içeriklere göre yapay zeka destekli kişiselleştirilmiş blog önerileri sunulur.
* **💬 Canlı Destek (Chatbox):** Kullanıcılar ve admin arasında anlık iletişim sağlayan mesajlaşma modülü bulunur.
* **💡 AI Hakkımda Öneri:** Footerda yer alan about kısmı dinamik olarak güncellenir.

---

## 👥 Panel Yapısı ve Özellikler

Sistemde **Admin, Writer ve Member (User)** olmak üzere birbirinden izole 3 farklı panel bulunmaktadır.

### 🛡️ 1. Admin Paneli
Tam yetkili yönetim merkezidir.
* **Dashboard & İstatistikler:** Site trafiği ve verilerin grafiksel analizi.
* **Kullanıcı & Rol Yönetimi:** Yazar atama, üye banlama veya yetkilendirme.
* **İçerik Yönetimi:** Kategorileri, blogları ve yorumları düzenleme/silme.
* **Mesajlaşma:** Gelen kullanıcı mesajlarını okuma.
* **Etkileşim:** Yorum yapma(AI denetimli).
* **Profil:** Profil güncelleme ve şifre değiştirme işlemleri.

### ✍️ 2. Writer (Yazar) Paneli
İçerik üreticileri için özel alandır.
* **Blog Yönetimi:** Zengin metin editörü ile blog yazma ve düzenleme.
* **Profil Yönetimi:** Yazar profili ve yayınlanan yazıların takibi.
* **Etkileşim:** Yorum yapma(AI denetimli).
* **Profil:** Profil güncelleme ve şifre değiştirme işlemleri.

### 👤 3. Member (Üye) Paneli
Son kullanıcı deneyim alanıdır.
* **Etkileşim:** Blog okuma, yorum yapma (AI denetimli).
* **Yorum:** Yapılan yorumlar.
* **Profil:** Profil güncelleme ve şifre değiştirme işlemleri.

---

## 🛠️ Teknik Mimari ve Kullanılan Teknolojiler

Proje **Solid** prensiplerine uygun olarak **N-Katmanlı Mimari (N-Layer Architecture)** üzerinde inşa edilmiştir.

| Alan | Teknoloji / Araç |
| :--- | :--- |
| **Framework** | ASP.NET Core 8.0 MVC |
| **Veritabanı & ORM** | MS SQL Server, Entity Framework Core (Code First) |
| **Mimari Desenler** | N-Layer, Generic Repository Pattern, Dependency Injection |
| **Kimlik Doğrulama** | ASP.NET Core Identity |
| **Validasyon** | FluentValidation (Server-side), DataAnnotations |
| **Mapping** | AutoMapper |
| **Yapay Zeka (AI)** | **OpenAI Moderation API**, **hugging face token**(Toxiclik kontrolü) |
| **UI & Frontend** | Bootstrap 5, jQuery, FontAwesome, SweetAlert2 |
| **Güvenlik** | Google reCAPTCHA v3 |
| **UI Yapısı** | ViewComponents, Partial Views, Layouts |

---

# 📷 Ekran Görüntüleri

## Blogy Web Sayfası
### Anasayfa
<img width="1890" height="824" alt="Ekran görüntüsü 2025-11-29 223301" src="https://github.com/user-attachments/assets/53d9297a-d1a3-43fc-add0-5a875e4d6c4d" />
<img width="1893" height="829" alt="Ekran görüntüsü 2025-11-29 223253" src="https://github.com/user-attachments/assets/f3385d2e-285c-4aed-808e-309e4bcd2134" />
<img width="1896" height="828" alt="Ekran görüntüsü 2025-11-29 223245" src="https://github.com/user-attachments/assets/81d143fa-a616-43dc-b4d9-f730872c4ce5" />
<img width="1895" height="825" alt="Ekran görüntüsü 2025-11-29 223238" src="https://github.com/user-attachments/assets/09768eb6-aa0b-40ac-9267-e8f64d32c8d5" />
<img width="1895" height="822" alt="Ekran görüntüsü 2025-11-29 223230" src="https://github.com/user-attachments/assets/190af7df-05c2-4346-8149-b878038da94d" />
<img width="1907" height="835" alt="Ekran görüntüsü 2025-11-29 223220" src="https://github.com/user-attachments/assets/7b3d4e0f-c68f-45ea-bd6e-6fc8e3a46fac" />
<img width="1894" height="830" alt="Ekran görüntüsü 2025-11-29 223308" src="https://github.com/user-attachments/assets/c7a57e1f-f39a-4f4f-891b-a0691ab22df6" />



