USE [MVC]
GO

/****** Object:  Table [dbo].[Movie]    Script Date: 16-03-2020 22:41:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Cust](
	[FirstName] [varchar](max) NULL,
	[LastName] [varchar](max) NULL,
	[Date] DATE NULL,
	[Time] VARCHAR (max),
	[Suburb] [varchar](max) NULL,
	[Zipcode] INT,
	[Category] [varchar] (max) NULL,
	[ID] INT NOT NULL,
	[Description] [varchar](max) NULL,
	[Price] NUMERIC(12,2),
	[Phone] [varchar] (max) NULL,
	[Email] [varchar](max) NULL,
	[Status] [varchar] (max), 
	PRIMARY KEY (ID)
	)

GO

SET ANSI_PADDING OFF
GO










