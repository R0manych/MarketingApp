USE [MarketingAppData]
GO

/****** Объект: Table [dbo].[ShoppingCarts] Дата скрипта: 01.04.2017 23:59:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[ShoppingCarts];


GO
CREATE TABLE [dbo].[ShoppingCarts] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Number]   NVARCHAR (50) NULL,
    [Date]     DATETIME      NULL,
    [ClientId] INT           NOT NULL
);


