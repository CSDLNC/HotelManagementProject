USE [QuanLyKhachSan]
GO
/****** Object:  StoredProcedure [dbo].[SP_Booking]    Script Date: 6/30/18 11:06:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--UPDATE STATUS OF ROOM
ALTER PROCEDURE [dbo].[SP_UpdateStatus]
	@NUM_ROOM int, @DATE datetime, @STATUS int
AS
BEGIN
	UPDATE TrangThaiPhong
	SET tinhTrang = @STATUS
	WHERE maPhong = @NUM_ROOM and DATEDIFF(DAY,ngay,@DATE) = 0
END

GO

--BOKING
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

	--CHECK USER
	IF (NOT(EXISTS(SELECT * FROM KhachHang kh WHERE @USER = kh.tenDangNhap)))
	BEGIN
		PRINT N'YÊU CẦU KHÔNG ĐƯỢC THỰC HIỆN ! TÀI KHOẢN KHÔNG TỒN TẠI !'
		RETURN 1 
	END

	--GET NUM OF GUEST
	DECLARE @NUM_GUEST int
	SELECT @NUM_GUEST = KH.maKH
	FROM KhachHang KH
	WHERE @USER = KH.tenDangNhap

	--GET STATUS OF THIS ROOM
	DECLARE @STATUS int, @DATE datetime;
	SELECT @DATE = MAX(tt.ngay)
	FROM TrangThaiPhong tt
	WHERE tt.maPhong = @NUM_ROOM

	SELECT @STATUS = tt.tinhTrang
	FROM TrangThaiPhong tt  
	WHERE tt.maPhong = @NUM_ROOM AND DATEDIFF(DAY,tt.ngay,@DATE) = 0
	
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
		VALUES (@NUM_ROOM, @NUM_GUEST, @CHECK_IN, @CHECK_OUT, GETDATE(), @TARIFF, @DETAIL, 1)

		--UPDATE STATUS
		SET @DATE = GETDATE()
		WHILE (@DATE <= @CHECK_OUT) 
		BEGIN
			EXEC sp_UpdateStatus @NUM_ROOM, @DATE, 1
			SET @DATE = DATEADD(DAY,1,@DATE)
		END
		
		--BOOKING IS SUCCESSFUL
		PRINT N'Đã đặt phòng thành công.'
		RETURN 0
		END

	ELSE 
		BEGIN
		PRINT N'Xin lỗi, phòng bạn chọn đã có người đặt. Mời bạn chọn phòng khác.';
		RETURN 1
		END
END


