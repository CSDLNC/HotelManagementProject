USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_LoginAccount (@TenDangNhap nvarchar(20), @MatKhau varchar(50))
AS BEGIN
DECLARE @ChuoiTruyVan nvarchar(3000),
        @DSThamSo nvarchar(500)
        
IF (@TenDangNhap IS NOT NULL AND @MatKhau IS NOT NULL)
	BEGIN
		DECLARE @KT_DN int
		SELECT @KT_DN = COUNT(*)
		FROM KhachHang
		WHERE tenDangNhap = @TenDangNhap AND MatKhau = @MatKhau

		IF (@KT_DN > 0)
			PRINT N'Đăng Nhập Thành Công !!!.';
		ELSE
			PRINT N'Tên Đăng Nhập Không Tồn Tại Hoặc Mật Khẩu Không Chính Xác !!!.';
	END
ELSE
	PRINT N'Vui Lòng Nhập Đầy Đủ Tên Đăng Nhập Và Mật Khẩu !!!.';

SET @DSThamSo =' @TenDangNhap nvarchar(20), @MatKhau varchar(50) '

EXEC SP_EXECUTESQL @ChuoiTruyVan, 
				   @DSThamSo, 
				   @TenDangNhap, 
				   @MatKhau


END