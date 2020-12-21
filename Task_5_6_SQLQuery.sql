--CREATE DATABASE MyDb;
--USE task5
--DROP DATABASE MyDb;

USE MyDb;

--DROP TABLE Payments;
--DROP TABLE Goods;
--DROP TABLE OrderClients;
--DROP TABLE Clients;

------------------------
------------------------

--CREATE TABLE Clients
--(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(20),
--Surname NVARCHAR(20),
--Age INT
--)

--INSERT INTO Clients (Name, Surname, Age) VALUES
--('Ivan', 'Ivanov', 25),
--('Petr', 'Petrov', 30),
--('Sidor', 'Sidorov', 35),
--('Aleksandr', 'Aleksandrov', 20),
--('Nilolay', 'Nikolaev', 15);

---------------------------
---------------------------

--CREATE TABLE OrderClients
--(
--Id INT PRIMARY KEY IDENTITY,
--DateOrder DATETIME,
--ClientId INT FOREIGN KEY REFERENCES Clients (Id)
--)

--INSERT INTO OrderClients (DateOrder, ClientId) VALUES
--('01/10/2020', 1), ('10/10/2020', 2), ('02/10/2020', 3), 
--('05/10/2020', 4), ('12/10/2020', 5);

------------------------
------------------------

--CREATE TABLE Goods
--(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(20),
--Description NVARCHAR(100),
--Price MONEY,
--OrderClientId INT FOREIGN KEY REFERENCES OrderClients (Id)
--)

--INSERT INTO Goods(Name, Description, Price, OrderClientId) VALUES
--('Samsung M21', 'Ёкран (6.4", Super AMOLED, 2340х1080) / 
--Samsung Exynos 9611 (4 x 2.3 √√ц + 4 x 1.7 √√ц)', 5500, 1),
--('Samsung A71', 'Ёкран (6.7", Super AMOLED Plus, 2400x1080) 
--/ Qualcomm Snapdragon 730 (2 x 2.2 √√ц + 6 x 1.8 √√ц)', 10000, 2),
--('Xiaomi Redmi 7A', 'Ёкран (5.45'', IPS, 1440x720) / 
--Qualcomm Snapdragon 439 (4 x 1.95 √√ц + 4 х 1.45 √√ц)', 2500, 3),
--('Apple iPhone SE', 'Ёкран (5.45'', IPS, 1440x720) / 
--Qualcomm Snapdragon 439 (4 x 1.95 √√ц + 4 х 1.45 √√ц)', 14000, 4),
--('Samsung A71', 'Ёкран (6.7", Super AMOLED Plus, 2400x1080) 
--/ Qualcomm Snapdragon 730 (2 x 2.2 √√ц + 6 x 1.8 √√ц)', 10000, 5);

-------------------------
-------------------------

--CREATE TABLE Payments
--(
--Id INT PRIMARY KEY IDENTITY,
--OrderPrice MONEY,
--DatePay DATETIME,
--OrderClientId INT UNIQUE FOREIGN KEY REFERENCES OrderClients (Id)
--)

--INSERT INTO Payments(OrderPrice, DatePay, OrderClientId) VALUES
--(5500, '2020-10-01', 1), (10000, '2020-10-20', 2), (2500, '2020-10-10', 3), 
--(14000, '2020-10-05', 4), (10000, '2020-10-07', 5);

--INSERT INTO Payments(OrderPrice, DatePay, OrderClientId) VALUES
--(5500, '2020-10-01', 1), (10000, '2020-10-20', 2), (2500, '2020-10-10', 3), 
--(14000, '2020-10-05', 4), (10000, '2020-10-07', 5);

---------------------------
---------------------------

--SELECT TOP 50 PERCENT Name, Surname FROM Clients

---------------------------
---------------------------

--SELECT Id, Name, Surname FROM Clients
--ORDER BY Surname
--OFFSET 2 ROWS
--FETCH NEXT 2 ROWS ONLY

-----------------------------
-----------------------------

--ALTER TABLE Clients
--ADD MiddleName NVARCHAR(30);

-----------------------------
-----------------------------

--ALTER TABLE Clients
--ADD MiddleName NVARCHAR(30);

-----------------------------
-----------------------------


--ALTER TABLE Clients
--DROP COLUMN MiddleName;

-----------------------------
-----------------------------

--SELECT Surname INTO NewTable FROM Clients

--DROP TABLE NewTable;

-----------------------------
-----------------------------

--SELECT DateOrder 
--FROM OrderClients
--WHERE DateOrder < '2020/10/6'

-----------------------------
-----------------------------

--SELECT DateOrder 
--FROM OrderClients
--WHERE DateOrder < '2020/10/6'

-----------------------------
-----------------------------

--SELECT DateOrder,
--(SELECT Surname FROM Clients WHERE dbo.Clients.Id=dbo.OrderClients.ClientId) AS Client,
--(SELECT Name FROM Goods WHERE dbo.OrderClients.Id=dbo.Goods.OrderClientId) AS NameGood,
--(SELECT OrderPrice FROM Payments WHERE dbo.OrderClients.Id=dbo.Payments.OrderClientId) AS PriceCheck
--FROM OrderClients
--WHERE DateOrder < '2020/10/6'

-----------------------------
-----------------------------

SELECT * FROM Goods
WHERE Price BETWEEN 5000 AND 10000

