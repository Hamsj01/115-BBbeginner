CREATE DATABASE Idare
Use Idare

/*Bir okulun idari işleri için bir personel ve maaş yönetim sistemi kurulması isteniyor.
 Personelin adı, soyadı, pozisyonu ve maaşları kaydedilecek.
Ayrıca, maaş değişiklikleri kaydedilecek ve belirli raporlamalar yapılacak.
 
 1. Tabloları Oluşturun:
Personel tablosunu oluşturun: PersonelID, Ad, Soyad, Pozisyon, BaslangicTarihi.
 Maaslar tablosunu oluşturun: MaasID, PersonelID, MaasMiktari, GuncellemeTarihi.
 (Maaşlar tabloda her maaş değişikliğinde güncellenecek, bu yüzden her güncelleme ayrı bir kayıt olacak.)
 */

CREATE TABLE Personel(
    PersonelId INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    Pozisyon NVARCHAR(50) not null,
    BaslangicTarihi DATE null,
)

CREATE TABLE Maaslar(
    MaasId INT PRIMARY KEY IDENTITY(1,1),
    PersonelId INT NOT NULL,
    FOREIGN KEY(PersonelID) REFERENCES Personel(PersonelID),
    BaslangicMaasi INT NOT NULL,
    MaasMiktari INT NOT NULL,
    GuncellemeTarihi Date null
)