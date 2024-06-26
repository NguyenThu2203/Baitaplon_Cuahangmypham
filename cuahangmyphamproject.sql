USE [master]
GO
/****** Object:  Database [CuaHangMyPham]    Script Date: 6/7/2024 3:32:40 PM ******/
CREATE DATABASE [CuaHangMyPham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CuaHangMyPham', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CuaHangMyPham.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CuaHangMyPham_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CuaHangMyPham_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CuaHangMyPham] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CuaHangMyPham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CuaHangMyPham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET ARITHABORT OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CuaHangMyPham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CuaHangMyPham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CuaHangMyPham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CuaHangMyPham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CuaHangMyPham] SET  MULTI_USER 
GO
ALTER DATABASE [CuaHangMyPham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CuaHangMyPham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CuaHangMyPham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CuaHangMyPham] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CuaHangMyPham] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CuaHangMyPham] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CuaHangMyPham] SET QUERY_STORE = OFF
GO
USE [CuaHangMyPham]
GO
/****** Object:  Table [dbo].[tblChatlieu]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChatlieu](
	[Machatlieu] [nvarchar](10) NOT NULL,
	[Tenchatlieu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblChatlieu] PRIMARY KEY CLUSTERED 
(
	[Machatlieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChitiethoadonban]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitiethoadonban](
	[SoHDB] [nvarchar](50) NOT NULL,
	[Mahang] [nvarchar](10) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Giamgia] [float] NULL,
	[Thanhtien] [float] NOT NULL,
 CONSTRAINT [PK_tblChitiethoadonban] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC,
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChitiethoadonnhap]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitiethoadonnhap](
	[SoHDN] [nvarchar](50) NOT NULL,
	[Mahang] [nvarchar](10) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Dongianhap] [float] NOT NULL,
	[Giamgia] [float] NULL,
	[Thanhtien] [float] NOT NULL,
 CONSTRAINT [PK_tblChitiethoadonnhap] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC,
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCongdung]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCongdung](
	[Macongdung] [nvarchar](10) NOT NULL,
	[Tencongdung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblCongdung] PRIMARY KEY CLUSTERED 
(
	[Macongdung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCongviec]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCongviec](
	[MaCV] [nvarchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NOT NULL,
	[Mucluong] [float] NOT NULL,
 CONSTRAINT [PK_tblCongviec] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHanghoa]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHanghoa](
	[Mahang] [nvarchar](10) NOT NULL,
	[Tenhang] [nvarchar](50) NULL,
	[Maloai] [nvarchar](10) NULL,
	[Makhoiluong] [nvarchar](10) NULL,
	[Mahangsx] [nvarchar](10) NULL,
	[Machatlieu] [nvarchar](10) NULL,
	[Macongdung] [nvarchar](10) NOT NULL,
	[Mamua] [nvarchar](10) NOT NULL,
	[Mamau] [nvarchar](10) NOT NULL,
	[ManuocSX] [nvarchar](10) NOT NULL,
	[Soluong] [int] NOT NULL,
	[Dongianhap] [float] NOT NULL,
	[Dongiaban] [float] NOT NULL,
	[Thoigianbaohanh] [int] NULL,
	[Anh] [nvarchar](200) NULL,
	[Ghichu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblHanghoa] PRIMARY KEY CLUSTERED 
(
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHangsanxuat]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangsanxuat](
	[Mahangsx] [nvarchar](10) NOT NULL,
	[Tenhangsx] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblHangsanxuat] PRIMARY KEY CLUSTERED 
(
	[Mahangsx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoadonban]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadonban](
	[SoHDB] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[Ngayban] [datetime] NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[Tongtien] [float] NOT NULL,
 CONSTRAINT [PK_tblHoadonban] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoadonnhap]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadonnhap](
	[SoHDN] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[Ngaynhap] [datetime] NOT NULL,
	[MaNCC] [nvarchar](10) NOT NULL,
	[Tongtien] [float] NOT NULL,
 CONSTRAINT [PK_tblHoadonnhap] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachhang]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachhang](
	[MaKH] [nvarchar](10) NOT NULL,
	[Tenkhach] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Dienthoai] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tblKhachhang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhoiluong]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhoiluong](
	[Makhoiluong] [nvarchar](10) NOT NULL,
	[Tenkhoiluong] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblKhoiluong] PRIMARY KEY CLUSTERED 
(
	[Makhoiluong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoai]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoai](
	[Maloai] [nvarchar](10) NOT NULL,
	[Tenloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblLoai] PRIMARY KEY CLUSTERED 
(
	[Maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMausac]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMausac](
	[Mamau] [nvarchar](10) NOT NULL,
	[Tenmau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblMausac] PRIMARY KEY CLUSTERED 
(
	[Mamau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMua]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMua](
	[Mamua] [nvarchar](10) NOT NULL,
	[Tenmua] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblMua] PRIMARY KEY CLUSTERED 
(
	[Mamua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhacungcap]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhacungcap](
	[MaNCC] [nvarchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](200) NOT NULL,
	[Dienthoai] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tblNhacungcap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[Gioitinh] [nvarchar](10) NOT NULL,
	[Ngaysinh] [date] NOT NULL,
	[Dienthoai] [nvarchar](15) NOT NULL,
	[Diachi] [nvarchar](200) NOT NULL,
	[MaCV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblNhanvien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNuocsanxuat]    Script Date: 6/7/2024 3:32:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNuocsanxuat](
	[Manuocsx] [nvarchar](10) NOT NULL,
	[Tennuocsx] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNuocsanxuat] PRIMARY KEY CLUSTERED 
(
	[Manuocsx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChatlieu] ([Machatlieu], [Tenchatlieu]) VALUES (N'MT01', N'Chất gel')
INSERT [dbo].[tblChatlieu] ([Machatlieu], [Tenchatlieu]) VALUES (N'MT02', N'Chất lỏng ')
INSERT [dbo].[tblChatlieu] ([Machatlieu], [Tenchatlieu]) VALUES (N'MT03', N'Kem')
INSERT [dbo].[tblChatlieu] ([Machatlieu], [Tenchatlieu]) VALUES (N'MT04', N'Phấn')
GO
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD001', N'PROD01', 1, 0.1, 144000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD001', N'PROD05', 2, NULL, 520000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD001', N'PROD09', 4, 0.05, 1216000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD002', N'PROD02', 1, NULL, 224000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD002', N'PROD08', 2, 0.2, 180000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD003', N'PROD10', 3, 0.3, 483000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD004', N'PROD05', 5, NULL, 1300000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD005', N'PROD06', 4, NULL, 720000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD005', N'PROD15', 3, NULL, 1050000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD006', N'PROD12', 1, 0.3, 105000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD007', N'PROD13', 4, 0.1, 2520000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD008', N'PROD14', 2, NULL, 260000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD008', N'PROD20', 6, NULL, 900000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD009', N'PROD08', 5, 0.2, 560000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD010', N'PROD09', 1, 0.05, 304000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD011', N'PROD18', 2, NULL, 360000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD011', N'PROD20', 4, NULL, 600000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD012', N'PROD01', 3, 0.1, 432000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD012', N'PROD03', 3, NULL, 540000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD014', N'PROD10', 1, 0.3, 161000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD015', N'PROD12', 2, 0.3, 210000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD016', N'PROD13', 2, 0.1, 1260000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD016', N'PROD19', 4, NULL, 520000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD017', N'PROD09', 5, 0.05, 1520000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD018', N'PROD12', 7, 0.3, 735000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD019', N'PROD04', 9, NULL, 2070000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD019', N'PROD06', 2, NULL, 360000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD020', N'PROD17', 5, NULL, 1150000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD02062024163300', N'PROD06', 2, 0, 360000)
INSERT [dbo].[tblChitiethoadonban] ([SoHDB], [Mahang], [Soluong], [Giamgia], [Thanhtien]) VALUES (N'ORD07062024150858', N'PROD01', 20, 0.1, 2880000)
GO
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'I07062024151157', N'PROD01', 50, 100000, 0, 5000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT001', N'PROD02', 20, 120000, 0.15, 2040000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT001', N'PROD07', 25, 110000, NULL, 2750000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT002', N'PROD12', 10, 90000, 0.1, 810000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT003', N'PROD04', 20, 150000, NULL, 3000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT004', N'PROD01', 20, 100000, NULL, 2000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT004', N'PROD03', 15, 120000, NULL, 1800000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT005', N'PROD04', 30, 150000, NULL, 4500000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT005', N'PROD05', 20, 150000, 0.1, 2700000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT006', N'PROD06', 25, 120000, NULL, 3000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT007', N'PROD08', 50, 90000, NULL, 4500000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT008', N'PROD01', 20, 100000, 0.1, 1800000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT008', N'PROD09', 28, 170000, NULL, 4760000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT008', N'PROD10', 60, 160000, NULL, 9600000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT008', N'PROD11', 45, 140000, NULL, 6300000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT008', N'PROD19', 40, 80000, NULL, 3200000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT009', N'PROD13', 30, 450000, NULL, 13500000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT009', N'PROD17', 20, 150000, NULL, 3000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT010', N'PROD16', 35, 170000, NULL, 5950000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT011', N'PROD04', 15, 150000, NULL, 2250000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT012', N'PROD18', 50, 120000, NULL, 6000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT013', N'PROD02', 20, 120000, 0.15, 2040000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT013', N'PROD06', 25, 120000, NULL, 3000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT013', N'PROD09', 30, 170000, NULL, 5100000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT013', N'PROD20', 10, 100000, NULL, 1000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT014', N'PROD04', 30, 150000, NULL, 4500000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT014', N'PROD08', 35, 90000, NULL, 3150000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT015', N'PROD02', 20, 120000, 0.15, 2040000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT015', N'PROD09', 10, 170000, NULL, 1700000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT015', N'PROD16', 15, 170000, NULL, 2550000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT016', N'PROD03', 20, 120000, NULL, 2400000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT017', N'PROD02', 40, 120000, 0.15, 4080000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT017', N'PROD06', 50, 120000, NULL, 6000000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT018', N'PROD08', 35, 90000, NULL, 3150000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT019', N'PROD07', 35, 110000, 0.2, 3080000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT019', N'PROD12', 10, 90000, NULL, 900000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT019', N'PROD15', 20, 180000, NULL, 3600000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT019', N'PROD17', 35, 150000, NULL, 5250000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT020', N'PROD03', 50, 120000, 0.1, 5400000)
INSERT [dbo].[tblChitiethoadonnhap] ([SoHDN], [Mahang], [Soluong], [Dongianhap], [Giamgia], [Thanhtien]) VALUES (N'IMPORT020', N'PROD19', 20, 80000, NULL, 1600000)
GO
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR01', N'Trang điểm mắt')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR02', N'Trang điểm môi')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR03', N'Làm sạch da mặt')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR04', N'Cấp ẩm chuyên sâu')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR05', N'Sữa dưỡng ẩm')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR06', N'Trị mụn')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR07', N'Làm sạch da body')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR08', N'Căng bóng da')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR09', N'Dưỡng da body')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR10', N'Chống nắng')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR11', N'Chăm sóc tóc')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR12', N'Chăm sóc móng')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR13', N'Làm trắng da')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR14', N'Trị nám')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR15', N'Tẩy tế bào chết')
INSERT [dbo].[tblCongdung] ([Macongdung], [Tencongdung]) VALUES (N'PUR16', N'Khử mùi')
GO
INSERT [dbo].[tblCongviec] ([MaCV], [TenCV], [Mucluong]) VALUES (N'POS01', N'Quản lý cửa hàng', 12000000)
INSERT [dbo].[tblCongviec] ([MaCV], [TenCV], [Mucluong]) VALUES (N'POS02', N'Nhân viên bán hàng', 7000000)
INSERT [dbo].[tblCongviec] ([MaCV], [TenCV], [Mucluong]) VALUES (N'POS03', N'Nhân viên trực page', 5000000)
INSERT [dbo].[tblCongviec] ([MaCV], [TenCV], [Mucluong]) VALUES (N'POS04', N'Kế toán', 8000000)
INSERT [dbo].[tblCongviec] ([MaCV], [TenCV], [Mucluong]) VALUES (N'POS05', N'Thu ngân', 5000000)
INSERT [dbo].[tblCongviec] ([MaCV], [TenCV], [Mucluong]) VALUES (N'POS06', N'Nhân viên kho', 7000000)
INSERT [dbo].[tblCongviec] ([MaCV], [TenCV], [Mucluong]) VALUES (N'POS07', N'Bảo vệ', 4000000)
GO
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD01', N'Kem dưỡng ẩm La Roche Posay', N'TP01', N'QTT03', N'PD01', N'MT03', N'PUR04', N'SEASON01', N'CL05', N'CT01', 280, 100000, 110000.00000000002, 6, N'C:\Users\LAPTOP88\Pictures\Project NET\mypham.png', N'Phù hợp mọi loại da
')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD02', N'Kem dưỡng ẩm Paula''s Choice', N'TP01', N'QTT06', N'PD04', N'MT03', N'PUR04', N'SEASON02', N'CL05', N'CT02', 230, 120000, 132000, 6, N'C:\Users\LAPTOP88\Pictures\Project NET\mypham.png', N'Phù hợp mọi loại da')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD03', N'Kem chống nắng skin Aqua', N'TP02', N'QTT02', N'PD02', N'MT03', N'PUR10', N'SEASON03', N'CL06', N'CT03', 350, 120000, 132000, 12, N'C:\Users\LAPTOP88\Pictures\Project NET\mypham.png', N'Phù hợp cho da dầu')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD04', N'Kem chống nắng Anessa', N'TP02', N'QTT03', N'PD05', N'MT03', N'PUR10', N'SEASON04', N'CL05', N'CT04', 320, 150000, 165000, 3, N'C:\Users\LAPTOP88\Pictures\Project NET\mypham.png', N'Phù hợp mọi loại da')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD05', N'Toner Paula''s Choice', N'TP03', N'QTT02', N'PD04', N'MT02', N'PUR03', N'SEASON01', N'CL07', N'CT02', 200, 150000, 165000, 4, N'C:\Users\LAPTOP88\Pictures\Project NET\mypham.png', N'Phù hợp mọi loại da')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD06', N'Tẩy da chết Dove', N'TP04', N'QTT09', N'PD03', N'MT02', N'PUR15', N'SEASON02', N'CL06', N'CT06', 228, 120000, 132000, 12, N'C:\Users\LAPTOP88\Pictures\Project NET\mypham.png', N'Phù hợp mọi loại da')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD07', N'Sữa rửa mặt Simple', N'TP05', N'QTT03', N'PD08', N'MT01', N'PUR03', N'SEASON03', N'CL05', N'CT07', 200, 110000, 121000.00000000002, 6, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Phù hợp mọi loại da')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD08', N'Sữa rửa mặt Cerave', N'TP05', N'QTT02', N'PD12', N'MT03', N'PUR03', N'SEASON04', N'CL06', N'CT08', 230, 90000, 99000.000000000015, 6, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Phù hợp mọi loại da')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD09', N'Serum dưỡng trắng Klairs', N'TP06', N'QTT01', N'PD06', N'MT02', N'PUR13', N'SEASON01', N'CL08', N'CT10', 350, 170000, 187000.00000000003, 12, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Hiệu quả dùng ban đêm')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD10', N'Serum trị mụn B.O.M', N'TP07', N'QTT03', N'PD09', N'MT02', N'PUR06', N'SEASON02', N'CL06', N'CT11', 200, 160000, 176000, 3, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Đọc kĩ trước khi dùng')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD11', N'Kem dưỡng da Green Tea', N'TP08', N'QTT09', N'PD20', N'MT03', N'PUR08', N'SEASON03', N'CL04', N'CT12', 150, 140000, 154000, 4, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Sản phẩm dùng hàng ngày')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD12', N'Son lỳ Merzy', N'TP09', N'QTT07', N'PD07', N'MT05', N'PUR02', N'SEASON05', N'CL01', N'CT13', 500, 90000, 99000.000000000015, 12, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Phù hợp cho môi khô')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD13', N'Son Dior', N'TP09', N'QTT10', N'PD11', N'MT05', N'PUR02', N'SEASON06', N'CL09', N'CT14', 420, 450000, 495000.00000000006, 12, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Đọc kĩ trước khi dùng')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD14', N'Son dưỡng', N'TP09', N'QTT07', N'PD11', N'MT05', N'PUR02', N'SEASON05', N'CL02', N'CT15', 360, 70000, 77000, 12, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Dùng cho cả ngày và đêm')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD15', N'Kem trị nám Laneige', N'TP10', N'QTT08', N'PD13', N'MT03', N'PUR14', N'SEASON01', N'CL05', N'CT01', 120, 180000, 198000.00000000003, 12, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Đọc kĩ trước khi dùng')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD16A', N'Kem trị nám Nacos', N'TP10', N'QTT03', N'PD15', N'MT03', N'PUR14', N'SEASON02', N'CL08', N'CT02', 160, 170000, 187000.00000000003, 3, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Đọc kĩ trước khi dùng')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD17', N'Dầu dưỡng tóc L''Oreal', N'TP11', N'QTT01', N'PD10', N'MT01', N'PUR17', N'SEASON04', N'CL08', N'CT03', 120, 150000, 165000, 4, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Hiệu quả cho tóc gãy dụng')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD18', N'Sữa tắm Dove', N'TP12', N'QTT04', N'PD03', N'MT03', N'PUR07', N'SEASON05', N'CL05', N'CT06', 80, 120000, 132000, 12, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Phù hợp với mọi loại da')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD19', N'Phấn mắt Missha', N'TP13', N'QTT09', N'PD14', N'MT04', N'PUR01', N'SEASON06', N'CL10', N'CT05', 70, 80000, 88000, 6, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'An toàn cho mắt')
INSERT [dbo].[tblHanghoa] ([Mahang], [Tenhang], [Maloai], [Makhoiluong], [Mahangsx], [Machatlieu], [Macongdung], [Mamua], [Mamau], [ManuocSX], [Soluong], [Dongianhap], [Dongiaban], [Thoigianbaohanh], [Anh], [Ghichu]) VALUES (N'PROD20', N'Dầu dưỡng móng', N'TP14', N'QTT08', N'PD18', N'MT01', N'PUR12', N'SEASON05', N'CL06', N'CT06', 120, 100000, 110000.00000000002, 6, N'C:\Users\LAPTOP88\Pictures\simple.jpg', N'Đọc kĩ trước khi dùng')
GO
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD01', N'La Roche Posay

')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD02', N'Skin Aqua')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD03', N'Dove')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD04', N'Paula''s Choice
')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD05', N'Anessa ')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD06', N'Klairs')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD07', N'Merzy')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD08', N'Simple')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD09', N'B.O.M')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD10', N'L''Oreal')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD11', N'Dior')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD12', N'Cerave')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD13', N'Laneige')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD14', N'Missha ')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD15', N'Nacos')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD16', N'Vichy')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD17', N'Maybelline')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD18', N'Cocoon')
INSERT [dbo].[tblHangsanxuat] ([Mahangsx], [Tenhangsx]) VALUES (N'PD19', N'Bioderma')
GO
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'0RD002', N'EMP002', CAST(N'2024-02-05T00:00:00.000' AS DateTime), N'CUS003', 292000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD001
', N'EMP001', CAST(N'2024-01-01T00:00:00.000' AS DateTime), N'CUS002', 708000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD003', N'EMP003', CAST(N'2024-03-10T00:00:00.000' AS DateTime), N'CUS004', 161000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD004', N'EMP004', CAST(N'2024-04-15T00:00:00.000' AS DateTime), N'CUS006', 260000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD005', N'EMP005', CAST(N'2023-05-20T00:00:00.000' AS DateTime), N'CUS005', 530000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD006', N'EMP006', CAST(N'2023-06-25T00:00:00.000' AS DateTime), N'CUS007', 105000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD007', N'EMP007', CAST(N'2023-07-30T00:00:00.000' AS DateTime), N'CUS009', 630000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD008', N'EMP008', CAST(N'2023-11-17T00:00:00.000' AS DateTime), N'CUS010', 280000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD009', N'EMP009', CAST(N'2023-01-03T00:00:00.000' AS DateTime), N'CUS008', 112000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD010', N'EMP010', CAST(N'2024-02-07T00:00:00.000' AS DateTime), N'CUS001', 304000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD011', N'EMP011', CAST(N'2023-06-27T00:00:00.000' AS DateTime), N'CUS002', 330000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD012', N'EMP012', CAST(N'2023-05-22T00:00:00.000' AS DateTime), N'CUS003', 324000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD013', N'EMP013', CAST(N'2023-07-31T00:00:00.000' AS DateTime), N'CUS004', 230000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD014', N'EMP014', CAST(N'2023-10-15T00:00:00.000' AS DateTime), N'CUS012', 161000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD015', N'EMP015', CAST(N'2023-12-25T00:00:00.000' AS DateTime), N'CUS013', 105000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD016', N'EMP016', CAST(N'2023-02-09T00:00:00.000' AS DateTime), N'CUS014
', 760000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD017', N'EMP017', CAST(N'2023-03-14T00:00:00.000' AS DateTime), N'CUS015', 304000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD018', N'EMP018', CAST(N'2023-04-19T00:00:00.000' AS DateTime), N'CUS020', 105000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD020', N'EMP019', CAST(N'2023-10-27T00:00:00.000' AS DateTime), N'CUS010', 230000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD02062024163300', N'EMP003', CAST(N'2024-06-02T00:00:00.000' AS DateTime), N'CUS002', 360000)
INSERT [dbo].[tblHoadonban] ([SoHDB], [MaNV], [Ngayban], [MaKH], [Tongtien]) VALUES (N'ORD07062024150858', N'EMP005', CAST(N'2024-06-07T00:00:00.000' AS DateTime), N'CUS005', 2880000)
GO
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'I07062024151157', N'EMP006', CAST(N'2024-06-07T00:00:00.000' AS DateTime), N'SUP06', 5000000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT001', N'EMP001', CAST(N'2023-01-04T08:10:00.000' AS DateTime), N'SUP15', 4790000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT002', N'EMP010', CAST(N'2023-01-25T16:30:00.000' AS DateTime), N'SUP01', 810000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT003', N'EMP005', CAST(N'2023-02-15T11:55:00.000' AS DateTime), N'SUP09', 3000000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT004', N'EMP010', CAST(N'2023-02-27T12:00:00.000' AS DateTime), N'SUP04', 7800000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT005', N'EMP005', CAST(N'2023-03-03T07:35:00.000' AS DateTime), N'SUP08', 7200000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT006', N'EMP001', CAST(N'2024-03-12T11:20:00.000' AS DateTime), N'SUP12', 3000000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT007', N'EMP001', CAST(N'2023-03-31T13:30:00.000' AS DateTime), N'SUP16', 4500000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT008', N'EMP005', CAST(N'2023-04-11T13:10:00.000' AS DateTime), N'SUP01', 25660000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT009', N'EMP001', CAST(N'2023-04-26T16:30:00.000' AS DateTime), N'SUP03', 18250000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT010', N'EMP010', CAST(N'2023-05-04T11:55:00.000' AS DateTime), N'SUP10', 5950000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT011', N'EMP005', CAST(N'2023-05-15T12:00:00.000' AS DateTime), N'SUP02', 5850000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT012', N'EMP005', CAST(N'2023-05-24T07:35:00.000' AS DateTime), N'SUP05', 6000000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT013', N'EMP005', CAST(N'2023-07-02T11:20:00.000' AS DateTime), N'SUP07', 15640000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT014', N'EMP010', CAST(N'2023-09-27T13:30:00.000' AS DateTime), N'SUP06', 7650000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT015', N'EMP001', CAST(N'2023-11-20T13:10:00.000' AS DateTime), N'SUP14
', 6290000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT016', N'EMP001', CAST(N'2023-12-25T16:30:00.000' AS DateTime), N'SUP11', 2400000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT017', N'EMP010', CAST(N'2024-01-17T11:55:00.000' AS DateTime), N'SUP12', 10080000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT018', N'EMP005', CAST(N'2023-02-09T12:00:00.000' AS DateTime), N'SUP01', 3150000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT019', N'EMP005', CAST(N'2023-03-03T07:35:00.000' AS DateTime), N'SUP13', 12830000)
INSERT [dbo].[tblHoadonnhap] ([SoHDN], [MaNV], [Ngaynhap], [MaNCC], [Tongtien]) VALUES (N'IMPORT020', N'EMP001', CAST(N'2024-04-10T11:20:00.000' AS DateTime), N'SUP09', 7000000)
GO
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS001', N'Đào Thị Hạnh', N'Tam Đảo, Vĩnh Phúc', N'(023) 942-8343')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS002', N'Điền Kiều Hồng Hạnh', N'Gia Lộc, Hải Dương', N'(098) 765-4321')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS003', N'Nguyễn Lâm Anh', N'Đông Anh, Hà Nội', N'(032) 910-3583')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS004', N'Phạm Phương Mai', N'Gia Lâm, Hà Nội', N'(098) 712-3456')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS005', N'Ngô Thùy Linh', N'Tiên Lữ, Hưng Yên', N'(098) 456-7953')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS006', N'Thái Bảo Linh', N'Bắc Hà, Lào Cai', N'(089) 012-3598')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS007', N'Vũ Linh Nga', N'Nga Sơn, Thanh Hóa', N'(088) 795-1627')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS008', N'Hoàng Thị Nga', N'Châu Thành, An Giang', N'(035) 558-5501')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS009', N'Mai Hồng Ngọc', N'Tam Dương, Vĩnh Phúc', N'(032) 487-9310')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS010', N'Trương Văn Long', N'Tĩnh Gia, Thanh Hóa', N'(031) 799-3346')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS011', N'Nguyễn Linh Chi', N'Văn Giang, Hưng Yên', N'(029) 148-9734')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS012', N'Hoàng Minh Châu', N'Duy Tiên, Hà Nam', N'(098) 745-9123')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS013', N'Đỗ Thùy An', N'Yên Minh, Hà Giang', N'(032) 165-7985')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS014', N'Bùi Hồng Minh', N'Kim Bôi, Hòa Bình', N'(086) 941-7001')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS015', N'Nguyễn Bảo An', N'Kỳ Sơn, Hòa Bình', N'(032) 024-5605')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS016', N'Đỗ Thanh Thư', N'Tiền Hải, Thái Bình', N'(088) 005-2346')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS017', N'Trịnh Yến Thư', N'Gia Viễn, Ninh Bình', N'(089) 011-4484')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS018', N'Đỗ Văn Nam', N'Đồng Văn, Hà Nam', N'(086) 892-2388')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS019', N'Nguyễn Minh Hải', N'Đống Đa, Hà Nội', N'(029) 103-5541')
INSERT [dbo].[tblKhachhang] ([MaKH], [Tenkhach], [Diachi], [Dienthoai]) VALUES (N'CUS020', N'Đào Minh Thư', N'Tam Dương, Vĩnh Phúc', N'(033) 510-2456')
GO
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT01', N'200ml')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT02', N'250ml')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT03', N'150ml')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT04', N'800g')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT05', N'1kg')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT06', N'400g')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT07', N'4g')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT08', N'20ml')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT09', N'300g')
INSERT [dbo].[tblKhoiluong] ([Makhoiluong], [Tenkhoiluong]) VALUES (N'QTT10', N'6g')
GO
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP01', N'Kem dưỡng ẩm')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP02', N'Kem chống nắng')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP03
', N'Toner')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP04', N'Tẩy da chết')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP05', N'Sữa rửa mặt')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP06', N'Serum dưỡng trắng')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP07', N'Serum trị mụn')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP08', N'Kem dưỡng da')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP09', N'Son')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP10', N'Kem trị nám')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP11', N'Dầu dưỡng tóc')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP12', N'Sữa tắm')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP13', N'Phấn mắt')
INSERT [dbo].[tblLoai] ([Maloai], [Tenloai]) VALUES (N'TP14', N'Dầu dưỡng móng')
GO
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL01', N'Màu đỏ')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL02', N'Màu hồng')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL03', N'Màu cam')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL04', N'Không màu')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL05', N'Màu trắng nhạt')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL06', N'Màu trắng đục')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL07', N'Màu trong suốt')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL08', N'Màu vàng nhạt ')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL09', N'Màu nâu đất')
INSERT [dbo].[tblMausac] ([Mamau], [Tenmau]) VALUES (N'CL10', N'Màu nude ')
GO
INSERT [dbo].[tblMua] ([Mamua], [Tenmua]) VALUES (N'SEASON01', N'Mùa xuân')
INSERT [dbo].[tblMua] ([Mamua], [Tenmua]) VALUES (N'SEASON02', N'Mùa hè')
INSERT [dbo].[tblMua] ([Mamua], [Tenmua]) VALUES (N'SEASON03', N'Mùa thu')
INSERT [dbo].[tblMua] ([Mamua], [Tenmua]) VALUES (N'SEASON04', N'Mùa đông')
INSERT [dbo].[tblMua] ([Mamua], [Tenmua]) VALUES (N'SEASON05', N'Mùa giáng sinh')
GO
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP01', N'iFree', N'Số 102 Đường số 3, Bình Hưng Hoà, Bình Tân, TPHCM', N'0942002020')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP02', N'ResHPCos', N'Số 412 Nguyễn Thị Minh Khai, phường 5, quận 3, TPHCM', N'0949996969')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP03', N'Dạ Lan', N'Số 37, Đường Số 4, Khu Cityland Garden, P. 5, Q. Gò Vấp, TPHCM', N'0914469955')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP04', N'SUP04
Kanna Cosmetics

', N'Số 18 Võ Thị Thừa, P.An Phú Đông, Quận 12, TPHCM', N'0918732999')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP05', N'Tân Ngọc Phát', N'85/7 Nguyễn Hữu Dật, phường Tây Thạnh, quận Tân Phú, TPHCM', N'0287106755')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP06', N'Lahy’s', N'Số 118 Đường 3/2, Phường 12, Quận 10, TPHCM', N'0909002147')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP07', N'Đại Việt Hương', N'Số 111 Nguyễn Trãi, Quận 1, TPHCM', N'0763999063')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP08', N'EARTH CORPORATION ', N'Số 285 Cách Mạng Tháng Tám, Phường 12, Quận 10, TPHCM', N'0286256071')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP09', N'Hani', N'Số 43, Nguyễn Bá Tòng, P.11, Q.Tân Bình, TPHCM', N'0262874093')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP10', N'Viet Huong Cosmetics Factory', N'Cụm Công Nghiệp Triều Khúc, Tân Triều, Thanh Trì, Hà Nội
', N'0967124923')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP11', N'Vincos Vietnam', N'Tầng 11 tháp C Số 219 Trung Kính, Phường Yên Hoà, Quận Cầu Giấy, Hà Nội', N'0243210202')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP12', N'Gamma', N'Số 18 Nguyễn Hậu, Phường Tân Thành, Quận Tân Phú, TPHCM', N'0283123909')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP13', N'Shizencos', N'Một Phần Lô D, Khu Công Nghiệp Hòa Xá, Mỹ Xá, Nam Định', N'0228652666')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP14', N'3C', N'48/5 Lê Duẩn, Q. Hải Châu,Tp. Đà Nẵng', N'033282496')
INSERT [dbo].[tblNhacungcap] ([MaNCC], [TenNCC], [Diachi], [Dienthoai]) VALUES (N'SUP16', N'Bena', N'Lô A1-A2, Nam Trân, Hòa Minh, Liên Chiểu, Đà Nẵng', N'0511769797')
GO
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP001', N'Nguyễn Văn An', N'Nam
', CAST(N'1990-12-05' AS Date), N'0357620832', N'Hoàn Kiếm, Hà Nội', N'POS06')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP002', N'Trần Hải Đăng', N'Nam', CAST(N'1987-04-23' AS Date), N'0943720895
', N'Tây Hồ, Hà Nội', N'POS01')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP003', N'Phạm Thị Thúy
', N'Nữ', CAST(N'1994-08-08' AS Date), N'0396535461', N'Đống Đa, Hà Nội', N'POS02')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP004', N'Nguyễn Hoàng Hải', N'Nam', CAST(N'1995-06-11' AS Date), N'0918999245', N'Đống Đa, Hà Nội', N'POS02')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP005', N'Đồng Minh Lâm', N'Nam', CAST(N'1996-07-10' AS Date), N'0374065174', N'Hai Bà Trưng, Hà Nội', N'POS06')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP006', N'Vũ Văn Thanh', N'Nam', CAST(N'1969-05-11' AS Date), N'0912245111', N'Cầu Giấy, Hà Nội', N'POS07')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP007', N'Hà Minh Ngọc', N'Nữ
', CAST(N'1994-08-08' AS Date), N'0919451988', N'Hai Bà Trưng, Hà Nội', N'POS01')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP008', N'Hà Quang Thắng', N'Nam', CAST(N'1994-08-08' AS Date), N'0919451988', N'Hai Bà Trưng, Hà Nội', N'POS01')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP009', N'Vũ Hồng Ngọc', N'Nữ', CAST(N'1999-04-25' AS Date), N'0919162567
', N'Thanh Xuân, Hà Nội', N'POS04')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP010', N'Nguyễn Mai Hoa', N'Nữ', CAST(N'1994-04-03' AS Date), N'0889341995', N'Bắc Từ Liêm, Hà Nội', N'POS06')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP011', N'Hoàng Diệu Linh', N'Nữ', CAST(N'1994-08-24' AS Date), N'0329503026', N'Hai Bà Trưng, Hà Nội', N'POS02')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP012', N'Mai Thảo Nhi', N'Nữ', CAST(N'2000-05-06' AS Date), N'0915782001', N'Cầu Giấy, Hà Nội', N'POS04')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP013', N'Vũ Minh Duy', N'Nam', CAST(N'1987-06-09' AS Date), N'0916476060', N'Hoàn Kiếm, Hà Nội', N'POS07
')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP014', N'Nguyễn Thanh Phong', N'Nam', CAST(N'1996-10-16' AS Date), N'0357400346', N'Cầu Giấy, Hà Nội', N'POS02')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP015', N'Nguyễn Hà Trang', N'Nữ', CAST(N'1998-06-25' AS Date), N'0917942006', N'Hoàn Kiếm, Hà Nội
', N'POS05
')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP016', N'Hoàng Thùy Linh', N'Nữ', CAST(N'1994-09-18' AS Date), N'0372785376', N'Cầu Giấy, Hà Nội', N'POS03')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP017', N'Nguyễn Thị Mây', N'Nữ', CAST(N'1997-05-20' AS Date), N'086429401

', N'Hai Bà Trưng, Hà Nội', N'POS05')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP018', N'Hà Thúy Vân', N'Nữ', CAST(N'2000-09-10' AS Date), N'0917402009', N'Thanh Xuân, Hà Nội', N'POS03')
INSERT [dbo].[tblNhanvien] ([MaNV], [TenNV], [Gioitinh], [Ngaysinh], [Dienthoai], [Diachi], [MaCV]) VALUES (N'EMP019', N'Đồng Thị Mỹ Lệ', N'Nữ', CAST(N'1996-09-20' AS Date), N'0889526363', N'Thanh Xuân, Hà Nội', N'POS02')
GO
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT01', N'Pháp')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT02', N'Hàn Quốc')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT03', N'Việt Nam')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT04', N'Nhật Bản')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT05', N'Trung Quốc')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT06', N'Mỹ')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT07', N'Ý')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT08', N'Anh')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT09', N'Úc')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT10', N'Đức')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT11', N'Canada
')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT12', N'Thụy Điển')
INSERT [dbo].[tblNuocsanxuat] ([Manuocsx], [Tennuocsx]) VALUES (N'CT13
', N'Hà Lan')
GO
ALTER TABLE [dbo].[tblHoadonban]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonban_tblNhanvien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoadonban] CHECK CONSTRAINT [FK_tblHoadonban_tblNhanvien]
GO
ALTER TABLE [dbo].[tblHoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadonnhap_tblNhanvien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[tblHoadonnhap] CHECK CONSTRAINT [FK_tblHoadonnhap_tblNhanvien1]
GO
USE [master]
GO
ALTER DATABASE [CuaHangMyPham] SET  READ_WRITE 
GO
