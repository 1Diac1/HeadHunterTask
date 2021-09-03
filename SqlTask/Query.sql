CREATE TABLE Products
(
	Id INT PRIMARY KEY IDENTITY,
	ProductName NVARCHAR(50) NOT NULL
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(50) NOT NULL
)

INSERT INTO Products (ProductName)
VALUES
('iPhone 11'),
('iPhone 12'),
('iPhone 12 Pro Max')

INSERT INTO Categories (CategoryName)
VALUES
('Phone')

ALTER TABLE Products
	ADD CategoryId INT NOT NULL DEFAULT 1
	FOREIGN KEY(CategoryId) 
	REFERENCES Categories(Id)

ALTER TABLE Categories
	ADD ProductId INT NOT NULL DEFAULT 1
	FOREIGN KEY(ProductId) 
	REFERENCES Products(Id)

SELECT P.ProductName, C.CategoryName
FROM Products AS P
LEFT JOIN Categories AS C
	ON C.Id = P.CategoryId
LEFT JOIN Products
	ON P.Id = C.ProductId





