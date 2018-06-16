USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_SearchBill (@ConsID int, @Day datetime, @minTotal money, @maxTotal money)
AS BEGIN
DECLARE @SqlString nvarchar(1000),
        @ParaList nvarchar(1000)
        
SET @SqlString= 'SELECT maHD, ngayThanhToan, tongTien FROM HoaDon HD, DatPhong DP WHERE (HD.maDP =DP.maDP)'

IF @ConsID IS NOT NULL SET @SqlString= @SqlString + ' AND (DP.maKH =@ConsID )'

IF @Day IS NOT NULL SET @SqlString = @SqlString + ' AND ( CONVERT(date,HD.ngayThanhToan) = @Day ) '

IF (@minTotal IS NOT NULL and @maxTotal IS NOT NULL) -- Neu co 2 can
SET @SqlString = @SqlString + ' AND (HD.tongTien >= @minTotal ) AND (HD.tongTien <= @maxTotal ) '
ELSE
IF (@minTotal IS NULL and @maxTotal IS NOT NULL) -- Neu ko co min
SET @SqlString = @SqlString + ' AND (HD.tongTien <= @maxTotal ) '
ELSE
IF (@minTotal IS NOT NULL and @maxTotal IS NULL) -- Neu ko co max
SET @SqlString = @SqlString + ' AND (HD.tongTien >= @minTotal ) ' 

SET @ParaList =' @ConsID int, @Day datetime, @minTotal money, @maxTotal money '

EXEC SP_EXECUTESQL @SqlString, 
				   @ParaList, 
				   @ConsID, 
				   @Day, 
				   @minTotal,
				   @maxTotal


END