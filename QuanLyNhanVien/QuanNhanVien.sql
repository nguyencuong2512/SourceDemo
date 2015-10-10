create database QuanLyNhanVien
go
use QuanLyNhanVien
/*-----------------------------------------
	Tao Bang: Tao Cha Truoc con sau
	Xoa Bang la xoa con truoc cha sau.
----------------------------------------*/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[NHANVIEN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table NHANVIEN
create table NHANVIEN(
	--maSo int IDENTITY(1,1) PRIMARY KEY,
	maSo nvarchar(50) not null PRIMARY KEY,
	hoTen nvarchar(100) not null,
	ngaySinh datetime not null,
	gioiTinh nvarchar(3) constraint NHANVIEN_gioiTinh_ck check( gioiTinh =N'Nam' or gioiTinh = N'Nữ'),
	noiSinh nvarchar(100) not null

)

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CONGVIEC]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table CONGVIEC
create table CONGVIEC (
tenCV nvarchar(100) not null primary key


)
select * from NHANVIEN
insert into NHANVIEN values('NV001',N'Nguyễn Thái An',25/7/1995,N'Nam',N'Tiền Giang')
insert into NHANVIEN values('NV002',N'Nguyễn Thái',2/7/1995,N'Nam',N'Tiền Giang')
insert into NHANVIEN values('NV003',N'Nguyễn  An',5/7/1995,N'Nam',N'Tiền Giang')
insert into NHANVIEN values('NV004',N'Nguyễn Thán',25/8/1995,N'Nam',N'Tiền Giang')
