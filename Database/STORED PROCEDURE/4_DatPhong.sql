USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_UpdateStatus
	@NUM_ROOM int, @DATE datetime, @STATUS int
AS
BEGIN
	UPDATE TrangThaiPhong
	SET tinhTrang = @STATUS
	WHERE maPhong = @NUM_ROOM and ngay = @DATE
END
GO

-- RESULT = 0 // FAIL
-- RESULT = 1 // SUCCESS
CREATE PROCEDURE SP_Booking 
(  
	@USER nvarchar(20), @NUM_ROOM int, @CHECK_IN datetime, @CHECK_OUT datetime,
	@RESULT int OUTPUT
)
AS
BEGIN  
	--GET NUM OF GUEST
	DECLARE @NUM_GUEST int
	SELECT @NUM_GUEST = KH.maKH
	FROM KhachHang KH
	WHERE @USER = KH.tenDangNhap

	--GET STATUS OF THIS ROOM
	DECLARE @STATUS int, @DATE datetime;
	SELECT @STATUS = tt.tinhTrang, @DATE = MAX(tt.ngay) FROM Phong p join TrangThaiPhong tt ON p.maPhong = tt.maPhong
														WHERE p.maPhong = @NUM_ROOM
														GROUP BY tt.ngay, tt.tinhTrang

	SET @RESULT = 0;

	--CHECK STATUS OF THIS ROOM
	IF (@STATUS = 0 ) 
		BEGIN

		--GET DATA
		DECLARE @TARIFF money, @DETAIL nvarchar(200);
		SELECT @TARIFF = loai.donGia, @DETAIL = loai.moTa FROM Phong p JOIN LoaiPhong loai ON p.loaiPhong = loai.maLoaiPhong
														  WHERE p.maPhong = @NUM_ROOM

		--SAVE INFORMATION OF THIS ROOM
		INSERT INTO DatPhong (maLoaiPhong, maKH, ngayBatDau, ngayTraPhong, ngayDat, donGia, moTa, tinhTrang)
		VALUES (@NUM_ROOM, @NUM_GUEST, @CHECK_IN, @CHECK_OUT, GETDATE(), @TARIFF, @DETAIL, 1)

		--UPDATE STATUS
		EXEC sp_UpdateStatus @NUM_ROOM, @DATE, 1

		--BOOKING IS SUCCESSFUL
		SET @RESULT = 1;  
		PRINT N'Đã đặt phòng thành công.'
		END

	ELSE PRINT N'Xin lỗi, phòng bạn chọn đã có người đặt. Mời bạn chọn phòng khác.';
		
END