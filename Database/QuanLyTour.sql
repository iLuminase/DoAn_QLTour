USE MASTER
GO
CREATE DATABASE QuanLyTour
GO
USE QuanLyTour
GO

-- Bảng Tour
CREATE TABLE Tour (
    MaTour INT PRIMARY KEY IDENTITY(1,1),
    TenTour NVARCHAR(255) NOT NULL,
    LichTrinh NVARCHAR(MAX),
    GiaTien DECIMAL(18, 2) CHECK (GiaTien >= 0),
    MoTa NVARCHAR(MAX),
    TinhTrang INT, -- 0: Không hoạt động, 1: Đang hoạt động
    HuongDanVienID INT -- Khóa ngoại đến NhanVien (Hướng dẫn viên)
);
GO

-- Bảng KhachHang
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(255) NOT NULL,
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(255),
    DiaChi NVARCHAR(255),
    CMND NVARCHAR(12)
);
GO

-- Bảng NhanVien
CREATE TABLE NhanVien (
    NhanVienID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính tự động tăng
    HoTen NVARCHAR(100) NOT NULL,             
    ChucVu NVARCHAR(50) NOT NULL,             
    SoDienThoai NVARCHAR(15) NOT NULL,        
    Email NVARCHAR(100) NOT NULL,             
    DiaChi NVARCHAR(200) NOT NULL,            
    NgaySinh DATE NOT NULL,                   
    CMND NVARCHAR(12) NOT NULL,               
    TinhTrang INT -- 0: Nghỉ việc, 1: Đang làm việc
);
GO

-- Bảng DatTour
CREATE TABLE DatTour (
    MaDatTour INT PRIMARY KEY IDENTITY(1,1),
	MaTour Int,
    NgayDat DATE NOT NULL
);
GO
-- Bảng chi tiết
CREATE TABLE ChiTietDatTour (
    MaChiTietDatTour INT PRIMARY KEY IDENTITY(1,1),
    MaKhachHang INT NOT NULL,            -- Khóa ngoại đến bảng KhachHang
    MaDatTour INT NOT NULL,       -- Khóa ngoại đến bảng DatTour
    SoLuongNguoiDat INT CHECK (SoLuongNguoiDat > 0),  -- Số lượng người phải lớn hơn 0
    SoTienCoc DECIMAL(18, 2) CHECK (SoTienCoc >= 0),  -- Số tiền cọc phải lớn hơn hoặc bằng 0
    TinhTrang NVARCHAR(50),       -- Trạng thái đặt tour

);
GO

-- Bảng ThanhToan
CREATE TABLE ThanhToan (
    ThanhToanID INT PRIMARY KEY IDENTITY(1,1),
    MaDatTour INT NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL,
    NgayThanhToan DATE NOT NULL,
    PhuongThucThanhToan NVARCHAR(50) NOT NULL
);
GO

-- Bảng DichVu
CREATE TABLE DichVu (
    DichVuID INT PRIMARY KEY IDENTITY(1,1),
    TenDichVu NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255),
    GiaTien DECIMAL(18,2) NOT NULL,
    TinhTrang INT -- 0: Không hoạt động, 1: Đang hoạt động
);
GO

-- Bảng DatDichVu
CREATE TABLE DatDichVu (
    MaDatDichVu INT PRIMARY KEY IDENTITY(1,1),
    MaDatTour INT NOT NULL,  -- Khóa ngoại tới DatTour
    MaDichVu INT NOT NULL,   -- Khóa ngoại tới DichVu
    SoLuong INT CHECK (SoLuong > 0)  -- Số lượng phải lớn hơn 0
);
GO

-- Bảng KhuyenMai
CREATE TABLE KhuyenMai (
    KhuyenMaiID INT PRIMARY KEY IDENTITY(1,1),
    TenKhuyenMai NVARCHAR(100) NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    GiaTriKhuyenMai DECIMAL(5,2) NOT NULL,
    SoLuong INT -- Số lượng khuyến mãi có thể sử dụng
);
GO

-- Bảng KhachHangKhuyenMai
CREATE TABLE KhachHangKhuyenMai (
    MaKhuyenMai INT NOT NULL,   -- Khóa ngoại tới KhuyenMai
    MaDatTour INT NOT NULL,     -- Khóa ngoại tới DatTour
    NgaySuDung DATE,
    PRIMARY KEY (MaKhuyenMai, MaDatTour)  -- Khóa chính là kết hợp của MaKhuyenMai và MaDatTour
);
GO

-- Bảng Feedback
CREATE TABLE Feedback (
    MaFeedback INT PRIMARY KEY IDENTITY(1,1),
    MaKhachHang INT NOT NULL,  -- Khóa ngoại tới KhachHang
    MaTour INT NOT NULL,       -- Khóa ngoại tới Tour
    NoiDung NVARCHAR(MAX),
    NgayPhanHoi DATE
);
GO




-- Thêm khóa ngoại cho bảng Tour
ALTER TABLE Tour
ADD CONSTRAINT FK_Tour_HuongDanVien
FOREIGN KEY (HuongDanVienID) REFERENCES NhanVien(NhanVienID);
GO

-- Thêm khóa ngoại cho bảng DatTour
ALTER TABLE DatTour
ADD CONSTRAINT FK_DatTour_Tour
FOREIGN KEY (MaTour) REFERENCES Tour(MaTour);
GO


-- Thêm khóa ngoại cho bảng ChiTietDatTour
ALTER TABLE ChiTietDatTour
ADD CONSTRAINT FK_ChiTietDatTour_KhachHang
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang);
GO

ALTER TABLE ChiTietDatTour
ADD CONSTRAINT FK_ChiTietDatTour_DatTour
FOREIGN KEY (MaDatTour) REFERENCES DatTour(MaDatTour);
GO

-- Thêm khóa ngoại cho bảng ThanhToan
ALTER TABLE ThanhToan
ADD CONSTRAINT FK_ThanhToan_DatTour
FOREIGN KEY (MaDatTour) REFERENCES DatTour(MaDatTour);
GO

-- Thêm khóa ngoại cho bảng DatDichVu
ALTER TABLE DatDichVu
ADD CONSTRAINT FK_DatDichVu_DatTour
FOREIGN KEY (MaDatTour) REFERENCES DatTour(MaDatTour);
GO
ALTER TABLE DatDichVu
ADD CONSTRAINT FK_DatDichVu_DichVu
FOREIGN KEY (MaDichVu) REFERENCES DichVu(DichVuID);
GO

-- Thêm khóa ngoại cho bảng KhachHangKhuyenMai
ALTER TABLE KhachHangKhuyenMai
ADD CONSTRAINT FK_KhachHangKhuyenMai_KhuyenMai
FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(KhuyenMaiID);
GO
ALTER TABLE KhachHangKhuyenMai
ADD CONSTRAINT FK_KhachHangKhuyenMai_DatTour
FOREIGN KEY (MaDatTour) REFERENCES DatTour(MaDatTour);
GO

-- Thêm khóa ngoại cho bảng Feedback
ALTER TABLE Feedback
ADD CONSTRAINT FK_Feedback_KhachHang
FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang);
GO
ALTER TABLE Feedback
ADD CONSTRAINT FK_Feedback_Tour
FOREIGN KEY (MaTour) REFERENCES Tour(MaTour);
GO


-- Bảng Tour
INSERT INTO Tour (TenTour, LichTrinh, GiaTien, MoTa, TinhTrang)
VALUES
(N'Tour Bà Rịa - Suối Nghệ', N'Lịch trình tham quan Bà Rịa - Suối Nghệ trong 2 ngày', 3500000, N'Tour khám phá thiên nhiên', 1),
(N'Tour Quảng Nam - Phố cổ Hội An', N'Lịch trình khám phá Hội An trong 3 ngày', 4500000, N'Tour văn hóa lịch sử Hội An', 1),
(N'Tour Cà Mau - Mũi Cà Mau', N'Lịch trình khám phá mũi Cà Mau trong 2 ngày', 3000000, N'Tour khám phá cực Nam Việt Nam', 1),
(N'Tour Bắc Ninh - Đền Đô', N'Lịch trình tham quan Đền Đô trong 1 ngày', 2500000, N'Tour tâm linh Bắc Ninh', 1),
(N'Tour Thái Nguyên - Hồ Núi Cốc', N'Lịch trình khám phá Hồ Núi Cốc trong 2 ngày', 3000000, N'Tour thiên nhiên Thái Nguyên', 1),
(N'Tour Cà Mau - Rừng U Minh', N'Lịch trình khám phá rừng U Minh trong 3 ngày', 5000000, N'Tour khám phá thiên nhiên rừng ngập mặn', 1),
(N'Tour Lâm Đồng - Đồi chè Cầu Đất', N'Lịch trình khám phá đồi chè trong 2 ngày', 4000000, N'Tour sinh thái đồi chè', 1),
(N'Tour Điện Biên - A1', N'Lịch trình khám phá di tích Điện Biên Phủ trong 3 ngày', 4500000, N'Tour lịch sử Điện Biên', 1),
(N'Tour Cao Bằng - Thác Bản Giốc', N'Lịch trình khám phá thác Bản Giốc trong 3 ngày', 6000000, N'Tour thiên nhiên Cao Bằng', 1),
(N'Tour Ninh Bình - Hang Múa', N'Lịch trình khám phá Hang Múa trong 2 ngày', 5000000, N'Tour văn hóa lịch sử Ninh Bình', 1);
GO
-- Bảng KhachHang
INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiaChi, CMND)
VALUES
(N'Lê Văn Hiếu', N'0903456789', N'le.hieu@gmail.com', N'Hà Nam', N'456789012'),
(N'Nguyễn Thị Thảo', N'0914567890', N'nguyen.thao@yahoo.com', N'Thái Bình', N'567890123'),
(N'Vũ Văn Tùng', N'0925678901', N'vu.tung@outlook.com', N'Bắc Ninh', N'678901234'),
(N'Hoàng Văn Lâm', N'0936789012', N'hoang.lam@gmail.com', N'Bình Định', N'789012345'),
(N'Phạm Thị Hòa', N'0947890123', N'pham.hoa@gmail.com', N'Quảng Ngãi', N'890123456'),
(N'Lý Thị Cúc', N'0958901234', N'ly.cuc@yahoo.com', N'Bắc Giang', N'901234567'),
(N'Trần Văn Thành', N'0969012345', N'tran.thanh@outlook.com', N'Vĩnh Phúc', N'012345678'),
(N'Bùi Thị Hồng', N'0970123456', N'bui.hong@gmail.com', N'Nghệ An', N'123456789'),
(N'Nguyễn Minh Tâm', N'0981234567', N'nguyen.tam@gmail.com', N'Tây Ninh', N'234567890'),
(N'Tô Văn Bình', N'0992345678', N'to.binh@outlook.com', N'Bến Tre', N'345678901');
GO
-- Bảng NhanVien
INSERT INTO NhanVien (HoTen, ChucVu, SoDienThoai, Email, DiaChi, NgaySinh, CMND, TinhTrang)
VALUES
(N'Nguyễn Hồng Sơn', N'Nhân viên lễ tân', N'0912233445', N'nguyen.son@congty.com', N'Thái Bình', '1992-07-15', N'022334455', 1),
(N'Trần Văn Hùng', N'Hướng dẫn viên', N'0923344556', N'tran.hung@congty.com', N'Bắc Ninh', '1989-09-10', N'033445566', 1),
(N'Lê Thị Thanh', N'Nhân viên kế toán', N'0934455667', N'le.thanh@congty.com', N'Thái Nguyên', '1990-02-18', N'044556677', 1),
(N'Vũ Thị Nga', N'Nhân viên bán vé', N'0945566778', N'vu.nga@congty.com', N'Hòa Bình', '1988-11-25', N'055667788', 1),
(N'Hoàng Văn An', N'Hướng dẫn viên', N'0956677889', N'hoang.an@congty.com', N'Quảng Ninh', '1993-03-30', N'066778899', 1),
(N'Phan Văn Khải', N'Nhân viên bán vé', N'0967788990', N'phan.khai@congty.com', N'Nghệ An', '1986-08-05', N'077889900', 1),
(N'Nguyễn Thị Liên', N'Nhân viên lễ tân', N'0978899001', N'nguyen.lien@congty.com', N'Nam Định', '1991-06-12', N'088990011', 1),
(N'Lý Văn Lâm', N'Nhân viên kế toán', N'0989900112', N'ly.lam@congty.com', N'Lạng Sơn', '1989-01-23', N'099100122', 1),
(N'Bùi Văn Minh', N'Nhân viên kinh doanh', N'0990011223', N'bui.minh@congty.com', N'Cà Mau', '1992-04-16', N'100111223', 1),
(N'Nguyễn Văn Dũng', N'Quản lý', N'0901122334', N'nguyen.dung@congty.com', N'Hà Nội', '1984-05-20', N'011223344', 1);

GO
INSERT INTO DatTour (MaTour, NgayDat) 
VALUES 
    (1, '2024-01-10'),
    (2, '2024-01-15'),
    (3, '2024-02-20'),
    (4, '2024-03-05'),
    (5, '2024-03-10'),
    (1, '2024-04-15'),
    (2, '2024-05-20'),
    (3, '2024-06-10'),
    (4, '2024-07-25'),
    (5, '2024-08-01');

GO

INSERT INTO DichVu (TenDichVu, MoTa, GiaTien, TinhTrang)
VALUES
(N'Dịch vụ hướng dẫn viên', N'Hướng dẫn viên chuyên nghiệp', 500000.00, 1),
(N'Dịch vụ xe đưa đón', N'Xe du lịch 16 chỗ', 700000.00, 1),
(N'Dịch vụ khách sạn', N'Khách sạn 4 sao', 1200000.00, 1),
(N'Dịch vụ nhà hàng', N'Nhà hàng buffet', 800000.00, 1),
(N'Dịch vụ vé tham quan', N'Vé tham quan bảo tàng', 150000.00, 1),
(N'Dịch vụ bảo hiểm', N'Bảo hiểm du lịch', 200000.00, 1),
(N'Dịch vụ spa', N'Spa thư giãn', 600000.00, 0),
(N'Dịch vụ giặt ủi', N'Dịch vụ giặt ủi khách sạn', 100000.00, 1),
(N'Dịch vụ cho thuê xe', N'Cho thuê xe máy', 300000.00, 1),
(N'Dịch vụ giải trí', N'Karaoke tại khách sạn', 400000.00, 1);
GO


INSERT INTO KhuyenMai (TenKhuyenMai, NgayBatDau, NgayKetThuc, GiaTriKhuyenMai, SoLuong)
VALUES
(N'Giảm giá 10%', '2024-10-01', '2024-10-31', 10.00, 100),
(N'Giảm giá 20%', '2024-10-05', '2024-10-25', 20.00, 50),
(N'Giảm giá 5%', '2024-11-01', '2024-11-30', 5.00, 200),
(N'Tặng quà lưu niệm', '2024-10-15', '2024-12-31', 0.00, 150),
(N'Voucher ăn uống 200k', '2024-11-01', '2024-11-30', 200.00, 80),
(N'Giảm giá 15%', '2024-12-01', '2024-12-31', 15.00, 100),
(N'Giảm giá 50%', '2024-10-10', '2024-10-20', 50.00, 20),
(N'Voucher khách sạn', '2024-11-10', '2024-11-25', 500.00, 30),
(N'Giảm giá 25%', '2024-12-01', '2024-12-20', 25.00, 40),
(N'Tặng vé tham quan', '2024-12-05', '2024-12-25', 0.00, 60);
GO
INSERT INTO KhachHangKhuyenMai (MaKhuyenMai, MaDatTour, NgaySuDung)
VALUES
(1, 1, '2024-10-02'),
(2, 2, '2024-10-06'),
(3, 3, '2024-10-10'),
(4, 4, '2024-10-15'),
(5, 5, '2024-10-20'),
(6, 6, '2024-11-05'),
(7, 7, '2024-11-10'),
(8, 8, '2024-11-15'),
(9, 9, '2024-12-01'),
(10, 10, '2024-12-05');
GO


INSERT INTO ThanhToan (MaDatTour, SoTien, NgayThanhToan, PhuongThucThanhToan)
VALUES
(1, 500000.00, '2024-10-01', N'Thẻ tín dụng'),
(2, 700000.00, '2024-10-02', N'Tiền mặt'),
(3, 1000000.00, '2024-10-03', N'Chuyển khoản'),
(4, 300000.00, '2024-10-04', N'Thẻ tín dụng'),
(5, 1200000.00, '2024-10-05', N'Tiền mặt'),
(6, 800000.00, '2024-10-06', N'Thẻ tín dụng'),
(7, 600000.00, '2024-10-07', N'Chuyển khoản'),
(8, 900000.00, '2024-10-08', N'Thẻ tín dụng'),
(9, 1500000.00, '2024-10-09', N'Tiền mặt'),
(10, 700000.00, '2024-10-10', N'Chuyển khoản');
GO
INSERT INTO ChiTietDatTour (MaKhachHang, MaDatTour, SoLuongNguoiDat, SoTienCoc, TinhTrang)
VALUES
(1, 1, 2, 500000.00, N'Chờ xác nhận'),
(2, 2, 3, 700000.00, N'Đã xác nhận'),
(3, 3, 4, 1000000.00, N'Hoàn tất'),
(4, 4, 1, 300000.00, N'Chờ thanh toán'),
(5, 5, 5, 1200000.00, N'Đã thanh toán'),
(6, 6, 2, 800000.00, N'Chờ xác nhận'),
(7, 7, 3, 600000.00, N'Hoàn tất'),
(8, 8, 4, 900000.00, N'Đã xác nhận'),
(9, 9, 5, 1500000.00, N'Chờ thanh toán'),
(10, 10, 2, 700000.00, N'Đã thanh toán');
GO
-- Thêm dữ liệu vào bảng Feedback
INSERT INTO Feedback (MaKhachHang, MaTour, NoiDung, NgayPhanHoi)
VALUES
(1, 1, N'Tour rất tuyệt vời, mình sẽ giới thiệu cho bạn bè.', '2024-10-20'),
(2, 2, N'Mọi thứ ổn, nhưng hướng dẫn viên cần linh hoạt hơn.', '2024-10-21'),
(3, 3, N'Rất hài lòng với dịch vụ, cảm ơn công ty.', '2024-10-22'),
(4, 4, N'Cần cải thiện phương tiện di chuyển, còn khá bất tiện.', '2024-10-23'),
(5, 5, N'Chuyến đi đáng nhớ, mình rất hài lòng.', '2024-10-24'),
(6, 6, N'Dịch vụ khách sạn cần được nâng cấp, ngoài ra mọi thứ đều tốt.', '2024-10-25'),
(7, 7, N'Chuyến du lịch rất vui, cảm ơn đội ngũ đã hỗ trợ.', '2024-10-26'),
(8, 8, N'Khám phá vùng miền rất thú vị, dịch vụ cần linh hoạt hơn.', '2024-10-27'),
(9, 9, N'Tour ổn nhưng mình không hài lòng với đồ ăn.', '2024-10-28'),
(10, 10, N'Tour khá tốt, giá cả hợp lý, rất đáng thử.', '2024-10-29')


Go
INSERT INTO Tour ( TenTour, LichTrinh, GiaTien, MoTa, TinhTrang, HuongDanVienID)
VALUES (N'Tour Phú Quốc', N'Lịch trình khám phá Phú Quốc trong 3 ngày', 6000000.00, N'Tour khám phá đảo ngọc Phú Quốc', 1, 8);
Go
INSERT INTO Tour ( TenTour, LichTrinh, GiaTien, MoTa, TinhTrang, HuongDanVienID)
VALUES ( N'Tour Côn Đảo', N'Lịch trình khám phá Côn Đảo trong 3 ngày', 6500000.00, N'Tour thiên nhiên và lịch sử Côn Đảo', 1, 9);
GO
INSERT INTO Tour ( TenTour, LichTrinh, GiaTien, MoTa, TinhTrang, HuongDanVienID)
VALUES ( N'Tour Nha Trang', N'Lịch trình khám phá Nha Trang trong 4 ngày', 7000000.00, N'Tour khám phá biển Nha Trang', 1, 10);
GO
INSERT INTO Tour ( TenTour, LichTrinh, GiaTien, MoTa, TinhTrang, HuongDanVienID)
VALUES (N'Tour Hạ Long - Hà Nội', N'Lịch trình khám phá Hạ Long và Hà Nội trong 4 ngày', 8000000.00, N'Tour văn hóa và thiên nhiên Hạ Long - Hà Nội', 1, 10);

Go
INSERT INTO DatDichVu (MaDatTour, MaDichVu, SoLuong)
VALUES
(1, 1, 2),
(2, 2, 1),
(3, 3, 3),
(4, 4, 1),
(5, 5, 2),
(6, 6, 1),
(7, 7, 4),
(8, 8, 2),
(9, 9, 1),
(10, 10, 2);
GO


--Tạo View có cột tổng tiền trong bảng đặt dịch vụ
CREATE VIEW vw_DatDichVu AS
SELECT 
    d.MaDatDichVu,
    d.MaDatTour,
    d.MaDichVu,
    d.SoLuong,
    dv.GiaTien,
    d.SoLuong * dv.GiaTien AS TongTien
FROM 
    DatDichVu d
JOIN 
    DichVu dv ON d.MaDichVu = dv.DichVuID;

GO
Select * from vw_DatDichVu

GO
-- Các trigger quản lí hệ thống 

--1. Trigger để chặn xóa thông tin quan trọng
CREATE TRIGGER trg_BeforeDeleteTour
ON Tour
INSTEAD OF DELETE
AS
BEGIN
    PRINT 'Không thể xóa Tour vì điều này có thể gây ảnh hưởng đến hệ thống.'
    ROLLBACK TRANSACTION;
END;
GO

GO
--3. Trigger ghi lại hoạt động xóa dữ liệu
CREATE TABLE DeleteLog (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    TableName NVARCHAR(100),
    DeletedRecordID INT,
    DeletedTime DATETIME DEFAULT GETDATE(),
    DeletedBy NVARCHAR(100)
);
GO

CREATE TRIGGER trg_AfterDeleteKhachHang
ON KhachHang
AFTER DELETE
AS
BEGIN
    INSERT INTO DeleteLog (TableName, DeletedRecordID, DeletedBy)
    SELECT 'KhachHang', d.MaKhachHang, SYSTEM_USER
    FROM deleted d;
END;
GO

CREATE TRIGGER trg_AfterDeleteNhanVien
ON NhanVien 
AFTER DELETE
AS
BEGIN 
	INSERT INTO DeleteLog (TableName,DeletedRecordID, DeletedBy)
	SELECT 'NhanVien', d.NhanVienID, SYSTEM_USER
	FROM deleted d;
end;
GO
--Tạo các trigger delete log cho các bảng còn lại
CREATE TRIGGER trg_AfterDeleteDichVu
ON DichVu
AFTER DELETE 
AS
BEGIN
	INSERT INTO DeleteLog(TableName, DeletedRecordID, DeletedBy)
	SELECT 'DichVu', d.DichVuID, SYSTEM_USER
	FROM deleted d;
end;
GO
CREATE TRIGGER trg_AfterDeleteDatDichVu
ON DatDichVu
AFTER DELETE 
AS
BEGIN
	INSERT INTO DeleteLog(TableName, DeletedRecordID, DeletedBy)
	SELECT 'DatDichVu', d.MaDatDichVu, SYSTEM_USER
	FROM deleted d;
end;
GO