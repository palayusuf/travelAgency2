# Travel Agency

C# ile geliştirilmiş, veritabanı destekli bir Seyahat Acentesi (Travel Agency) yönetim uygulaması.

## Özellikler

- C# (.NET) ile yazılmıştır
- Visual Studio çözüm dosyası (`travelAgency2.sln`) ile yönetilir
- Veritabanı tasarımına ait şema/diyagram görselleri (`veritabanı görselleri` klasörü) içerir

## Proje Yapısı

```
travelAgency2/
├── travelAgency2/             # Uygulama kaynak kodu
├── veritabanı görselleri/     # Veritabanı şema ve tasarım görselleri
├── travelAgency2.sln          # Visual Studio çözüm dosyası
├── .gitattributes
└── .gitignore
```

## Gereksinimler

- Visual Studio 2019 veya üzeri
- .NET Framework / .NET SDK (proje yapılandırmasına göre)
- Bir veritabanı sunucusu (ör. SQL Server) — `veritabanı görselleri` klasöründeki şemaya göre kurulmalıdır

## Kurulum ve Çalıştırma

Depoyu klonlayın:

```bash
git clone https://github.com/palayusuf/travelAgency2.git
cd travelAgency2
```

`travelAgency2.sln` dosyasını Visual Studio ile açın.

Veritabanını `veritabanı görselleri` klasöründeki şemaya uygun şekilde oluşturun ve bağlantı dizesini (connection string) proje yapılandırma dosyasında güncelleyin.

Projeyi derleyip çalıştırın (Visual Studio üzerinden `Build` ve `Start` / `F5`).

## Katkıda Bulunma

1. Bu depoyu fork'layın
2. Yeni bir özellik dalı oluşturun (`git checkout -b ozellik/yeni-ozellik`)
3. Değişikliklerinizi commit'leyin (`git commit -m 'Yeni özellik eklendi'`)
4. Dalınızı push'layın (`git push origin ozellik/yeni-ozellik`)
5. Bir Pull Request açın

## Lisans

Bu proje için herhangi bir lisans belirtilmemiştir. Kullanmadan önce depo sahibiyle iletişime geçmeniz önerilir.
