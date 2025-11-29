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

## Blogy Web Sayfası
# Anasayfa
<img width="1894" height="830" alt="Ekran görüntüsü 2025-11-29 223308" src="https://github.com/user-attachments/assets/07058ce1-f4e2-4313-8d82-d91dafc7f8bf" />
<img width="1890" height="824" alt="Ekran görüntüsü 2025-11-29 223301" src="https://github.com/user-attachments/assets/77c61296-d0f2-4089-a26d-263816a815b4" />
<img width="1893" height="829" alt="Ekran görüntüsü 2025-11-29 223253" src="https://github.com/user-attachments/assets/67202493-282d-446d-9807-1c431b569e22" />
<img width="1896" height="828" alt="Ekran görüntüsü 2025-11-29 223245" src="https://github.com/user-attachments/assets/3597286b-ea48-458b-9624-c9bb837b9517" />
<img width="1895" height="825" alt="Ekran görüntüsü 2025-11-29 223238" src="https://github.com/user-attachments/assets/f92cc9b4-47c5-4dbe-bbca-352b8fcd5239" />
<img width="1895" height="822" alt="Ekran görüntüsü 2025-11-29 223230" src="https://github.com/user-attachments/assets/846cf24d-7ab9-436f-b868-65c73893c7f0" />
<img width="1907" height="835" alt="Ekran görüntüsü 2025-11-29 223220" src="https://github.com/user-attachments/assets/159906c1-a8f7-4c7b-8207-47cf1325d0c9" />

