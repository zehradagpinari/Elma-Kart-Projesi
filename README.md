# Elma Kart Projesi

🍎 ElmaKart - Şehir Kartı Yönetim Sistemi
Bu proje, C# Windows Forms kullanılarak geliştirilmiş bir şehir kartı yönetim simülasyonudur. Nesne Yönelimli Programlama (NYP) prensiplerini temel alarak; kullanıcı kaydı, giriş doğrulama ve kart bilgileri kontrolü gibi işlemleri gerçekleştirir.

🚀 Özellikler
Dinamik Giriş Paneli: Şifre göster/gizle (göz ikonu) özelliği ve interaktif yer tutucu (placeholder) metinler.

Merkezi Veri Yönetimi: static bir veri deposu (VeriDeposu) üzerinden tüm formlar arası veri senkronizasyonu.

Gelişmiş Kart Doğrulama: * Kart numarası için 4-4-4-4 formatı zorunluluğu.

Maksimum 19 hane ve CVV için 3 hane kısıtlaması.

Hata Yönetimi: Eksik veya hatalı girişlerde kullanıcıyı yönlendiren bilgilendirici MessageBox uyarıları.

🛠 Kullanılan Teknolojiler ve NYP Yapıları
Proje geliştirilirken aşağıdaki Nesne Yönelimli Programlama tekniklerinden yararlanılmıştır:

Kalıtım (Inheritance): OgrenciKullanici sınıfı, Kullanici temel sınıfından miras alarak kod tekrarını önler.

Polimorfizm (Polymorphism): TipiniSoyle() metodu her kart türü için (Standart/Öğrenci) farklı çıktı üretecek şekilde override edilmiştir.

Kapsülleme (Encapsulation): Kritik veriler private olarak tutulmuş ve kontrollü erişim için Property (get/set) yapıları kullanılmıştır.

Statik Sınıflar: Uygulama ömrü boyunca verilerin korunması için VeriDeposu statik olarak tanımlanmıştır.
