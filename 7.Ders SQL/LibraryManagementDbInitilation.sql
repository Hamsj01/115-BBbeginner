----------------------------------------------------------------------------
-------1)VERI TABANI YARATMA ADIMI --------------------------------------------
----------------------------------------------------------------------------
USE master
GO

DROP DATABASE IF EXISTS LibraryManagement
GO

CREATE DATABASE LibraryManagement
GO

USE LibraryManagement
GO
----------------------------------------------------------------------------
-------2)TABLOLARIN YARATILMASI --------------------------------------------
----------------------------------------------------------------------------
CREATE TABLE LibraryItems(
    Id INT PRIMARY KEY IDENTITY(1,1),  --IDENTITY:birer birer arttırır direk, Primary key:bir tane olur
    Title NVARCHAR(100) NOT NULL,
    PublishedDate DATE NOT NULL,
    ItemType NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Books(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Author NVARCHAR(100) NOT NULL,
    FOREIGN KEY(Id) REFERENCES LibraryItems(Id) --Bu tablodaki Id LibraryItems'taki Id den referans olsun buradaki Id yerine bakşka da yapabilirdik.bu tür işlemleri Foreıgn Key ile yaparız
)
GO

CREATE TABLE Magazines(
    Id INT PRIMARY KEY IDENTITY(1,1),
    IssueNumber NVARCHAR(50) NOT NULL,
    FOREIGN KEY(Id) REFERENCES LibraryItems(Id)
 )
 GO

 CREATE TABLE Dvds(
    Id INT PRIMARY KEY,
    Direktor NVARCHAR(100),
    FOREIGN KEY(Id) REFERENCES LibraryItems(Id)
 )
GO

CREATE TABLE MEMBERS(
    Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    MembershipStatus NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE ContractInfos(
    Id INT PRIMARY KEY IDENTITY(1,1),  --PRIMARY KEY DEFaULT OLARAK IDENTİTY(1,1) dir
    MemberId INT NOT NULL,
    ContactInfo NVARCHAR(255) NOT NULL,
    FOREIGN KEY(MemberId) REFERENCES Members(Id)
)
GO

CREATE TABLE Borrowings(
    Id INT PRIMARY KEY IDENTITY(1,1),
    ItemId INT NOT NULL,
    MemberId INT NOT NULL,
    BorrowedDate DATETIME NOT NULL,
    ReturnDate DATETIME,
    FOREIGN KEY(MemberId) REFERENCES Members(Id),
    FOREIGN KEY(ItemId) REFERENCES LibraryItems(Id),
    CHECK (ReturnDate IS NULL OR ReturnDate>BorrowedDate)
)
GO

CREATE TABLE LateFees(
    Id INT PRIMARY KEY IDENTITY(1,1),
    BorrowingId INT NOT NULL,
    FeeAmount DECIMAL(10,2),
    FOREIGN KEY(BorrowingId) REFERENCES Borrowings(Id)
)
GO

CREATE TABLE Ratings(
    Id INT PRIMARY KEY IDENTITY(1,1),
    ItemId INT NOT NULL,
    MemberId INT NOT NULL,
    RatingValue INT CHECK(RatingValue BETWEEN 1 AND 5) --Puan 1 ile 5 arsında
    FOREIGN KEY(ItemId) REFERENCES LibraryItems(Id),
    FOREIGN KEY(MemberId) REFERENCES Members(Id),
    CONSTRAINT  UQ_Item_Member UNIQUE(ItemId,MemberId) --CONSTRAINT KISIT KOYMAK İÇİN
)
GO

