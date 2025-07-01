USE Ttt_Day10;
GO

-- Tạo bảng Account
CREATE TABLE Account (
    AccountId UNIQUEIDENTIFIER PRIMARY KEY,
    Username VARCHAR(36) NOT NULL,
    Password VARCHAR(256) NOT NULL,
    FullName NVARCHAR(100),
    Picture VARCHAR(512),
    Email VARCHAR(100),
    Address NVARCHAR(512),
    Phone VARCHAR(20),
    IsAdmin BIT,
    Active BIT
);

-- Tạo bảng Category
CREATE TABLE Category (
    CategoryId INT PRIMARY KEY,
    CategoryName NVARCHAR(100)
);

-- Tạo bảng Publisher
CREATE TABLE Publisher (
    PublisherId INT PRIMARY KEY,
    PublisherName NVARCHAR(200),
    Phone VARCHAR(30),
    Address NVARCHAR(200)
);

-- Tạo bảng Book
CREATE TABLE Book (
    BookId INT PRIMARY KEY,
    Title NVARCHAR(200),
    Author NVARCHAR(100),
    Release DATE,
    Picture VARCHAR(512),
    Price FLOAT,
    Description NTEXT,
    PublisherId INT FOREIGN KEY REFERENCES Publisher(PublisherId),
    CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId)
);

-- Tạo bảng OrderBook
CREATE TABLE OrderBook (
    OrderId VARCHAR(16) PRIMARY KEY,
    OrderDate DATETIME,
    AccountId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Account(AccountId),
    ReceiveAddress NVARCHAR(512),
    ReceivePhone VARCHAR(64),
    OrderReceive DATETIME,
    Note NVARCHAR(512),
    Status VARCHAR(16)
);

-- Tạo bảng OrderDetail
CREATE TABLE OrderDetail (
    OrderDetailId INT PRIMARY KEY,
    OrderId VARCHAR(16) FOREIGN KEY REFERENCES OrderBook(OrderId),
    BookId INT FOREIGN KEY REFERENCES Book(BookId),
    Quantity INT,
    Price FLOAT,
    TotalMoney FLOAT
);

-- Dữ liệu mẫu
-- Thêm Account
DECLARE @acc1 UNIQUEIDENTIFIER = NEWID();
DECLARE @acc2 UNIQUEIDENTIFIER = NEWID();

INSERT INTO Account VALUES 
(@acc1, 'tungtran', '123456', N'Trần Thanh Tùng', NULL, 'tung@example.com', N'Hà Nội', '0123456789', 1, 1),
(@acc2, 'user02', 'abc123', N'Nguyễn Văn A', NULL, 'vana@example.com', N'Hồ Chí Minh', '0987654321', 0, 1);

-- Thêm Category
INSERT INTO Category VALUES
(1, N'Tiểu thuyết'),
(2, N'Kinh tế'),
(3, N'Truyện tranh');

-- Thêm Publisher
INSERT INTO Publisher VALUES
(1, N'NXB Trẻ', '0834567890', N'123 Nguyễn Văn Cừ, Q5, TP.HCM'),
(2, N'NXB Kim Đồng', '0845678901', N'62 Nguyễn Du, Hà Nội');

-- Thêm Book
INSERT INTO Book VALUES
(1, N'Đắc nhân tâm', N'Dale Carnegie', '2020-01-01', NULL, 120000, N'Sách phát triển bản thân', 1, 2),
(2, N'Tôi thấy hoa vàng trên cỏ xanh', N'Nguyễn Nhật Ánh', '2015-06-01', NULL, 85000, N'Truyện thiếu nhi nổi tiếng', 1, 1);

-- Thêm OrderBook
INSERT INTO OrderBook VALUES
('ORD001', GETDATE(), @acc1, N'Hà Nội', '0123456789', GETDATE(), N'Giao buổi sáng', 'Đang xử lý');

-- Thêm OrderDetail
INSERT INTO OrderDetail VALUES
(1, 'ORD001', 1, 1, 120000, 120000),
(2, 'ORD001', 2, 2, 85000, 170000);
