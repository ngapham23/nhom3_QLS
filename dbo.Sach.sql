CREATE TABLE [dbo].[Sach] (
    [MaSach]    INT           NOT NULL ,
    [TenSach]   NVARCHAR (50) NULL,
    [GiaBan]    INT           NULL,
    [SoLuong]   INT           NULL,
    [MaTacGia]  INT           NOT NULL,
    [MaTheLoai] INT           NOT NULL,
    [MaNXB]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([MaSach] ASC),
    CONSTRAINT [FK_Sach_ToTable] FOREIGN KEY ([MaTacGia]) REFERENCES [dbo].[TacGia] ([MaTacGia]),
    CONSTRAINT [FK_Sach_ToTable_1] FOREIGN KEY ([MaTheLoai]) REFERENCES [dbo].[TheLoai] ([MaTheLoai]),
    CONSTRAINT [FK_Sach_ToTable_2] FOREIGN KEY ([MaNXB]) REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
);

