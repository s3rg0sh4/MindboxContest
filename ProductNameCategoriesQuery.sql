SELECT ProductName AS Product, CategoryName AS Category
FROM MindboxTest.dbo.Product_Category AS pc
RIGHT JOIN MindboxTest.dbo.Product AS prod
ON pc.ProductID = prod.ProductID
LEFT JOIN MindboxTest.dbo.Category AS cat
ON pc.CategoryID = cat.CategoryID;