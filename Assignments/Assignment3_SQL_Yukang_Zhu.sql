-- Assignment3  Name: Yukang Zhu

USE Northwind
GO

-- 1. List all cities that have both Employees and Customers.
SELECT DISTINCT c.City
FROM Customers c, Employees e
WHERE c.City = e.City;


-- 2. List all cities that have Customers but no Employee.
--    a. Use sub-query
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (
	SELECT e.City
	FROM Employees e
);

--    b. Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL;


-- 3. List all products and their total order quantities throughout all orders.
SELECT p.ProductID, SUM(Quantity) [Total Quantity]
FROM Products p, [Order Details] d
WHERE d.ProductID = p.ProductID
GROUP BY p.ProductID
ORDER BY p.ProductID;


-- 4. List all Customer Cities and total products ordered by that city.
SELECT c.City, SUM(d.Quantity) [Total Products Quantity]
FROM Customers c, Orders o, [Order Details] d
WHERE c.City = o.ShipCity AND o.OrderID = d.OrderID
GROUP BY c.City
ORDER BY c.City;


-- 5. List all Customer Cities that have at least two customers.
--    a. Use union
SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) = 2
UNION
SELECT c.City
FROM Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) > 2;

--    b. Use sub-query and no union
SELECT n.City
FROM (
	SELECT c.City, COUNT(c.CustomerID) [Number of Customers]
	FROM Customers c
	GROUP BY c.City
) n
WHERE n.[Number of Customers] >= 2;


-- 6. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City
FROM Orders o, [Order Details] d, Customers c
WHERE o.OrderID = d.OrderID AND c.City = o.ShipCity
GROUP BY c.City
HAVING COUNT(DISTINCT d.ProductID) >= 2;


-- 7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
SELECT DISTINCT c.CustomerID, c.CompanyName Name
FROM Customers c, Orders o
WHERE o.CustomerID = c.CustomerID AND o.ShipCity != c.City;


-- 8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
WITH Popular AS (
	SELECT TOP 5 d.ProductID, SUM(d.Quantity) [Total Quantity], SUM(Quantity * (1-Discount) * UnitPrice) / SUM(d.Quantity) [Average Price]
	FROM [Order Details] d
	GROUP BY d.ProductID
)

SELECT Popular.*, ProductNo1City.ShipCity [City That Ordered Most]
FROM Popular, 
(
	SELECT ProductID, ShipCity
	FROM (	
		SELECT ProductCity.ProductID, ProductCity.ShipCity, RANK() OVER(PARTITION BY ProductCity.ProductID ORDER BY ProductCity.[Total Quantity], NEWID()) RNK
		FROM
		(
			SELECT d.ProductID, O.ShipCity, SUM(Quantity) [Total Quantity]
			FROM Orders o, [Order Details] d
			WHERE o.OrderID = d.OrderID
			GROUP BY d.ProductID, o.ShipCity
		) AS ProductCity
	) AS ProductCityRNK
	WHERE RNK = 1
) AS ProductNo1City
WHERE ProductNo1City.ProductID = Popular.ProductID;


-- 9. List all cities that have never ordered something but we have employees there.
--    a. Use sub-query
SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (
	SELECT o.ShipCity City
	FROM Orders o
);

--    b. Do not use sub-query
SELECT DISTINCT e.City
FROM Employees e LEFT JOIN Orders o ON e.City = o.ShipCity
WHERE o.ShipCity IS NULL;


-- 10. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
WITH CityMostOrder AS (
	SELECT TOP 1 e.City
	FROM Orders o, Employees e
	WHERE o.EmployeeID = e.EmployeeID
	GROUP BY e.City
    ORDER BY COUNT(*) DESC
), 

CityMostQuant AS(
	SELECT TOP 1 o.ShipCity
	FROM Orders o, [Order Details] d
	WHERE o.OrderID = d.OrderID
	GROUP BY o.ShipCity
	ORDER BY SUM(d.Quantity) DESC
) 

SELECT CityMostOrder.City
FROM CityMostOrder, CityMostQuant
WHERE CityMostOrder.City = CityMostQuant.ShipCity;


-- 11. How do you remove the duplicates record of a table?
--     Firstly, identify the duplicates, which can be typically done by rank the record
--     Then, Delete the unwanted duplicates (where rank > 1)
WITH CTE_Duplicates AS (
    SELECT *, 
           ROW_NUMBER() OVER (PARTITION BY theColumnThatShouldBeUnique ORDER BY NEWID()) AS RowNum
    FROM theTable
)
DELETE FROM CTE_Duplicates
WHERE RowNum > 1;