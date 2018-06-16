USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_RevenueReport (@option NVARCHAR(10),@hotelname NVARCHAR(50), @m INT, @y INT)
AS BEGIN
DECLARE @sqlstring nvarchar(1500), @input nvarchar(100)
IF(@option = N'Tháng' AND @y IS NULL) --báo cáo doanh thu theo tháng
	BEGIN
	SET @sqlstring = 'SELECT K.maKS, K.tenKS, DATEPART(MONTH,H.ngayThanhToan) as Thang, SUM(H.tongTien) as DoanhThu
						      FROM HoaDon H, DatPhong D, LoaiPhong L, KhachSan K
						      WHERE K.maKS=L.MaKS AND L.maLoaiPhong=D.maLoaiPhong AND D.maDP=H.maDP '
		---IF(@hotelname IS NULL) ---không báo cáo theo khách sạn --không làm gì cả
		IF(@hotelname IS NOT NULL)---báo cáo theo khách sạn
		SET @sqlstring = @sqlstring + ' AND K.tenKS LIKE N''%' +@hotelname + '%'''
		---IF(@m IS NULL) ---không làm gì cả
		IF(@m is NOT NULL)
		SET @sqlstring = @sqlstring + ' AND DATEPART(MONTH,H.ngayThanhToan) = @m'
		--thêm group by và order
		SET @sqlstring = @sqlstring + ' GROUP BY DATEPART(MONTH,H.ngayThanhToan), K.maKS, K.tenKS'
		SET @sqlstring = @sqlstring + ' ORDER BY K.maKS'
	END

ELSE IF(@option = N'Năm' AND @m IS NULL) ---báo cáo doanh thu theo năm

BEGIN
	SET @sqlstring = 'SELECT K.maKS, K.tenKS,DATEPART(YEAR,H.ngayThanhToan) as Nam, SUM(H.tongTien) as DoanhThu
					  FROM HoaDon H, DatPhong D, LoaiPhong L, KhachSan K
					  WHERE K.maKS=L.MaKS AND L.maLoaiPhong=D.maLoaiPhong AND D.maDP=H.maDP'
	---IF(@hotelname IS NULL) ---không báo cáo theo khách sạn--không làm gì cả
	IF(@hotelname IS NOT NULL)---báo cáo theo khách sạn
		SET @sqlstring = @sqlstring + ' AND K.tenKS LIKE N''%' +@hotelname + '%'''
	--IF(@y IS NULL) --theo năm bất kỳ ---không làm gì cả
	IF(@y IS NOT NULL)
		SET @sqlstring = @sqlstring + ' AND DATEPART(YEAR,H.ngayThanhToan) = @y'
	--thêm group by và order
	SET @sqlstring = @sqlstring + ' GROUP BY K.maKS, K.tenKS, DATEPART(YEAR,H.ngayThanhToan)'
	SET @sqlstring = @sqlstring + ' ORDER BY K.maKS'
END

ELSE IF (@option=N'Tháng, Năm')
BEGIN
	SET @sqlstring = 'SELECT K.maKS, K.tenKS, DATEPART(MONTH,H.ngayThanhToan) as Thang, DATEPART(YEAR,H.ngayThanhToan) as Nam,SUM(H.tongTien) as DoanhThu
						      FROM HoaDon H, DatPhong D, LoaiPhong L, KhachSan K
						      WHERE  K.maKS=L.MaKS AND L.maLoaiPhong=D.maLoaiPhong AND D.maDP=H.maDP '
	---IF(@hotelname IS NULL) ---không báo cáo theo khách sạn --không làm gì cả
	IF(@hotelname IS NOT NULL)---báo cáo theo khách sạn
		SET @sqlstring = @sqlstring + ' AND K.tenKS LIKE N''%' +@hotelname + '%'''
	--IF(@m IS NULL) --không làm gì cả
	IF(@m IS NOT NULL) 
		SET @sqlstring = @sqlstring + ' AND DATEPART(MONTH,H.ngayThanhToan) = @m'
	--IF(@y IS NULL) --không làm gì cả
	IF(@y IS NOT NULL)
		SET @sqlstring = @sqlstring + ' AND DATEPART(YEAR,H.ngayThanhToan) = @y'
	---thêm phần group by và order
		SET @sqlstring = @sqlstring + ' GROUP BY K.maKS, K.tenKS, DATEPART(MONTH,H.ngayThanhToan), DATEPART(YEAR,H.ngayThanhToan) '
		SET @sqlstring = @sqlstring + ' ORDER BY K.maKS'
END

ELSE
BEGIN
	RAISERROR (N'Lỗi! Không đúng định dạng',16,1);
	RETURN
END
SET @input = ' @option NVARCHAR(10), @hotelname NVARCHAR(50), @m INT, @y INT '
EXEC SP_EXECUTESQL @sqlstring,
				   @input,
				   @option,
				   @hotelname,
				   @m,
				   @y
END