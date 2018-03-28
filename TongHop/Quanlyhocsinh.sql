﻿-- thực tập nhóm
-- đề tài quản lý học sinh 
CREATE DATABASE QUANLYHOCSINH
GO
USE QUANLYHOCSINH
GO
CREATE TABLE HOCSINH 
(
   MAHOCSINH INT  PRIMARY KEY IDENTITY(1,1),
   HOTEN NVARCHAR(50),
   GIOITINH NVARCHAR(5),
   NGAYSINH DATETIME,
   NOISINH NVARCHAR(50),
   DANTOC NVARCHAR(50),
   TONGIAO NVARCHAR(50) 
)
GO
CREATE TABLE GIAOVIEN
(
   MAGIAOVIEN INT PRIMARY KEY IDENTITY(1,1),
   HOTEN NVARCHAR(50),
   GTINH NVARCHAR(5),
   NGAYSINH DATETIME,
   NOISINH NVARCHAR(50),
   DIACHI NVARCHAR(50),
   CHUYENMON NVARCHAR(20),
   SODIENTHOAI NVARCHAR(11),
)
GO
CREATE TABLE LOP
(
   MALOP INT PRIMARY KEY IDENTITY(1,1),
   TENLOP NVARCHAR(20),
   SISO INT,
   MA_GVCHUNHIEM INT REFERENCES dbo.GIAOVIEN(MAGIAOVIEN)
)
GO
CREATE TABLE KETQUAHOCTAP
(
  MAHOCSINH INT REFERENCES dbo.HOCSINH(MAHOCSINH),
  MALOP INT REFERENCES dbo.LOP(MALOP),
  DIEMTBKY1 FLOAT,
  DIEMTBKY2 FLOAT,
  DIEMTBCANAM FLOAT,
  PRIMARY KEY(MAHOCSINH,MALOP)
)
GO
CREATE TABLE MONHOC 
(
  MAMONHOC INT PRIMARY KEY IDENTITY(1,1),
  TENMONHOC NVARCHAR(30)
)
GO

CREATE TABLE LOP_MON 
(
  MAMONHOC INT REFERENCES dbo.MONHOC,
  MALOP INT REFERENCES dbo.LOP,
  MAGIAOVIEN INT REFERENCES dbo.GIAOVIEN(MAGIAOVIEN),
  SOTIET INT,
  PRIMARY KEY(MAMONHOC,MALOP)
)
GO
CREATE TABLE BANGDIEM
(
  MAHOCSINH INT REFERENCES DBO.HOCSINH(MAHOCSINH),
  MAMONHOC INT REFERENCES dbo.MONHOC(MAMONHOC),
  HOCKY INT,
  DIEMMIENG FLOAT,
  DIEM15PHUT FLOAT,
  DIEM1TIET FLOAT,
  DIEMHK FLOAT,
  DIEMTB FLOAT,
  PRIMARY KEY(MAHOCSINH,MAMONHOC)
)
GO

CREATE TABLE ACCOUNT
(
 USERNAME VARCHAR(30) PRIMARY KEY,
 PASSWORD VARCHAR(30),
 MAGIAOVIEN INT FOREIGN KEY REFERENCES dbo.GIAOVIEN( MAGIAOVIEN),
 PHANQUYEN INT
)


CREATE TABLE KHENTHUONG 
(
  MAKHENTHUONG INT PRIMARY KEY IDENTITY(1,1),
  MAHOCSINH INT REFERENCES DBO.HOCSINH(MAHOCSINH),
  LYDO NVARCHAR(100),
  NGAY DATE,
  SOQD NCHAR(5)
)
GO
-- THEM HOC SINH
INSERT HOCSINH (
HOTEN,
GIOITINH,
NGAYSINH,
NOISINH,
DIACHI,
TONGIAO) VALUES (
'NGUYEN VAN B',
'NAM',  
'2/3/1997', - 
'HA NOI',  
'HA NOI',  
 'không'
)
SELECT * FROM HOCSINH 
GO
DELETE dbo.HOCSINH 
WHERE MAHOCSINH='1' AND MAHOCSINH='2'

ALTER TABLE dbo.HOCSINH ADD DANTOC NVARCHAR(50)
GO
INSERT dbo.HOCSINH
        (MAHOCSINH, 
		HOTEN ,
          GIOITINH ,
          NGAYSINH ,
          NOISINH ,
          TONGIAO ,
          DANTOC
        )
VALUES  (
		N'Tran van b' , -- HOTEN - nvarchar(50)
          N'Nam' , -- GIOITINH - nvarchar(5)
          '1997-26-3' , -- NGAYSINH - datetime
          N'Ha Noi' , -- NOISINH - nvarchar(50)
          N'Khong' , -- TONGIAO - nvarchar(5)
          N'Kinh'  -- DANTOC - nvarchar(50)
        )

DELETE dbo.HOCSINH 
WHERE MAHOCSINH=1

GO
SELECT * FROM  dbo.HOCSINH
GO
INSERT dbo.HOCSINH( HOTEN ,GIOITINH , NGAYSINH , NOISINH ,TONGIAO ,DANTOC)VALUES  ( N'Tran van E' , N'Nam' , '3-2-97' ,N'Ha Noi' , N'KHÔNG' ,  N'Kinh')

INSERT dbo.HOCSINH VALUES  ( N'Nguyen Van A' ,N'Nam' , '1-1-1997' , N'ha noi' , N'kinh' , N'khong')

GO
DELETE dbo.HOCSINH WHERE MAHOCSINH=4

UPDATE dbo.HOCSINH SET HOTEN ='a' ,GIOITINH='Nam',NGAYSINH='1-1-1997',NOISINH='ha noi',DANTOC='kinh',TONGIAO='khong' WHERE MAHOCSINH=1

SELECT * FROM dbo.HOCSINH WHERE HOTEN LIKE '%uye%'
SELECT * FROM dbo.MONHOC WHERE TENMONHOC

INSERT dbo.HOCSINH
        ( 
          HOTEN ,
          GIOITINH ,
          NGAYSINH ,
          NOISINH ,
          DANTOC ,
          TONGIAO
        )
VALUES  ( 
          N'Nguyen Van A' , -- HOTEN - nvarchar(50)
          N'Nam' , -- GIOITINH - nvarchar(5)
          '11-1-1997', -- NGAYSINH - datetime
          N'Ha nội' , -- NOISINH - nvarchar(50)
          N'Kinh' , -- DANTOC - nvarchar(50)
          N'Không'  -- TONGIAO - nvarchar(50)
        )
SELECT * FROM dbo.LOP
SELECT * FROM dbo.LOP_MON
SELECT * FROM dbo.MONHOC

GO
UPDATE dbo.GIAOVIEN SET HOTEN='{0}', GTINH='{1}',NGAYSINH='',NOISINH='{3}',DIACHI='{4}',CHUYENMON='{5}',SODIENTHOAI='{6}' WHERE MAGIAOVIEN=1
INSERT dbo.LOP_MON VALUES  ( 4, 1 , 5,50  )

UPDATE dbo.LOP_MON SET MAGIAOVIEN=2 WHERE MAMONHOC=1 AND MALOP=3
GO
SELECT l.TENLOP, m.TENMONHOC,lm.MAGIAOVIEN 
FROM dbo.LOP l,dbo.MONHOC m,dbo.LOP_MON lm, dbo.GIAOVIEN gv 
WHERE l.MALOP=lm.MALOP AND m.MAMONHOC=lm.MAMONHOC
GO 

INSERT dbo.GIAOVIEN
        ( 
          HOTEN ,
          GTINH ,
          NGAYSINH ,
          NOISINH ,
          DIACHI ,
          SODIENTHOAI
        )
VALUES  ( 
          N'Nguyen Van A' , -- HOTEN - nvarchar(50)
          N'Nam' , -- GIOITINH - nvarchar(5)
          '11-1-1997', -- NGAYSINH - datetime
          N'Ha nội' , -- NOISINH - nvarchar(50)
          N'Hà Nội' , -- DANTOC - nvarchar(50)
          N'0123456789'  -- TONGIAO - nvarchar(50)
        )

GO
SELECT DISTINCT LopMon.TENLOP, LopMon.TENMONHOC, gv.HOTEN 
FROM (SELECT l.TENLOP, m.TENMONHOC,lm.MAGIAOVIEN
FROM dbo.LOP l,dbo.MONHOC m,dbo.LOP_MON lm, dbo.GIAOVIEN gv 
WHERE l.MALOP=lm.MALOP AND m.MAMONHOC=lm.MAMONHOC)LopMon LEFT JOIN dbo.GIAOVIEN gv ON LopMon.MAGIAOVIEN= gv.MAGIAOVIEN

SELECT DISTINCT LopMon.MALOP, LopMon.TENLOP,LopMon.MAMONHOC, LopMon.TENMONHOC, gv.MAGIAOVIEN, gv.HOTEN FROM(SELECT l.MALOP,l.TENLOP,m.MAMONHOC, m.TENMONHOC, lm.MAGIAOVIEN FROM dbo.LOP l, dbo.MONHOC m, dbo.LOP_MON lm, dbo.GIAOVIEN gv WHERE l.MALOP = lm.MALOP AND m.MAMONHOC = lm.MAMONHOC)LopMon LEFT JOIN dbo.GIAOVIEN gv ON LopMon.MAGIAOVIEN = gv.MAGIAOVIEN
GO
SELECT * FROM dbo.GIAOVIEN WHERE MAGIAOVIEN = 1

SELECT * FROM dbo.LOP_MON


GO
SELECT l.MALOP,l.TENLOP,l.SISO,l.MA_GVCHUNHIEM,gv.HOTEN FROM dbo.LOP l, dbo.GIAOVIEN gv WHERE l.MA_GVCHUNHIEM=gv.MAGIAOVIEN



GO
CREATE TRIGGER XOAMONHOC ON dbo.MONHOC INSTEAD OF DELETE  
AS 
    DECLARE @MAMONHOC INT 
	BEGIN
	SELECT @MAMONHOC=Deleted.MAMONHOC FROM Deleted
	DELETE dbo.BANGDIEM WHERE MAMONHOC=@MAMONHOC
	DELETE dbo.MONHOC WHERE MAMONHOC=@MAMONHOC
	DELETE dbo.LOP_MON WHERE MAMONHOC=@MAMONHOC
	PRINT 'đã xóa môn học có mã môn học :' +@MAMONHOC
	END
GO
--xóa giáo viên
CREATE TRIGGER XOAGIAOVIEN ON dbo.GIAOVIEN INSTEAD OF DELETE
AS 
    DECLARE @MAGIAOVIEN INT 
	BEGIN 
	SELECT @MAGIAOVIEN=Deleted.MAGIAOVIEN FROM Deleted
	
	UPDATE dbo.LOP SET MA_GVCHUNHIEM=NULL WHERE MA_GVCHUNHIEM=@MAGIAOVIEN
	UPDATE dbo.LOP_MON SET MAGIAOVIEN=NULL WHERE MAGIAOVIEN=@MAGIAOVIEN
	DELETE dbo.GIAOVIEN WHERE MAGIAOVIEN=@MAGIAOVIEN
	END
GO
CREATE TRIGGER XOAHOCSINH ON dbo.HOCSINH INSTEAD OF DELETE
AS
   DECLARE @MAHOCSINH INT 
   BEGIN 
   SELECT @MAHOCSINH=Deleted.MAHOCSINH FROM Deleted
  
   DELETE dbo.BANGDIEM WHERE MAHOCSINH=@MAHOCSINH
   DELETE dbo.KETQUAHOCTAP WHERE MAHOCSINH=@MAHOCSINH
    DELETE dbo.HOCSINH WHERE MAHOCSINH=@MAHOCSINH
   END


GO
INSERT dbo.KETQUAHOCTAP
        ( MAHOCSINH ,
          MALOP 
         
        )
VALUES  ( 1 , -- MAHOCSINH - int
          1  -- MALOP - int        
        )

INSERT dbo.LOP_MON
        ( MAMONHOC, MALOP, MAGIAOVIEN, SOTIET )
VALUES  ( 0, -- MAMONHOC - int
          0, -- MALOP - int
          0, -- MAGIAOVIEN - int
          0  -- SOTIET - int
          )

GO
INSERT dbo.BANGDIEM
        ( MAHOCSINH ,
          MAMONHOC 
          
        )
VALUES  ( 2, -- MAHOCSINH - int
          1 
        )
GO

SELECT DISTINCT bd.MAHOCSINH,hs.HOTEN, bd.MAMONHOC,bd.HOCKY, bd.DIEMMIENG,bd.DIEM15PHUT, bd.DIEM1TIET,bd.DIEMHK,bd.DIEMTB
FROM dbo.BANGDIEM bd,dbo.HOCSINH hs,dbo.MONHOC mh,dbo.LOP_MON ml
WHERE bd.MAHOCSINH=hs.MAHOCSINH AND bd.MAMONHOC=mh.MAMONHOC AND bd.MAMONHOC =1 AND  hs.MAHOCSINH IN (SELECT kq.MAHOCSINH FROM dbo.KETQUAHOCTAP kq WHERE kq.MALOP=2)


 SELECT DISTINCT bd.MAHOCSINH, hs.HOTEN, bd.MAMONHOC, bd.DIEMMIENG, bd.DIEM15PHUT, bd.DIEM1TIET, bd.DIEMHK, bd.DIEMTB FROM dbo.BANGDIEM bd, dbo.HOCSINH hs, dbo.MONHOC mh, dbo.LOP_MON ml WHERE bd.MAHOCSINH = hs.MAHOCSINH AND bd.MAMONHOC = mh.MAMONHOC AND mh.MAMONHOC = ml.MALOP AND mh.MAMONHOC=4 AND ml.MALOP = 1
 UPDATE dbo.BANGDIEM SET HOCKY=1, DIEM15PHUT=8,DIEMMIENG=7,DIEM1TIET=8,DIEMHK=8,DIEMTB=8 WHERE MAHOCSINH=1 AND MAMONHOC=1  
GO 

CREATE FUNCTION CHNECKLOGIN(@username VARBINARY(30), @password VARCHAR(30)) RETURNS BIT AS
BEGIN
 
END


GO
INSERT dbo.ACOUNT 
        ( USENAME ,
          PASSWORD ,
          
          PHANQUYEN
        )
VALUES  ( 'admin' , -- USENAME - varchar(30)
          'admin' , -- PASSWORD - varchar(30)
        
          1  -- PHANQUYEN - int
        )

SELECT *FROM  dbo.ACOUNT

DELETE dbo.ACOUNT
INSERT dbo.ACCOUNT
        ( USERNAME ,
          PASSWORD ,
          
          PHANQUYEN
        )
VALUES  ( 'admin' , -- USERNAME - varchar(30)
          'admin' , -- PASSWORD - varchar(30)
         
          0  -- PHANQUYEN - int
        )
		GO
        
SELECT*FROM dbo.ACCOUNT

GO
UPDATE dbo.ACCOUNT SET PASSWORD='admin' WHERE USERNAME='admin'AND PASSWORD='123'

UPDATE dbo.ACCOUNT SET PASSWORD='moi' WHERE USERNAME='admin'AND PASSWORD='admin'

create proc ThemLop (@tenlop nvarchar(20), @siso int)
as
begin
	insert into dbo.LOP
	values (@tenlop, @siso)
end

	