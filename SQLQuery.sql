CREATE TABLE Products (
		Id INT PRIMARY KEY,
		"Name" nvarchar(128)
	);
	
	INSERT INTO Products
	VALUES
		(1, N'����'),
		(2, N'��������'),
		(3, N'����'),
		(4, N'�������');
	
	CREATE TABLE Categories (
		Id INT PRIMARY KEY,
		"Name" nvarchar(128)
	);
	
	INSERT INTO Categories
	VALUES
		(1, N'���'),
		(2, N'������'),
		(3, N'�������');
	
	CREATE TABLE ProductsCategories (
		ProductId INT FOREIGN KEY REFERENCES Products(Id),
		CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
		PRIMARY KEY (ProductId, CategoryId)
	);
	
	INSERT INTO ProductsCategories
	VALUES
		(1, 1),
		(3, 2),
		(4, 3);
	
	SELECT Prod."Name", Cat."Name"
	FROM Products Prod
	LEFT JOIN ProductsCategories ProdCat
		ON Prod.Id = ProdCat.ProductId
	LEFT JOIN Categories Cat
		ON ProdCat.CategoryId = Cat.Id;