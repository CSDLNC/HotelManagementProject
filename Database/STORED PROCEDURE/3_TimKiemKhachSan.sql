USE [QuanLyKhachSan]
GO

-- Searching hotel inform by city
CREATE PROCEDURE SP_SearchHotelByCity
(
	@City nvarchar(30)
)
AS
BEGIN

	DECLARE @SqlString nvarchar(2000), @input nvarchar(1000);

	IF (@City IS NOT NULL)
	SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE KS.thanhPho = @City'

	SET @input = '@City nvarchar(30)'

	EXEC SP_EXECUTESQL @SqlString, @input, @City

END

-- Searching hotel inform by city and price
CREATE PROCEDURE SP_SearchHotelByCity_Price
(
	@City nvarchar(30),
	@Price money
)
AS
BEGIN

	DECLARE @SqlString nvarchar(2000), @input nvarchar(1000);

	IF (@City IS NOT NULL AND @Price IS NOT NULL)
	SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE KS.thanhPho = @City AND KS.giaTB = @Price'

	SET @input = '@City nvarchar(30), @Price money'

	EXEC SP_EXECUTESQL @SqlString, @input, @City, @Price

END

-- Searching hotel inform by city and star voting
CREATE PROCEDURE SP_SearchHotelByCity_voteStar
(
	@City nvarchar(30),
	@voteStar int
)
AS
BEGIN

	DECLARE @SqlString nvarchar(2000), @input nvarchar(1000);

	IF (@City IS NOT NULL AND @voteStar IS NOT NULL)
	SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE KS.thanhPho = @City AND KS.soSao = @voteStar'

	SET @input = '@City nvarchar(30), @voteStar int'

	EXEC SP_EXECUTESQL @SqlString, @input, @City, @voteStar

END