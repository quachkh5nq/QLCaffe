create Database SinhVienDB
go

create table sinhvien(
	msSV char(10),
	tenSV varchar(50) not null,
	maLop char(10),
	ngaySinh char(100),
	gioiTinh char(10),
	ccCD char(10)
	)

insert into sinhvien values
('01', 'Quach Nhut Khang', '11DHTH02', '10/05/2002', 'Nam', '381995927'),
('02', 'Tran Huu Hoang', '11DHTH02', '18/07/2002', 'Nam', '3814542345'),
('03', 'Tran Manh Hung', '11DHTH08', '15/07/2002', 'Nu', '456345568'),
('04', 'Nguyen tan Phat', '11DHTH08', '10/05/2002', 'Nam', '456345343'),
('05', 'Nguyen The Dung', '11DHTH01', '09/02/2002', 'Nam', '758345234')

select * from sinhvien