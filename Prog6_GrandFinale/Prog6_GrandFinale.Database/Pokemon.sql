CREATE TABLE [dbo].[Pokemon]
(
	[Name] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Type] NVARCHAR(50) NOT NULL, 
    [Level] INT NOT NULL, 
    [DateOfBirth] DATE NOT NULL
)
