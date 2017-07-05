CREATE TABLE [dbo].[Producto]
(
	[IdProducto] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] VARCHAR(50) NULL, 
    [IdTipoProducto] INT NOT NULL, 
    [FechaLanzamiento] DATETIME NOT NULL, 
    CONSTRAINT [FK_Producto_TipoProducto] FOREIGN KEY ([IdTipoProducto]) REFERENCES [TipoProducto]([IdTipoProducto])
)