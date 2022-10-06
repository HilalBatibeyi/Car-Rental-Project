CREATE TABLE [dbo].[Cars] (
    [CarId]        INT            IDENTITY (1, 1) NOT NULL,
    [BrandId]      INT            NOT NULL,
    [ColorId]      INT            NOT NULL,
    [ModelYear]    INT            NULL,
    [DailyPrice]   INT            NULL,
    [Description] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [FK_Cars_Brands] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    CONSTRAINT [FK_Cars_Colors] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId])
);
