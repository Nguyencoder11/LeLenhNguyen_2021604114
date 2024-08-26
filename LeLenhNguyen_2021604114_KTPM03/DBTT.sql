create database DBTT
use DBTT

create table ThoiTietTrongNgay(
	MaKhuVuc varchar(10) not null,
	Gio datetime not null,
	NhietDo decimal(18, 1),
	DoAm decimal(18, 1)
	PRIMARY KEY (MaKhuVuc, Gio)
)

insert into ThoiTietTrongNgay values
('KV01', '2024-08-26 08:00:00', 29.5, 75.0),
('KV02', '2024-08-26 09:00:00', 30.0, 73.5),
('KV03', '2024-08-26 10:00:00', 31.2, 70.0),
('KV04', '2024-08-26 11:00:00', 32.5, 65.8),
('KV05', '2024-08-26 12:00:00', 33.0, 60.5),
('KV01', '2024-08-26 13:00:00', 34.1, 55.3),
('KV02', '2024-08-26 14:00:00', 35.0, 50.0),
('KV03', '2024-08-26 15:00:00', 36.2, 45.7),
('KV04', '2024-08-26 16:00:00', 37.5, 40.9),
('KV05', '2024-08-26 17:00:00', 38.0, 35.4);

drop database DBTT