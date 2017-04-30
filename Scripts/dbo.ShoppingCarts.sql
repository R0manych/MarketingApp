USE [MarketingAppData]
GO

/****** Объект: Table [dbo].[ShoppingCarts] Дата скрипта: 30.04.2017 13:59:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[ShoppingCarts];


GO
CREATE TABLE [dbo].[ShoppingCarts] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Number]    NVARCHAR (50) NOT NULL,
    [Date]      DATETIME2 (7) NOT NULL,
    [ClientId]  INT           NOT NULL,
    [Delivered] BIT           NOT NULL
);


