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
	[MaDM] int IDENTITY(1,1) NOT NULL,
	[TenDM] Nvarchar(30) NULL,
Constraint [pk_DanhMuc] Primary Key ([MaDM])
) 
go

Create table [SanPham]
(
	[MaSP] int IDENTITY(1,1) NOT NULL,
	[MaDM] int NOT NULL,
	[TenSP] Nvarchar(30) NULL,
	[SLTon] Integer NULL,
	[Gia] Integer NULL,
	[MoTa] Ntext NULL,
	[MaNCC] int,
Constraint [pk_SanPham] Primary Key ([MaSP])
) 
go

Create table [HoaDon]
(
	[MaHD] int IDENTITY(1,1) NOT NULL,
	[NgayLap] Datetime NULL,
	[MaKH] int NOT NULL,
	[MaNV] int NOT NULL,
Constraint [pk_HoaDon] Primary Key ([MaHD])
) 
go

Create table [ChiTietHD]
(
	[MaSP] int NOT NULL,
	[MaHD] int NOT NULL,
	[SLBan] Integer NULL,
Constraint [pk_ChiTietHD] Primary Key ([MaSP],[MaHD])
) 
go

Create table [KhachHang]
(
	[MaKH] int IDENTITY(1,1) NOT NULL,
	[TenKH] Nvarchar(30) NULL,
	[SDT] Nvarchar(20) NULL,
	[DiaChi] Nvarchar(150) NULL,
Constraint [pk_KhachHang] Primary Key ([MaKH])
) 
go

Create table [NhanVien]
(
	[MaNV] int IDENTITY(1,1) NOT NULL,
	[TenNV] Nvarchar(30) NULL,
	[SDT] Nvarchar(20) NULL,
	[DiaChi] Nvarchar(150) NULL,
	[Luong] Integer NULL,
Constraint [pk_NhanVien] Primary Key ([MaNV])
) 
go

Create table [NCC]
(
	[MaNCC] int IDENTITY(1,1) NOT NULL,
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
insert into NCC(TenNCC,SDT,DiaChi) values ('Guardian', '028.3832.8689',N'Bến Vân Đồn, P1, Q4, TP Hồ Chí Minh, VN')
insert into NCC(TenNCC,SDT,DiaChi) values ('Watsons', '0314911564',N'Đường Cách Mạng Tháng Tám, Phường 12, Quận 10, Thành phố Hồ Chí Minh, Việt Nam')
insert into NCC(TenNCC,SDT,DiaChi) values ('Sammi Online', '1900 2631',N'Số 65 Nguyễn Phong Sắc, Hà Nội, Việt Nam')
go
select * from NCC
-- DanhMuc
go
insert into DanhMuc(TenDM) values 	(N'Môi')
insert into DanhMuc(TenDM) values 	(N'Mặt')
insert into DanhMuc(TenDM) values 	(N'Mắt')
insert into DanhMuc(TenDM) values 	(N'Phụ kiện')
go
select * from DanhMuc
--

go
insert into NhanVien(TenNV,SDT ,DiaChi,Luong) values (N'Nguyễn Thị Lan','0987328540','Nam Dinh',12300000)
insert into NhanVien(TenNV,SDT ,DiaChi,Luong) values(N'Trần Hoàng Thủy','0687228740','Ha Nam',11600000)
insert into NhanVien(TenNV,SDT ,DiaChi,Luong) values(N'Đỗ Văn Long','0982228666','Thai Nguyen',13700000)
insert into NhanVien(TenNV,SDT ,DiaChi,Luong) values	(N'Chu Ngọc Hùng','0863328540','Ha Noi',10000000)
go
select * from NhanVien
--KhachHang
go
insert into KhachHang(TenKH,SDT,DiaChi) values (N'Nguyễn Thị Hồng','0987328540',N'Nam Định')
insert into KhachHang(TenKH,SDT,DiaChi) values (N'Ma Thị Nhị Hằng','0687228740',N'Thái Nguyên')
go
select * from KhachHang
--SanPham
insert into SanPham(MaDM,TenSP,SLTon,Gia,MoTa,MaNCC) values
	(1,N'Son BlackRouge Rose',200,250000,N'Lấy cảm hứng từ hoa hồng - loài hoa thống trị cái đẹp, Black Rouge vừa cho ra mắt BST mới toanh có tên Rose Velvet Lipstick',1)
insert into SanPham(MaDM,TenSP,SLTon,Gia,MoTa,MaNCC) values	(2,N'Phấn nước Black Rouge Peach',300,550000,N'Lấy cảm hứng từ những quả đào mùa thu căng mọng, Black Rouge đã cho ra mắt Peach Cover Velvet Cushion với finish mịn mượt như nhung, che phủ hoàn hảo gương mặt nhưng vẫn mỏng nhẹ và khô thoáng trên da.',2)
insert into SanPham(MaDM,TenSP,SLTon,Gia,MoTa,MaNCC) values(3,N'Kẻ mắt Black Rouge All Day',100,250000,N'All Day Power Proof Pen Liner với tông màu chủ đạo living coral hot nhất hiện nay, chống trôi suốt ngày dài, còn chần chừ gì nữa mà không hòa vào mùa hè sôi động cùng Black Rouge!',3)
insert into SanPham(MaDM,TenSP,SLTon,Gia,MoTa,MaNCC) values(4,N'Bông tẩy trang Forwatch',250,50000,N'Loại bông mềm mượt giúp tẩy sạch các bụi bẩn sâu bên trong lỗ chân lông',2)
go
select * from SanPham
--HoaDon
insert into HoaDon(NgayLap,MaKH,MaNV)	values('2021-02-11',1,1)
insert into HoaDon(NgayLap,MaKH,MaNV) values('2021-03-11',1,1)
insert into HoaDon(NgayLap,MaKH,MaNV) values('2021-04-11',2,3)
insert into HoaDon(NgayLap,MaKH,MaNV) values('2021-02-12',2,2)
go 
select * from HoaDon
go

--ChiTietHoaDon
insert into ChiTietHD values (1,1,10)
insert into ChiTietHD values (2,2,15)
insert into ChiTietHD values (3,3,6)
insert into ChiTietHD values (1,4,8)
go 
select * from ChiTietHD
go
create trigger trginsertChiTietHD
on ChiTietHD
for insert
as
begin
	declare @slban int, @masp int
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
ID int  Identity(1,1) primary key,
UserName nvarchar(30),
PassWord nvarchar(30),
Role int
)
insert into TaiKhoan(UserName,PassWord,Role) values ('admin','12345',1), ('nv','12345',2)
select * from TaiKhoan
delete from TaiKhoan where id = 1 or id = 2
go
Alter table taikhoan 
  add manv int
  go
 ALTER TABLE TaiKhoan
ADD constraint fk_tkhoan foreign key (manv) references NhanVien(manv)
go
insert into TaiKhoan values('admin','12345',1,2), ('LanNguyen','12345',2,1), ('NgocHung','12345',2,4)