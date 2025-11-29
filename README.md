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
<img width="1894" height="830" alt="Ekran görüntüsü 2025-11-29 223308" src="https://github.com/user-attachments/assets/e9a0a153-fcec-4e30-85c6-fc0f6c9358bd" />
<img width="1890" height="824" alt="Ekran görüntüsü 2025-11-29 223301" src="https://github.com/user-attachments/assets/e81fae6e-90a1-4b67-bcef-a787be3594be" />
<img width="1893" height="829" alt="Ekran görüntüsü 2025-11-29 223253" src="https://github.com/user-attachments/assets/03c6bea6-1203-45c1-b316-e7048ef5a6d6" />
<img width="1896" height="828" alt="Ekran görüntüsü 2025-11-29 223245" src="https://github.com/user-attachments/assets/028a0746-7b51-4583-98b5-9dddffc4c438" />
<img width="1895" height="825" alt="Ekran görüntüsü 2025-11-29 223238" src="https://github.com/user-attachments/assets/8c1a3405-99dd-4792-af46-d379027e1ed6" />
<img width="1895" height="822" alt="Ekran görüntüsü 2025-11-29 223230" src="https://github.com/user-attachments/assets/3f951dee-df55-40b3-ad0b-94519273ef8c" />
<img width="1907" height="835" alt="Ekran görüntüsü 2025-11-29 223220" src="https://github.com/user-attachments/assets/1aafed01-c4db-41c2-9be0-79046f5034cb" />


