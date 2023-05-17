CREATE DATABASE QuanLyThuVienSach
GO

USE QuanLyThuVienSach

CREATE TABLE tblSach 
(
	maSach VARCHAR(20) PRIMARY KEY,
	tenSach NVARCHAR(100),
	tacGia NVARCHAR(100),
	soLuong INT ,
	maLoai VARCHAR(20),
	FOREIGN KEY (maLoai) REFERENCES tblTheLoai (maLoai) ON DELETE CASCADE
)
GO

CREATE TABLE tblTheLoai
(
	maLoai VARCHAR(20) PRIMARY KEY,
	tenLoai NVARCHAR(100) ,
)
GO

CREATE TABLE tblSinhVien
(
	maSV VARCHAR(20) PRIMARY KEY,
	hoTen NVARCHAR(100),
	ngaySinh DATETIME,
	gioiTinh NVARCHAR(10),
	lopHC VARCHAR(20) ,
	soDT VARCHAR(15) 
)
GO

CREATE TABLE tblPhieuMuon
(
	soPhieuMuon VARCHAR(20) PRIMARY KEY,
	maSV VARCHAR(20) UNIQUE,
	maTT VARCHAR(20),
	FOREIGN KEY (maSV) REFERENCES tblSinhVien (maSV) ON DELETE CASCADE,
	FOREIGN KEY (maTT) REFERENCES tblThuThu (maTT) ON DELETE CASCADE
)
GO
INSERT INTO tblPhieuMuon
VALUES
('20PM01','20SV10','20TT01')
SELECT * FROM tblPhieuMuon
SELECT * FROM tblSinhVien
SELECT * FROM tblThuThu
/*Nếu tình trạng :
---Đã trả : Mặc định ngày trả chính là ngày hiện tại
---Chưa trả : Ngày trả = NULL*/
CREATE TABLE tblPhieuMuonCT 
(
	soCTPM VARCHAR(20) PRIMARY KEY ,
	soPhieuMuon VARCHAR(20),
	maSach VARCHAR(20),
	ngayMuon DATETIME ,
	ngayHenTra DATETIME,
	tinhTrang NVARCHAR(20) DEFAULT N'Chưa trả',
	ngayTra DATETIME ,
	FOREIGN KEY (maSach) REFERENCES tblSach (maSach) ON DELETE CASCADE,
	FOREIGN KEY (soPhieuMuon) REFERENCES tblPhieuMuon (soPhieuMuon) ON DELETE CASCADE
)
GO

 CREATE TABLE tblThuThu
(
	maTT VARCHAR(20) PRIMARY KEY ,
	hoTenTT NVARCHAR(30) NOT NULL,
	sdtTT VARCHAR(13) NOT NULL,
	diaChiTT NVARCHAR(50)
)
GO


/*Nếu đăng nhập sai quá 3 lần thì hiện thông báo , Thử lại sau */
/*Tạo báo cáo liên quan đến 2 bảng và in ra */
/**/

/*Trước khi quản lý sách thì sẽ cập nhật thể loại sách : 
---Thêm, sửa , xóa Thể loại sách*/ 

/*--------------------------------------------------------------------------------------------------------------------------*/
/*Quản lý thể loại sách */
/*Lấy thông tin thể loại sách*/
CREATE PROCEDURE pr_SelectTLSach
AS
	BEGIN
			SELECT * FROM tblTheLoai
	END

/*Thêm thể loại sách*/
CREATE PROCEDURE pr_InsertTheLoai
@maloai VARCHAR(20),
@tenloai NVARCHAR(100)
AS
	BEGIN
			INSERT INTO tblTheLoai (maLoai , tenLoai )
			VALUES  (@maloai,@tenloai)
	END

/*Kiểm tra trùng mã */
CREATE PROCEDURE pr_CheckMaTL
@maloai VARCHAR(20)
AS	
	BEGIN
			SELECT COUNT(tblTheLoai.maLoai)
			FROM tblTheLoai
			WHERE @maloai = tblTheLoai.maLoai
	END

EXEC pr_InsertTheLoai '20A1',N'Khoa học' 
EXEC pr_InsertTheLoai '20A2',N'Lập Trình' 
EXEC pr_InsertTheLoai '20A3',N'Toán' 
EXEC pr_InsertTheLoai '20A4',N'Tiếng Anh' 
EXEC pr_InsertTheLoai '20A5',N'Thể Thao' 
/*Sửa thể loại sách*/
CREATE PROCEDURE pr_UpdateTheLoai
@maloai VARCHAR(20),
@tenloai NVARCHAR(100)
AS
	BEGIN
			UPDATE tblTheLoai
			SET tenLoai = @tenloai
			WHERE @maloai = tblTheLoai.maLoai	
	END

EXEC pr_UpdateTheLoai 'TL01' , N'Lập trình cở sở'
SELECT * FROM tblTheLoai


/*Xóa thể loại sách*/
CREATE PROC pr_DeleteTheLoai
@maloai VARCHAR(20)
AS
	BEGIN
		DELETE FROM tblTheLoai
		WHERE @maloai = tblTheLoai.maLoai
	END

EXEC pr_DeleteTheLoai '20A'
SELECT * FROM tblTheLoai

/*Tìm kiếm theo tên*/
CREATE PROCEDURE pr_SearchTenTL
@tenloai NVARCHAR(50)
AS
	BEGIN
			SELECT * FROM tblTheLoai
			WHERE tblTheLoai.tenLoai LIKE N'%' + @tenloai + '%'
	END



/*--------------------------------------------------------------------------------------------------------------------------*/
/*Quản lý sách*/
/*Lấy thông tin sách*/
CREATE PROCEDURE pr_SelectSach 
AS
	BEGIN
			SELECT * FROM tblSach
	END
/*Check trùng mã sách*/

CREATE PROCEDURE pr_CheckMaS
@maSach VARCHAR(20)
AS
	BEGIN
			SELECT COUNT(maSach)
			FROM tblSach
			WHERE tblSach.maSach = @maSach
	END


/*Thêm sách*/
CREATE PROC pr_InsertSach
@maSach VARCHAR(20),
@tenSach NVARCHAR(100),
@tacGia NVARCHAR(100),
@soLuong INT,
@maLoai VARCHAR(20)
AS
	BEGIN
		INSERT INTO tblSach (maSach,tenSach,tacGia,soLuong,maLoai)
		VALUES (@maSach,@tenSach,@tacGia,@soLuong,@maLoai)
	END

EXEC pr_InsertSach 'S06',N'Đi tìm khoa học',N'Lê Văn Hưu',50,'20A1'
EXEC pr_InsertSach 'S11',N'Lập trình hướng đối tượng',N'L.ALER',150,'20A2'
EXEC pr_InsertSach 'S14',N'Giải tích',N'ALEX',250,'20A3'
EXEC pr_InsertSach 'S13',N'Anh 2',N'Nguyễn Ngọc Huyền',110,'20A4'
EXEC pr_InsertSach 'S22',N'Anh chuyên nghành',N'Nguyễn Thảo Chi',220,'20A4'
EXEC pr_InsertSach 'S09',N'Lập trình cơ sở',N'Lê Hữu Dũng',20,'20A2'
EXEC pr_InsertSach 'S23',N'Lập trình hướng sự kiện',N'Lê Anh Tuấn',40,'20A2'
EXEC pr_InsertSach 'S02',N'Nhật Ký Cầu Thủ',N'Lê Anh Tuấn',270,'20A2'

SELECT * FROM tblSach

/*Sửa sách*/
ALTER PROC pr_UpdateSach
@maSach VARCHAR(20),
@tenSach NVARCHAR(100),
@tacGia NVARCHAR(100),
@soLuong INT,
@maLoai VARCHAR(20)
AS
	BEGIN
			UPDATE tblSach
			SET tenSach = @tenSach , tacGia = @tacGia , soLuong = @soLuong , maLoai = @maLoai
			WHERE  maSach = @maSach
		
	END

/*Xoá sách*/
CREATE PROC pr_DeleteSach
@maSach VARCHAR(20),
@maLoai VARCHAR(20)
AS
	BEGIN
			DELETE FROM tblSach
			WHERE maLoai = @maLoai AND maSach = @maSach
	END

EXECUTE pr_DeleteSach  '20A01','20A1' 
/*Tìm kiếm sách theo tên*/
ALTER PROCEDURE pr_CheckSach
@tenSach NVARCHAR(50)
AS
	BEGIN 
			SELECT * FROM tblSach
			WHERE tblSach.tenSach LIKE N'%' +@tenSach+ '%'
	END


/*--------------------------------------------------------------------------------------------------------------------------*/
/*Quản lý sinh viên*/

/*Lấy thông tin sinh viên*/
CREATE PROCEDURE pr_SelectSinhVien
AS
	BEGIN
			SELECT * FROM tblSinhVien
	END
/*Kiểm tra mã sinh viên */
CREATE PROCEDURE pr_CheckMaSV
@maSV NVARCHAR(20)
AS
	BEGIN	
			SELECT COUNT(tblSinhVien.maSV) FROM tblSinhVien
		    WHERE tblSinhVien.maSV = @maSV
	END
/*Thêm sinh viên*/
CREATE PROCEDURE pr_InsertSinhVien
@maSV VARCHAR(20),
@hoTen NVARCHAR(100) ,
@ngaySinh DATETIME,
@gioiTinh NVARCHAR(10),
@lopHC VARCHAR(20) ,
@soDT VARCHAR(15)
AS
	BEGIN
			INSERT INTO tblSinhVien (maSV,hoTen,ngaySinh,gioiTinh,lopHC,soDT)
			VALUES
			(@maSV,@hoTen,@ngaySinh,@gioiTinh,@lopHC,@soDT)
	END

EXECUTE pr_InsertSinhVien '20SV01',N'Nguyễn Hoàng Anh','8/5/2002',N'Nam','2010A01','0902020102'
EXECUTE pr_InsertSinhVien '20SV02',N'Đặng Minh Cương','12/25/2002',N'Nam','2010A01','0388271928'
EXECUTE pr_InsertSinhVien '20SV03',N'Lê Anh Dũng','10/15/2002',N'Nam','2010A01','0291082091'
EXECUTE pr_InsertSinhVien '19SV20',N'Nguyễn Thanh Nhàn','9/21/2001',N'Nữ','1910A03','0291892731'

EXECUTE pr_InsertSinhVien '20A101',N'aaaa','1/1/2002',N'Nữ','2010A01','0901320102'  
EXECUTE pr_InsertSinhVien '20A102',N'aaaa','1/1/2002',N'Nữ','2010A01','0901320102'  
SELECT * FROM tblSinhVien

/*Sửa sinh viên*/

CREATE PROCEDURE pr_UpdateSinhVien
@maSV VARCHAR(20),
@hoTen NVARCHAR(100) ,
@ngaySinh DATETIME,
@gioiTinh NVARCHAR(10),
@lopHC VARCHAR(20) ,
@soDT VARCHAR(15)
AS
	BEGIN
		UPDATE tblSinhVien
		SET hoTen = @hoTen , ngaySinh = @ngaySinh , gioiTinh = @gioiTinh , lopHC = @lopHC , soDT = @soDT
		WHERE maSV = @maSV
	END
EXECUTE pr_UpdateSinhVien '20A101',N'Nguyễn Thị Lan','1/3/2002',N'Nữ','2010A10','0912340102'
SELECT * FROM tblSinhVien

/*Xóa sinh viên*/

CREATE PROCEDURE pr_DeleteSinhVien
@maSV VARCHAR(20)
AS
	BEGIN
		DELETE FROM tblSinhVien
		WHERE @maSV = tblSinhVien.maSV
	END
EXECUTE pr_DeleteSinhVien ' 18A121'
SELECT * FROM tblSinhVien

/*Tìm kiếm sinh viên theo tên*/
CREATE PROCEDURE pr_SearchSinhVien
@tensv NVARCHAR(50)
AS
	BEGIN
			SELECT * 
			FROM tblSinhVien
			  WHERE tblSinhVien.hoTen LIKE N'%' + @tensv + '%' 
	END





 /*--------------------------------------------------------------------------------------------------------------------------------------------*/
 /*Quản lý thông tin thủ thư */

/*Thêm thủ thư */
ALTER PROCEDURE pr_InsertThuThu
@matt VARCHAR(20),
@hotentt NVARCHAR(30),
@sdttt VARCHAR(13),
@dctt NVARCHAR(50)
AS
	BEGIN 
			INSERT INTO tblThuThu (maTT,hoTenTT,sdtTT,diaChiTT)
			VALUES
			(@matt,@hotentt,@sdttt,@dctt)
	END
EXECUTE pr_InsertThuThu 'TT01',N'Lê Ngọc Thanh','0902010021', N'306 Hai Bà Trưng'
EXECUTE pr_InsertThuThu 'TT02',N'Trần Thanh Lam','0293829123', N'265 Tạ Quang Bửu'
EXECUTE pr_InsertThuThu 'TT03',N'Lưu Tiến Đạt','02938459123', N'316 Nguyễn Trãi'
SELECT * FROM tblThuThu

/*Cập nhật thủ thư*/
ALTER PROCEDURE pr_UpdateThuThu
@matt VARCHAR(20),
@hotentt NVARCHAR(30),
@sdttt VARCHAR(13),
@dctt NVARCHAR(50)
AS
	BEGIN
		UPDATE tblThuThu
		SET hoTenTT = @hotentt , sdtTT = @sdttt , diaChiTT = @dctt
		WHERE  maTT= @matt
	END
EXECUTE pr_UpdateThuThu 'TT01',N'Trần Ngọc Thanh', '0902010021', N'306 Giải Phóng'
/*Xóa thủ thư*/
CREATE PROCEDURE pr_DeleteThuThu
@matt VARCHAR(20)
AS
	BEGIN
			DELETE tblThuThu
			WHERE maTT = @matt
	END
EXECUTE pr_DeleteThuThu '20'
/*Hiện thông tin thủ thư*/
CREATE PROCEDURE pr_SelectThuThu
AS
	BEGIN
			SELECT * FROM tblThuThu
	END
/*Kiểm tra trùng mã*/
CREATE PROCEDURE pr_CheckMaTT
@matt VARCHAR(20)
AS
	BEGIN 
			SELECT COUNT(maTT)
			FROM tblThuThu
			WHERE maTT = @matt
	END
/*Tìm kiếm thủ thư theo tên*/
ALTER PROCEDURE pr_SearchTT
@tentt NVARCHAR(30)
AS
	BEGIN 
			SELECT * 
			FROM tblThuThu
			WHERE tblThuThu.hoTenTT LIKE N'%' + @tentt + '%'
	END 

	EXECUTE pr_SearchTT N'Anh'


/*-----------------------------------------------------------------------------------*/
	/*Thông tin Phiếu mượn */

/*Hiện thông tin Phiếu mượn */

ALTER PROCEDURE pr_SelectPhieuMuon
AS
	BEGIN
			SELECT tblPhieuMuon.soPhieuMuon, tblPhieuMuon.maSV , tblPhieuMuon.maTT, tblSinhVien.hoTen,tblThuThu.hoTenTT
			FROM (tblPhieuMuon INNER JOIN tblSinhVien
			ON tblPhieuMuon.maSV = tblSinhVien.maSV)
			INNER JOIN tblThuThu 
			ON tblPhieuMuon.maTT = tblThuThu.maTT
	END
/*Lấy số phiếu mượn */
CREATE PROCEDURE pr_SelectSoPM
AS
	BEGIN
			SELECT * FROM tblPhieuMuon
	END
/*Thêm thông tin Phiếu mượn */
 CREATE PROCEDURE pr_InsertPhieuMuon
 @sopmuon VARCHAR(20),
 @masv VARCHAR(20),
 @matt VARCHAR(20)
 AS
	BEGIN
			INSERT INTO tblPhieuMuon (soPhieuMuon,maSV,maTT)
			VALUES(@sopmuon,@masv,@matt)
	END
EXECUTE pr_InsertPhieuMuon '23PM03','20SV03','TT01'
EXECUTE pr_InsertPhieuMuon '23PM04','19SV20','TT01'
/*Check trùng mã phiếu mượn */
CREATE PROCEDURE pr_CheckMaPM
@sopm VARCHAR(20)
AS
	BEGIN
			SELECT COUNT(soPhieuMuon)
			FROM tblPhieuMuon
			WHERE soPhieuMuon = @sopm
	END
/*Kiểm tra Một sinh viên chỉ được thuộc 1 phiếu mượn*/
CREATE PROCEDURE pr_CheckMaSVM
@maSV VARCHAR(20)
AS
	BEGIN
			SELECT COUNT(*)
			FROM tblPhieuMuon
			WHERE maSV = @maSV
	END
/*Sửa phiếu mượn*/
ALTER PROCEDURE pr_UpdatePhieuMuon
 @sopmuon VARCHAR(20),
 @masv VARCHAR(20),
 @matt VARCHAR(20)
AS	
	BEGIN
			UPDATE tblPhieuMuon
			SET maSV = @masv , maTT = @matt
			WHERE soPhieuMuon = @sopmuon
	END 
/*Xóa phiếu mượn*/
CREATE PROCEDURE pr_DeletePhieuMuon
@sopm VARCHAR(20)
AS
	BEGIN
			DELETE tblPhieuMuon
			WHERE soPhieuMuon = @sopm
	END
/*Tìm kiếm phiếu mượn*/
ALTER PROCEDURE pr_SearchPhieuMuon
@sopm VARCHAR(20)
AS
	BEGIN
			SELECT tblPhieuMuon.soPhieuMuon, tblPhieuMuon.maSV , tblPhieuMuon.maTT, tblSinhVien.hoTen,tblThuThu.hoTenTT
			FROM (tblPhieuMuon INNER JOIN tblSinhVien
			ON tblPhieuMuon.maSV = tblSinhVien.maSV)
			INNER JOIN tblThuThu 
			ON tblPhieuMuon.maTT = tblThuThu.maTT
			WHERE tblPhieuMuon.soPhieuMuon LIKE '%' + @sopm +'%'
	END
EXECUTE pr_SearchPhieuMuon '01'

/*----------------------------------------------------------------------------------------------------*/
/*Thông tin chi tiết phiếu mượn*/
/*Hiện thông tin phiếu mượn*/
ALTER PROCEDURE pr_SelectCTPM
AS
	BEGIN
			SELECT tblPhieuMuonCT.soCTPM,tblSinhVien.hoTen, tblThuThu.hoTenTT , tblSach.tenSach , tblPhieuMuonCT.ngayMuon
			,tblPhieuMuonCT.ngayHenTra, tblPhieuMuonCT.tinhTrang , tblPhieuMuonCT.ngayTra , tblSach.maSach , tblPhieuMuon.soPhieuMuon
			FROM (((tblPhieuMuon INNER JOIN tblSinhVien
			ON tblPhieuMuon.maSV = tblSinhVien.maSV)
			INNER JOIN tblThuThu 
			ON tblPhieuMuon.maTT = tblThuThu.maTT)
			INNER JOIN tblPhieuMuonCT
			ON tblPhieuMuonCT.soPhieuMuon = tblPhieuMuon.soPhieuMuon)
			INNER JOIN tblSach
			ON tblSach.maSach = tblPhieuMuonCT.maSach
			
	END 

/*Thêm thông tin phiếu mượn */
ALTER PROCEDURE pr_InsertCTPM
@soct VARCHAR(20),
@sopm VARCHAR(20),
@mas VARCHAR(20),
@ngaym DATETIME,
@ngayht DATETIME
AS
	BEGIN
			INSERT INTO tblPhieuMuonCT (soCTPM,soPhieuMuon,maSach,ngayMuon,ngayHenTra)
			VALUES
			(@soct,@sopm,@mas,@ngaym,@ngayht)
			
	END
EXECUTE pr_InsertCTPM 'CTPM01','23PM03','S03','11/4/2023','11/13/2023'
/*Kiểm tra trùng số chi tiết phiếu mượn */
CREATE PROCEDURE pr_CheckSoCTPM
@soct VARCHAR(20)
AS
	BEGIN
			SELECT COUNT(soCTPM)
			FROM tblPhieuMuonCT
			WHERE soCTPM = @soct
	END

/*Kiểm tra theo phiếu mượn*/
CREATE PROCEDURE pr_CheckQua3Muon
@sopm VARCHAR(20)
AS
   BEGIN
   SELECT COUNT (tblPhieuMuon.soPhieuMuon)
   FROM (((tblPhieuMuon INNER JOIN tblSinhVien
			ON tblPhieuMuon.maSV = tblSinhVien.maSV)
			INNER JOIN tblThuThu 
			ON tblPhieuMuon.maTT = tblThuThu.maTT)
			INNER JOIN tblPhieuMuonCT
			ON tblPhieuMuonCT.soPhieuMuon = tblPhieuMuon.soPhieuMuon)
			INNER JOIN tblSach
			ON tblSach.maSach = tblPhieuMuonCT.maSach
			WHERE tblPhieuMuon.soPhieuMuon = @sopm
END
    SELECT * FROM tblPhieuMuon
EXECUTE  pr_CheckQua3Muon '23PM03'
        
/*Hiện thông tin sinh viên , số lượng sách đã mượn của từng sách*/
SELECT tblSinhVien.hoTen,COUNT(tblPhieuMuonCT.maSach) AS N'Số sách đã mượn' ,tblSach.tenSach
FROM (((tblPhieuMuon INNER JOIN tblSinhVien
			ON tblPhieuMuon.maSV = tblSinhVien.maSV)
			INNER JOIN tblThuThu 
			ON tblPhieuMuon.maTT = tblThuThu.maTT)
			INNER JOIN tblPhieuMuonCT
			ON tblPhieuMuonCT.soPhieuMuon = tblPhieuMuon.soPhieuMuon)
			INNER JOIN tblSach
			ON tblSach.maSach = tblPhieuMuonCT.maSach
GROUP BY tblSinhVien.hoTen , tblSach.tenSach

/*Xóa chi tiết phiếu mượn */
CREATE PROCEDURE pr_DeleteCTPhieuMuon
@mactpm VARCHAR(20)
AS 
	BEGIN
			DELETE tblPhieuMuonCT
			WHERE tblPhieuMuonCT.soCTPM = @mactpm
	END 
EXECUTE pr_DeleteCTPhieuMuon 'CTPM06'
SELECT * FROM tblPhieuMuonCT
/*Cập nhật phiếu mượn (Ngày mượn , Ngày hẹn trả , Ngày trả )
--Điều kiện : Ngày mượn phải nhỏ hơn ngày hẹn trả và ngày trả (1)
			  UPDATE khi sinh viên đến trả sách thì mới được cập nhật ngày trả sách. (2)
			  => Tình trạng : Đã trả 
			  Nếu sinh viên trả sách muộn hơn ngày hẹn trả
			  => Tình trạng : Trả muộn (3)		  
*/
ALTER PROCEDURE pr_UpdateCTPhieuMuon
@soct VARCHAR(20),
@ngaym DATETIME,
@ngayht DATETIME,
@ngayt DATETIME
AS
BEGIN
	-- Kiểm tra điều kiện nếu sinh viên trả sách muộn hơn ngày hẹn trả
	IF @ngayt > @ngayht OR @ngayht < GETDATE()
	BEGIN
		UPDATE tblPhieuMuonCT
		SET tinhTrang = N'Trả muộn', ngayTra = @ngayt
		WHERE soCTPM = @soct
	END

	-- Cập nhật thông tin phiếu mượn sách
	IF @ngayt < @ngayht
	BEGIN 
		UPDATE tblPhieuMuonCT
		SET tinhTrang = N'Đã trả', ngayTra = @ngayt
		WHERE soCTPM = @soct
	END 
	ELSE
	UPDATE tblPhieuMuonCT
	SET ngayMuon = @ngaym, ngayHenTra = @ngayht, ngayTra = @ngayt
	WHERE soCTPM = @soct
END

EXECUTE pr_UpdateCTPhieuMuon 'CTPM01','11/4/2023','11/13/2023','11/15/2023'

SELECT * FROM tblPhieuMuonCT

/*Tài khoản*/

CREATE TABLE tblUsers
(
	userName NVARCHAR(100) UNIQUE,
	userPassword VARCHAR(200),
)
/*Tạo bản ghi mới */
INSERT INTO tblUsers
VALUES
('dunglelass','dungle111')
('nguyenhoanganh','hoang2anh2002'),
('ngoclam2k2','lam!2002'),
('tranngan','ngan@tran'),

SELECT * FROM tblUsers

ALTER PROCEDURE pr_CheckTrung
@username NVARCHAR(100)
AS
BEGIN
    -- Kiểm tra trùng lặp userID
    SELECT COUNT(*) 
    FROM tblUsers
    WHERE tblUsers.userName = @username

END

EXECUTE pr_CheckTrung 'nguyenhoanganh'

CREATE PROCEDURE pr_CheckTK
@username NVARCHAR(100)
AS
BEGIN
    -- Kiểm tra tài khoản trong bảng tblUsers
    SELECT COUNT(userName) 
    FROM tblUsers
    WHERE tblUsers.userName = @username 
END

CREATE PROCEDURE pr_CheckMK
@password VARCHAR(200)
AS
BEGIN
    -- Kiểm tra tài khoản trong bảng tblUsers
    SELECT COUNT(userPassword) 
    FROM tblUsers
    WHERE tblUsers.userPassword = @password
END

CREATE PROCEDURE pr_InsertUser
@username NVARCHAR(100),
@password VARCHAR(200)
AS
	BEGIN
			INSERT INTO tblUsers
			VALUES
			(@username,@password)
	END

 --Đỏi mk
CREATE PROCEDURE pr_CheckMKNew
@passwordnew VARCHAR(200),
@username VARCHAR(100)
AS
	BEGIN
			UPDATE tblUsers
			SET userPassword = @passwordnew
			WHERE userName = @username
	END