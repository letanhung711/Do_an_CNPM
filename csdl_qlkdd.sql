Create database QLKDD
go

use QLKDD
go

Create table ChucVu
(
	MaCV		varchar(10) primary key,
	TenCV		nvarchar(50)	
)
go

Create table NhanVien
(
	MaNV		varchar(10) primary key,
	MK		    varchar(15),
	TenNV		nvarchar(50),
	NgaySinh	date,
	GioiTinh	int,
	DiaChi		nvarchar(50),
	SDT			varchar(20),	
	MaCV		varchar(10)
	Constraint PK_NV_CV Foreign key (MaCV) REFERENCES ChucVu(MaCV)
)
go

Create table LoaiKH
(
	MaLoai		varchar(10) primary key,
	TenLoai		nvarchar(50)	
)
go

Create table DienKe
(
	MaDK		varchar(10) primary key,
	NgayKyHD	date,
	NgayHieuLuc	date
)
go

Create table KhachHang
(
	MaKH		varchar(10) primary key,
	TenKH		nvarchar(50),
	SDT			int,
	MaLoai		varchar(10),
	Tenduong	nvarchar(50)
	Constraint PK_KH_LoaiKH Foreign key (MaLoai) REFERENCES LoaiKH(MaLoai)
)
go

Create table Hopdong
(
	MaHD		varchar(10) primary key,
	NgayKi		date,
	MaDK		varchar(10),
	MaKH		varchar(10)
	Constraint PK_Hd_DK Foreign key (MaDK) REFERENCES DienKe(MaDK),
	Constraint PK_Hd_KH Foreign key (MaKH) REFERENCES KhachHang(MaKH)
)
go

Create table BaoTri
(
	MaPBaoTri	varchar(10) primary key,
	TienBT		int,
	NgayBT		date,
	LyDo		nvarchar(50),
	MaDK		varchar(10),
	MaNV		varchar(10)
	Constraint PK_BT_DK Foreign key (MaDK) REFERENCES DienKe(MaDK),
	Constraint PK_BT_NV Foreign key (MaNV) REFERENCES NhanVien(MaNV)
)
go

Create table TieuThu
(
	MaTieuThu	varchar(10) primary key,
	TienDien	int,
	DienCu		int,
	DienMoi		int,
	Ngaynhap	date,
	MaKH		varchar(10),
	MaNV		varchar(10),
	MaDK		varchar(10)
	Constraint PK_TT_KH Foreign key (MaKH) REFERENCES KhachHang(MaKH),
	Constraint PK_TT_NV Foreign key (MaNV) REFERENCES NhanVien(MaNV),
	Constraint PK_TT_DK Foreign key (MaDK) REFERENCES DienKe(MaDK)
)
go

Create table HoaDon
(
	MaHD		varchar(10) primary key,
	Dot			int,
	TrangThai   nvarchar(50),
	NgayDocChiSo date,
	Ngaygui		date,
	NgayThuTien	date,
	MaKH		varchar(10),
	MaTieuThu	varchar(10)
	Constraint PK_HoaDon_KH Foreign key (MaKH) REFERENCES KhachHang(MaKH),
	Constraint PK_HoaDon_Tieuthu Foreign key (MaTieuThu) REFERENCES TieuThu(MaTieuThu)
)
go

--ChucVu--
Insert into ChucVu([MaCV],[TenCV]) values ('CV01',N'Quản lý')
Insert into ChucVu([MaCV],[TenCV]) values ('CV02',N'Nhân viên')
--loai khach hang---
Insert into LoaiKH([MaLoai],[TenLoai]) values ('SH',N'Điện sinh hoạt')
Insert into LoaiKH([MaLoai],[TenLoai]) values ('SX',N'Điện sản xuất')
--Dien ke---
insert into DienKe([MaDK],[NgayKyHD],[NgayHieuLuc]) values ('DK1','12/16/2022','12/16/2022')
---nhanvien---
Insert into NhanVien([MaNV],[TenNV],[GioiTinh],[DiaChi],[SDT],[MK],[MaCV],[NgaySinh]) values ('NV01',N'Lê Văn A',1,N'Tiền Giang',0453657825,'123','CV01','10/10/2022')
Insert into NhanVien([MaNV],[TenNV],[GioiTinh],[DiaChi],[SDT],[MK],[MaCV],[NgaySinh]) values ('NV02',N'Nguyễn Thị C',0,N'Long An',0765231756,'123','CV02','10/10/2022')
--khachhang---
Insert into KhachHang([MaKH],[TenKH],[SDT],[MaLoai],[Tenduong]) values ('KH01',N'Bùi Văn G','773773773','SH','803')
--hopdong--
Insert into Hopdong([MaHD],[MaKH],[MaDK],[NgayKi]) values ('HD01','KH01','DK1','12/16/2022')
--bao tri--
Insert into BaoTri([MaPBaoTri],[NgayBT],[TienBT],[LyDo],[MaDK],[MaNV]) values ('BT01','12/16/2022','100000',N'Thay đồng hồ','DK1','NV01')
--tieu thu--
Insert into TieuThu([MaTieuThu],[MaDK],[MaKH],[DienCu],[DienMoi],[Ngaynhap],[TienDien],[MaNV]) values ('TT01','DK1','KH01',102,104,'12/16/2022',1500000,'NV02')
--hoa don--
Insert into HoaDon([MaHD],[Dot],[MaKH],[NgayDocChiSo],[Ngaygui],[NgayThuTien],[MaTieuThu],[TrangThai]) values ('HD01',1,'KH01','12/16/2022','12/24/2022','12/25/2022','TT01',N'Chưa thanh toán')

select * from Hopdong
select * from TieuThu
