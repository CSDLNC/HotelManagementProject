use QuanLyKhachSan

-- Tổng tiền hóa đơn = (ngày tp - ngày bđ)* Đơn giá
go
CREATE TRIGGER TG_TongTienHD ON HoaDon
FOR INSERT
AS
BEGIN
	DECLARE @maDP int = (SELECT maDP FROM inserted)
	DECLARE @TongTien money
	DECLARE @ngayBD datetime
	DECLARE @ngayTP datetime
	DECLARE @DonGia money
	
	SELECT @ngayBD= ngayBatDau, @ngayTP =ngayTraPhong, @DonGia= donGia
	FROM DatPhong WHERE maDP=@maDP
	
	set @TongTien = datediff(day, @ngayBD, @ngayTP) *@DonGia
	UPDATE HOADON
	SET tongTien = @TongTien WHERE maDP=@maDP
END


-- Ngày đặt nhỏ hơn ngày bđ và ngày trả
go
CREATE TRIGGER TG_NgayDat ON DatPhong
FOR INSERT
AS
BEGIN
	DECLARE @ngaybd datetime 
	DECLARE @ngaytra datetime
	DECLARE @ngaydat datetime
	SELECT @ngaybd= ngayBatDau, @ngaytra =ngayTraPhong, @ngaydat= ngayDat
	FROM inserted

	IF (@ngaydat > @ngaybd or @ngaydat >@ngaytra) -- Không thỏa điều kiện
		RollBack Tran -- Ngăn insert dòng dữ liệu
END


-- Ngày bắt đầu lớn hơn ngày trả
go
CREATE TRIGGER TG_NgayBDNgayTra ON DatPhong
FOR INSERT
AS
BEGIN
	DECLARE @ngaybd datetime 
	DECLARE @ngaytra datetime

	SELECT @ngaybd= ngayBatDau, @ngaytra =ngayTraPhong
	FROM inserted

	IF (@ngaytra < @ngaybd) -- Không thỏa điều kiện
		RollBack Tran -- Ngăn insert dòng dữ liệu
END


-- Ngày lập hóa đơn = ngày trả
go
CREATE TRIGGER TG_NgayThanhToan ON HoaDon
FOR INSERT
AS
BEGIN
	DECLARE @ngaytt datetime  = (SELECT ngayThanhToan  FROM inserted)
	DECLARE @maDP int = (SELECT maDP FROM inserted)
	DECLARE @ngaytra datetime = (SELECT ngayTraPhong FROM DatPhong WHERE maDP= @maDP)

	IF (datediff(day,@ngaytra,@ngaytt) != 0) -- Không thỏa điều kiện
		RollBack Tran -- Ngăn insert dòng dữ liệu
END


-- Những đơn đặt phòng trạng thái "chưa xác định" thì sẽ không có hóa đơn
go
CREATE TRIGGER TG_TrangThaiPhong ON HoaDon
FOR INSERT
AS
BEGIN
	DECLARE @maDP int = (SELECT maDP FROM inserted)
	DECLARE @TinhTrangPhong nvarchar(15) = (SELECT tinhTrang FROM DatPhong WHERE maDP=@maDP) 
	
	IF (@TinhTrangPhong = N'Chưa xác định') -- Không thỏa điều kiện (Tình trạng chưa xác định)
		RollBack Tran -- Ngăn insert dòng dữ liệu
END


------------RBTV Đã cài trực tiếp khi tạo csdl -------
-- mã đp trong bảng hóa đơn là unique
-- tên đn, sdt, mail, cmnd unique
------------------------------------------------------
