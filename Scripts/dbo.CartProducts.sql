USE [MarketingAppData]
GO

/****** Объект: Table [dbo].[CartProducts] Дата скрипта: 01.04.2017 23:58:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[CartProducts];


GO
CREATE TABLE [dbo].[CartProducts] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ProductId] INT NOT NULL,
    [CartId]    INT NOT NULL,
    [Count]     INT NOT NULL
);


