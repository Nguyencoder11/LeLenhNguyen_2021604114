use master
create database CSDLQLBanHang

use CSDLQLBanHang

create table DanhMuc(
	MaDanhMuc char(10) not null primary key,
	TenDanhMuc nvarchar(20)
)

create table SanPham(
	Ma char(10) not null primary key,
	Ten nvarchar(25),
	DonGia int,
	MaDanhMuc char(10) not null,
	constraint fk_sp_dm foreign key(MaDanhMuc)
	references DanhMuc(MaDanhMuc)
)

insert into DanhMuc values
('DM01', N'Quần áo nam'),
('DM02', N'Quần áo nữ'),
('DM03', N'Giày')

insert into SanPham values
('SP01', N'Váy xếp ly', 500000, 'DM02'),
('SP02', N'Áo thun', 350000, 'DM01')

drop database CSDLQLBanHang