create database QLLuong
use QLLuong

create table DonVi(
	MaDonVi char(10) not null primary key,
	TenDonVi nvarchar(20)
)

create table NhanVien(
	Ma char(10) not null primary key,
	HoTen nvarchar(20),
	NgaySinh datetime,
	GioiTinh nchar(6),
	Hsluong decimal,
	MaDonVi char(10) not null,
	constraint fk_nv_dv foreign key(MaDonVi)
	references DonVi(MaDonVi)
)

insert into DonVi values
('DV01', N'Phòng Marketting'),
('DV02', N'Phòng kế hoạch'),
('DV03', N'Phòng quản lý')

insert into Nhanvien values
('NV01', N'Trần Văn Hùng', '1997-10-10', N'Nam', 2.34, 'DV02'),
('NV02', N'Bùi Thị Trà My', '1998-05-20', N'Nữ', 3.12, 'DV01')