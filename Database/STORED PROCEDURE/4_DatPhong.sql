USE [QuanLyKhachSan]
GO
/****** Object:  StoredProcedure [dbo].[SP_Booking]    Script Date: 6/22/18 9:10:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- RESULT = 0 // SUCCESS
-- RESULT = 1 // FAIL
ALTER PROCEDURE [dbo].[SP_Booking] 
(  
	@USER nvarchar(20), @NUM_ROOM int, @CHECK_IN datetime, @CHECK_OUT datetime
)
AS
BEGIN  
	--CHECK VALUES OF CHECK_IN
	IF (@CHECK_IN < GETDATE() )
	BEGIN
		PRINT N'YÊU CẦU KHÔNG ĐƯỢC THỰC HIỆN ! NGÀY NHẬN PHÒNG NHỎ HƠN NGÀY ĐẶT PHÒNG'
		RETURN 1
	END

	--CHECK VALUES OF CHECK_OUT
	IF (@CHECK_OUT < @CHECK_IN )
	BEGIN
		PRINT N'YÊU CẦU KHÔNG ĐƯỢC THỰC HIỆN ! NGÀY TRẢ PHÒNG NHỎ HƠN NGÀY NHẬN PHÒNG'
		RETURN 1
	END

	--CHECK EXISTENCE OF USER
	IF (NOT(EXISTS(SELECT * FROM KhachHang kh WHERE @USER = kh.tenDangNhap)))
	BEGIN
		PRINT N'YÊU CẦU KHÔNG ĐƯỢC THỰC HIỆN ! TÀI KHOẢN KHÔNG TỒN TẠI !'
		RETURN 1 
	END

	--GET TYPE OF ROOM
	DECLARE @TYPE int
	SELECT @TYPE = P.loaiPhong
	FROM Phong P
	WHERE @NUM_ROOM = P.maPhong

	--GET NUM OF GUEST
	DECLARE @NUM_GUEST int
	SELECT @NUM_GUEST = KH.maKH
	FROM KhachHang KH
	WHERE @USER = KH.tenDangNhap

	DECLARE @RESULT int
	SET @RESULT = 0;
	--GET STATUS OF THIS ROOM
	DECLARE @STATUS int, @DATE datetime;
	SELECT @STATUS = tt.tinhTrang, @DATE = MAX(tt.ngay) 
	FROM Phong p,TrangThaiPhong tt  
	WHERE p.maPhong = @NUM_ROOM AND p.maPhong = tt.maPhong
	GROUP BY tt.ngay, tt.tinhTrang
	
	--CHECK STATUS OF THIS ROOM
	IF (@STATUS = 0 ) 
		BEGIN

		--GET DATA
		DECLARE @TARIFF money, @DETAIL nvarchar(200);
		SELECT @TARIFF = loai.donGia, @DETAIL = loai.moTa 
		FROM Phong p ,LoaiPhong loai 
		WHERE p.maPhong = @NUM_ROOM AND p.loaiPhong = loai.maLoaiPhong

		--SAVE INFORMATION OF THIS ROOM
		INSERT INTO DatPhong (maLoaiPhong, maKH, ngayBatDau, ngayTraPhong, ngayDat, donGia, moTa, tinhTrang)
		VALUES (@TYPE, @NUM_GUEST, @CHECK_IN, @CHECK_OUT, GETDATE(), @TARIFF, @DETAIL, 1)

		--UPDATE STATUS
		EXEC sp_UpdateStatus @NUM_ROOM, @DATE, 1

		--BOOKING IS SUCCESSFUL
		SET @RESULT = 1;  
		PRINT N'Đã đặt phòng thành công.'
		RETURN 0
		END

	ELSE 
		BEGIN
		PRINT N'Xin lỗi, phòng bạn chọn đã có người đặt. Mời bạn chọn phòng khác.';
		RETURN 1
		END
END




