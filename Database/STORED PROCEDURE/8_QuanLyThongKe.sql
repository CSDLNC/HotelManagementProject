USE [QuanLyKhachSan]
GO

CREATE PROCEDURE SP_EmptyRoomStatistics(@hotelname NVARCHAR(50),@typeofroomname NVARCHAR(50) ,@date DATETIME, @sortoption INT)
AS BEGIN
DECLARE @sqlstring NVARCHAR(1500), @input NVARCHAR(100)
IF(@date IS NOT NULL)
BEGIN
	SET @sqlstring = 'SELECT K.maKS, K.tenKS, L.maLoaiPhong, L.tenLoaiPhong, K.thanhPho, K.soSao, SUM(CASE WHEN T3.tinhTrang=0 THEN 1 ELSE 0 END) AS soPhongTrong
					  FROM (SELECT T1.maPhong, MAX(T1.ngay) AS ngay FROM TrangThaiPhong T1 WHERE CONVERT(date,T1.ngay)=CONVERT(date,@date) GROUP BY T1.maPhong) AS T2, TrangThaiPhong T3, Phong P, KhachSan K, LoaiPhong L 
					  WHERE T3.maPhong=T2.maPhong AND T3.ngay = T2.ngay and T3.maPhong=P.maPhong AND P.loaiPhong=L.maLoaiPhong AND L.maKS=K.maKS '

	---IF(@hotelname IS NULL)---không thống kê theo khách sạn --không làm gì cả
	IF(@hotelname IS NOT  NULL)---thống kê theo khách sạn 
		SET @sqlstring = @sqlstring + ' AND K.tenKS LIKE N''%' +@hotelname + '%'''
	---IF(@typeofroomname IS NULL)---không thống kê theo loại phòng --không làm gì cả
	IF(@typeofroomname IS NOT  NULL)---thống kê theo khách sạn 
		set @sqlstring = @sqlstring + ' AND L.tenLoaiPhong LIKE N''%' +@typeofroomname + '%'''

	---thêm phần group by và order
	SET @sqlstring = @sqlstring + ' GROUP BY K.maKS, K.tenKS, K.thanhPho, K.soSao,L.maLoaiPhong, L.tenLoaiPhong'
	IF (@sortoption = 2) --nếu muốn sắp xếp theo thành phố và số sao
		SET @sqlstring = @sqlstring + ' ORDER BY K.thanhPho, K.soSao'
	IF (@sortoption = 1) --nếu muốn sắp xếp theo thành phố
		SET @sqlstring = @sqlstring + ' ORDER BY K.thanhPho'
	IF (@sortoption = 0) --nếu muốn sắp xếp theo số sao
		SET @sqlstring = @sqlstring + ' ORDER BY K.soSao'
	---IF (@sortoption = 3) ---khong sap xep
END
ELSE
BEGIN
	RAISERROR (N'Lỗi! không chọn ngày thống kê',16,1);
	RETURN
END
SET @input = ' @hotelname NVARCHAR (50),@typeofroomname NVARCHAR(50) ,@date DATETIME, @sortoption INT '
EXEC SP_EXECUTESQL @sqlstring,
			       @input,
				   @hotelname,
				   @typeofroomname,
				   @date,
				   @sortoption
END