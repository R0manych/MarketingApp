USE [MarketingAppData]
GO

/****** Объект: Table [dbo].[Products] Дата скрипта: 01.04.2017 23:59:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Products];


GO
CREATE TABLE [dbo].[Products] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Price]       MONEY          NULL
);


