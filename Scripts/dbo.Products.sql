USE [MarketingAppData]
GO

/****** Объект: Table [dbo].[Products] Дата скрипта: 30.04.2017 13:59:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Products];


GO
CREATE TABLE [dbo].[Products] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Description] NVARCHAR (50) NULL,
    [Price]       DECIMAL (18)  NOT NULL
);


