USE [MarketingAppDataStorage]
GO

/****** Объект: Table [dbo].[CartProducts] Дата скрипта: 30.04.2017 13:58:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[CartProducts];


GO
CREATE TABLE [dbo].[CartProducts] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [Count]     INT NOT NULL,
    [ProductId] INT NOT NULL,
    [CartId]    INT NOT NULL
);


