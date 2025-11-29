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
<img width="1907" height="835" alt="Ekran görüntüsü 2025-11-29 223220" src="https://github.com/user-attachments/assets/7b3d4e0f-c68f-45ea-bd6e-6fc8e3a46fac" />
<img width="1895" height="822" alt="Ekran görüntüsü 2025-11-29 223230" src="https://github.com/user-attachments/assets/190af7df-05c2-4346-8149-b878038da94d" />
<img width="1895" height="825" alt="Ekran görüntüsü 2025-11-29 223238" src="https://github.com/user-attachments/assets/09768eb6-aa0b-40ac-9267-e8f64d32c8d5" />
<img width="1896" height="828" alt="Ekran görüntüsü 2025-11-29 223245" src="https://github.com/user-attachments/assets/81d143fa-a616-43dc-b4d9-f730872c4ce5" />
<img width="1893" height="829" alt="Ekran görüntüsü 2025-11-29 223253" src="https://github.com/user-attachments/assets/f3385d2e-285c-4aed-808e-309e4bcd2134" />
<img width="1890" height="824" alt="Ekran görüntüsü 2025-11-29 223301" src="https://github.com/user-attachments/assets/53d9297a-d1a3-43fc-add0-5a875e4d6c4d" />
<img width="1894" height="830" alt="Ekran görüntüsü 2025-11-29 223308" src="https://github.com/user-attachments/assets/c7a57e1f-f39a-4f4f-891b-a0691ab22df6" />

### Hakkımızda
<img width="1896" height="606" alt="Ekran görüntüsü 2025-11-29 223327" src="https://github.com/user-attachments/assets/c1636c9d-f52e-451a-89bc-96f51b434743" />
<img width="1919" height="835" alt="Ekran görüntüsü 2025-11-29 223340" src="https://github.com/user-attachments/assets/4e8e91a1-3f4a-40d4-b716-aae4a7d9784c" />
<img width="1897" height="821" alt="Ekran görüntüsü 2025-11-29 223400" src="https://github.com/user-attachments/assets/a74ffc77-0a7c-4abf-9df2-7301faedd5f9" />
<img width="1888" height="834" alt="Ekran görüntüsü 2025-11-29 223429" src="https://github.com/user-attachments/assets/c9cb7c41-4f74-46c7-bec8-e881cdfe50f0" />

### Bloglar
<img width="1919" height="824" alt="Ekran görüntüsü 2025-11-29 223451" src="https://github.com/user-attachments/assets/104934d6-f9d0-4b59-bfde-5a863057e99b" />
<img width="1890" height="825" alt="Ekran görüntüsü 2025-11-29 223459" src="https://github.com/user-attachments/assets/8d26a653-105c-40f2-9cf4-f77c23fddfe5" />
<img width="1897" height="834" alt="Ekran görüntüsü 2025-11-29 223521" src="https://github.com/user-attachments/assets/4b1b8953-8c8d-44fb-91f7-8739c46da949" />
<img width="1896" height="825" alt="Ekran görüntüsü 2025-11-29 223537" src="https://github.com/user-attachments/assets/47f7c56d-969e-40c6-aede-3803543bf840" />
<img width="1899" height="822" alt="Ekran görüntüsü 2025-11-29 223545" src="https://github.com/user-attachments/assets/9a47725a-7423-4bf1-9bc2-a5e2ee8aa5ab" />

### Yorum Yapma
<img width="1896" height="831" alt="Ekran görüntüsü 2025-11-29 223554" src="https://github.com/user-attachments/assets/5f694706-eb54-4d6b-b7e4-0039317a57ac" />
<img width="865" height="463" alt="Ekran görüntüsü 2025-11-29 223612" src="https://github.com/user-attachments/assets/164250e2-2072-4811-ad0d-ced19d923a58" />
<img width="765" height="425" alt="Ekran görüntüsü 2025-11-29 223702" src="https://github.com/user-attachments/assets/289be621-3bca-4551-b095-57d122ecfbd7" />
<img width="984" height="547" alt="Ekran görüntüsü 2025-11-29 223724" src="https://github.com/user-attachments/assets/35d9afb4-39ed-4fc0-a401-b6b1b125d30b" />
<img width="1061" height="525" alt="Ekran görüntüsü 2025-11-29 223732" src="https://github.com/user-attachments/assets/f0067413-097a-4f0c-ba07-437df433acd0" />

### İletişim
<img width="1895" height="842" alt="Ekran görüntüsü 2025-11-29 223743" src="https://github.com/user-attachments/assets/ab4827d7-2bcd-4510-863b-2be6d8479252" />
<img width="602" height="428" alt="Ekran görüntüsü 2025-11-29 223759" src="https://github.com/user-attachments/assets/68c2d3d8-79f0-4178-8f4f-13895ec20ed0" />
<img width="689" height="444" alt="Ekran görüntüsü 2025-11-29 223835" src="https://github.com/user-attachments/assets/79483fb5-0847-406c-8901-aae9acc533d6" />

## Admin Paneli
### Dashboard
<img width="1894" height="826" alt="Ekran görüntüsü 2025-11-29 223910" src="https://github.com/user-attachments/assets/e40e59f8-fddd-4203-8f9a-5cea8aaedbb2" />
<img width="1895" height="825" alt="Ekran görüntüsü 2025-11-29 223921" src="https://github.com/user-attachments/assets/d0932bd4-0dab-4791-b934-d2d639a6194b" />
<img width="1898" height="827" alt="Ekran görüntüsü 2025-11-29 223938" src="https://github.com/user-attachments/assets/6d12b0ed-1832-4164-96fe-7a3423a2ac1d" />

### Bloglar
<img width="1891" height="827" alt="Ekran görüntüsü 2025-11-29 223952" src="https://github.com/user-attachments/assets/024d270a-df54-482e-93f7-eadc6879897a" />
<img width="1894" height="832" alt="Ekran görüntüsü 2025-11-29 224004" src="https://github.com/user-attachments/assets/c483d9e7-0b14-4451-8e61-15e05676e5b4" />

### Diğer Sayfalar
<img width="1919" height="756" alt="Ekran görüntüsü 2025-11-29 224013" src="https://github.com/user-attachments/assets/994abf89-9cd6-4363-947b-5c2d44945cfc" />
<img width="1897" height="830" alt="Ekran görüntüsü 2025-11-29 224023" src="https://github.com/user-attachments/assets/7f6043e6-8b3f-4a21-9d8a-ef4486b4311d" />
<img width="1897" height="824" alt="Ekran görüntüsü 2025-11-29 224030" src="https://github.com/user-attachments/assets/05918ff1-38d9-4637-99da-e1e31ee76719" />
<img width="1896" height="826" alt="Ekran görüntüsü 2025-11-29 224040" src="https://github.com/user-attachments/assets/115c32f9-a64c-42b8-9196-a98c216fbe28" />
<img width="1919" height="758" alt="Ekran görüntüsü 2025-11-29 224047" src="https://github.com/user-attachments/assets/cad53272-fe99-4b02-9732-aa50d2a5228c" />
<img width="1919" height="756" alt="Ekran görüntüsü 2025-11-29 224056" src="https://github.com/user-attachments/assets/a3cbd8d8-08d8-4732-9878-7ad507fb318d" />
<img width="1919" height="829" alt="Ekran görüntüsü 2025-11-29 224104" src="https://github.com/user-attachments/assets/dd9fb8ec-405f-460f-8221-806ade3d6fda" />
<img width="1917" height="766" alt="Ekran görüntüsü 2025-11-29 224112" src="https://github.com/user-attachments/assets/f46d5d97-fc19-4f24-b9ba-512cfe665452" />

## Yazar Paneli
### Dashboard
<img width="1895" height="824" alt="Ekran görüntüsü 2025-11-29 224155" src="https://github.com/user-attachments/assets/152e52e9-ddde-4eb7-ab2c-8d6701a69c79" />

### Diğer Sayfalar
<img width="1917" height="830" alt="Ekran görüntüsü 2025-11-29 224134" src="https://github.com/user-attachments/assets/4b16ce7a-c197-4069-8e9e-bb9b3edef521" />
<img width="1919" height="832" alt="Ekran görüntüsü 2025-11-29 224142" src="https://github.com/user-attachments/assets/5bfa1675-5dc1-4ee7-93b5-40e6adf44f52" />
<img width="1918" height="604" alt="Ekran görüntüsü 2025-11-29 224203" src="https://github.com/user-attachments/assets/18017df5-da79-485d-aba2-4662afce887a" />
<img width="1919" height="833" alt="Ekran görüntüsü 2025-11-29 224211" src="https://github.com/user-attachments/assets/a27b38bd-c811-4f8d-85aa-b5f251d0d8ad" />
<img width="1919" height="835" alt="Ekran görüntüsü 2025-11-29 224218" src="https://github.com/user-attachments/assets/bcf080c8-b3d2-4d78-a549-519110c06cc5" />

## Kullanıcı Paneli
### Sayfalar
<img width="1898" height="826" alt="Ekran görüntüsü 2025-11-29 224243" src="https://github.com/user-attachments/assets/1c567b64-91ba-4b5e-b665-371e949ccd75" />
<img width="1897" height="820" alt="Ekran görüntüsü 2025-11-29 224250" src="https://github.com/user-attachments/assets/7d52846a-5f8a-4486-ae3e-b3563ef3df39" />
<img width="1899" height="827" alt="Ekran görüntüsü 2025-11-29 224300" src="https://github.com/user-attachments/assets/4adf13e4-0ebc-4568-9219-fe38b5442803" />

## Giriş ve Kayıt Sayfaları
<img width="1919" height="825" alt="Ekran görüntüsü 2025-11-29 223628" src="https://github.com/user-attachments/assets/82e2cc4f-9ceb-4b53-a164-d4b57e46e803" />
<img width="1913" height="833" alt="Ekran görüntüsü 2025-11-29 223620" src="https://github.com/user-attachments/assets/87ce0a62-72ae-404e-bbd8-1a6d3086e13d" />

