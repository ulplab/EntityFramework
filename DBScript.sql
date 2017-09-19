USE [ef5demo]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 09/19/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ProveedorId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProveedorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 09/19/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[CategoriaId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoriaId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 09/19/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoId] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](50) NOT NULL,
	[Costo] [decimal](18, 2) NOT NULL,
	[CoefUtil] [decimal](18, 2) NOT NULL,
	[Estado] [bit] NOT NULL,
	[CategoriaId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoProveedor]    Script Date: 09/19/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoProveedor](
	[ProductoId] [int] NOT NULL,
	[ProveedorId] [int] NOT NULL,
 CONSTRAINT [PK_ProductoProveedor] PRIMARY KEY CLUSTERED 
(
	[ProductoId] ASC,
	[ProveedorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__Categoria__Estad__1B0907CE]    Script Date: 09/19/2017 11:50:37 ******/
ALTER TABLE [dbo].[Categoria] ADD  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__tmp_ms_xx__Estad__36B12243]    Script Date: 09/19/2017 11:50:37 ******/
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Proveedor__Estad__1BFD2C07]    Script Date: 09/19/2017 11:50:37 ******/
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  ForeignKey [FK_Producto_ToCategoria]    Script Date: 09/19/2017 11:50:37 ******/
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_ToCategoria] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categoria] ([CategoriaId])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_ToCategoria]
GO
/****** Object:  ForeignKey [FK_ProductoProveedor_ToProducto]    Script Date: 09/19/2017 11:50:37 ******/
ALTER TABLE [dbo].[ProductoProveedor]  WITH CHECK ADD  CONSTRAINT [FK_ProductoProveedor_ToProducto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Producto] ([ProductoId])
GO
ALTER TABLE [dbo].[ProductoProveedor] CHECK CONSTRAINT [FK_ProductoProveedor_ToProducto]
GO
/****** Object:  ForeignKey [FK_ProductoProveedor_ToProveedor]    Script Date: 09/19/2017 11:50:37 ******/
ALTER TABLE [dbo].[ProductoProveedor]  WITH CHECK ADD  CONSTRAINT [FK_ProductoProveedor_ToProveedor] FOREIGN KEY([ProveedorId])
REFERENCES [dbo].[Proveedor] ([ProveedorId])
GO
ALTER TABLE [dbo].[ProductoProveedor] CHECK CONSTRAINT [FK_ProductoProveedor_ToProveedor]
GO
