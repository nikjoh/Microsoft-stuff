CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[UserName] varchar (50) not null,
	[Password] varchar (50) not null,
	[Image] varchar (200) null,
	[Info] varchar (MAX) null,
	
)
