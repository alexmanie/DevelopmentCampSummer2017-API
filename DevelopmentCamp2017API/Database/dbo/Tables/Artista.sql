CREATE TABLE [dbo].[Artista]
(
	[IdArtista] INT NOT NULL IDENTITY , 
    [Nombre] VARCHAR(50) NULL, 
    [Apellido_1] VARCHAR(50) NULL, 
    [Edad] INT NULL, 
    CONSTRAINT [PK_Artista] PRIMARY KEY ([IdArtista]) 
)
