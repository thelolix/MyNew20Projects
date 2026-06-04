# 🚀 ADO.NET ile Müşteri Yönetim Sistemi (20 Proje Serisi - Proje 1)

Bu proje, C# Windows Forms ve ilişkisel SQL Server veri tabanı kullanılarak temel **CRUD (Create, Read, Update, Delete)** operasyonlarını ve ADO.NET mimarisini kavramak amacıyla geliştirilmiştir.


## 💻 Proje Klasör Yapısı
* `/Project1_Adonetcustomer` -> ADO.NET ile Katı SQL Sorgulu Müşteri Yönetimi
* `/Project2_EntityFrameworkDbFirstProduct` -> EF DbFirst ile Modern Ürün Yönetim Paneli
* `/Project3_EntityFrameWorkStatistics` -> EF & T-SQL Dinamik İstatistik Paneli *(Aktif Proje)*

---

## 🛠️ Kullanılan Teknolojiler ve Yapı

* **Programlama Dili:** C# (.NET Framework)
* **Arayüz:** Windows Forms (WinForms)
* **Veri Tabanı:** SQL Server (MSSQL)
* **Veri Erişim Teknolojisi:** ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`, `DataTable`)

---

## 📌 Proje Özellikleri ve Öğrenilen Kazanımlar

* **İlişkisel Veri Tabanı Mimarisi:** `TblCustomer` (Müşteri) ve `TblCity` (Şehir) tabloları arasında `INNER JOIN` kullanılarak şehir bazlı ilişkisel listeleme yapılmıştır.
* **Güvenli Sorgu Yönetimi:** SQL Injection açıklarını tamamen engellemek amacıyla parametreli sorgu yapısı (`command.Parameters.AddWithValue`) kullanılmıştır.
* **Dinamik Veri Bağlama:** Form açıldığında şehir listesi SQL tablosundan çekilerek ComboBox (`cbmCity`) içerisine `ValueMember` ve `DisplayMember` özellikleri kullanılarak dinamik olarak yüklenmektedir.
* **Durum Kontrolü:** RadioButton kontrolüyle müşterinin aktiflik/pasiflik durumu `if-else` bloklarıyla güvenli bir şekilde `bit` (boolean) olarak veri tabanına işlenmektedir.

---

## 📸 Projeden Ekran Görüntüsü
<img width="1919" height="1025" alt="Ekran görüntüsü 2026-05-30 145203" src="https://github.com/user-attachments/assets/42504c50-2aa0-4112-b83a-0dd7434c01a2" />
<img width="1918" height="1029" alt="Ekran görüntüsü 2026-05-30 145220" src="https://github.com/user-attachments/assets/dd9075bd-bcd1-42db-aa82-797cdfcd2dfd" />
<img width="1913" height="1017" alt="image" src="https://github.com/user-attachments/assets/2ca37643-3cff-4587-b246-d12d9068cc02" />



---


## 📦 Proje 2: Entity Framework DbFirst ile Ürün Yönetim Paneli

Serinin bu projesinde, MS SQL Server üzerinde tasarlanan ilişkisel veritabanı mimarisi, **Entity Framework DbFirst (Database First)** yaklaşımı kullanılarak C# .NET WinForms ortamına aktarılmış ve uçtan uca modern bir **CRUD (Create, Read, Update, Delete)** yönetim paneli geliştirilmiştir.

Projenin temel amacı; veri tabanı nesnelerini (Tablolar, İlişkiler) tamamen nesne yönelimli programlama (OOP) sınıflarına dönüştürerek, katı SQL sorguları yazmadan daha güvenli, hızlı ve temiz bir kod mimarisi (`Clean Code`) inşa etmektir.

### 🛠️ Kullanılan Teknolojiler & Mimariler
* **Geliştirme Ortamı:** C# .NET WinForms
* **ORM (Object-Relational Mapping):** Entity Framework (DbFirst - EDMX modeli)
* **Veritabanı:** MS SQL Server (İlişkisel Veritabanı Mimarisi)
* **Programlama Yaklaşımı:** OOP (Nesne Yönelimli Programlama), LINQ bazlı CRUD operasyonları

### ⚙️ Öne Çıkan Teknik Detaylar & Mimari Yaklaşımlar
* **DbFirst Entegrasyonu:** Veritabanındaki `TblProduct` ve `TblCategory` tabloları EDMX (Entity Data Model) aracılığıyla C# entity sınıflarına dönüştürülmüştür.
* **İlişkisel Veri Yönetimi (Foreign Key):** Ürün ekleme ve güncelleme işlemlerinde, kategori eşleştirmeleri sihirli sayılarla (ID) değil; nesne ilişkileri üzerinden yönetilmiştir.
* **LINQ Tabanlı Veri Listeleme & Filtreleme:** Klasik SQL komutları yerine `db.TblProduct.ToList()` ve `.Where()` fonksiyonları kullanılarak veri manipülasyonu optimize edilmiştir.
* **Güvenli CRUD Operasyonları:** `Context` yönetimi (`db.SaveChanges()`) ile veri tabanına veri yazma, silme ve güncelleme süreçleri transaksiyonel güvenlikle gerçekleştirilmiştir.
* **Durum ve Stok Yönetimi:** Ürünlerin aktif/pasif durum kontrolleri ve stok miktarları dinamik arayüz elementleriyle kontrol altına alınmıştır.



## 📸 Projeden Ekran Görüntüsü
<img width="1903" height="756" alt="image" src="https://github.com/user-attachments/assets/0f6b26fd-6054-40fb-b884-060027a3f31c" />
<img width="1919" height="985" alt="Ekran görüntüsü 2026-06-04 170253" src="https://github.com/user-attachments/assets/91374dc5-8d40-4f8f-adb4-75e0bb76c7ab" />

----

Bu repo, C# programlama dili, .NET WinForms mimarisi ve kurumsal veritabanı yönetim sistemlerini (MS SQL Server) uçtan uca uygulamalı olarak öğrenmek ve sektörel senaryolarla deneyimlemek amacıyla geliştirilen **20 farklı projeden oluşan** bir portfolyo serisidir.

Her bir proje, katmanlı mimari mantığını, veri tutarlılığını ve performanslı sorgu yazım tekniklerini (LINQ & Ham SQL) pekiştirmek amacıyla sıfırdan inşa edilmiştir.

---

## 📈 Proje 3: Entity Framework ile Dinamik İstatistik Paneli

Serinin bu projesinde, ilişkisel bir veritabanı (E-Ticaret modeli) üzerinde Entity Framework (DbFirst) ve ham T-SQL sorguları kullanılarak kurumsal bir **Dashboard / İstatistik Paneli** geliştirilmiştir. 

Projenin temel amacı; veritabanındaki büyük verileri anlamlı raporlara dönüştürürken **Entity Framework - LINQ** mimarisi ile **Ham SQL (Raw SQL)** sorgularının performans ve doğruluk karşılaştırmalarını simüle etmektir.

### 🛠️ Kullanılan Teknolojiler & Mimariler
* **Geliştirme Ortamı:** C# .NET WinForms
* **ORM (Object-Relational Mapping):** Entity Framework (DbFirst - EDMX)
* **Veritabanı:** MS SQL Server & T-SQL
* **Sorgulama Teknolojileri:** LINQ (Language Integrated Query), Lambda Expressions, `SqlQuery<T>`

### ⚙️ Öne Çıkan Teknik Detaylar & Hesaplamalar
Panel üzerinde tamamen dinamik olarak hesaplanan ve anlık güncellenen metriklerden bazıları şunlardır:
* **Veri Agregasyonu:** `Sum()`, `Count()`, `Average()` ve `Distinct()` fonksiyonları ile toplam stok, ortalama ürün fiyatı ve ülke çeşitliliği analizi.
* **Koşullu Filtreleme (Where):** Kategori bazlı aktif/pasif durum kontrolleri ve kritik stok seviyesi (`Stock < 100`) analizi.
* **Gelişmiş Sıralama (Ordering):** `OrderByDescending` ve `FirstOrDefault` kombinasyonları ile sisteme son eklenen müşteri ve son eklenen ürün bilgilerinin dinamik tespiti.
* **Dinamik İşlem Hacmi:** Belirli ürün gruplarının (Gazoz, Kola vb.) anlık stok miktarları ile birim fiyatlarının `.Sum(x => x.Stok * x.Fiyat)` şeklinde inline çarpılarak toplam ciro potansiyelinin hesaplanması.
* **EF vs Raw SQL Performansı:** Meyve kategorisine ait toplam ciro verisi hem **LINQ (Join-less logic)** hem de **SQL `JOIN`** sorguları (`Database.SqlQuery`) ile çift yönlü doğrulanmış ve veri kaçakları (Null Reference) önlenmiştir.


## 📸 Projeden Ekran Görüntüsü
<img width="1918" height="1027" alt="image" src="https://github.com/user-attachments/assets/b5f4420d-ce9f-4881-9c16-9fe354793691" />

---

## 👥 İletişim & Portfolyo
* **Geliştirici:** Mustafa Talha Yılmaz  
* **LinkedIn:** [Mustafa Talha Yılmaz](https://www.linkedin.com/in/mustafatalhayilmaz/)  
* **E-Posta:** mustafatalha311@gmail.com

## ⚙️ Nasıl Çalıştırılır?

1. Bilgisayarınızda **SQL Server** servisinin açık olduğundan emin olun.
2. `FrmCustomer.cs` içerisindeki `SqlConnection` string alanını kendi SQL Server sunucu adınıza (`server=...`) göre güncelleyin.
3. Projeyi Visual Studio ile açıp `F5` tuşuna basarak çalıştırabilirsiniz.
