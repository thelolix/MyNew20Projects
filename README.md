# 🚀 ADO.NET ile Müşteri Yönetim Sistemi (20 Proje Serisi - Proje 1)

Bu proje, C# Windows Forms ve ilişkisel SQL Server veri tabanı kullanılarak temel **CRUD (Create, Read, Update, Delete)** operasyonlarını ve ADO.NET mimarisini kavramak amacıyla geliştirilmiştir.

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



![Müşteri Formu Ekran Görüntüsü]()

---

## ⚙️ Nasıl Çalıştırılır?

1. Bilgisayarınızda **SQL Server** servisinin açık olduğundan emin olun.
2. `FrmCustomer.cs` içerisindeki `SqlConnection` string alanını kendi SQL Server sunucu adınıza (`server=...`) göre güncelleyin.
3. Projeyi Visual Studio ile açıp `F5` tuşuna basarak çalıştırabilirsiniz.
