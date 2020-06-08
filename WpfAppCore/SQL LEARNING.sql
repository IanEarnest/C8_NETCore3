/*
SELECT - extracts data from a database
UPDATE - updates data in a database
DELETE - deletes data from a database
INSERT INTO - inserts new data into a database
CREATE DATABASE - creates a new database
ALTER DATABASE - modifies a database
CREATE TABLE - creates a new table
ALTER TABLE - modifies a table
DROP TABLE - deletes a table
CREATE INDEX - creates an index (search key)
DROP INDEX - deletes an index

Highlight lines to run code
*/
Select *
FROM Employees;

SELECT * FROM Employees
WHERE Name = 'Steve1'
ORDER BY ID

/*Create Employee*/
INSERT INTO Employees(ID, Name, Age)
VALUES ('200', 'Steve1', '20')

/*Update "ID 200" name to "Steve2"*/
UPDATE Employees
SET Name='Steve4'
WHERE ID = 201

/*Delete "Steve1"*/
DELETE FROM Employees
WHERE Name='Steve1'


SELECT *
FROM Employees
WHERE EXISTS (SELECT * FROM Employees WHERE Name = 'Steve2');

/*
SELECT SupplierName
FROM Suppliers
WHERE EXISTS (SELECT ProductName FROM Products WHERE Products.SupplierID = Suppliers.supplierID AND Price < 20);

SELECT ProductName
FROM Products
WHERE ProductID = ALL (SELECT ProductID FROM OrderDetails WHERE Quantity = 10);
*/