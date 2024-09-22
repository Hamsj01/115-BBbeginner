-- DROP TABLE Bolumler
use Okul
CREATE TABLE Bolumler(
    BolumID int PRIMARY KEY identity(1,1),
    BolumAdi NVARCHAR(50) not null
)

CREATE TABLE Dersler(
    DersID INT PRIMARY KEY IDENTITY(1,1),
    DersAdi NVARCHAR(100) NOT NULL,
    Kredi TINYINT NOT NULL,
    BolumID INT NOT NULL,
    FOREIGN KEY(BolumID) REFERENCES Bolumler(BolumID)
)

CREATE TABLE Ogrenciler(
    OgrenciID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) not NULL,
    DogumTarihi DATE NULL,
    BolumID INT NOT NULL,
    FOREIGN KEY(BolumID) REFERENCES Bolumler(BolumID)  --FOREIGN KEY BAŞKA BİR TABLODAN REFERANS VERMEK İÇİN KULLANILIR.
)

CREATE TABLE DersKayitlari(
    OgrenciID INT,
    DersID INT,
    PRIMARY KEY(OgrenciID, DersID),
    FOREIGN KEY(OgrenciID) REFERENCES Ogrenciler(OgrenciID),
    FOREIGN KEY(DersID) REFERENCES Dersler(DersID)
)

-- Veri ekleme işlemi başlıyor

-- 

