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
    ISBN VARCHAR(17) NOT NULL
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

INSERT INTO Kitaplar
    (KitapAdi, Yazar, YayinYili, SayfaSayisi, ISBN)
VALUES
    ('Rüyaların Yorumu', 'SIGMUND FREUD', '2021', 647, '978-625-7135-99-3'),
    ('Düşlerin Yorumu', 'CARL GUSTAV JUNG', '2019', 528, '978-605-0205-48-1'),
    ('İnsan ve Semboller', 'CARL GUSTAV JUNG', '2015', 448, '978-9944-868-63-9'),
    ('Freud ve Psikanaliz', 'ERICH FROMM', '2020', 256, '978-605-0204-27-9'),
    ('Bilinçdışı', 'SIGMUND FREUD', '2017', 224, '978-605-0203-99-9'),
    ('Varoluşun Psikolojisi', 'ABRAHAM MASLOW', '2016', 300, '978-605-0203-84-5'),
    ('Kendini Arayan İnsan', 'ROLLO MAY', '2019', 280, '978-605-0951-61-6'),
    ('Özgürlük Korkusu', 'ERICH FROMM', '2014', 224, '978-605-0201-87-2'),
    ('İnsan Olmak', 'CARL ROGERS', '2013', 320, '978-605-0201-92-6'),
    ('Psikolojik Tipler', 'CARL GUSTAV JUNG', '2020', 750, '978-605-0203-94-4'),
    ('1984', 'GEORGE ORWELL', '2016', 352, '978-0-452-28423-4'),
    ('Cesur Yeni Dünya', 'ALDOUS HUXLEY', '2018', 288, '978-0-099-51648-7'),
    ('Fahrenheit 451', 'RAY BRADBURY', '2017', 256, '978-1-4516-7331-9'),
    ('Mülksüzler', 'URSULA K. LE GUIN', '2019', 336, '978-0-061-05168-4'),
    ('Karanlığın Sol Eli', 'URSULA K. LE GUIN', '2018', 304, '978-0-441-47812-5'),
    ('Ben, Robot', 'ISAAC ASIMOV', '2016', 224, '978-0-553-29438-5'),
    ('Vakıf', 'ISAAC ASIMOV', '2021', 320, '978-0-553-29335-7'),
    ('Yıldız Gemisi Askerleri', 'ROBERT A. HEINLEIN', '2015', 263, '978-0-441-78438-8'),
    ('Çocukluğun Sonu', 'ARTHUR C. CLARKE', '2016', 240, '978-1-59102-086-3'),
    ('Dune', 'FRANK HERBERT', '2019', 688, '978-0-441-17271-0')

