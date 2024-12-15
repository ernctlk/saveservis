CREATE TABLE [dbo].[Table]
(
	[Id] INT  IDENTITY (1, 1) NOT NULL, 
    [barkot] NVARCHAR(MAX) NULL, 
    [oem no] NVARCHAR(MAX) NULL, 
    [adi] NVARCHAR(MAX) NULL, 
    [miktar] NVARCHAR(MAX) NULL, 
    [birim] NVARCHAR(MAX) NULL, 
    [alisFiyat] NVARCHAR(MAX) NULL, 
    [satisFiyat] NVARCHAR(MAX) NULL, 
    [alisTarih] NVARCHAR(MAX) NULL, 
    [sonKullanma] NVARCHAR(MAX) NULL, 
    [alindiğiYer] NVARCHAR(MAX) NULL, 
    [ürünAdresi] NVARCHAR(MAX) NULL
)
