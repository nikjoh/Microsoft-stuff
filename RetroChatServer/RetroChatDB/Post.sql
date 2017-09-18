CREATE TABLE [dbo].[Post]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[Image] varchar (200) not null,
	[Text] varchar(200) not null,
	[Like] int default ((0)) null,
	[UserID] int not null,
	foreign key (UserID) references [User] ([Id])
	on delete cascade
)
