/*2. Veri ekleme:
10 personel ekleyin.
Personelin pozisyonları okul müdürü, öğretmen, sekreter
gibi roller olsun.
Her personel için başlangıç maaşlarını Maaslar tablosuna ekleyin.
Her personel için en az bir maaş güncellemesi daha yapın.
*/
USE Idare
INSERT INTO Personel
    (AD, Soyad, Pozisyon, BaslangicTarihi)
VALUES

    ('Mahmut', 'Işık', 'Okul Müdürü', '2005-10-11'),
    ('Selin', 'Yetmez', 'Sekreter', '2007-01-25' ),
    ('Miraç','Katmer','Öğretmen','2019-11-21'),
    ('Kazım','Yerebatan','Öğretmen','2018-11-23'),
    ('Nazım Ali','Yıldırır','Sekreter','2010-05-12'),
    ('Binnaz','Parke','Öğretmen','2017-02-16'),
    ('Olga', 'Rabolli', 'Öğretmen', '2011-04-03'),
    ('İpek', 'Beyazbekir', 'Sekreter', '2019-12-03'),
    ('Mehmet', 'Persuyu', 'Öğretmen', '2020-04-03'),
    ('Cansu', 'Çakıroğlu', 'Öğretmen', '2021-04-03')

    INSERT INTO Maaslar
        (PersonelID,BaslangicMaasi,GuncellemeTarihi,MaasMiktari)
    VALUES
        (3,'15234','2023-12-29',49213),
        (4,15234,'2023-12-29',42135),
        (5,15234,'2023-12-29',22212),
        (1,800,'2023-12-29',88213),
        (9,15234,'2023-12-29',24352),
        (6,15234,'2023-12-29',2352),
        (2,750,'2023-12-29',42002),
        (7,15234,'2023-12-29',17002),
        (10,15234,'2023-12-29',17002),
        (8,15234,'2023-12-29',17003)
