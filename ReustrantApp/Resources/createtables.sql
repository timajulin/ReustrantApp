-- ������� �������������
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Role NVARCHAR(50),
    Login NVARCHAR(50),
    Password NVARCHAR(100),
);

-- ������� ���������
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(100)
);

-- ������� ����
CREATE TABLE Menu (
    MenuID INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Description NVARCHAR(255),
    Price DECIMAL(10, 2),
    Status NVARCHAR(50),
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID)
);

-- ������� �������
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY,
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    TotalPrice DECIMAL(10, 2),
    OrderStatus NVARCHAR(50),
    OrderDate DATETIME DEFAULT GETDATE()
);

-- ������� ��� ���������� �������
CREATE TABLE OrderItems (
    OrderItemID INT PRIMARY KEY IDENTITY,
    OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
    MenuID INT FOREIGN KEY REFERENCES Menu(MenuID),
    Quantity INT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL
);

-- ������� �������
CREATE TABLE Reviews (
    ReviewID INT PRIMARY KEY IDENTITY,
    OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Rating INT,
    Comment NVARCHAR(255)
);