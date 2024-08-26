create database QuanLySanPhamDB
use QuanLySanPhamDB

create table NhomHang(
	MaNhomHang int primary key,
	TenNhomHang nvarchar(30)
)

create table SanPham(
	MaSP int primary key,
	TenSP nvarchar(50),
	DonGia float,
	SoLuongBan int,
	TienBan float,
	MaNhomHang int foreign key references NhomHang(MaNhomHang)
)

insert into NhomHang values
(1, N'Điện thoại'),
(2, N'Đồ makeup'),
(3, N'Quần áo'),
(4, N'Đồ gia dụng')

insert into SanPham values
(1,N'Iphone 7',1000000,2,2000000,1),
(2,N'Son phấn',100000,2,200000,2),
(3,N'Áo phông',150000,2,300000,3),
(4,N'Cây lau nhà',420000,1,420000,4),
(5,N'Note 10',8000000,2,16000000,1),
(6,N'Iphone 8',1100000,2,2200000,1);
