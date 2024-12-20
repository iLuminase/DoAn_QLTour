USE [QuanLyTour]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](60) NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDatTour]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatTour](
	[MaChiTietDatTour] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[MaDatTour] [int] NOT NULL,
	[SoLuongNguoiDat] [int] NULL,
	[SoTienCoc] [decimal](18, 2) NULL,
	[TinhTrang] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietDatTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatDichVu]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatDichVu](
	[MaDatDichVu] [int] IDENTITY(1,1) NOT NULL,
	[MaDatTour] [int] NOT NULL,
	[MaDichVu] [int] NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDatDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatTour]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatTour](
	[MaDatTour] [int] IDENTITY(1,1) NOT NULL,
	[MaTour] [int] NULL,
	[NgayDat] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDatTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[DichVuID] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](255) NULL,
	[GiaTien] [decimal](18, 2) NOT NULL,
	[TinhTrang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DichVuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[MaFeedback] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[MaTour] [int] NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[NgayPhanHoi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaFeedback] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[CMND] [nvarchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHangKhuyenMai]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHangKhuyenMai](
	[MaKhuyenMai] [int] NOT NULL,
	[MaDatTour] [int] NOT NULL,
	[NgaySuDung] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhuyenMai] ASC,
	[MaDatTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[KhuyenMaiID] [int] IDENTITY(1,1) NOT NULL,
	[TenKhuyenMai] [nvarchar](100) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[GiaTriKhuyenMai] [decimal](5, 2) NOT NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[KhuyenMaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[NhanVienID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
	[SoDienThoai] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[CMND] [nvarchar](12) NOT NULL,
	[TinhTrang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[ThanhToanID] [int] IDENTITY(1,1) NOT NULL,
	[MaDatTour] [int] NOT NULL,
	[SoTien] [decimal](18, 2) NOT NULL,
	[NgayThanhToan] [date] NOT NULL,
	[PhuongThucThanhToan] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ThanhToanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tour]    Script Date: 10/31/2024 11:54:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tour](
	[MaTour] [int] IDENTITY(1,1) NOT NULL,
	[TenTour] [nvarchar](255) NOT NULL,
	[LichTrinh] [nvarchar](max) NULL,
	[GiaTien] [decimal](18, 2) NULL,
	[MoTa] [nvarchar](max) NULL,
	[TinhTrang] [int] NULL,
	[NhanVienID] [int] NOT NULL,
 CONSTRAINT [PK__Tour__4E5557DE9FA4AA37] PRIMARY KEY CLUSTERED 
(
	[MaTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Role]
GO
ALTER TABLE [dbo].[ChiTietDatTour]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatTour_DatTour] FOREIGN KEY([MaDatTour])
REFERENCES [dbo].[DatTour] ([MaDatTour])
GO
ALTER TABLE [dbo].[ChiTietDatTour] CHECK CONSTRAINT [FK_ChiTietDatTour_DatTour]
GO
ALTER TABLE [dbo].[ChiTietDatTour]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatTour_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[ChiTietDatTour] CHECK CONSTRAINT [FK_ChiTietDatTour_KhachHang]
GO
ALTER TABLE [dbo].[DatDichVu]  WITH CHECK ADD  CONSTRAINT [FK_DatDichVu_DatTour] FOREIGN KEY([MaDatTour])
REFERENCES [dbo].[DatTour] ([MaDatTour])
GO
ALTER TABLE [dbo].[DatDichVu] CHECK CONSTRAINT [FK_DatDichVu_DatTour]
GO
ALTER TABLE [dbo].[DatDichVu]  WITH CHECK ADD  CONSTRAINT [FK_DatDichVu_DichVu] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([DichVuID])
GO
ALTER TABLE [dbo].[DatDichVu] CHECK CONSTRAINT [FK_DatDichVu_DichVu]
GO
ALTER TABLE [dbo].[DatTour]  WITH CHECK ADD  CONSTRAINT [FK_DatTour_Tour] FOREIGN KEY([MaTour])
REFERENCES [dbo].[Tour] ([MaTour])
GO
ALTER TABLE [dbo].[DatTour] CHECK CONSTRAINT [FK_DatTour_Tour]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_KhachHang]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Tour] FOREIGN KEY([MaTour])
REFERENCES [dbo].[Tour] ([MaTour])
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Tour]
GO
ALTER TABLE [dbo].[KhachHangKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_KhachHangKhuyenMai_DatTour] FOREIGN KEY([MaDatTour])
REFERENCES [dbo].[DatTour] ([MaDatTour])
GO
ALTER TABLE [dbo].[KhachHangKhuyenMai] CHECK CONSTRAINT [FK_KhachHangKhuyenMai_DatTour]
GO
ALTER TABLE [dbo].[KhachHangKhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_KhachHangKhuyenMai_KhuyenMai] FOREIGN KEY([MaKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([KhuyenMaiID])
GO
ALTER TABLE [dbo].[KhachHangKhuyenMai] CHECK CONSTRAINT [FK_KhachHangKhuyenMai_KhuyenMai]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_ThanhToan_DatTour] FOREIGN KEY([MaDatTour])
REFERENCES [dbo].[DatTour] ([MaDatTour])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK_ThanhToan_DatTour]
GO
ALTER TABLE [dbo].[Tour]  WITH CHECK ADD  CONSTRAINT [FK_Tour_HuongDanVien] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([NhanVienID])
GO
ALTER TABLE [dbo].[Tour] CHECK CONSTRAINT [FK_Tour_HuongDanVien]
GO
ALTER TABLE [dbo].[ChiTietDatTour]  WITH CHECK ADD CHECK  (([SoLuongNguoiDat]>(0)))
GO
ALTER TABLE [dbo].[ChiTietDatTour]  WITH CHECK ADD CHECK  (([SoTienCoc]>=(0)))
GO
ALTER TABLE [dbo].[DatDichVu]  WITH CHECK ADD CHECK  (([SoLuong]>(0)))
GO
ALTER TABLE [dbo].[Tour]  WITH CHECK ADD  CONSTRAINT [CK__Tour__GiaTien__5CD6CB2B] CHECK  (([GiaTien]>=(0)))
GO
ALTER TABLE [dbo].[Tour] CHECK CONSTRAINT [CK__Tour__GiaTien__5CD6CB2B]
GO
