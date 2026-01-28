/*
	1.Hər bir müştərinin ümumi sifariş sayini tapın
	2.Yalnız ümumi sifarisleri  5000-dən çox olan müştəriləri göstər
	3.Hər sifariş üçün məhsulların ümumi qiymətini (Quantity × UnitPrice) hesablayın və sifarişin TotalAmount ilə müqayisə edin
	4.Hər məhsul kateqoriyası üzrə satılan toplam məhsul sayı və toplam satış məbləğini tapın
	5.Hər müştərinin ən çox sifariş etdiyi məhsul kateqoriyasını tapın
	6.Bu tapşırıqların nəticələrini istifadə edərək bir VIEW yaradın, CustomerOrderSummary, VIEW aşağıdakı məlumatları saxlamalıdır
*/

/* CREATE NEW DATABASE */
CREATE DATABASE E_Commerce_DB;

/* SELECT NEW DATABASE */
USE E_Commerce_DB;

/* CREATE RELATED TABLES FOR TASK */
CREATE TABLE Customers(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL CHECK(LEN(Name)>2),
);
CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(12) NOT NULL
);
CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(50) NOT NULL CHECK(LEN(Title)>2),
	Price INT NOT NULL CHECK(Price>=0 AND Price<=1000000),
	CategoryId INT REFERENCES Categories(Id)
);
CREATE TABLE Orders(
	Id INT PRIMARY KEY IDENTITY,
	Quantity INT NOT NULL DEFAULT(1) CHECK(Quantity<=999),
	CustomerId INT REFERENCES Customers(Id),
	ProductId INT REFERENCES Products(Id)
);

/* QUERY FOR SHOWING RELATED TABLES */
SELECT * FROM Customers;
SELECT * FROM Orders;
SELECT * FROM Products;
SELECT * FROM Categories;

/* ADD SOME DATA TO CUSTOMERS TABLE */
INSERT INTO Customers VALUES
('Lorem Ipsum'),
('Wade Wilson'),
('Trevor Philips'),
('Ali Kisi')

/* ADD SOME DATA TO ORDERS TABLE */
INSERT INTO Orders(Quantity, CustomerId, ProductId) VALUES
(3, 1, 2),
(2, 2, 1),
(1, 3, 3),
(10, 4, 3),
(9, 1, 3),
(50, 2, 1),
(15, 3, 2),
(13, 4, 2)

/* ADD SOME DATA TO PRODUCTS TABLE */
INSERT INTO Products(Title, Price, CategoryId) VALUES
('MSI Gaming Laptop', 2400, 1),
('Xiaomi Redmi Note 14', 400, 2),
('HP Victus Gaming Laptop', 2000, 1)

/* ADD SOME DATA TO CATEGORIES TABLE */
INSERT INTO Categories VALUES
('Laptop'),
('Smartphone')

/* OBJECTIVE 1 - SHOW ORDER COUNT FOR EACH CUSTOMER */
SELECT c.[Name] AS 'Client',p.Title AS 'Product' 
FROM Orders AS o 
JOIN Customers AS c ON o.CustomerId=c.Id 
JOIN Products AS p ON o.ProductId=p.Id;
--or just →
--SELECT c.[Name] AS 'Client',o.Id AS 'Product' FROM Orders AS o JOIN Customers AS c ON o.CustomerId=c.Id;

/* OBJECTIVE 2 - SHOW ONLY CUSTOMERS WHO HAS 5000+ ORDER COUNT */
SELECT Customers.[Name], Orders.Quantity AS Total 
FROM Orders 
INNER JOIN Customers ON Orders.CustomerId=Customers.Id;
--or
SELECT Customers.[Name], SUM(Orders.Quantity) AS Total 
FROM Orders 
INNER JOIN Customers ON Orders.CustomerId=Customers.Id 
GROUP BY Customers.[Name];

/* OBJECTIVE 3 - FOR EACH ORDER CALCULATE QUANTITY AND UNITPRICE, THEN COMPARE WITH TOTAL AMOUNT */
SELECT Customers.[Name] AS Client, Products.Title AS Item, Products.Price AS Cost 
FROM Orders 
INNER JOIN Customers ON Orders.CustomerId=Customers.Id 
RIGHT JOIN Products ON Orders.ProductId=Products.Id;
--or
SELECT Customers.[Name] AS Client, SUM(Products.Price) AS Cost 
FROM Orders 
INNER JOIN Customers ON Orders.CustomerId=Customers.Id 
INNER JOIN Products ON Orders.ProductId=Products.Id 
GROUP BY Customers.[Name];

/* OBJECTIVE 4 - SHOW TOTAL INCOME AND SOLD COUNT FOR EACH PRODUCT CATEGORY */
--we have joined wrong tables, need to add or replace orders table with products!!!!!!!!!!!
SELECT c.[Name] AS Category, SUM(p.Price) AS Total_Sold 
FROM Products p 
INNER JOIN Categories c ON p.CategoryId=c.id 
GROUP BY c.[Name];


/* OBJECTIVE 5 - FOR EACH CUSTOMER, SHOW PRODUCT CATEGORY WHICH THEY MOST ORDER */
--...

/* OBJECTIVE 6 - CREATE NEW VIEW FOR CUSTOMER ORDER SUMMARY */
--...
