-- SELECT CategoryNmae, Description FROM Categories 
-- SELECT * Categories

-- Products tablosundaki tüm kayıtların ProductId, PriceId,Price UnitsInStock,UnitPrice, kolonlarını geri döndürün

-- SELECT
--     p.ProductID AS Id,
--     p.ProductName AS 'Birim Fiyat',
--     p.UnitsInStock [Stock Adedi],
--     p.UnitPrice AS 'Birim Fiyat'
-- FROM Products p

--En yüksek fiyatı bulalım
-- SELECT 
--     MAX(p.UnitPrice) AS [Maksimum Fiyat],
--     MIN(p.UnitPrice) AS [Minimum Fiyat],
--     AVG(p.UnitPrice) AS [Ortalama],
--     COUNT(*) AS [Ürün sayisi]        *: HEPSİNİ GETİRİR
--     COUNT(p.UnitPrice) AS [Ürün Sayisi],
--     SUM(p.UnitPrice*p.UnitsInStock) AS [Toplam Değer]

-- FROM Products p

--TEMEL FONKSYİON

-- SELECT 
--     p.ProductName AS [Default],
--     UPPER(p.ProductName) AS [BÜYÜK HARF],
--     LOWER(p.ProductName) AS [küçük harf],
--     REPLACE(REPLACE(p.ProductName,' ','_'),'?','') AS [Url]
-- FROM Products p

-- SELECT *
-- FROM Products p
-- WHERE p.UnitPrice>40

SELECT *
FROM Products p
-- WHERE p.UnitPrice>=40 AND p.UnitPrice<=100
WHERE p.UnitPrice BETWEEN 40 AND 100 --BETWEEN: ARASINDA
--ORDER BY  p.ProductName --BU FONKSİYON SIRALAMA YAPAR (ORDER BY)
ORDER BY p.CategoryID, p.UnitPrice DEsc -- DESC İLGİLİ KATEGORİYİ BÜYÜKTEN KÜÇÜĞE YAPAPR.



