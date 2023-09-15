create Database SinhVien
go
use SinhVien

create table sinhVien(
	maSinhVien char(10) ,
	tenSV varchar(50) not NULL,
	MaLop char(10),
	NgaySinh char(100),
	GioiTinh Char(6),
	CCCD char(6)

)

insert into sinhVien(maSinhVien,tenSV,MaLop,NgaySinh,GioiTinh,CCCD) values ('1',N'Ngueyn Van A','DH1','23-02-2011','nam','12321'),
('2',N'Ngueyn Van B','DH2','21-02-2011','nam','123321'),
('3',N'Ngueyn Van C','DH1','23-02-2001','nam','12221'),
('4',N'Ngueyn Van D','DH2','03-02-2011','nam','12321')

select * from sinhVien where maSinhVien ='1'