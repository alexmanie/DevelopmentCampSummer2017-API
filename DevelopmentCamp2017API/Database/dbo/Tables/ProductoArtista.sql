CREATE TABLE [dbo].[ProductoArtista]
(
	[IdProductoArtista] INT NOT NULL PRIMARY KEY IDENTITY, 
    [idProducto] INT NOT NULL, 
    [idArtista] INT NOT NULL, 
    CONSTRAINT [FK_ProductoArtista_Producto] FOREIGN KEY ([idProducto]) REFERENCES [Producto]([idProducto]), 
    CONSTRAINT [FK_ProductoArtista_Artista] FOREIGN KEY ([idArtista]) REFERENCES [Artista]([idArtista])
)
