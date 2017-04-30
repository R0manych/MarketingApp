USE [MarketingAppDataStorage]
GO

/****** Объект: Table [dbo].[Clients] Дата скрипта: 30.04.2017 15:00:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Clients];


GO
CREATE TABLE [dbo].[Clients] (
    [Id]       INT            IDENTITY (0, 1) NOT NULL,
    [Name]     NVARCHAR (50)  NOT NULL,
    [Phone]    NVARCHAR (20)  NOT NULL,
    [Passport] NVARCHAR (50)  NULL,
    [Adress]   NVARCHAR (MAX) NULL,
    [Contract] NVARCHAR (50)  NULL,
    [BankCard] NVARCHAR (50)  NULL,
    [Birthday] DATETIME       NULL,
    [Email]    NVARCHAR (50)  NULL,
    [Points]   INT            NULL,
    [ParentId] INT            NULL
);


