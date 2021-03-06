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
   NAMHOC NVARCHAR(20),
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
  HANHKIEM_KY1 NVARCHAR(20),
  HANHKIEM_KY2 NVARCHAR(20),
  HANHKIEM_KY3 NVARCHAR(20),
  PRIMARY KEY(MAHOCSINH,MALOP)
)
GO
CREATE TABLE MONHOC 
(
  MAMONHOC INT PRIMARY KEY IDENTITY(1,1),
  TENMONHOC NVARCHAR(30)
)
GO
CREATE TABLE KHENTHUONG 
(
  MAKHENTHUONG INT PRIMARY KEY IDENTITY(1,1),
  MAHOCSINH INT REFERENCES DBO.HOCSINH(MAHOCSINH),
  LYDO NVARCHAR(100),
  NGAY DATE,
  SOQD NCHAR(5)
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
GO
INSERT dbo.MONHOC
        ( TENMONHOC )
VALUES  ( N'Toan-10'  -- TENMONHOC - nvarchar(30)
          )

insert into BANGDIEM (MAHOCSINH,MAMONHOC)
select 1 ,L.MAMONHOC from KETQUAHOCTAP kq, LOP_MON l WHERE kq.MALOP=L.MALOP AND L.MALOP=1