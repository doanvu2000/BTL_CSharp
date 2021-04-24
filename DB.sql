/*
Created		21/04/2021
Modified		22/04/2021
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/
use master
go
create database QLCH
go
use QLCH
go


Create table [DanhMuc]
(
	[MaDM] Nvarchar(20) NOT NULL,
	[TenDM] Nvarchar(30) NULL,
Constraint [pk_DanhMuc] Primary Key ([MaDM])
) 
go

Create table [SanPham]
(
	[MaSP] Nvarchar(20) NOT NULL,
	[MaDM] Nvarchar(20) NOT NULL,
	[TenSP] Nvarchar(30) NULL,
	[SLTon] Integer NULL,
	[Gia] Integer NULL,
	[MoTa] Ntext NULL,
	[MaNCC] Nvarchar(20) NOT NULL,
Constraint [pk_SanPham] Primary Key ([MaSP])
) 
go

Create table [HoaDon]
(
	[MaHD] Nvarchar(20) NOT NULL,
	[NgayLap] Datetime NULL,
	[MaKH] Nvarchar(20) NOT NULL,
	[MaNV] Nvarchar(20) NOT NULL,
Constraint [pk_HoaDon] Primary Key ([MaHD])
) 
go

Create table [ChiTietHD]
(
	[MaSP] Nvarchar(20) NOT NULL,
	[MaHD] Nvarchar(20) NOT NULL,
	[SLBan] Integer NULL,
Constraint [pk_ChiTietHD] Primary Key ([MaSP],[MaHD])
) 
go

Create table [KhachHang]
(
	[MaKH] Nvarchar(20) NOT NULL,
	[TenKH] Nvarchar(30) NULL,
	[SDT] Nvarchar(20) NULL,
	[DiaChi] Nvarchar(150) NULL,
Constraint [pk_KhachHang] Primary Key ([MaKH])
) 
go

Create table [NhanVien]
(
	[MaNV] Nvarchar(20) NOT NULL,
	[TenNV] Nvarchar(30) NULL,
	[SDT] Nvarchar(20) NULL,
	[DiaChi] Nvarchar(150) NULL,
	[Luong] Integer NULL,
Constraint [pk_NhanVien] Primary Key ([MaNV])
) 
go

Create table [NCC]
(
	[MaNCC] Nvarchar(20) NOT NULL,
	[TenNCC] Nvarchar(20) NULL,
	[SDT] Nvarchar(20) NULL,
	[DiaChi] Nvarchar(150) NULL,
Constraint [pk_NCC] Primary Key ([MaNCC])
) 
go


Alter table [SanPham] add  foreign key([MaDM]) references [DanhMuc] ([MaDM])  on update no action on delete no action 
go
Alter table [ChiTietHD] add  foreign key([MaSP]) references [SanPham] ([MaSP])  on update no action on delete no action 
go
Alter table [ChiTietHD] add  foreign key([MaHD]) references [HoaDon] ([MaHD])  on update no action on delete no action 
go
Alter table [HoaDon] add  foreign key([MaKH]) references [KhachHang] ([MaKH])  on update no action on delete no action 
go
Alter table [HoaDon] add  foreign key([MaNV]) references [NhanVien] ([MaNV])  on update no action on delete no action 
go
Alter table [SanPham] add  foreign key([MaNCC]) references [NCC] ([MaNCC])  on update no action on delete no action 
go

select * from SanPham
select * from KhachHang
select * from HoaDon
select * from ChiTietHD
go
-- NCC
insert into NCC values
	('NCC01','Guardian', '028.3832.8689',N'Bến Vân Đồn, P1, Q4, TP Hồ Chí Minh, VN'),
	('NCC02','Watsons', '0314911564',N'Đường Cách Mạng Tháng Tám, Phường 12, Quận 10, Thành phố Hồ Chí Minh, Việt Nam'),
	('NCC03','Sammi Online', '1900 2631',N'Số 65 Nguyễn Phong Sắc, Hà Nội, Việt Nam')
go
select * from NCC
-- DanhMuc
go
insert into DanhMuc values
	('DM01',N'Môi'),('DM02',N'Mặt'),('DM03',N'Mắt'),('DM04',N'Phụ kiện')
go
select * from DanhMuc
--
go
insert into NhanVien values
	('NV01',N'Nguyễn Thị Lan','0987328540','Nam Dinh',12300000),
	('NV02',N'Trần Hoàng Thủy','0687228740','Ha Nam',11600000),
	('NV03',N'Đỗ Văn Long','0982228666','Thai Nguyen',13700000),
	('NV04',N'Chu Ngọc Hùng','0863328540','Ha Noi',10000000)
go
select * from NhanVien
--KhachHang
go
insert into KhachHang values
	('KH01',N'Nguyễn Thị Hồng','0987328540',N'Nam Định'),
	('KH02',N'Ma Thị Nhị Hằng','0687228740',N'Thái Nguyên')
go
select * from KhachHang
--SanPham
insert into SanPham values
	('SP01','DM01',N'Son BlackRouge Rose',200,250000,N'Lấy cảm hứng từ hoa hồng - loài hoa thống trị cái đẹp, Black Rouge vừa cho ra mắt BST mới toanh có tên Rose Velvet Lipstick','NCC01'),
	('SP02','DM02',N'Phấn nước Black Rouge Peach',300,550000,N'Lấy cảm hứng từ những quả đào mùa thu căng mọng, Black Rouge đã cho ra mắt Peach Cover Velvet Cushion với finish mịn mượt như nhung, che phủ hoàn hảo gương mặt nhưng vẫn mỏng nhẹ và khô thoáng trên da.','NCC02'),
	('SP03','DM03',N'Kẻ mắt Black Rouge All Day',100,250000,N'All Day Power Proof Pen Liner với tông màu chủ đạo living coral hot nhất hiện nay, chống trôi suốt ngày dài, còn chần chừ gì nữa mà không hòa vào mùa hè sôi động cùng Black Rouge!','NCC03'),
	('SP04','DM04',N'Bông tẩy trang Forwatch',250,50000,N'Loại bông mềm mượt giúp tẩy sạch các bụi bẩn sâu bên trong lỗ chân lông','NCC02')
go
select * from SanPham
--HoaDon
insert into HoaDon values
	('HD01','2021-02-11','KH01','NV01'),
	('HD02','2021-03-11','KH01','NV01'),
	('HD03','2021-04-11','KH02','NV03'),
	('HD04','2021-02-12','KH02','NV02')
go 
select * from HoaDon
go

--ChiTietHoaDon
insert into ChiTietHD values ('SP01','HD01',10)
insert into ChiTietHD values ('SP02','HD02',15)
insert into ChiTietHD values ('SP03','HD03',6)
insert into ChiTietHD values ('SP01','HD04',8)
go 
select * from ChiTietHD
go
create trigger trginsertChiTietHD
on ChiTietHD
for insert
as
begin
	declare @slban int, @masp nvarchar(20)
	set @slban = (select SLBan from inserted)
	set @masp = (select MaSP from inserted)
	if (@slban <= (select SLTon from Sanpham where MaSP = @masp))
	begin
		update SanPham set SLTon = SLTon - @slban where MaSP = @masp
	end
	else 
	begin
		raiserror(N'Không đủ số lượng để bán',16,1)
		rollback transaction
	end
end
--
select * from SanPham
select * from HoaDon
select * from ChiTietHD
select * from DanhMuc
select * from NCC
select * from NhanVien
select * from KhachHang
go
create table TaiKhoan(
IDTK int primary key,
UserName nvarchar(30),
PassWord nvarchar(30),
Role int
)
insert into TaiKhoan values (1,'admin','12345',1), (2,'nv','12345',2)