USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_RegisterAccount (@HoTen nvarchar(50), @TenDangNhap nvarchar(20), @MatKhau varchar(50), @soCMND varchar(9), @diaChi nvarchar(100), @soDienThoai varchar(13), @moTa nvarchar(200), @email varchar(50))
AS BEGIN
DECLARE @ChuoiTruyVan nvarchar(3000),
        @DSThamSo nvarchar(500)
        
IF (@HoTen IS NOT NULL AND @TenDangNhap IS NOT NULL AND @MatKhau IS NOT NULL AND @soCMND IS NOT NULL AND @diaChi IS NOT NULL AND @soDienThoai IS NOT NULL AND @email IS NOT NULL)
	BEGIN
		DECLARE @KT_tenDangNhap int
		SELECT @KT_tenDangNhap = COUNT(*)
		FROM KhachHang
		WHERE tenDangNhap = @TenDangNhap
		DECLARE @KT_soCMND int
		SELECT @KT_soCMND = COUNT(*)
		FROM KhachHang
		WHERE soCMND = @soCMND
		DECLARE @KT_soDienThoai int
		SELECT @KT_soDienThoai = COUNT(*)
		FROM KhachHang
		WHERE soDienThoai = @soDienThoai
		DECLARE @KT_email int
		SELECT @KT_email = COUNT(*)
		FROM KhachHang
		WHERE email = @email

		IF (@KT_tenDangNhap > 0)
			BEGIN
				PRINT N'Tên Đăng Nhập Đã Tồn Tại.';
			END
		ELSE IF (@KT_soCMND > 0)
			BEGIN
				PRINT N'Số CMND Đã Tồn Tại.';
			END
		ELSE IF (@KT_soDienThoai > 0)
			BEGIN
				PRINT N'Số Điện Thoại Đã Tồn Tại.';
			END
		ELSE IF (@KT_email > 0)
			BEGIN
				PRINT N'Địa Chỉ Email Đã Tồn Tại.';
			END
		ELSE
			SET @ChuoiTruyVan = 'INSERT INTO KhachHang (hoTen, tenDangNhap, matKhau, soCMND, diaChi, soDienThoai, moTa, email) 
								VALUES (@HoTen, @TenDangNhap, @MatKhau, @soCMND, @diaChi, @soDienThoai, @moTa, @email)'
	END
ELSE
	PRINT N'Bạn Chưa Điền Đầy Đủ Thông Tin Đăng Ký.';


SET @DSThamSo =' @HoTen nvarchar(50), @TenDangNhap nvarchar(20), @MatKhau varchar(50), @soCMND varchar(9), @diaChi nvarchar(100), @soDienThoai varchar(13), @moTa nvarchar(200), @email varchar(50) '

EXEC SP_EXECUTESQL @ChuoiTruyVan, 
				   @DSThamSo,
				   @HoTen, 
				   @TenDangNhap, 
				   @MatKhau, 
				   @soCMND,
				   @diaChi,
				   @soDienThoai,
				   @moTa,
				   @email


END