-- Create Database
CREATE DATABASE InventoryManagementSystem;

USE InventoryManagementSystem;

-- Create Tables
-- Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    Prodectsname NVARCHAR(100) NOT NULL,
    SKU NVARCHAR(50) UNIQUE NOT NULL,
    Category NVARCHAR(50),
    Quantity INT DEFAULT 0,
    UnitPrice DECIMAL(10, 2),
    Barcode NVARCHAR(50),
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);

-- Suppliers Table
CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName NVARCHAR(100) NOT NULL,
    ContactName NVARCHAR(100),
    Phone NVARCHAR(15),
    Email NVARCHAR(100),
    SupplierAddress NVARCHAR(255)
);

-- PurchaseOrders Table
CREATE TABLE PurchaseOrders (
    PurchaseOrderID INT PRIMARY KEY IDENTITY(1,1),
    SupplierID INT FOREIGN KEY REFERENCES Suppliers(SupplierID),
    OrderDate DATETIME DEFAULT GETDATE(),
    OrderStatus NVARCHAR(20) CHECK (OrderStatus IN ('Pending', 'Completed', 'Cancelled')),
    TotalAmount DECIMAL(10, 2)
);

-- PurchaseOrderDetails Table
CREATE TABLE PurchaseOrderDetails (
    PODetailID INT PRIMARY KEY IDENTITY(1,1),
    PurchaseOrderID INT FOREIGN KEY REFERENCES PurchaseOrders(PurchaseOrderID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL
);

-- SalesOrders Table
CREATE TABLE SalesOrders (
    SalesOrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100),
    OrderDate DATETIME DEFAULT GETDATE(),
    OrderStatus NVARCHAR(20) CHECK (OrderStatus IN ('Pending', 'Shipped', 'Cancelled')),
    TotalAmount DECIMAL(10, 2)
);

-- SalesOrderDetails Table
CREATE TABLE SalesOrderDetails (
    SODetailID INT PRIMARY KEY IDENTITY(1,1),
    SalesOrderID INT FOREIGN KEY REFERENCES SalesOrders(SalesOrderID),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL
);

-- StockMovements Table
CREATE TABLE StockMovements (
    MovementID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
    MovementType NVARCHAR(20) CHECK (MovementType IN ('IN', 'OUT', 'ADJUSTMENT')),
    Quantity INT NOT NULL,
    MovementDate DATETIME DEFAULT GETDATE(),
    Descriptions NVARCHAR(255)
);

-- Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Roles NVARCHAR(20) CHECK (Roles IN ('Admin', 'Manager', 'Staff')),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- AuditLogs Table
CREATE TABLE AuditLogs (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    Actions NVARCHAR(100) NOT NULL,
    TableAffected NVARCHAR(50),
    ActionTime DATETIME DEFAULT GETDATE(),
    Descriptions NVARCHAR(255)
);

-- Categories Table
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) UNIQUE NOT NULL,
    Descriptions NVARCHAR(255)
);

-- Insert Dummy Data
-- Insert into Categories
INSERT INTO Categories (CategoryName, Descriptions) VALUES
('Electronics', 'Devices and gadgets'),
('Clothing', 'Apparel and accessories'),
('Furniture', 'Home and office furniture');

-- Insert into Products
INSERT INTO Products (Prodectsname, SKU, Category, Quantity, UnitPrice, Barcode) VALUES
('Smartphone', 'ELEC12345', 'Electronics', 50, 699.99, '123456789012'),
('Laptop', 'ELEC54321', 'Electronics', 30, 999.99, '987654321098'),
('T-Shirt', 'CLOT12345', 'Clothing', 100, 19.99, '111213141516'),
('Office Chair', 'FURN12345', 'Furniture', 20, 150.00, '222324252627');

-- Insert into Suppliers
INSERT INTO Suppliers (SupplierName, ContactName, Phone, Email, SupplierAddress) VALUES
('Tech Distributors Inc.', 'John Doe', '123-456-7890', 'john@techdistributors.com', '123 Tech Street'),
('Clothing Supplies Ltd.', 'Jane Smith', '987-654-3210', 'jane@clothingsupplies.com', '456 Fashion Ave');

-- Insert into PurchaseOrders
INSERT INTO PurchaseOrders (SupplierID, OrderDate, OrderStatus, TotalAmount) VALUES
(1, GETDATE(), 'Pending', 5000.00),
(2, GETDATE(), 'Completed', 2000.00);

-- Insert into PurchaseOrderDetails
INSERT INTO PurchaseOrderDetails (PurchaseOrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 10, 699.99),
(1, 2, 5, 999.99),
(2, 3, 50, 19.99);

-- Insert into SalesOrders
INSERT INTO SalesOrders (CustomerName, OrderDate, OrderStatus, TotalAmount) VALUES
('Alice Johnson', GETDATE(), 'Shipped', 1500.00),
('Bob Williams', GETDATE(), 'Pending', 300.00);

-- Insert into SalesOrderDetails
INSERT INTO SalesOrderDetails (SalesOrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 2, 699.99),
(1, 2, 1, 999.99),
(2, 3, 10, 19.99);

-- Insert into StockMovements
INSERT INTO StockMovements (ProductID, MovementType, Quantity, Descriptions) VALUES
(1, 'IN', 10, 'Stock replenishment from supplier'),
(2, 'OUT', 5, 'Sold to customer'),
(3, 'ADJUSTMENT', -2, 'Damaged stock');

-- Insert into Users
INSERT INTO Users (Username, PasswordHash, Roles) VALUES
('admin', 'hashedpassword1', 'Admin'),
('manager1', 'hashedpassword2', 'Manager'),
('staff1', 'hashedpassword3', 'Staff');

-- Insert into AuditLogs
INSERT INTO AuditLogs (UserID, Actions, TableAffected, Descriptions) VALUES
(1, 'Insert', 'Products', 'Added new product Smartphone'),
(2, 'Update', 'StockMovements', 'Adjusted stock levels for T-Shirt');

-- Fetch data from all tables
SELECT * FROM Products;
SELECT * FROM Suppliers;
SELECT * FROM PurchaseOrders;
SELECT * FROM PurchaseOrderDetails;
SELECT * FROM SalesOrders;
SELECT * FROM SalesOrderDetails;
SELECT * FROM StockMovements;
SELECT * FROM Users;
SELECT * FROM AuditLogs;
SELECT * FROM Categories;


