CREATE TABLE [dbo].[Job] (
    [IDNguoiThue] NVARCHAR (50) NULL,
	[TenNguoiThue] NVARCHAR (MAX) NULL,
	[IDNguoiLam] NVARCHAR (50) NULL,
	[TenNguoiLam] NVARCHAR (MAX) NULL,
	[MaCV] NVARCHAR (50) NULL,
	[MoTaCV] NVARCHAR (MAX) NULL,
	[TrangThaiCV] NVARCHAR (MAX) NULL,
	[DanhGia] NVARCHAR (50) DEFAULT '0',
	[BinhLuan] NVARCHAR (MAX) NULL,
	[NgayLam] NVARCHAR (50) NULL,
	[Luong] INT,
	[DaDanhGia] NVARCHAR (50) DEFAULT '0'
);