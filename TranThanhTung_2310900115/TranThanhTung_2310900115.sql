CREATE DATABASE TranThanhTung_2310900115;
GO

USE TranThanhTung_2310900115;

CREATE TABLE TttEmployee (
    TttEmpId INT PRIMARY KEY,
    TttEmpName NVARCHAR(100),
    TttEmpLevel NVARCHAR(50),
    TttEmpStartDate DATE,
    TttEmpStatus BIT
);

INSERT INTO TttEmployee VALUES
(1, N'Trần Thanh Tùng', 'Junior', '2005-05-30', 2005),
(2, N'Nguyễn Văn B', 'Senior', '2020-01-15', 0),
(3, N'Lê Thị C', 'Intern', '2024-06-01', 1);
