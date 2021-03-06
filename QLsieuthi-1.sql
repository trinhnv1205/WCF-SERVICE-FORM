USE [QLsieuthi]
GO
/****** Object:  Table [dbo].[BANHANG]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANHANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [char](15) NULL,
	[MaSP] [char](15) NULL,
	[TenSP] [nchar](30) NULL,
	[MaKH] [char](15) NULL,
	[MaNCC] [char](15) NULL,
	[Ngayban] [char](20) NULL,
	[Soluong] [int] NULL,
	[Gia] [int] NULL,
	[Ghichu] [nchar](50) NULL,
	[Thanhtien] [int] NULL,
 CONSTRAINT [PK__BANHANG__2725A6E0E76BFD49] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DULIEUBAN]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DULIEUBAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [nchar](15) NULL,
	[MaSP] [nchar](15) NULL,
	[TenSP] [nchar](30) NULL,
	[MaKH] [nchar](15) NULL,
	[MaNCC] [nchar](15) NULL,
	[Ngayban] [nchar](20) NULL,
	[Soluong] [int] NULL,
	[Gia] [int] NULL,
	[Ghichu] [nchar](50) NULL,
	[Thanhtien] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DULIEUNHAP]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DULIEUNHAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieu] [nchar](15) NULL,
	[MaSP] [nchar](15) NULL,
	[TenSP] [nchar](30) NULL,
	[MaNCC] [nchar](15) NULL,
	[Ngaynhap] [nchar](20) NULL,
	[Soluong] [int] NULL,
	[Gianhap] [int] NULL,
	[Thanhtien] [int] NULL,
	[Ghichu] [nchar](50) NULL,
 CONSTRAINT [PK_DULIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [char](15) NOT NULL,
	[TenKH] [nchar](50) NULL,
	[Diachi] [nchar](30) NULL,
	[Sdt] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NCC](
	[MaNCC] [char](15) NOT NULL,
	[TenNCC] [nchar](30) NULL,
	[Diachi] [nchar](30) NULL,
	[Sdt] [char](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](10) NOT NULL,
	[Hoten] [nchar](50) NULL,
	[Ngaysinh] [char](20) NULL,
	[Diachi] [nchar](40) NULL,
	[Sdt] [char](15) NULL,
	[Chucvu] [nchar](20) NULL,
	[Luongcb] [int] NULL,
	[Phucap] [int] NULL,
	[thuong] [int] NULL,
	[Luong] [int] NULL,
 CONSTRAINT [PK__NHANVIEN__2725D70A2822FAB0] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAPSP]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAPSP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieu] [char](15) NULL,
	[MaSP] [char](15) NULL,
	[TenSP] [nchar](30) NULL,
	[MaNCC] [char](15) NULL,
	[Ngaynhap] [char](20) NULL,
	[Soluong] [int] NULL,
	[Gianhap] [int] NULL,
	[Thanhtien] [int] NULL,
	[Ghichu] [nchar](50) NULL,
 CONSTRAINT [PK__NHAPSP__2660BFE0D70B634F] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SP]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SP](
	[MaSP] [char](15) NOT NULL,
	[TenSP] [nchar](30) NULL,
	[MaNCC] [char](15) NULL,
	[Soluong] [int] NULL,
	[Gia] [int] NULL,
	[Ghichu] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 3/13/2017 7:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenTK] [nchar](30) NOT NULL,
	[MK] [nchar](30) NULL,
	[CV] [nchar](30) NULL,
	[Fullname] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DULIEUBAN] ON 

INSERT [dbo].[DULIEUBAN] ([ID], [MaHD], [MaSP], [TenSP], [MaKH], [MaNCC], [Ngayban], [Soluong], [Gia], [Ghichu], [Thanhtien]) VALUES (3, N'49581          ', N'SP003          ', N'Bột giặt Omo                  ', N'KH001          ', N'NCC07          ', N'13/3/2017           ', 4, 65000, N'Đv: Túi                                           ', 260000)
INSERT [dbo].[DULIEUBAN] ([ID], [MaHD], [MaSP], [TenSP], [MaKH], [MaNCC], [Ngayban], [Soluong], [Gia], [Ghichu], [Thanhtien]) VALUES (4, N'49581          ', N'SP005          ', N'Nước ngọt Cocacola            ', N'KH001          ', N'NCC02          ', N'13/3/2017           ', 3, 15000, N'Đv: Chai                                          ', 60000)
INSERT [dbo].[DULIEUBAN] ([ID], [MaHD], [MaSP], [TenSP], [MaKH], [MaNCC], [Ngayban], [Soluong], [Gia], [Ghichu], [Thanhtien]) VALUES (5, N'49581          ', N'SP005          ', N'Nước ngọt Cocacola            ', N'KH001          ', N'NCC02          ', N'13/3/2017           ', 4, 15000, N'Đv: Chai                                          ', 60000)
SET IDENTITY_INSERT [dbo].[DULIEUBAN] OFF
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [Diachi], [Sdt]) VALUES (N'KH001          ', N'Đặng Tuấn Linh                                    ', N'296 Minh Khai,HBT,HN          ', N'01298081195         ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [Diachi], [Sdt]) VALUES (N'KH002          ', N'Hoàng Văn Tuấn                                    ', N'345 Minh Khai,HBT,HN          ', N'019865894           ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [Diachi], [Sdt]) VALUES (N'KH010          ', N'Lê Quang Phong                                    ', N'Lò Đúc                        ', N'1564165465          ')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [Diachi], [Sdt]) VALUES (N'KH015          ', N'Bùi Quang Tuấn                                    ', N'Sóc Sơn                       ', N'0198625677          ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC01          ', N'Pepsi                         ', N'123 Minh Khai, HBT, HN        ', N'0435986878     ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC02          ', N'Cocacola                      ', N'34 Hoàng Hoa Thám, Ba Đình, HN', N'043986598      ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC03          ', N'Tường An                      ', N'60 Lê Thánh Tông, HBT,HN      ', N'043673554      ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC04          ', N'Vinamilk                      ', N'320 Đại La, HBT,HN            ', N'043985986      ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC05          ', N'Bia Hà Nội                    ', N'99 Minh Khai,HBT,HN           ', N'043598628      ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC06          ', N'Chinsufood                    ', N'370 Bạch Mai,HBT,HN           ', N'043259862      ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC07          ', N'Omo                           ', N'KCN Bắc Thăng Long,HN         ', N'047895623      ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC08          ', N'Neptune                       ', N'130 Thái Hà, Đống Đa,HN       ', N'043698598      ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC09          ', N'Vina Acecook                  ', N'Tân Bình, Tân Phú,HCM         ', N'0838154064     ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC10          ', N'Phân phối Phát Việt           ', N'12A Thái Hà, Đống Đa, HN      ', N'0436985621     ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC11          ', N'Ajinomoto                     ', N'74 Minh Khai, Q3, HCM         ', N'0839586789     ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC12          ', N'Hải Hà- Kotobuki              ', N'25 Trương Định,BHT,HN         ', N'0439856121     ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC13          ', N'Yakult Vietnam                ', N' KCN VN-Singapo,Bình Dương    ', N'0837598623     ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC14          ', N'Công ty Phân phối Hoàng Hà    ', N'30 Lò Đúc,HBT,HN              ', N'0435698203     ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC15          ', N'Quang Tuấn                    ', N'123 Minh Khai, HBT, HN        ', N'043598687      ')
INSERT [dbo].[NCC] ([MaNCC], [TenNCC], [Diachi], [Sdt]) VALUES (N'NCC16          ', N'Giấy VS Hoàng Hà              ', N'234 Trần Hữu Tước             ', N'04895325       ')
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [Sdt], [Chucvu], [Luongcb], [Phucap], [thuong], [Luong]) VALUES (N'NV001     ', N'Đặng Tuấn Linh                                    ', N'08/11/1995          ', N'Yên Bái                                 ', N'01298081195    ', N'Quản lý             ', 4500000, 1500000, 500000, 6500000)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [Sdt], [Chucvu], [Luongcb], [Phucap], [thuong], [Luong]) VALUES (N'NV002     ', N'Bùi Quang Tuấn                                    ', N'22/01/1994          ', N'Hà Nội                                  ', N'0123456789     ', N'Nhân viên kho       ', 3000000, 1000000, 0, 4000000)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [Sdt], [Chucvu], [Luongcb], [Phucap], [thuong], [Luong]) VALUES (N'NV003     ', N'Phạm Ngọc Tân                                     ', N'07/08/1995          ', N'Hải Dương                               ', N'01239865485    ', N'Nhân viên BH        ', 3000000, 800000, 300000, 4100000)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [Sdt], [Chucvu], [Luongcb], [Phucap], [thuong], [Luong]) VALUES (N'NV004     ', N'Lê Văn Hồng                                       ', N'01/09/1995          ', N'Hà Nội                                  ', N'01886546154    ', N'Nhân viên BH        ', 3000000, 800000, 100000, 3900000)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [Sdt], [Chucvu], [Luongcb], [Phucap], [thuong], [Luong]) VALUES (N'NV005     ', N'Trần Thị Hoa                                      ', N'06/08/1995          ', N'Bắc Ninh                                ', N'0986589521     ', N'Nhân viên BH        ', 3000000, 800000, 200000, 4000000)
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [Sdt], [Chucvu], [Luongcb], [Phucap], [thuong], [Luong]) VALUES (N'NV006     ', N'Phạm Ngọc Tân                                     ', N'07/08/1995          ', N'Hải Dương                               ', N'01239865485    ', N'Nhân viên BH        ', 3000000, 800000, 300000, 4100000)
SET IDENTITY_INSERT [dbo].[NHAPSP] ON 

INSERT [dbo].[NHAPSP] ([ID], [MaPhieu], [MaSP], [TenSP], [MaNCC], [Ngaynhap], [Soluong], [Gianhap], [Thanhtien], [Ghichu]) VALUES (6, N'P001           ', N'SP020          ', N'Giấy ăn                       ', N'NCC16          ', N'13/03/2017          ', 200, 5000, 1000000, N'Đơn vị: Túi                                       ')
INSERT [dbo].[NHAPSP] ([ID], [MaPhieu], [MaSP], [TenSP], [MaNCC], [Ngaynhap], [Soluong], [Gianhap], [Thanhtien], [Ghichu]) VALUES (7, N'P002           ', N'SP021          ', N'Bia Hà Nội                    ', N'NCC05          ', N'13/03/2017          ', 50, 270000, 13500000, N'Đơn vị: Két                                       ')
INSERT [dbo].[NHAPSP] ([ID], [MaPhieu], [MaSP], [TenSP], [MaNCC], [Ngaynhap], [Soluong], [Gianhap], [Thanhtien], [Ghichu]) VALUES (8, N'P003           ', N'SP022          ', N'dkfghjfgh                     ', N'NCC11          ', N'12/03/2017          ', 100, 30000, 3000000, N'Đv:fhgjfg                                         ')
INSERT [dbo].[NHAPSP] ([ID], [MaPhieu], [MaSP], [TenSP], [MaNCC], [Ngaynhap], [Soluong], [Gianhap], [Thanhtien], [Ghichu]) VALUES (9, N'P004           ', N'SP023          ', N'dfgdfg                        ', N'NCC12          ', N'12/03/2017          ', 10, 600000, 6000000, N'Đv: Chiếc                                         ')
SET IDENTITY_INSERT [dbo].[NHAPSP] OFF
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP001          ', N'Bia Hà Nội                    ', N'NCC05          ', 200, 240000, N'Đv: Két                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP0017         ', N'Bia heniken                   ', N'NCC05          ', 200, 240000, N'Đv: Két                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP002          ', N'Nước CoCa Cola                ', N'NCC05          ', 200, 8000, N'Đv: lon                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP003          ', N'Bột giặt Omo                  ', N'NCC07          ', 200, 65000, N'Đv: Túi                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP004          ', N'Nước Giặt Omo                 ', N'NCC07          ', 200, 74000, N'Đv: Chai                                          ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP005          ', N'Nước ngọt Cocacola            ', N'NCC02          ', 200, 15000, N'Đv: Chai                                          ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP006          ', N'Nước ngọt Sprite              ', N'NCC02          ', 200, 16000, N'Đv: Chai                                          ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP007          ', N'Nước ngọt Pepsi               ', N'NCC01          ', 200, 15000, N'Đv: Chai                                          ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP008          ', N'Bột canh Ajinomoto            ', N'NCC11          ', 200, 4000, N'Đv: Túi                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP009          ', N'Bột ngọt Ajinomoto            ', N'NCC11          ', 200, 6000, N'Đv: Túi                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP010          ', N'Kẹo sữa                       ', N'NCC12          ', 200, 24000, N'Đv: Túi                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP011          ', N'Sữa chua                      ', N'NCC04          ', 200, 22000, N'Đv: Lốc                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP012          ', N'Dầu ăn Tường An               ', N'NCC03          ', 200, 47000, N'Đv: Chai lớn                                      ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP013          ', N'Dầu ăn Neptune                ', N'NCC08          ', 200, 52000, N'Đv: Chai lớn                                      ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP014          ', N'Dầu ăn Tường An               ', N'NCC03          ', 200, 42000, N'Đv: Chai lớn                                      ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP015          ', N'Sữa chua uống Yakult          ', N'NCC13          ', 200, 12000, N'Đv: Lốc                                           ')
INSERT [dbo].[SP] ([MaSP], [TenSP], [MaNCC], [Soluong], [Gia], [Ghichu]) VALUES (N'SP016          ', N'Bánh Mì  tươi                 ', N'NCC05          ', 200, 240000, N'Đv: Túi                                           ')
INSERT [dbo].[TAIKHOAN] ([TenTK], [MK], [CV], [Fullname]) VALUES (N'ad1                           ', N'123456                        ', N'Admin                         ', N'Tài khoản Admin                                   ')
INSERT [dbo].[TAIKHOAN] ([TenTK], [MK], [CV], [Fullname]) VALUES (N'bh1                           ', N'123456                        ', N'BH                            ', N'Nhân viên Bán Hàng                                ')
INSERT [dbo].[TAIKHOAN] ([TenTK], [MK], [CV], [Fullname]) VALUES (N'kho1                          ', N'123456                        ', N'Kho                           ', N'Nhân viên Kho                                     ')
INSERT [dbo].[TAIKHOAN] ([TenTK], [MK], [CV], [Fullname]) VALUES (N'Kunbi                         ', N'08111995                      ', N'Admin                         ', N'Đặng Tuấn Linh                                    ')
INSERT [dbo].[TAIKHOAN] ([TenTK], [MK], [CV], [Fullname]) VALUES (N'Tan                           ', N'123456                        ', N'BH                            ', N'Phạm Ngọc Tân                                     ')
INSERT [dbo].[TAIKHOAN] ([TenTK], [MK], [CV], [Fullname]) VALUES (N'Tuan                          ', N'123456                        ', N'Kho                           ', N'Bùi Quang Tuấn Tuấn                               ')
ALTER TABLE [dbo].[BANHANG]  WITH CHECK ADD  CONSTRAINT [FK__BANHANG__MaKH__25869641] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[BANHANG] CHECK CONSTRAINT [FK__BANHANG__MaKH__25869641]
GO
ALTER TABLE [dbo].[BANHANG]  WITH CHECK ADD  CONSTRAINT [FK__BANHANG__MaSP__24927208] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SP] ([MaSP])
GO
ALTER TABLE [dbo].[BANHANG] CHECK CONSTRAINT [FK__BANHANG__MaSP__24927208]
GO
ALTER TABLE [dbo].[NHAPSP]  WITH CHECK ADD  CONSTRAINT [FK__NHAPSP__MaNCC__20C1E124] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NCC] ([MaNCC])
GO
ALTER TABLE [dbo].[NHAPSP] CHECK CONSTRAINT [FK__NHAPSP__MaNCC__20C1E124]
GO
ALTER TABLE [dbo].[SP]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NCC] ([MaNCC])
GO
