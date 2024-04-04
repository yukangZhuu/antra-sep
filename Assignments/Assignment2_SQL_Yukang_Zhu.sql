-- Assignment2  Name: Yukang Zhu
USE AdventureWorks2019
GO


-- 1. How many products can you find in the Production.Product table?
SELECT COUNT(p.ProductID) [Number of Product]
FROM Production.Product p;


-- 2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
--    The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
SELECT COUNT(p.ProductSubcategoryID) [Number of Product That Has A Subcategory]
FROM Production.Product p;


-- 3. How many Products reside in each SubCategory? Write a query to display the results with the following titles.
--   ProductSubcategoryID CountedProducts
--   -------------------- ---------------
SELECT p.ProductSubcategoryID,  COUNT(p.ProductSubcategoryID) CountedProducts
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NOT NULL
GROUP BY p.ProductSubcategoryID;


-- 4. How many products that do not have a product subcategory.
SELECT COUNT(p.ProductID) [Number of Product Without A Subcategory]
FROM Production.Product p
WHERE p.ProductSubcategoryID IS NULL;


-- 5. Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(i.Quantity) [Total Products Quantity]
FROM Production.ProductInventory i;


-- 6. Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100.
--    ProductID    TheSum
--    ---------    ------
SELECT i.ProductID, SUM(i.Quantity) TheSum
FROM Production.ProductInventory i
WHERE i.LocationID = 40
GROUP BY i.ProductID
HAVING SUM(i.Quantity) < 100;


-- 7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
--    Shelf      ProductID    TheSum
--    ------     ---------    -------
SELECT i.Shelf, i.ProductID, SUM(i.Quantity) TheSum
FROM Production.ProductInventory i
WHERE i.LocationID = 40
GROUP BY i.Shelf, i.ProductID
HAVING SUM(i.Quantity) < 100;


-- 8. Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
SELECT i.ProductID, AVG(i.Quantity) TheAvg
FROM Production.ProductInventory i
WHERE i.LocationID = 10
GROUP BY i.ProductID;


-- 9. Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
--  ProductID   Shelf   TheAvg
--  ---------   -----   -----
SELECT i.ProductID, i.Shelf, AVG(i.Quantity) TheAvg
FROM Production.ProductInventory i
GROUP BY i.ProductID, i.Shelf;


-- 10. Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
--  ProductID   Shelf   TheAvg
--  ---------   ------  ------
SELECT i.ProductID, i.Shelf, AVG(i.Quantity) TheAvg
FROM Production.ProductInventory i
WHERE i.Shelf <> 'N/A'
GROUP BY i.ProductID, i.Shelf;


-- 11. List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. 
-- Exclude the rows where Color or Class are null.
-- Color  Class  TheCount  AvgPrice
-- ----   -----  --------  -------  
SELECT p.Color, p.Class, COUNT(p.ProductID) TheCount, AVG(p.ListPrice) AvgPrice
FROM Production.Product p
WHERE p.Color IS NOT NULL AND p.Class IS NOT NULL
GROUP BY p.Color, p.Class;


-- 12. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. 
--     Join them and produce a result set similar to the following.
--     Country   Province
--      ------   --------
SELECT c.Name Country, s.Name Province
FROM person.CountryRegion c JOIN person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
ORDER BY Country;


-- 13. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada. 
-- Join them and produce a result set similar to the following.
-- Country    Province
-- -------    --------
SELECT c.Name Country, s.Name Province
FROM person.CountryRegion c JOIN person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany', 'Canada')
ORDER BY Country;



USE Northwind
GO

-- 14.  List all Products that has been sold at least once in last 25 years.
SELECT p.ProductID, p.ProductName
FROM Products p
WHERE p.ProductID IN (
	SELECT d.ProductID
	FROM Orders o, [Order Details] d
	WHERE o.OrderID = d.OrderID AND DATEDIFF(year, o.OrderDate, GETDATE()) <= 25
)
ORDER BY p.ProductID;


-- 15. List top 5 locations (Zip Code) where the products sold most.
SELECT TOP 5 o.ShipPostalCode, SUM(d.Quantity) [Total Sold]
FROM Orders o, [Order Details] d
WHERE o.OrderID = d.OrderID AND o.ShipPostalCode IS NOT NULL
GROUP BY o.ShipPostalCode
ORDER BY [Total Sold] DESC;


-- 16. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 o.ShipPostalCode, SUM(d.Quantity) [Total Sold]
FROM Orders o, [Order Details] d
WHERE o.OrderID = d.OrderID AND o.ShipPostalCode IS NOT NULL AND  DATEDIFF(year, o.OrderDate, GETDATE()) <= 25
GROUP BY o.ShipPostalCode
ORDER BY [Total Sold] DESC;


-- 17. List all city names and number of customers in that city.  
SELECT o.ShipCity, COUNT(DISTINCT CustomerID) [Number of Customers]
FROM Orders o
GROUP BY ShipCity;


-- 18. List city names which have more than 2 customers, and number of customers in that city
SELECT o.ShipCity, COUNT(DISTINCT CustomerID) [Number of Customers]
FROM Orders o
GROUP BY ShipCity 
HAVING COUNT(DISTINCT CustomerID) > 2;


-- 19. List the names of customers who placed orders after 1/1/98 with order date.
SELECT DISTINCT c.CompanyName
FROM Orders o, Customers c
WHERE o.CustomerID = c.CustomerID AND DATEDIFF(day, o.OrderDate, '1998-01-01 00:00:00:000') >= 0;


-- 20. List the names of all customers with most recent order dates
SELECT c.CompanyName, MAX(o.OrderDate) [Most Recent Order Date]
FROM Orders o, Customers c
WHERE o.CustomerID = c.CustomerID
GROUP BY c.CompanyName;


-- 21. Display the names of all customers along with the count of products they bought
SELECT c.CompanyName, SUM(d.Quantity) [Number of Products Ordered]
FROM Orders o, Customers c, [Order Details] d
WHERE o.CustomerID = c.CustomerID AND d.OrderID = o.OrderID
GROUP BY c.CompanyName;


-- 22. Display the customer ids who bought more than 100 Products with count of products.
SELECT o.CustomerID, SUM(d.Quantity) [Number of Products Ordered]
FROM Orders o, [Order Details] d
WHERE d.OrderID = o.OrderID
GROUP BY o.CustomerID
HAVING SUM(d.Quantity) > 100;


-- 23.  List all of the possible ways that suppliers can ship their products. Display the results as below
-- Supplier Company Name  Shipping Company Name
-- ---------------------  ---------------------
SELECT su.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name]
FROM Suppliers su, Shippers sh
ORDER BY su.CompanyName;


-- 24.  Display the products order each day. Show Order date and Product Name.
SELECT DISTINCT o.OrderDate, p.ProductName
FROM Orders o, [Order Details] d, Products p
WHERE o.OrderID = d.OrderID AND d.ProductID = p.ProductID;


-- 25. Displays pairs of employees who have the same job title.
SELECT [Employee 1], [Employee 2]
FROM (
	SELECT e1.FirstName + ' ' + e1.LastName AS [Employee 1], e2.FirstName + ' ' + e2.LastName AS [Employee 2]
	FROM Employees e1, Employees e2
	WHERE e1.Title = e2.Title AND e1.EmployeeID != e2.EmployeeID
) AS Pairs;


-- 26. Display all the Managers who have more than 2 employees reporting to them.
SELECT m.Manager Name
FROM (
	SELECT e2.FirstName + ' ' + e2.LastName AS [Manager], e1.FirstName + ' ' + e1.LastName AS [Subordinate]
	FROM Employees e1, Employees e2
	WHERE e1.ReportsTo = e2.EmployeeID
) AS m
GROUP BY m.Manager
HAVING COUNT(m.Subordinate) > 2;


-- 27. Display the customers and suppliers by city. The results should have the following columns
--   City  Name  Contact Name  Type(Customer or Supplier)
--   ----  ----  ------------  ----
SELECT c.City, c.CompanyName Name, c.ContactName, 'Customer' Type
FROM Customers c
UNION
SELECT s.City, s.CompanyName Name, s.ContactName, 'Supplier' Type
FROM Suppliers s