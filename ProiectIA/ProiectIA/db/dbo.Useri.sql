CREATE TABLE [dbo].[Useri]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Nume] NCHAR(32) NULL, 
    [Parola] NCHAR(20) NULL, 
    [Data_Inregistrare] DATETIME NULL
)
