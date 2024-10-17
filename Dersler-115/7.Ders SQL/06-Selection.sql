-- Join: SQL'de tabloları ilişki alanlar üzerinden birleştirme işlemine join denir.

-- Join türleri:
-- (inner) join: birleştirilecek iki tablodaki eşleşen kayıtları bir araya getirir.
-- Left join: Sol taraftaki tabloların tüm kayıtlarını sağ taraftaki tablonun ise sadece eşleşen kayıtlarını getirir.
-- Right join: Sağ taraftaki tabloların tüm kayıtlarını sol taraftaki tablonun ise sadece eşleşen kayıtlarını getirir.
-- outer: (full) join: Birleştirilecek iki tablodaki eşleşen ya da eşleşmeyen kayıtları bir araya getirir.

-- Product ve categories tablolarını birleştrimesini sağlayan
-- SELECT
--     p.ProductID AS [Id],
--     p.ProductName AS [Ürün],
--     p.UnitPrice AS [Fiyat],
--     c.CategoryName AS [Kategori]
-- FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
-- WHERE c.CategoryName='Beverages'

--YENİ BİR KATEGORİ EKLİYORUZ

-- INSERT INTO Categories(CategoryName, Description)
-- VALUEs ('Televizyon' ,' Televizyon ürünleri','Televizyon ürünleri burada')


-- SELECT *
-- FROM Products p INNER JOIN Categories c ON p.CategoryID=c.CategoryID

-- Ürünleri (ProductID, ProductName, UnitPrice) Supplier Company Name'leri ile birlikte listeleyim.

-- SELECT 
--     p.ProductID AS [Id],
--     p.ProductName AS [Ürün],
--     p.UnitPrice AS [Fiyat],
--     s.CompanyName AS [Tedarikçi]
-- FROM Products p
--         JOIN Suppliers s ON p.SupplierID=s.SupplierID 
--         ORDER BY [Tedarikçi]

-- Ürünleri (ProductID, ProductName, UnitPrice) Category name ve Supplier Company Name'leri ile birlikte listeleyim.

-- SELECT 
--     p.ProductID AS [Id],
--     p.ProductName AS [Ürün],
--     p.UnitPrice AS [Fiyat],
--     s.CompanyName AS [Tedarikçi],
--     c.CategoryName AS [Kategori]
-- FROM Products p
--         JOIN Suppliers s ON p.SupplierID=s.SupplierID 
--         JOIN Categories c ON p.SupplierID=c.CategoryID
--         ORDER BY [Kategori], [Tedarikçi]

-- Hangi sipariş hangi çalışan tarafından hangi müşteriye gerçekleştirilmiştir.
-- OrderID, OrderDate, Employee Name, Customer Name
-- SELECT
--     o.OrderID AS [Sipariş NO],
--     O.OrderDate AS [Sipariş Tarihi],
--     (e.FirstName+ ' '+ e.LastName) AS [Çalışan],
--     c.CompanyName AS [Müşteri]
-- FROM Orders o JOIN Employees e ON o.EmployeeID=e.EmployeeID
--     JOIN Customers c ON o.CustomerID=c.CustomerID


-- Kategoriye göre ürün stok adedini gösterelim

-- SELECT 
--     c.CategoryName AS [Kategori],
--     SUM(p.UnitsInStock)
-- FROM Products p JOIN Categories c ON p.CategoryID=c.CategoryID
-- GROUP BY c.CategoryName

-- Hangi ülkede kaç müşterimiz var.

-- SELECT 
--     c.Country AS [ÜLKE],
--     COUNT(*) AS [Müşteri Sayısı]
-- FROM Customers c 
-- GROUP BY c.Country
-- ORDER BY [Müşteri Sayısı] DESC

-- En çok hangi ülkede müşterimiz varsa müşteri sayısı ile birlikte gösterelim.
-- SELECT TOP(1) -- Buradaki sıralmada Top kullanarak kaçınsı sıraya kadar almak istediğimizi belirttik ona yarıray
--     c.Country AS [ÜLKE],
--     COUNT(*) AS [Müşteri Sayısı]
-- FROM Customers c 
-- GROUP BY c.Country
-- ORDER BY [Müşteri Sayısı] DESC


--Hangi kategoride kaç adet ürün var 

-- SELECT
--     c.CategoryName AS [Kategori],
--     COUNT(p.ProductID) AS [Adet]   
-- FROM Products p RIGHT JOIN Categories c ON c.CategoryID=p.CategoryID
-- GROUP BY c.CategoryName

-- Hangi ülkeye ne kadarlık kargo harcaması yapmışız.

-- SELECT
--     o.ShipCountry AS [Ülke],
--     SUM(o.Freight) AS [Kargo Harcaması]
-- FROM Orders o 
-- GROUP BY o.ShipCountry

-- Hangi ülkeye ne kadarlık Satış yapmışız.

-- SELECT
--     o.ShipCountry AS [Ülke],
--     SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS [Tutar]
-- FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID
-- GROUP BY o.ShipCountry
-- ORDER BY [Tutar] DESC

-- Tutar kolonunda görüntülenen sayının 18.810,05 şeklinde görünmesi için ne yapmalıyız.

-- SELECT
--     c.CategoryName AS [Kategori],
--     SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS [Tutar]
-- FROM OrderDetails od JOIN Products p ON od.ProductID=p.ProductID
--         JOIN Suppliers s ON p.SupplierID=s.SupplierID
--             JOIN Categories c ON p.CategoryID=c.CategoryID
-- WHERE s.Country='Germany'
-- GROUP BY c.CategoryName
-- HAVING SUM(od.UnitPrice*od.Quantity*(1-od.Discount))>20000
-- ORDER BY [Tutar] DESC

--Bölgelere göre satış tutarı

-- SELECT 
-- r.RegionDescription AS [Bölge],
-- FORMAT(SUM(od.UnitPrice*od.Quantity*(1-od.Discount)),'N2', 'tr-TR') AS [Tutar]
--     FROM OrderDetails od JOIN Orders o ON od.OrderID=o.OrderID
--         JOIN Employees e ON o.EmployeeID=e.EmployeeID
--         JOIN EmployeeTerritories et ON e.EmployeeID=et.EmployeeID
--         JOIN  Territories t ON et.TerritoryID=t.TerritoryID
--         JOIN Region r ON t.RegionID=r.RegionID
--             GROUP BY r.RegionDescription
--             ORDER BY r.RegionDescription


-- Hangi çalışanım hangi kategoriden ne kadarlık sipariş almıştır.....

-- SELECT 
-- e.FirstName AS [Çalışan],
-- c.CategoryName AS [Kategori],
-- SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS [TUTAR]
-- FROM OrderDetails od JOIN ORDERs o ON od.OrderID=o.OrderID
-- JOIN Employees e ON o.EmployeeID=e.EmployeeID
-- JOIN Products p ON od.ProductID=p.ProductID
-- JOIN Categories c ON p.CategoryID=c.CategoryID
-- GROUP BY c.CategoryName, e.FirstName 
-- ORDER BY e.FirstName, c.CategoryName

-- SELECT 
-- cu.CompanyName AS [Müşteri],
-- c.CategoryName AS [Kategori],
-- SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS [TUTAR]
-- FROM OrderDetails od JOIN ORDERs o ON od.OrderID=o.OrderID
-- JOIN Customers cu ON o.CustomerID=cu.CustomerID
-- JOIN Products p ON od.ProductID=p.ProductID
-- JOIN Categories c ON p.CategoryID=c.CategoryID
-- GROUP BY c.CategoryName, cu.CompanyName
-- ORDER BY cu.CompanyName, c.CategoryName

--1997 yılının mart ayında yapılan satışları listeleyelim
-- SELECT*
-- FROM Orders o 
-- WHERE o.OrderDate BETWEEN '1997-03-01' and '1997-3-31'

--Chai ürününe ait 1997 yılının mart ayında yapılan satışları listeleyim.

SELECT*
FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID
    JOIN Products p ON p.ProductID=od.ProductID
WHERE o.OrderDate BETWEEN '1997-03-01' and '1997-3-31' and p.ProductName='Chai'