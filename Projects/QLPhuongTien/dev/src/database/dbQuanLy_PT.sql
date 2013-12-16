USE [QuanLy_PT]
GO
/****** Object:  Table [dbo].[NguyenMauPT]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NguyenMauPT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NguyenMauPT](
	[NguyenMauID] [nvarchar](50) NOT NULL,
	[NguyenMauTen] [nvarchar](50) NULL,
	[NhanHieu] [nvarchar](50) NULL,
	[NangLuc] [float] NULL,
	[DonVi] [nvarchar](50) NULL,
	[BDTX] [float] NULL,
	[TieuTu] [float] NULL,
	[TrungTu] [float] NULL,
	[DaiTu] [float] NULL,
	[NguyenMauChiTiet] [nvarchar](max) NULL,
 CONSTRAINT [PK_NguyenMau_PT] PRIMARY KEY CLUSTERED 
(
	[NguyenMauID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0001', N'XT', N'HuynDai', 2555, N'tan', 1000, 2000, 3000, 4000, N'gfdg')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0002', N'XL', N'Jiulong', 4, N't?n', 2000, 6000, 18000, 42000, N'Xe bánh dôi')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0003', N'MX', N'1', 1, N'1', 1, 1, 1, 1, N'1')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0004', N'XC', N'1', 1, N'1', 1, 1, 1, 1, N'1')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0005', N'XC', N'suzuki', 1, N'm3', 10000, 30000, 90000, 270000, N'fdsfd')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0006', N'XL', N'Hitachi', 10, N't?n', 500000, 1500000, 4500000, 13500000, N'tr?ng t?i l?n')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0007', N'XL', N'Hitachi', 10, N't?n', 100000, 300000, 900000, 2700000, N'Xe lu tr?ng t?i l?n ')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0008', N'XSG', N'Kumasut', 0,5, N'm3', 1000, 3000, 9000, 27000, N'chi tiet')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0009', N'XT', N'vinaxuki', 4, N'tan', 2000, 6000, 18000, 52000, N'l?p dôi')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0010', N'XT', N'vinaxuki', 4, N'tan', 1000, 3000, 9000, 27000, N'da')
INSERT [dbo].[NguyenMauPT] ([NguyenMauID], [NguyenMauTen], [NhanHieu], [NangLuc], [DonVi], [BDTX], [TieuTu], [TrungTu], [DaiTu], [NguyenMauChiTiet]) VALUES (N'NM0011', N'XL', N'vinaxuki', 10, N't?n', 1000, 3000, 9000, 27000, N'avd')
/****** Object:  Table [dbo].[LoaiPT]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoaiPT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LoaiPT](
	[LoaiPTMa] [nvarchar](50) NOT NULL,
	[LoaiPTTen] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiPT_1] PRIMARY KEY CLUSTERED 
(
	[LoaiPTMa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[LoaiPT] ([LoaiPTMa], [LoaiPTTen]) VALUES (N'MX', N'Máy xúc')
INSERT [dbo].[LoaiPT] ([LoaiPTMa], [LoaiPTTen]) VALUES (N'XC', N'Xe cần cẩu')
INSERT [dbo].[LoaiPT] ([LoaiPTMa], [LoaiPTTen]) VALUES (N'XL', N'Xe lu')
INSERT [dbo].[LoaiPT] ([LoaiPTMa], [LoaiPTTen]) VALUES (N'XMU', N'Máy ủi')
INSERT [dbo].[LoaiPT] ([LoaiPTMa], [LoaiPTTen]) VALUES (N'XSG', N'Xe san gạt')
INSERT [dbo].[LoaiPT] ([LoaiPTMa], [LoaiPTTen]) VALUES (N'XT', N'Xe tải')
/****** Object:  Table [dbo].[DonViTC]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DonViTC]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DonViTC](
	[DonViTCID] [nvarchar](50) NOT NULL,
	[DonViTCTen] [nvarchar](150) NULL,
	[DonViTCToTruong] [nvarchar](150) NULL,
	[Sdt] [int] NULL,
	[Email] [nvarchar](150) NULL,
 CONSTRAINT [PK_DonVi_TC] PRIMARY KEY CLUSTERED 
(
	[DonViTCID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[DonViTC] ([DonViTCID], [DonViTCTen], [DonViTCToTruong], [Sdt], [Email]) VALUES (N'DVTC0001', N'Ðon V? TC s? 1', N'Ngọc Tân', 1674567845, N'tan@gmail.com')
INSERT [dbo].[DonViTC] ([DonViTCID], [DonViTCTen], [DonViTCToTruong], [Sdt], [Email]) VALUES (N'DVTC0002', N'Ðon v? TC s? 2', N'Quang Cường', 974586931, N'cuong@gmail.com')
/****** Object:  Table [dbo].[DonViQuanLy]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DonViQuanLy]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DonViQuanLy](
	[DonViQLID] [nvarchar](50) NOT NULL,
	[DonViQLTen] [nvarchar](150) NULL,
	[DonViQLToTruong] [nvarchar](50) NULL,
	[Sdt] [int] NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonVi_QuanLy] PRIMARY KEY CLUSTERED 
(
	[DonViQLID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[DonViQuanLy] ([DonViQLID], [DonViQLTen], [DonViQLToTruong], [Sdt], [Email]) VALUES (N'DVQL0001', N'Đơn vị quản lý số 1', N'Chu Văn Bằng', 1674530973, N'bang200391@gmail.com')
INSERT [dbo].[DonViQuanLy] ([DonViQLID], [DonViQLTen], [DonViQLToTruong], [Sdt], [Email]) VALUES (N'DVQL0002', N'Đơn vị quản lý số 2', N'Nguyến Ngọc Tân', 938473235, N'tannn@gmail.com')
INSERT [dbo].[DonViQuanLy] ([DonViQLID], [DonViQLTen], [DonViQLToTruong], [Sdt], [Email]) VALUES (N'DVQL0003', N'Đơn vị quản lý số 3', N'Lê Quang Cường', 1738493945, N'cuonglv903@yahoo.com')
INSERT [dbo].[DonViQuanLy] ([DonViQLID], [DonViQLTen], [DonViQLToTruong], [Sdt], [Email]) VALUES (N'DVQL0004', N'Thuê ngoài', N'Lê Văn Vân', 948528495, N'van3004@gmail.com')
/****** Object:  Table [dbo].[DangNhap]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DangNhap]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DangNhap](
	[UserName] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[DangNhap] ([UserName], [Pass], [Ten]) VALUES (N'1', N'z', NULL)
INSERT [dbo].[DangNhap] ([UserName], [Pass], [Ten]) VALUES (N'a', N'a', N'Bằng')
/****** Object:  Table [dbo].[NhienLieu]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhienLieu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NhienLieu](
	[NhienLieuID] [nvarchar](50) NOT NULL,
	[NhienLieuTen] [nvarchar](150) NULL,
	[NhienLieuDungTich] [float] NULL,
	[NhienLieuDonVi] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_NhienLieu] PRIMARY KEY CLUSTERED 
(
	[NhienLieuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[NhienLieu] ([NhienLieuID], [NhienLieuTen], [NhienLieuDungTich], [NhienLieuDonVi], [GhiChu]) VALUES (N'1', N'Diezel', 1000, N'lít', N'dùng nhi?u')
INSERT [dbo].[NhienLieu] ([NhienLieuID], [NhienLieuTen], [NhienLieuDungTich], [NhienLieuDonVi], [GhiChu]) VALUES (N'2', N'Aq2', 500, N'lít', N'Dùng ? m?c d? v?a ph?i')
INSERT [dbo].[NhienLieu] ([NhienLieuID], [NhienLieuTen], [NhienLieuDungTich], [NhienLieuDonVi], [GhiChu]) VALUES (N'3', N'Hybrid', 600, N'lít', N'Nhiên li?u kép')
/****** Object:  Table [dbo].[PhuongTien]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhuongTien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhuongTien](
	[AutoNum] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiPT] [nvarchar](50) NULL,
	[PhuongTienID] [nvarchar](50) NOT NULL,
	[NguyenMauID] [nvarchar](50) NULL,
	[DonViQLID] [nvarchar](50) NULL,
	[DonViTCID] [nvarchar](50) NULL,
	[BienDK] [nvarchar](50) NULL,
	[NgayVH] [datetime] NULL,
	[LanBDTX] [int] NULL,
	[LanTieuTu] [int] NULL,
	[LanTrungTu] [int] NULL,
	[LanDaiTu] [int] NULL,
	[XuatXu] [nvarchar](50) NULL,
	[TongVH] [float] NULL,
 CONSTRAINT [PK_PhuongTien_1] PRIMARY KEY CLUSTERED 
(
	[PhuongTienID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[PhuongTien] ON
INSERT [dbo].[PhuongTien] ([AutoNum], [MaLoaiPT], [PhuongTienID], [NguyenMauID], [DonViQLID], [DonViTCID], [BienDK], [NgayVH], [LanBDTX], [LanTieuTu], [LanTrungTu], [LanDaiTu], [XuatXu], [TongVH]) VALUES (58, N'XT', N'XT1', N'MX', N'DVQL0001', N'DVTC0001', N'14444', CAST(0x0000A25500000000 AS DateTime), 1, 1, 1, 1, N'1', 1)
INSERT [dbo].[PhuongTien] ([AutoNum], [MaLoaiPT], [PhuongTienID], [NguyenMauID], [DonViQLID], [DonViTCID], [BienDK], [NgayVH], [LanBDTX], [LanTieuTu], [LanTrungTu], [LanDaiTu], [XuatXu], [TongVH]) VALUES (59, N'XT', N'XT59', N'MX', N'DVQL0002', N'DVTC0001', N'11111', CAST(0x0000A28B00000000 AS DateTime), 1, 1, 1, 1, N'1', 1)
INSERT [dbo].[PhuongTien] ([AutoNum], [MaLoaiPT], [PhuongTienID], [NguyenMauID], [DonViQLID], [DonViTCID], [BienDK], [NgayVH], [LanBDTX], [LanTieuTu], [LanTrungTu], [LanDaiTu], [XuatXu], [TongVH]) VALUES (62, N'XT', N'XT60', N'MX', N'DVQL0001', N'DVTC0001', N'XT-29L-2849', CAST(0x0000A17F00000000 AS DateTime), 2222, 0, 0, 0, N'Nh?t B?n', 5000)
SET IDENTITY_INSERT [dbo].[PhuongTien] OFF
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NhanVien](
	[NhanVienID] [nvarchar](50) NOT NULL,
	[NhanVienTen] [nvarchar](50) NULL,
	[NhanVienSdt] [nvarchar](50) NULL,
	[NhanVienEmail] [nvarchar](50) NULL,
	[NhanVienDC] [nvarchar](150) NULL,
	[PhuongTienID] [nvarchar](50) NULL,
	[DonViTCID] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[NhanVien] ([NhanVienID], [NhanVienTen], [NhanVienSdt], [NhanVienEmail], [NhanVienDC], [PhuongTienID], [DonViTCID]) VALUES (N'NV0001', N'1', N'2', N'3', N'4', NULL, N'DVTC0001')
INSERT [dbo].[NhanVien] ([NhanVienID], [NhanVienTen], [NhanVienSdt], [NhanVienEmail], [NhanVienDC], [PhuongTienID], [DonViTCID]) VALUES (N'NV0002', N'1', N'2', N'3', N'4', NULL, N'DVTC0001')
INSERT [dbo].[NhanVien] ([NhanVienID], [NhanVienTen], [NhanVienSdt], [NhanVienEmail], [NhanVienDC], [PhuongTienID], [DonViTCID]) VALUES (N'NV0003', N'1', N'1', N'1', N'1', NULL, N'DVTC0002')
/****** Object:  Table [dbo].[VanHanh]    Script Date: 12/16/2013 23:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VanHanh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[VanHanh](
	[VanHanhID] [nvarchar](50) NOT NULL,
	[PhuongTienID] [nvarchar](50) NOT NULL,
	[NgayVanHanh] [datetime] NULL,
	[VanHanh] [float] NULL,
	[VanHanhDV] [nvarchar](50) NULL,
	[CaLamViec] [int] NULL,
	[NhanVienID] [nvarchar](50) NULL,
	[DonViTCID] [nvarchar](50) NULL,
	[MoTa] [nvarchar](500) NULL,
 CONSTRAINT [PK_VanHanh] PRIMARY KEY CLUSTERED 
(
	[VanHanhID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  ForeignKey [FK_NhanVien_DonViTC]    Script Date: 12/16/2013 23:16:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NhanVien_DonViTC]') AND parent_object_id = OBJECT_ID(N'[dbo].[NhanVien]'))
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_DonViTC] FOREIGN KEY([DonViTCID])
REFERENCES [dbo].[DonViTC] ([DonViTCID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_NhanVien_DonViTC]') AND parent_object_id = OBJECT_ID(N'[dbo].[NhanVien]'))
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_DonViTC]
GO
/****** Object:  ForeignKey [FK_PhuongTien_DonViQuanLy]    Script Date: 12/16/2013 23:16:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhuongTien_DonViQuanLy]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhuongTien]'))
ALTER TABLE [dbo].[PhuongTien]  WITH CHECK ADD  CONSTRAINT [FK_PhuongTien_DonViQuanLy] FOREIGN KEY([DonViQLID])
REFERENCES [dbo].[DonViQuanLy] ([DonViQLID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhuongTien_DonViQuanLy]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhuongTien]'))
ALTER TABLE [dbo].[PhuongTien] CHECK CONSTRAINT [FK_PhuongTien_DonViQuanLy]
GO
/****** Object:  ForeignKey [FK_PhuongTien_DonViTC]    Script Date: 12/16/2013 23:16:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhuongTien_DonViTC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhuongTien]'))
ALTER TABLE [dbo].[PhuongTien]  WITH CHECK ADD  CONSTRAINT [FK_PhuongTien_DonViTC] FOREIGN KEY([DonViTCID])
REFERENCES [dbo].[DonViTC] ([DonViTCID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhuongTien_DonViTC]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhuongTien]'))
ALTER TABLE [dbo].[PhuongTien] CHECK CONSTRAINT [FK_PhuongTien_DonViTC]
GO
/****** Object:  ForeignKey [FK_VanHanh_NhanVien1]    Script Date: 12/16/2013 23:16:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VanHanh_NhanVien1]') AND parent_object_id = OBJECT_ID(N'[dbo].[VanHanh]'))
ALTER TABLE [dbo].[VanHanh]  WITH CHECK ADD  CONSTRAINT [FK_VanHanh_NhanVien1] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([NhanVienID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VanHanh_NhanVien1]') AND parent_object_id = OBJECT_ID(N'[dbo].[VanHanh]'))
ALTER TABLE [dbo].[VanHanh] CHECK CONSTRAINT [FK_VanHanh_NhanVien1]
GO
/****** Object:  ForeignKey [FK_VanHanh_PhuongTien]    Script Date: 12/16/2013 23:16:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VanHanh_PhuongTien]') AND parent_object_id = OBJECT_ID(N'[dbo].[VanHanh]'))
ALTER TABLE [dbo].[VanHanh]  WITH CHECK ADD  CONSTRAINT [FK_VanHanh_PhuongTien] FOREIGN KEY([PhuongTienID])
REFERENCES [dbo].[PhuongTien] ([PhuongTienID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_VanHanh_PhuongTien]') AND parent_object_id = OBJECT_ID(N'[dbo].[VanHanh]'))
ALTER TABLE [dbo].[VanHanh] CHECK CONSTRAINT [FK_VanHanh_PhuongTien]
GO
