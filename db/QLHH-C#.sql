create database QLBH
go
use QLBH

create table HoaDon
(
	MaHD varchar(10)not null,
	MaKhachHang varchar(10),
	TongTien float,
	NhanVienLap varchar(10),
	NgayLap varchar(10)
	primary key (MaHD)
)

create table NhanVien
(
	MaNV varchar(10)not null,
	TenNV nvarchar(50),
	GioiTinh nvarchar(5),
	DiaChi nvarchar(50),
	NgaySinh Date,
	SDT varchar(12),
	Pwd varchar(20),
	primary key (MaNV)
)

create table KhachHang
(
	MaKH varchar(10)not null,
	TenKH nvarchar(50),
	Cmnd varchar(12),
	SDT varchar(12),
	GioiTinh nvarchar(5),
	NgaySinh Date,
	DiaChi nvarchar(50),
	DiemTichLuy int,
	LoaiThe nvarchar(20),
	TinhTrang bit,
	primary key (MaKH)
)


create table CTHD
(
	MaHD varchar(10)not null,
	MaHH varchar(10),
	DonGia float,
	SoLuong int,
	primary key (MaHD,MaHH)
)

create table HangHoa
(
	MaHang varchar(10)not null,
	TenHang nvarchar(50),
	LoaiHH nvarchar(50),
	TenNSX nvarchar(50),
	GiaNhap float,
	LoiNhuan float,
	DonGia float,
	NgayNhap Datetime,
	SoLuong int,
	SoLuongMin int,
	NgNhapHang varchar(10),
	TinhTrang bit,
	primary key (MaHang)
)

alter table HangHoa
add constraint FK_HH_NV
foreign key (NgNhapHang)
references NhanVien(MaNV)
----------
alter table HoaDon
add constraint FK_HD_NV
foreign key (NhanVienLap)
references NhanVien(MaNV)
----------
alter table HoaDon
add constraint FK_HD_KH
foreign key (MaKhachHang)
references KhachHang(MaKH)
---------
alter table CTHD
add constraint FK_CTHD_HD
foreign key (MaHD)
references HoaDon(MaHD)
--------
alter table CTHD
add constraint FK_CTHD_HH
foreign key (MaHH)
references HangHoa(MaHang)
------------------------------------------------------------------------