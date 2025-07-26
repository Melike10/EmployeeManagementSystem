# 👩‍💼 Personel Yönetim Sistemi (.NET 8 & DevExpress)

Bu proje, DevExpress bileşenleri kullanılarak geliştirilen çok katmanlı bir **Personel Yönetim Uygulamasıdır**. Projede amaç, DevExpress Form bileşenleri üzerinde deneyim kazanmak ve çok katmanlı mimaride personel yönetimi süreçlerini gerçekleştirmektir.

## 🎯 Proje Amacı

Bu uygulama, insan kaynakları süreçlerini desteklemek amacıyla geliştirilmiştir. Ana hedef, **DevExpress Form kontrolleri** ile kullanıcı dostu bir arayüz oluşturarak, **personel işlemleri**, **izin yönetimi**, **bordro işlemleri** ve **işten ayrılma/yeniden işe alım** gibi operasyonların kolayca yapılabilmesini sağlamaktır.

---

## 🔧 Kullanılan Teknolojiler

- **.NET 8**
- **DevExpress Windows Forms UI**
- **MSSQL (Microsoft SQL Server)**
- **N-Layer Mimari**
  - `Business`
  - `Core`
  - `DataAccess`
  - `Entities`
  - `EmployeeUI`
- **Dependency Injection (DI)** yapısı
- **Entity Framework**

---

## 📁 Proje Yapısı

```text
├── Business               # İş mantığı (Services, Rules)
├── Core                  # Ortak arayüzler ve yardımcı sınıflar
├── DataAccess            # Veritabanı erişimi (EF kullanılarak)
├── Entities              # DTO ve Entity modelleri
├── EmployeeUI            # DevExpress ile geliştirilen Windows Form arayüzü
```
## 🧩 Özellikler

### 📋 Ana Sayfa – Personel Listesi
- TC Kimlik No  
- Ad Soyad  
- Bölüm  
- Doğum Tarihi  
- Maaş  
- İşe Başlama Tarihi  
- İzin Bitiş Tarihi (varsa)  
- İşten Çıkma Tarihi ve Ayrılma Sebebi  
- İşlemler: `Güncelle`, `Sil`, `İşten Çıkar`, `İşe Geri Al`

### 👤 Personel Ekleme Formu  
Yeni personel bilgileri sisteme DevExpress formlar aracılığıyla eklenebilir.

### ⛱️ İzinli Personel ve İzin Kaydı  
- İzinli personeller listelenir.  
- Yeni izin kayıtları oluşturulabilir.

### 🧾 Bordro Modülü  
- Bordro özet ve detay ekranları  
- Bordro oluşturma işlemleri  
- Parametrelerle hesaplama özelleştirmesi

### 🔁 İşten Çıkış / Geri Alım  
- İşten ayrılma işlemleri ve sebep kaydı  
- Personelin sisteme yeniden alınması

### 🏢 Bölüm Listesi  
- Personel bölümleri listelenir ve düzenlenebilir

---

## 🛠️ Kurulum ve Çalıştırma

1. Veritabanını oluşturun ve `appsettings.json` üzerinden bağlantı ayarlarını yapın.  
2. Gerekli NuGet paketlerini yükleyin (`DevExpress`, `Microsoft.EntityFrameworkCore`, vb.).  
3. `EmployeeUI` katmanını başlatın.  
4. DI yapılandırmaları `Program.cs` veya `Startup.cs` içerisinde yapılmıştır.  
5. Uygulamayı Visual Studio ile çalıştırabilirsiniz.

---

## 📷 Ekran Görüntüleri


![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b1.png?raw=true)
![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b2.png?raw=true)
![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b3.png?raw=true)
![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b4.png?raw=true)
![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b5.png?raw=true)
![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b6.png?raw=true)
![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b7.png?raw=true)
![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b8.png?raw=true)
![Ana Sayfa](https://github.com/Melike10/EmployeeManagementSystem/blob/af2d6ff96063a62ea235e3762b76b83a519e92ec/b9.png?raw=true)

