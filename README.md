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

## 📷 Ekran Görüntüleri

| Admin Dashboard | Blog Detay & Yorum |
| :---: | :---: |
| ![Admin](https://via.placeholder.com/400x200?text=Admin+Panel) | ![Blog](https://via.placeholder.com/400x200?text=Blog+Detail+AI) |

| Yazar Paneli | AI Chatbox |
| :---: | :---: |
| ![Writer](https://via.placeholder.com/400x200?text=Writer+Panel) | ![Chat](https://via.placeholder.com/400x200?text=Chatbox) |

---



Geliştirici: **[Adınız Soyadınız]**
LinkedIn: [linkedin.com/in/profiliniz](https://linkedin.com/in/profiliniz)
GitHub: [github.com/KullaniciAdiniz](https://github.com/KullaniciAdiniz)

---
*Bu proje, modern web geliştirme standartları ve yapay zeka teknolojileri kullanılarak geliştirilmiştir.*
