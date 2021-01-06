--CREATE DATABASE Task8

USE Task8;
GO

--CREATE TABLE Customers
--(
--Id INT PRIMARY KEY IDENTITY,
--FirstName VARCHAR(20),
--SecondName VARCHAR(20)
--)

--CREATE TABLE Products
--(
--Id INT PRIMARY KEY IDENTITY,
--ProductName VARCHAR(30),
--Manufacturer VARCHAR(30),
--ProductCount INT DEFAULT 0,
--Price MONEY
--)

--CREATE TABLE Orders
--(
--Id INT PRIMARY KEY IDENTITY,
--CreateAT DATE,
--Price INT,
--ProductCount INT DEFAULT 1,
--CustomerId INT REFERENCES Customers (Id),
--ProductId INT REFERENCES Products (Id)
--)

------------------------
------------------------

--INSERT INTO Products VALUES
--('IPhone XR', 'USA', 3, 17800),
--('IPhone SE', 'USA', 1, 13300),
--('IPhone 11', 'USA', 2, 22000),
--('IPhone 12', 'USA', 2, 28000),
--('Samsung M21', 'Korea', 6, 6000),
--('Samsung S10', 'Korea', 5, 21000),
--('Samsung M31', 'Korea', 4, 7300),
--('Samsung M21', 'Korea', 6, 6000),
--('Huawei P Smart', 'China', 5, 5500),
--('Huawei Nova 5T', 'China', 6, 10000),
--('Huawei P40 lite', 'China', 6, 7000),
--('Huawei Y6P', 'China', 7, 4200),
--('Huawei P40 Pro', 'China', 3, 24000),
--('Meizu 16', 'Taiwan', 3, 4600),
--('Meizu Note 9', 'Taiwan', 3, 4400),
--('Meizu M10', 'Taiwan', 3, 3300)


-------------------
-------------------
--удаляет все данные из таблицы
--DELETE Products

-------------------
-------------------

--ALTER TABLE Customers
--DROP COLUMN FirstName

--ALTER TABLE Customers
--DROP COLUMN SecondName

------------------
------------------

--ALTER TABLE Customers
--ADD FirstName VARCHAR(20)

--ALTER TABLE Customers
--ADD SecondName VARCHAR(20)

------------------
------------------

--ALTER TABLE Products
--DROP COLUMN ProductName

--ALTER TABLE Products
--DROP COLUMN Manufacturer

-------------------
-------------------

--ALTER TABLE Products
--ADD ProductName VARCHAR(20)

--ALTER TABLE Products
--ADD Manufacturer VARCHAR(20)

-------------------
-------------------

--INSERT INTO Products VALUES
--(3, 17800, 'IPhone XR', 'США'),
--(1, 13300, 'IPhone SE', 'США'),
--(2, 22000, 'IPhone 11', 'США'),
--(2, 28000, 'IPhone 12', 'США'),
--(6, 6000, 'Samsung M21', 'Корея'),
--(5, 21000, 'Samsung S10', 'Корея'),
--(4, 7300, 'Samsung M31', 'Корея'),
--(6, 6000, 'Samsung M21', 'Корея'),
--(5, 5500, 'Huawei P Smart', 'Китай'),
--(6, 10000, 'Huawei Nova 5T', 'Китай'),
--(6, 7000, 'Huawei P40 lite', 'Китай'),
--(7, 4200, 'Huawei Y6P', 'Китай'),
--(3, 24000, 'Huawei P40 Pro', 'Китай'),
--(3, 4600, 'Meizu 16', 'Тайвань'),
--(3, 4400, 'Meizu Note 9', 'Тайвань'),
--(3, 3300, 'Meizu M10', 'Тайвань')

-------------------
-------------------

--INSERT INTO Customers VALUES
--('Ivan', 'Ivanov'),
--('Petr', 'Petrov'),
--('Sidor', 'Sidorov'),
--('Nikolay', 'Nikolaev'),
--('Alexandr', 'Alexandrov'),
--('Denis', 'Denisov'),
--('Kiril', 'Kirilov'),
--('Vladimir', 'Vladimirov'),
--('Valerii', 'Valerenko'),
--('Taras', 'Tarasov')

------------------------
------------------------

--INSERT INTO Orders VALUES
--('2020-10-10', ((SELECT Price FROM Products WHERE Id=10) * 2), 2, 1, 10),
--('2020-10-11', ((SELECT Price FROM Products WHERE Id=11) * 4), 4, 3, 11),
--('2020-09-14', ((SELECT Price FROM Products WHERE Id=5) * 3), 3, 4, 5),
--('2020-09-18', (SELECT Price FROM Products WHERE Id=3), 1, 6, 3),
--('2020-09-25', (SELECT Price FROM Products WHERE Id=16), 1, 7, 16),
--('2020-10-11', (SELECT Price FROM Products WHERE Id=1), 1, 9, 1),
--('2020-10-23', (SELECT Price FROM Products WHERE Id=10), 1, 1, 10),
--('2020-10-11', (SELECT Price FROM Products WHERE Id=1), 1, 9, 1) 

------------------------
------------------------

--SELECT DISTINCT Manufacturer FROM Products

------------------------
------------------------

--SELECT * FROM Products
--ORDER BY Price

------------------------
------------------------

--SELECT TOP 30 PERCENT * FROM Products
--ORDER BY Price DESC

------------------------
------------------------

--SELECT * FROM Products
--ORDER BY Price
--OFFSET 6 ROWS
--FETCH NEXT 4 ROWS ONLY

------------------------
------------------------

--SELECT * FROM Products
--WHERE Manufacturer IN ('USA', 'Taiwan')

------------------------
------------------------

--SELECT * FROM Products
--WHERE Price BETWEEN 10000 AND 15000

------------------------
------------------------

--SELECT * FROM Products
--WHERE ProductName LIKE('IP%')

------------------------
------------------------

--SELECT Manufacturer, SUM(Price) AS PriceProducts FROM Products
--GROUP BY ROLLUP(Manufacturer) 

------------------------
------------------------

--SELECT Customers.Id, Customers.FirstName, Customers.SecondName, Orders.CreateAT, Orders.Price
--FROM Orders 
--JOIN Customers ON Orders.CustomerId=Customers.Id

------------------------
------------------------

--SELECT Customers.Id, Customers.FirstName, Customers.SecondName, Orders.CreateAT, Orders.Price
--FROM Orders 
--LEFT JOIN Customers 
--ON Orders.CustomerId=Customers.Id

------------------------
------------------------

--SELECT Customers.Id, Customers.FirstName, Customers.SecondName, Orders.CreateAT, Orders.Price
--FROM Orders 
--RIGHT JOIN Customers 
--ON Orders.CustomerId=Customers.Id

------------------------
------------------------

--SELECT Customers.Id, Customers.FirstName, Customers.SecondName, Orders.CreateAT, Orders.Price
--FROM Orders 
--RIGHT JOIN Customers 
--ON Orders.CustomerId=Customers.Id
--WHERE Orders.Price IS NULL
--ORDER BY Customers.SecondName

------------------------
------------------------

--SELECT Customers.Id, Customers.FirstName, Customers.SecondName, Orders.CreateAT, Orders.Price
--FROM Orders 
--CROSS JOIN Customers 

------------------------
------------------------

--SELECT Customers.SecondName, COUNT(Orders.Id) AS QtyOrders
--FROM Orders 
--JOIN Customers 
--ON Orders.CustomerId=Customers.Id
--GROUP BY Customers.SecondName
--ORDER BY QtyOrders DESC

------------------------
------------------------

--SELECT Customers.SecondName, COUNT(Orders.Id) AS QtyOrders
--FROM Orders 
--RIGHT JOIN Customers 
--ON Orders.CustomerId=Customers.Id
--GROUP BY Customers.SecondName
--ORDER BY QtyOrders DESC

------------------------
------------------------

--SELECT Customers.FirstName, Customers.SecondName
--FROM Customers
--UNION SELECT Products.ProductName, Products.Manufacturer FROM Products

------------------------
------------------------

--CREATE TABLE Employees
--(
--Id INT IDENTITY PRIMARY KEY,
--FirstName VARCHAR(20),
--SecondName VARCHAR(20)
--)

------------------------
------------------------

--INSERT INTO Employees VALUES
--('Ivan', 'Ivanov'),
--('Irina', 'Irinova'),
--('Svetlana', 'Svetlova'),
--('Nikolay', 'Nikolaev'),
--('Marina', 'Marinova'),
--('Tatiana', 'Tatianova'),
--('Vladimir', 'Vladimirov'),
--('Kondratii', 'Kondratenko'),
--('Taras', 'Tarasov')

-------------------------
-------------------------

--SELECT FirstName, SecondName
--FROM Customers
--UNION SELECT FirstName, SecondName
--FROM Employees

-------------------------
-------------------------

--SELECT FirstName, SecondName
--FROM Customers
--EXCEPT SELECT FirstName, SecondName
--FROM Employees

------------------------
------------------------

--SELECT FirstName, SecondName
--FROM Customers
--INTERSECT SELECT FirstName, SecondName
--FROM Employees

------------------------
------------------------

--SELECT 'I am ' + Customers.FirstName + ' ' + Customers.SecondName +
--'. I bought ' + Products.ProductName + ' for ' + 
--CAST(Products.Price AS varchar) AS MyStory
--FROM Customers
--JOIN Orders
--ON Orders.CustomerId=Customers.Id
--JOIN Products
--ON Orders.ProductId = Products.Id


------------------------
------------------------

--SELECT 'I am ' + Customers.FirstName + ' ' + Customers.SecondName +
--'. I bought ' + Products.ProductName + ' for ' + 
--CAST(Products.Price AS varchar) AS MyStory
--FROM Customers
--JOIN Orders
--ON Orders.CustomerId=Customers.Id
--JOIN Products
--ON Orders.ProductId = Products.Id
--WHERE Products.Price < 10000
--ORDER BY MyStory DESC

------------------------
------------------------

--SELECT TRY_CONVERT(VARCHAR, Price) AS ValidPrice
--FROM Orders

------------------------
------------------------

--SELECT TRY_CONVERT(INT, ProductName) AS InvalidProductName
--FROM Products

------------------------
------------------------

--SELECT ProductName, Manufacturer,
--CASE ProductCount
--WHEN 1 THEN 'Leave one good'
--WHEN 2 THEN 'Few goods'
--WHEN 3 THEN 'We have good'
--ELSE 'We have many goods'
--END AS ProductCount
--FROM Products

------------------------
------------------------

--SELECT ProductName, 
--IIF(Manufacturer != 'China', Manufacturer, 'Do not give this manufacturer')
--AS Manufacturer, Price
--FROM Products

------------------------
------------------------

--CREATE TABLE TableNewId
--(
--Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
--MyName VARCHAR(20)
--)
--GO

--INSERT INTO TableNewId (MyName) VALUES
--('First'), ('Second'), ('Third')

------------------------
------------------------

--DROP TABLE TableNewId

------------------------
------------------------

--SELECT Customers.FirstName, Customers.SecondName, 
--	ISNULL(CAST(Orders.Price AS VARCHAR), 'We do not have this customer') 
--	AS Price, 
--	ISNULL(CAST(Orders.CreateAT AS VARCHAR), 'We do not have this customer')
--	AS CreateAT
--FROM Customers LEFT JOIN Orders
--ON Orders.CustomerId=Customers.Id
 
------------------------
------------------------

--DECLARE @name VARCHAR(50);
--SET @name = (
--SELECT FirstName + ' ' + SecondName 
--FROM Customers
--WHERE Id=1
--);

--PRINT @name;


------------------------
------------------------

--DECLARE @price NVARCHAR;
--SET @price = (
--SELECT CAST(Orders.Price AS NVARCHAR) 
--FROM Orders
--WHERE Orders.Id=1
--)

--PRINT 'Price: ' + @price

------------------------
------------------------

--DECLARE @name VARCHAR(50)
--SET @name = (
--SELECT FirstName + ' ' + SecondName 
--FROM Customers
--WHERE Id=1
--)

--IF @name = 'Petr Petrov'
--BEGIN
--	PRINT 'True. I am Petr Petrov'
--END
--ELSE
--BEGIN
--	PRINT 'False. I am ' + @name
--END


------------------------
------------------------

--DECLARE @count INT
--SET @count = 1
--WHILE @count<=5
--BEGIN

--SELECT Customers.FirstName, Customers.SecondName, 
--Products.ProductName, Products.Price 
--FROM Customers JOIN Orders 
--ON Orders.CustomerId=Customers.Id
--JOIN Products 
--ON Orders.ProductId=Products.Id
--WHERE Customers.Id=@count
--SET @count=@count+1

--END

----------------------------
----------------------------

--SELECT ProductName, Price
--INTO #TempProducts
--FROM Products
 
--SELECT * FROM #TempProducts

----------------------------
----------------------------

--WITH OrdersInfo AS
--(
--    SELECT CreateAT, Price
--    FROM Orders
--)
 
--SELECT * FROM OrdersInfo -- здесь нормально
--SELECT * FROM OrdersInfo --второй раз вызывать нельзя, т.к. будет ошибка

----------------------------
----------------------------

--CREATE PROCEDURE ShowCustomers AS
--BEGIN
--SELECT * FROM Customers
--END

--------------------
--------------------

--EXECUTE ShowCustomers

--------------------
--------------------

--DROP PROCEDURE ShowCustomers

--------------------
--------------------

--CREATE PROCEDURE MyProc
--@name VARCHAR(20),
--@age INT = 33
--AS
--PRINT @name+' '+CAST(@age AS VARCHAR)
--GO

--MyProc 'Ivan'
--GO

--DROP PROCEDURE MyProc

--------------------
--------------------

--CREATE PROCEDURE GetRand AS
--RETURN RAND(10)
--GO
DECLARE @rez FLOAT;
EXECUTE @rez = GetRand

PRINT @rez




