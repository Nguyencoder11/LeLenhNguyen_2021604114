create database db_qlnv
use db_qlnv

create table NhanVien(
	MaNV int not null primary key,
	HoTen nvarchar(20),
	TrinhDo nvarchar(15),
	Luong int
)

insert into NhanVien values
(1, N'Lê Văn A', N'Thạc sĩ', 50000000),
(2, N'Nguyễn Văn B', N'Cử nhân', 15000000),
(3, N'Trần Văn C', N'Tiến sĩ', 200000000)