CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" NVARCHAR(30)
);

INSERT INTO Products
VALUES
	(1, 'Iphone'),
	(2, 'Ipad'),
	(3, 'Table'),
	(4, 'Panama'),
	(5, 'Nokia 3310'),
	(6, 'MacBook');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" NVARCHAR(30)
);

INSERT INTO Categories
VALUES
	(1, 'AppleProduction'),
	(2, 'Clothes'),
	(3, 'Hats'),
	(4, 'Smartphones');

CREATE TABLE ProductsIdToCategoriesId (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductsIdToCategoriesId
VALUES
	(1, 1),
	(1, 4),
	(2, 1),
	(4, 3),
	(5, 4),
	(6, 1);


	SELECT Products.Name, Categories.Name
FROM Products 
LEFT JOIN ProductsIdToCategoriesId 
	ON Products.Id = ProductsIdToCategoriesId.ProductId
LEFT JOIN Categories 
	ON ProductsIdToCategoriesId.CategoryId = Categories.Id;