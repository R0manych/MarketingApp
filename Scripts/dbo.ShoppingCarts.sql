CREATE TABLE [dbo].[ShoppingCarts] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Number]   NVARCHAR (50) NULL,
    [Date]     DATETIME      NULL,
    [ClientId] INT           NOT NULL,
    [Delivered] BIT NOT NULL DEFAULT 0, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ShoppingCarts_ToClients] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Clients] ([Id])
);

