USE Kutuphane
/* 1.Tabloları Oluşturun:

Kitaplar tablosunu oluşturun:
KitapID, KitapAdi, Yazar, YayınYılı, SayfaSayisi, ISBN.
Dergiler tablosunu oluşturun:
DergiID, DergiAdi, Yayınci, YayınTarihi, Sayı.
DVDler tablosunu oluşturun:
DVDID, DVDAdi, Yönetmen, YayınYılı, Süre.
Ogrenciler tablosunu kullanın
(mevcut Ogrenciler tablosu ile devam edebilir). */

CREATE TABLE Kitaplar
(
    KitapID INT PRIMARY KEY IDENTITY(1,1),
    KitapAdi NVARCHAR(50) NOT NULL,
    Yazar NVARCHAR(50) NOT NULL,
    YayinYili INT NOT NULL,
    SayfaSayisi INT NOT NULL,
    ISBN INT NOT NULL
)

CREATE TABLE Dergiler
(
    DergiID INT PRIMARY KEY IDENTITY(1,1),
    DergiAdi NVARCHAR(50) NOT NULL,
    Yayinci NVARCHAR(50) NOT NULL,
    YayinTarihi DATE NULL,
    Sayi INT NOT NULL

)

CREATE TABLE DVDler(
    DVDID INT PRIMARY KEY IDENTITY(1,1),
    DVDAdi NVARCHAR(50) NOT NULL,
    Yonetmen NVARCHAR(50) NOT NULL,
    YayinYili DATE NOT NULL,
    Sure TIME null
)

CREATE TABLE [Ogrenciler]
(
    [OgrenciID] [int] IDENTITY(1,1) NOT NULL,
    [Ad] [nvarchar](50) NOT NULL,
    [Soyad] [nvarchar](50) NOT NULL,
    [DogumTarihi] [date] NULL,
    [BolumID] [int] NOT NULL
) 

/*
2. Veri Ekleme
Kitaplar tablosuna 20 kitap ekleyin. Türkçe yazar ve kitap adlarını kullanarak örnek veriler oluşturun.
Dergiler tablosuna 5 dergi ekleyin. Dergi adları ve yayıncıları Türkçe olsun.
DVDler tablosuna 5 DVD ekleyin. Türkçe film isimleri ve yönetmenlerle doldurun.
*/

INSERT INTO Dergiler
    (DergiAdi, Yayinci, YayinTarihi, Sayi)
VALUES
    ('Albüm 1 - Hayata Tersten Bak', 'Çizge Yayınevi', '2021-04-08', 1),
    ('Bilim ve Teknoloji - Yeni Ufuklar', 'Bilimsel Yayıncılık', '2020-06-15', 5),
    ('Tarih ve Kültür Dergisi', 'Kültür Yayınları', '2019-11-01', 3),
    ('Sanat ve Edebiyat - Özel Sayı', 'Sanat Dergisi', '2022-09-30', 7),
    ('Doğa ve Çevre Dergisi', 'Yeşil Yayınevi', '2021-02-19', 2);

    INSERT INTO Ogrenciler
    (BolumID, Ad, Soyad, DogumTarihi)
VALUES
    (1, 'Alican', 'Kintutar', '2000-05-19'),
    (1, 'Seden', 'Serdengeçen', '1998-06-12'),
    (2, 'Candan', 'Tutankaçan', '1985-03-19'),
    (3, 'Kemal', 'Evrim', '1996-07-16')

INSERT INTO DVDler
    (DVDAdi, Yonetmen, Sure, YayinYili)
VALUES
    ('Süngerbob', 'Derek Drymon Tim Hill Nicholas R. Jennings', '00:25:00', '2005-01-01'),
    ('Regular Show', 'J. G. Quintel', '00:25:00', '2008-01-01'),
    ('Betamax Video 2', 'Karakarga', '02:25:00', '2004-05-06'),
    ('Looney, Looney, Looney Bugs Bunny', 'Friz Freleng', '01:19:00', '1981-01-01'),
    ('Space Jam', 'Space Jam', '01:28:00', '1996-11-02')

