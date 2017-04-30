USE [MarketingAppData]
GO

/****** Объект: Table [dbo].[Clients] Дата скрипта: 30.04.2017 13:59:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Clients];


GO
CREATE TABLE [dbo].[Clients] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Phone]    NVARCHAR (MAX) NULL,
    [Passport] NVARCHAR (MAX) NULL,
    [Contract] NVARCHAR (MAX) NULL,
    [Adress]   NVARCHAR (MAX) NULL,
    [BankCard] NVARCHAR (MAX) NULL,
    [Birthday] DATETIME       NOT NULL,
    [Email]    NVARCHAR (MAX) NULL,
    [Points]   INT            NULL,
    [ParentId] INT            NOT NULL
);


