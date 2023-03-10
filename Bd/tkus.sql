USE [Tkos]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 20/12/2022 3:24:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[IdCities] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCities] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[form]    Script Date: 20/12/2022 3:24:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[form](
	[IdForm] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](75) NOT NULL,
	[Fktypeform] [int] NOT NULL,
	[Fksuppliers] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdForm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[security]    Script Date: 20/12/2022 3:24:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[security](
	[IdSecurity] [int] IDENTITY(1,1) NOT NULL,
	[Users] [varchar](50) NOT NULL,
	[NameUser] [varchar](10) NOT NULL,
	[Password] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSecurity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[services]    Script Date: 20/12/2022 3:24:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[services](
	[IdServices] [int] IDENTITY(1,1) NOT NULL,
	[Nit] [char](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [smallmoney] NOT NULL,
	[FkSupplier] [int] NOT NULL,
	[Fkcities] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdServices] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 20/12/2022 3:24:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[IdSupplier] [int] IDENTITY(1,1) NOT NULL,
	[Nit] [char](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSupplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[typeform]    Script Date: 20/12/2022 3:24:00 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[typeform](
	[Idtypeform] [int] IDENTITY(1,1) NOT NULL,
	[string] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Idtypeform] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (1, N'Mexico')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (2, N'Colombia')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (3, N'Peru')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (4, N'Argentina')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (5, N'Uruaguay')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (6, N'Brasil')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (7, N'Venezuela')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (8, N'Ecuadro')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (9, N'Chile')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (10, N'Paraguay')
INSERT [dbo].[Cities] ([IdCities], [Name]) VALUES (11, N'string')
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[form] ON 

INSERT [dbo].[form] ([IdForm], [Name], [Fktypeform], [Fksuppliers]) VALUES (3, N'Hola Amigos', 1, 1)
INSERT [dbo].[form] ([IdForm], [Name], [Fktypeform], [Fksuppliers]) VALUES (4, N'Cosas ex', 1, 2)
SET IDENTITY_INSERT [dbo].[form] OFF
GO
SET IDENTITY_INSERT [dbo].[services] ON 

INSERT [dbo].[services] ([IdServices], [Nit], [Name], [Price], [FkSupplier], [Fkcities]) VALUES (1, N'456123    ', N'IOnternet', 42000.0000, 1, 2)
INSERT [dbo].[services] ([IdServices], [Nit], [Name], [Price], [FkSupplier], [Fkcities]) VALUES (2, N'45687     ', N'Soporte', 45.0000, 2, 4)
INSERT [dbo].[services] ([IdServices], [Nit], [Name], [Price], [FkSupplier], [Fkcities]) VALUES (3, N'string    ', N'string', 0.0000, 5, 11)
SET IDENTITY_INSERT [dbo].[services] OFF
GO
SET IDENTITY_INSERT [dbo].[suppliers] ON 

INSERT [dbo].[suppliers] ([IdSupplier], [Nit], [Name], [Email]) VALUES (1, N'123455789 ', N'tkos', N'rkos@gmail.com')
INSERT [dbo].[suppliers] ([IdSupplier], [Nit], [Name], [Email]) VALUES (2, N'456789123 ', N'Cafetal', N'Cafetal@gmail.com')
INSERT [dbo].[suppliers] ([IdSupplier], [Nit], [Name], [Email]) VALUES (4, N'4567896231', N'Colsanitas', N'colsanitasgmail.com')
INSERT [dbo].[suppliers] ([IdSupplier], [Nit], [Name], [Email]) VALUES (5, N'string    ', N'string', N'string')
SET IDENTITY_INSERT [dbo].[suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[typeform] ON 

INSERT [dbo].[typeform] ([Idtypeform], [string]) VALUES (1, N'Varchar')
SET IDENTITY_INSERT [dbo].[typeform] OFF
GO
ALTER TABLE [dbo].[form]  WITH CHECK ADD FOREIGN KEY([Fksuppliers])
REFERENCES [dbo].[suppliers] ([IdSupplier])
GO
ALTER TABLE [dbo].[form]  WITH CHECK ADD FOREIGN KEY([Fktypeform])
REFERENCES [dbo].[typeform] ([Idtypeform])
GO
ALTER TABLE [dbo].[services]  WITH CHECK ADD FOREIGN KEY([Fkcities])
REFERENCES [dbo].[Cities] ([IdCities])
GO
ALTER TABLE [dbo].[services]  WITH CHECK ADD FOREIGN KEY([FkSupplier])
REFERENCES [dbo].[suppliers] ([IdSupplier])
GO
