USE [BugsClase04]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 08/25/2018 12:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([id_producto], [nombre]) VALUES (1, N'SOFTWARE GESTION II')
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[Prioridades]    Script Date: 08/25/2018 12:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prioridades](
	[id_prioridad] [int] IDENTITY(1,1) NOT NULL,
	[n_prioridad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Prioridades] PRIMARY KEY CLUSTERED 
(
	[id_prioridad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Prioridades] ON
INSERT [dbo].[Prioridades] ([id_prioridad], [n_prioridad]) VALUES (1, N'BAJA')
INSERT [dbo].[Prioridades] ([id_prioridad], [n_prioridad]) VALUES (2, N'MEDIA')
INSERT [dbo].[Prioridades] ([id_prioridad], [n_prioridad]) VALUES (3, N'ALTA')
INSERT [dbo].[Prioridades] ([id_prioridad], [n_prioridad]) VALUES (4, N'URGENTE')
SET IDENTITY_INSERT [dbo].[Prioridades] OFF
/****** Object:  Table [dbo].[Perfiles]    Script Date: 08/25/2018 12:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[n_perfil] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (1, N'Administrador')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (2, N'Tester')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (3, N'Desarrollador')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (4, N'Responsable de Reportes')
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
/****** Object:  Table [dbo].[Estados]    Script Date: 08/25/2018 12:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[n_estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Estados] ON
INSERT [dbo].[Estados] ([id_estado], [n_estado]) VALUES (1, N'Nuevo')
INSERT [dbo].[Estados] ([id_estado], [n_estado]) VALUES (2, N'Asignado')
INSERT [dbo].[Estados] ([id_estado], [n_estado]) VALUES (3, N'Cerrado')
INSERT [dbo].[Estados] ([id_estado], [n_estado]) VALUES (4, N'En testing')
SET IDENTITY_INSERT [dbo].[Estados] OFF
/****** Object:  Table [dbo].[Criticidades]    Script Date: 08/25/2018 12:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Criticidades](
	[id_criticidad] [int] IDENTITY(1,1) NOT NULL,
	[n_criticidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Criticidades] PRIMARY KEY CLUSTERED 
(
	[id_criticidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Criticidades] ON
INSERT [dbo].[Criticidades] ([id_criticidad], [n_criticidad]) VALUES (1, N'LEVE')
INSERT [dbo].[Criticidades] ([id_criticidad], [n_criticidad]) VALUES (2, N'GRAVE')
INSERT [dbo].[Criticidades] ([id_criticidad], [n_criticidad]) VALUES (3, N'INVALIDANTE')
SET IDENTITY_INSERT [dbo].[Criticidades] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 08/25/2018 12:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[n_usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[estado] [varchar](1) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([id_usuario], [n_usuario], [password], [email], [id_perfil], [estado]) VALUES (1, N'ADMIN', N'123', N'admin@bt.com', 1, N'S')
INSERT [dbo].[Users] ([id_usuario], [n_usuario], [password], [email], [id_perfil], [estado]) VALUES (2, N'acme', N'test123', N'test123', 2, N'N')
INSERT [dbo].[Users] ([id_usuario], [n_usuario], [password], [email], [id_perfil], [estado]) VALUES (4, N'Test3', N'test', N'test2@bt.com', 3, N'')
INSERT [dbo].[Users] ([id_usuario], [n_usuario], [password], [email], [id_perfil], [estado]) VALUES (5, N'one21', N'fhkjasdhfa', N'fhkjasdhfa', 2, N'N')
INSERT [dbo].[Users] ([id_usuario], [n_usuario], [password], [email], [id_perfil], [estado]) VALUES (6, N'Test11-09', N'123', N'test1109@bugs.com.ar', 3, N'N')
INSERT [dbo].[Users] ([id_usuario], [n_usuario], [password], [email], [id_perfil], [estado]) VALUES (7, N'Melisa', N'123', N'meli@gmail.com', 4, N'S')
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[Bugs]    Script Date: 08/25/2018 12:35:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bugs](
	[id_bug] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[id_producto] [int] NOT NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[fecha_alta] [date] NOT NULL,
 CONSTRAINT [PK_Bugs] PRIMARY KEY CLUSTERED 
(
	[id_bug] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Bugs] ON
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [id_producto], [id_prioridad], [id_criticidad], [fecha_alta]) VALUES (2, N'Test', N'First bug of test', 1, 1, 1, CAST(0x523D0B00 AS Date))
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [id_producto], [id_prioridad], [id_criticidad], [fecha_alta]) VALUES (5, N'TEST FIRST BUG', N'hsfhkADSFHAKDS', 1, 1, 1, CAST(0x523D0B00 AS Date))
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [id_producto], [id_prioridad], [id_criticidad], [fecha_alta]) VALUES (6, N'Tercer bug test', N'Tercer bug test', 1, 2, 3, CAST(0x533D0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Bugs] OFF
/****** Object:  ForeignKey [FK_Bugs_Criticidades]    Script Date: 08/25/2018 12:35:19 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Criticidades]
GO
/****** Object:  ForeignKey [FK_Bugs_Prioridades]    Script Date: 08/25/2018 12:35:19 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Prioridades]
GO
/****** Object:  ForeignKey [FK_Bugs_Productos]    Script Date: 08/25/2018 12:35:19 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Productos]
GO
/****** Object:  ForeignKey [FK_Users_Perfiles]    Script Date: 08/25/2018 12:35:19 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Perfiles]
GO
