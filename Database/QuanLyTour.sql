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
    NgayBatDau DATE,
    NgayKetThuc DATE
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
    CMND NVARCHAR(12) NOT NULL                
);
GO
-- Bảng DatTour
CREATE TABLE DatTour (
    MaDatTour INT PRIMARY KEY IDENTITY(1,1),
    MaKhachHang INT NOT NULL,  -- Khóa ngoại tới KhachHang
    MaTour INT NOT NULL,       -- Khóa ngoại tới Tour
    NgayDat DATE NOT NULL,
    SoLuongNguoi INT CHECK (SoLuongNguoi > 0), -- Số lượng người phải lớn hơn 0
    TongTien DECIMAL(18, 2) CHECK (TongTien >= 0),  -- Tổng tiền phải lớn hơn hoặc bằng 0
    TinhTrang NVARCHAR(50) DEFAULT N'Chưa thanh toán'  -- Trạng thái mặc định là 'Chưa thanh toán'
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
    GiaTien DECIMAL(18,2) NOT NULL
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
    GiaTriKhuyenMai DECIMAL(5,2) NOT NULL
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

--Thêm các ràng buộc
ALTER TABLE Tour
ADD CONSTRAINT CHK_Tour_NgayKetThuc CHECK (NgayKetThuc >= NgayBatDau);

ALTER TABLE KhuyenMai
ADD CONSTRAINT CHK_KhuyenMai_NgayKetThuc CHECK (NgayKetThuc >= NgayBatDau);

-- Khóa ngoại cho bảng DatTour
ALTER TABLE DatTour
ADD CONSTRAINT FK_DatTour_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang);

ALTER TABLE DatTour
ADD CONSTRAINT FK_DatTour_Tour FOREIGN KEY (MaTour) REFERENCES Tour(MaTour);

-- Khóa ngoại cho bảng ThanhToan
ALTER TABLE ThanhToan
ADD CONSTRAINT FK_ThanhToan_DatTour FOREIGN KEY (MaDatTour) REFERENCES DatTour(MaDatTour);

-- Khóa ngoại cho bảng DatDichVu
ALTER TABLE DatDichVu
ADD CONSTRAINT FK_DatDichVu_DatTour FOREIGN KEY (MaDatTour) REFERENCES DatTour(MaDatTour);

ALTER TABLE DatDichVu
ADD CONSTRAINT FK_DatDichVu_DichVu FOREIGN KEY (MaDichVu) REFERENCES DichVu(DichVuID);

-- Khóa ngoại cho bảng KhachHangKhuyenMai
ALTER TABLE KhachHangKhuyenMai
ADD CONSTRAINT FK_KhachHangKhuyenMai_KhuyenMai FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(KhuyenMaiID);

ALTER TABLE KhachHangKhuyenMai
ADD CONSTRAINT FK_KhachHangKhuyenMai_DatTour FOREIGN KEY (MaDatTour) REFERENCES DatTour(MaDatTour);

-- Khóa ngoại cho bảng Feedback
ALTER TABLE Feedback
ADD CONSTRAINT FK_Feedback_KhachHang FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang);

ALTER TABLE Feedback
ADD CONSTRAINT FK_Feedback_Tour FOREIGN KEY (MaTour) REFERENCES Tour(MaTour);

GO
--Insert dữ liệu
INSERT INTO Tour (TenTour, LichTrinh, GiaTien, MoTa, NgayBatDau, NgayKetThuc)
VALUES
(N'Tour Hà Nội - Hạ Long', N'Lịch trình tham quan Hà Nội và Vịnh Hạ Long trong 4 ngày', 8000000, N'Tour du lịch khám phá thủ đô và di sản thiên nhiên', '2024-11-01', '2024-11-04'),
(N'Tour Đà Lạt - Thung Lũng Tình Yêu', N'Lịch trình Đà Lạt trong 3 ngày', 5000000, N'Tour tham quan cảnh đẹp Đà Lạt', '2024-11-10', '2024-11-12'),
(N'Tour Phú Quốc', N'Lịch trình khám phá đảo Phú Quốc trong 5 ngày', 10000000, N'Tour nghỉ dưỡng tại Phú Quốc', '2024-12-01', '2024-12-05'),
(N'Tour Sapa - Fansipan', N'Lịch trình chinh phục Fansipan trong 4 ngày', 9000000, N'Tour khám phá Sapa và đỉnh Fansipan', '2024-11-15', '2024-11-18'),
(N'Tour Nha Trang', N'Lịch trình khám phá bãi biển Nha Trang trong 3 ngày', 7000000, N'Tour nghỉ dưỡng biển tại Nha Trang', '2024-11-20', '2024-11-22'),
(N'Tour Huế - Đà Nẵng', N'Lịch trình tham quan cố đô Huế và Đà Nẵng trong 4 ngày', 8500000, N'Tour khám phá di sản văn hóa Huế và thành phố biển Đà Nẵng', '2024-12-05', '2024-12-08'),
(N'Tour Hội An - Mỹ Sơn', N'Lịch trình khám phá Hội An và Thánh địa Mỹ Sơn trong 3 ngày', 6000000, N'Tour văn hóa lịch sử tại Hội An và Mỹ Sơn', '2024-11-25', '2024-11-27'),
(N'Tour Cần Thơ - Chợ nổi Cái Răng', N'Lịch trình khám phá miền Tây trong 2 ngày', 4000000, N'Tour du lịch miền Tây và chợ nổi Cái Răng', '2024-11-28', '2024-11-29'),
(N'Tour Bình Thuận - Mũi Né', N'Lịch trình nghỉ dưỡng tại Mũi Né trong 3 ngày', 6000000, N'Tour khám phá biển và đồi cát Mũi Né', '2024-12-01', '2024-12-03'),
(N'Tour Vũng Tàu', N'Lịch trình nghỉ dưỡng tại Vũng Tàu trong 2 ngày', 3500000, N'Tour tham quan thành phố biển Vũng Tàu', '2024-12-10', '2024-12-11'),
(N'Tour Quảng Bình - Hang Sơn Đoòng', N'Lịch trình khám phá hang động lớn nhất thế giới Sơn Đoòng trong 7 ngày', 25000000, N'Tour khám phá Sơn Đoòng và vườn quốc gia Phong Nha', '2024-12-15', '2024-12-21'),
(N'Tour Hà Giang - Cao nguyên đá Đồng Văn', N'Lịch trình khám phá cao nguyên đá Hà Giang trong 5 ngày', 12000000, N'Tour tham quan cảnh đẹp Hà Giang', '2024-12-01', '2024-12-05'),
(N'Tour Côn Đảo', N'Lịch trình khám phá di tích lịch sử và biển Côn Đảo trong 4 ngày', 11000000, N'Tour lịch sử và nghỉ dưỡng tại Côn Đảo', '2024-12-25', '2024-12-28'),
(N'Tour Đà Nẵng - Bà Nà Hills', N'Lịch trình tham quan Đà Nẵng và Bà Nà Hills trong 3 ngày', 7500000, N'Tour khám phá thành phố biển Đà Nẵng và Bà Nà Hills', '2024-12-20', '2024-12-22'),
(N'Tour Phan Thiết - Làng Chài', N'Lịch trình khám phá Phan Thiết và làng chài trong 3 ngày', 5500000, N'Tour du lịch biển và văn hóa Phan Thiết', '2024-11-05', '2024-11-07'),
(N'Tour Pleiku - Gia Lai', N'Lịch trình khám phá vùng cao Pleiku trong 4 ngày', 6500000, N'Tour tham quan vùng cao nguyên Tây Nguyên', '2024-11-10', '2024-11-13'),
(N'Tour Đắk Lắk - Buôn Ma Thuột', N'Lịch trình khám phá Buôn Ma Thuột trong 3 ngày', 7000000, N'Tour khám phá văn hóa và thiên nhiên Buôn Ma Thuột', '2024-12-05', '2024-12-07'),
(N'Tour Nam Định - Tràng An', N'Lịch trình khám phá danh thắng Tràng An trong 3 ngày', 5000000, N'Tour tham quan di sản Tràng An', '2024-11-17', '2024-11-19'),
(N'Tour Lào Cai - Chợ Bắc Hà', N'Lịch trình khám phá chợ Bắc Hà và Sapa trong 4 ngày', 8500000, N'Tour khám phá văn hóa dân tộc vùng cao', '2024-11-12', '2024-11-15'),
(N'Tour Tây Ninh - Núi Bà Đen', N'Lịch trình leo núi và khám phá Tây Ninh trong 2 ngày', 3000000, N'Tour leo núi và khám phá văn hóa Tây Ninh', '2024-12-01', '2024-12-02');
GO
INSERT INTO KhachHang (HoTen, SoDienThoai, Email, DiaChi, CMND)
VALUES
(N'Nguyễn Văn An', N'0901234567', N'nguyen.an@gmail.com', N'Hà Nội', N'123456789'),
(N'Trần Thị Bích', N'0912345678', N'tran.bich@yahoo.com', N'Đà Nẵng', N'234567890'),
(N'Lê Văn Cường', N'0923456789', N'le.cuong@outlook.com', N'TP Hồ Chí Minh', N'345678901'),
(N'Hoàng Thị Dung', N'0934567890', N'hoang.dung@gmail.com', N'Huế', N'456789012'),
(N'Phạm Quốc Đạt', N'0945678901', N'pham.dat@gmail.com', N'Quảng Nam', N'567890123'),
(N'Vũ Minh Châu', N'0956789012', N'vu.chau@gmail.com', N'Hải Phòng', N'678901234'),
(N'Ngô Thanh Hà', N'0967890123', N'ngo.ha@yahoo.com', N'Vũng Tàu', N'789012345'),
(N'Bùi Thị Hương', N'0978901234', N'bui.huong@gmail.com', N'Nha Trang', N'890123456'),
(N'Tô Văn Hải', N'0989012345', N'to.hai@outlook.com', N'Phan Thiết', N'901234567'),
(N'Trịnh Thị Kim Anh', N'0990123456', N'trinh.kimanh@gmail.com', N'Cần Thơ', N'012345678'),
(N'Lý Quốc Khánh', N'0913456789', N'ly.khanh@yahoo.com', N'Đà Lạt', N'112345678'),
(N'Phan Thị Mai', N'0924567890', N'phan.mai@gmail.com', N'Buôn Ma Thuột', N'122345679'),
(N'Thái Bảo Long', N'0935678901', N'thai.long@outlook.com', N'Tây Ninh', N'132345670'),
(N'Võ Thị Ngọc Lan', N'0946789012', N'vo.lan@gmail.com', N'Quảng Bình', N'142345671'),
(N'Nguyễn Minh Hùng', N'0957890123', N'nguyen.hung@gmail.com', N'Hòa Bình', N'152345672'),
(N'Phạm Thị Tuyết', N'0968901234', N'pham.tuyet@outlook.com', N'Hà Giang', N'162345673'),
(N'Đỗ Minh Khôi', N'0979012345', N'do.khoi@yahoo.com', N'Hà Nội', N'172345674'),
(N'Bùi Thị Ngọc Trâm', N'0980123456', N'bui.tram@gmail.com', N'Sapa', N'182345675'),
(N'Trần Văn Bình', N'0991234567', N'tran.binh@gmail.com', N'Nam Định', N'192345676'),
(N'Võ Thị Yến', N'0902345678', N'vo.yen@gmail.com', N'Hà Nội', N'202345677');
GO
INSERT INTO NhanVien (HoTen, ChucVu, SoDienThoai, Email, DiaChi, NgaySinh, CMND)
VALUES
(N'Nguyễn Văn Thanh', N'Quản lý', N'0901122334', N'nguyen.thanh@congty.com', N'Hà Nội', '1985-05-20', N'011223344'),
(N'Trần Thị Hồng', N'Nhân viên kinh doanh', N'0912233445', N'tran.hong@congty.com', N'Đà Nẵng', '1990-07-15', N'022334455'),
(N'Hoàng Văn Nam', N'Hướng dẫn viên', N'0923344556', N'hoang.nam@congty.com', N'TP Hồ Chí Minh', '1988-09-10', N'033445566'),
(N'Võ Thị Bích', N'Nhân viên kế toán', N'0934455667', N'vo.bich@congty.com', N'Huế', '1992-02-18', N'044556677'),
(N'Lê Văn Toàn', N'Hướng dẫn viên', N'0945566778', N'le.toan@congty.com', N'Nha Trang', '1987-11-25', N'055667788'),
(N'Phạm Thị Lan', N'Quản lý', N'0956677889', N'pham.lan@congty.com', N'Phú Quốc', '1995-03-30', N'066778899'),
(N'Ngô Minh Sơn', N'Nhân viên kinh doanh', N'0967788990', N'ngo.son@congty.com', N'Sapa', '1986-08-05', N'077889900'),
(N'Bùi Thị Nga', N'Nhân viên lễ tân', N'0978899001', N'bui.nga@congty.com', N'Cần Thơ', '1991-06-12', N'088990011'),
(N'Trịnh Văn Hải', N'Nhân viên bán vé', N'0989900112', N'trinh.hai@congty.com', N'Vũng Tàu', '1989-01-23', N'099100122'),
(N'Vũ Thị Hương', N'Quản lý', N'0900011223', N'vu.huong@congty.com', N'Hà Giang', '1984-04-16', N'100111223'),
(N'Đỗ Thị Thủy', N'Nhân viên lễ tân', N'0911122334', N'do.thuy@congty.com', N'Hà Nội', '1993-12-20', N'111122334'),
(N'Phan Quốc Định', N'Nhân viên bán vé', N'0922233445', N'phan.dinh@congty.com', N'Đà Lạt', '1990-08-22', N'122233445'),
(N'Tô Thị Bích', N'Quản lý', N'0933344556', N'to.bich@congty.com', N'Pleiku', '1983-10-13', N'133344556'),
(N'Lý Minh Cường', N'Hướng dẫn viên', N'0944455667', N'ly.cuong@congty.com', N'Hải Phòng', '1989-07-17', N'144455667'),
(N'Phạm Văn Hải', N'Nhân viên kinh doanh', N'0955566778', N'pham.hai@congty.com', N'Quảng Bình', '1994-02-07', N'155566778'),
(N'Trần Thị Thanh', N'Nhân viên bán vé', N'0966677889', N'tran.thanh@congty.com', N'Tây Ninh', '1992-01-19', N'166677889'),
(N'Võ Minh Tuấn', N'Nhân viên lễ tân', N'0977788990', N'vo.tuan@congty.com', N'Buôn Ma Thuột', '1991-06-09', N'177788900'),
(N'Lê Thị Ngọc', N'Nhân viên kế toán', N'0988899001', N'le.ngoc@congty.com', N'Bình Thuận', '1988-09-11', N'188899011'),
(N'Nguyễn Văn Sơn', N'Quản lý', N'0900011223', N'nguyen.son@congty.com', N'Tây Ninh', '1993-03-03', N'199900122'),
(N'Trần Thị Mai', N'Hướng dẫn viên', N'0911122334', N'tran.mai@congty.com', N'Côn Đảo', '1986-05-28', N'200111223');
GO
INSERT INTO DatTour (MaTour, MaKhachHang, NgayDat, SoLuongNguoi, TongTien)
VALUES
(1, 1, '2024-11-01', 2, 16000000),
(2, 2, '2024-11-10', 3, 15000000),
(3, 3, '2024-12-01', 4, 40000000),
(4, 4, '2024-11-15', 1, 9000000),
(5, 5, '2024-11-20', 5, 35000000),
(6, 6, '2024-12-05', 2, 17000000),
(7, 7, '2024-11-25', 2, 12000000),
(8, 8, '2024-11-28', 3, 12000000),
(9, 9, '2024-12-01', 1, 6000000),
(10, 10, '2024-12-10', 2, 7000000),
(11, 11, '2024-12-15', 1, 25000000),
(12, 12, '2024-12-01', 2, 24000000),
(13, 13, '2024-12-25', 4, 44000000),
(14, 14, '2024-12-20', 2, 15000000),
(15, 15, '2024-11-05', 1, 5500000),
(16, 16, '2024-11-10', 3, 19500000),
(17, 17, '2024-12-05', 2, 14000000),
(18, 18, '2024-11-17', 1, 5000000),
(19, 19, '2024-11-12', 2, 17000000),
(20, 20, '2024-12-01', 1, 3000000);
GO
INSERT INTO ThanhToan (MaDatTour, SoTien, NgayThanhToan, PhuongThucThanhToan)
VALUES
(1, 8000000, '2024-11-02', N'Tiền mặt'),
(2, 5000000, '2024-11-11', N'Thẻ tín dụng'),
(3, 10000000, '2024-12-02', N'Chuyển khoản'),
(4, 4500000, '2024-11-16', N'Tiền mặt'),
(5, 7000000, '2024-11-21', N'Thẻ tín dụng'),
(6, 8500000, '2024-12-06', N'Chuyển khoản'),
(7, 6000000, '2024-11-26', N'Tiền mặt'),
(8, 4000000, '2024-11-29', N'Thẻ tín dụng'),
(9, 3000000, '2024-12-02', N'Chuyển khoản'),
(10, 3500000, '2024-12-11', N'Tiền mặt'),
(11, 5000000, '2024-12-16', N'Thẻ tín dụng'),
(12, 12000000, '2024-12-02', N'Chuyển khoản'),
(13, 20000000, '2024-12-26', N'Tiền mặt'),
(14, 15000000, '2024-12-21', N'Thẻ tín dụng'),
(15, 3000000, '2024-11-06', N'Chuyển khoản'),
(16, 6000000, '2024-11-11', N'Tiền mặt'),
(17, 7000000, '2024-12-06', N'Thẻ tín dụng'),
(18, 2500000, '2024-11-18', N'Chuyển khoản'),
(19, 8500000, '2024-11-13', N'Tiền mặt'),
(20, 1500000, '2024-12-02', N'Thẻ tín dụng');
GO
INSERT INTO DichVu (TenDichVu, MoTa, GiaTien)
VALUES
(N'Tour tham quan bằng thuyền', N'Thuyền sang trọng cho nhóm', 3000000),
(N'Khách sạn 5 sao', N'Bao gồm 2 đêm nghỉ tại khách sạn 5 sao', 5000000),
(N'Bữa tối cao cấp', N'Bữa tối tại nhà hàng sang trọng', 2000000),
(N'Tour du lịch xe đạp', N'Tour đạp xe khám phá địa phương', 1000000),
(N'Tour tham quan bằng xe bus', N'Xe bus du lịch toàn thành phố', 1500000),
(N'Bảo hiểm du lịch', N'Bảo hiểm toàn diện cho chuyến đi', 500000),
(N'Tour leo núi', N'Tour khám phá và leo núi', 2000000),
(N'Xe đưa đón sân bay', N'Xe đưa đón tiện lợi từ sân bay', 800000),
(N'Vé tham quan công viên quốc gia', N'Vé tham quan các khu bảo tồn', 600000),
(N'Gói spa & massage', N'Trải nghiệm spa tại khách sạn', 3000000),
(N'Tour chèo thuyền kayak', N'Chèo kayak khám phá sông nước', 2500000),
(N'Tour ngắm cảnh bằng khinh khí cầu', N'Bay trên khinh khí cầu', 7000000),
(N'Tour ẩm thực', N'Khám phá ẩm thực địa phương', 1500000),
(N'Thuê xe máy', N'Thuê xe máy tự lái trong 1 ngày', 500000),
(N'Vé tham quan khu bảo tồn thiên nhiên', N'Vé vào cửa khu bảo tồn', 400000),
(N'Gói dịch vụ hồ bơi', N'Trải nghiệm hồ bơi sang trọng', 1000000),
(N'Tour ngắm cảnh hoàng hôn', N'Ngắm hoàng hôn từ trên đồi', 2000000),
(N'Tour du thuyền', N'Tour du thuyền biển ngắn ngày', 8000000),
(N'Vé vào cửa khu di tích', N'Vé tham quan khu di tích lịch sử', 300000),
(N'Tour xe jeep', N'Tour khám phá bằng xe jeep', 2500000);

GO
INSERT INTO DatDichVu (MaDatTour, MaDichVu, SoLuong)
VALUES
(1, 1, 2),
(2, 2, 1),
(3, 3, 3),
(4, 4, 1),
(5, 5, 2),
(6, 6, 4),
(7, 7, 1),
(8, 8, 2),
(9, 9, 1),
(10, 10, 1),
(11, 11, 2),
(12, 12, 1),
(13, 13, 3),
(14, 14,1),
(15, 15, 2),
(16, 16, 1),
(17, 17, 1),
(18, 18, 1),
(19, 19, 2),
(20, 20, 1);


GO
INSERT INTO KhuyenMai (TenKhuyenMai, NgayBatDau, NgayKetThuc, GiaTriKhuyenMai)
VALUES
(N'Khuyến mãi mùa đông', '2024-12-01', '2024-12-31', 15),
(N'Khuyến mãi lễ 30/4', '2024-04-01', '2024-04-30', 10),
(N'Giảm giá mùa hè', '2024-06-01', '2024-07-31', 20),
(N'Khuyến mãi cuối năm', '2024-12-15', '2024-12-31', 25),
(N'Giảm giá dịp Noel', '2024-12-20', '2024-12-25', 10),
(N'Khuyến mãi Tết nguyên đán', '2025-01-01', '2025-02-15', 30),
(N'Giảm giá Black Friday', '2024-11-24', '2024-11-28', 40),
(N'Khuyến mãi lễ 2/9', '2024-08-25', '2024-09-05', 20),
(N'Giảm giá tháng 5', '2024-05-01', '2024-05-31', 15),
(N'Giảm giá tháng 11', '2024-11-01', '2024-11-30', 10),
(N'Giảm giá tháng 7', '2024-07-01', '2024-07-31', 15),
(N'Khuyến mãi Trung Thu', '2024-09-15', '2024-09-30', 20),
(N'Khuyến mãi lễ Quốc Khánh', '2024-09-01', '2024-09-05', 10),
(N'Giảm giá tháng 10', '2024-10-01', '2024-10-31', 20),
(N'Giảm giá tháng 9', '2024-09-01', '2024-09-30', 15),
(N'Khuyến mãi dịp Valentine', '2025-02-10', '2025-02-15', 10),
(N'Khuyến mãi ngày 8/3', '2025-03-01', '2025-03-10', 15),
(N'Khuyến mãi Halloween', '2024-10-25', '2024-10-31', 20),
(N'Khuyến mãi mừng khai trương', '2024-11-01', '2024-11-15', 30),
(N'Khuyến mãi dịp sinh nhật công ty', '2024-08-01', '2024-08-10', 20);

Go
INSERT INTO KhachHangKhuyenMai (MaKhuyenMai, MaDatTour, NgaySuDung) VALUES 
(1, 1, '2024-01-15'),
(1, 2, '2024-02-20'),
(2, 3, '2024-03-10'),
(2, 4, '2024-04-05'),
(3, 5, '2024-05-18'),
(3, 6, '2024-06-25'),
(4, 7, '2024-07-30'),
(4, 8, '2024-08-22'),
(5, 9, '2024-09-10'),
(5, 10, '2024-10-01'),
(6, 11, '2024-11-15'),
(6, 12, '2024-12-20'),
(7, 13, '2024-01-30'),
(7, 14, '2024-02-18'),
(8, 15, '2024-03-25'),
(8, 16, '2024-04-10'),
(9, 17, '2024-05-20'),
(9, 18, '2024-06-15'),
(10, 19, '2024-07-05'),
(10, 20, '2024-08-30');

Go
INSERT INTO Feedback (MaKhachHang, MaTour, NoiDung, NgayPhanHoi) VALUES 
(1, 1, N'Tour rất tuyệt vời!', '2024-01-16'),
(2, 2, N'Chất lượng dịch vụ tốt.', '2024-02-21'),
(3, 3, N'Tôi đã có một trải nghiệm tuyệt vời.', '2024-03-11'),
(4, 4, N'Tour rất đáng giá.', '2024-04-06'),
(5, 5, N'Dịch vụ tốt nhưng có thể cải thiện thêm.', '2024-05-19'),
(6, 6, N'Tôi rất hài lòng với chuyến đi.', '2024-06-26'),
(7, 7, N'Tour có giá cả hợp lý.', '2024-07-31'),
(8, 8, N'Mọi thứ đều hoàn hảo!', '2024-08-23'),
(9, 9, N'Tôi sẽ quay lại lần sau.', '2024-09-11'),
(10, 10, N'Tuyệt vời, cảm ơn!', '2024-10-02'),
(1, 11, N'Chuyến đi thú vị.', '2024-11-16'),
(2, 12, N'Dịch vụ rất chuyên nghiệp.', '2024-12-21'),
(3, 13, N'Một trải nghiệm tuyệt vời.', '2024-01-31'),
(4, 14, N'Thật đáng nhớ.', '2024-02-19'),
(5, 15, N'Chất lượng dịch vụ cần cải thiện.', '2024-03-26'),
(6, 16, N'Tôi rất vui với chuyến đi này.', '2024-04-11'),
(7, 17, N'Giá cả rất hợp lý.', '2024-05-21'),
(8, 18, N'Mọi thứ đều rất hoàn hảo.', '2024-06-16'),
(9, 19, N'Tôi sẽ giới thiệu cho bạn bè.', '2024-07-06'),
(10, 20, N'Tuyệt vời, cảm ơn các bạn!', '2024-08-31');


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
--2. Trigger kiểm tra dữ liệu trước khi thêm hoặc sửa
CREATE TRIGGER trg_BeforeInsertUpdateDatTour
ON DatTour
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @SoLuongNguoi INT, @NgayDat DATE;
    
    SELECT @SoLuongNguoi = i.SoLuongNguoi, @NgayDat = i.NgayDat
    FROM inserted i;
    
    -- Kiểm tra số lượng người
    IF @SoLuongNguoi <= 0
    BEGIN
        PRINT 'Số lượng người phải lớn hơn 0.';
        ROLLBACK TRANSACTION;
        RETURN;
    END

    -- Kiểm tra ngày đặt không nằm trong quá khứ
    IF @NgayDat < GETDATE()
    BEGIN
        PRINT 'Ngày đặt không hợp lệ. Ngày đặt phải lớn hơn hoặc bằng ngày hiện tại.';
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
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
