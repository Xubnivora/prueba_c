USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[BODEGA]    Script Date: 4/23/2024 11:09:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BODEGA](
	[id_bodega] [int] NOT NULL,
	[direccion] [nvarchar](64) NOT NULL,
	[eje_x] [numeric](10, 7) NOT NULL,
	[eje_y] [numeric](10, 7) NOT NULL,
	[largo] [numeric](8, 2) NOT NULL,
	[ancho] [numeric](8, 2) NOT NULL,
	[altura] [numeric](8, 2) NOT NULL,
	[refrigeracion] [bit] NULL,
	[caja_fuerte] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[FOLIO]    Script Date: 4/23/2024 11:09:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FOLIO](
	[id_folio] [int] NOT NULL,
	[cantidad_kardex] [int] NOT NULL,
	[fecha_registro] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[KARDEX_DETALLE]    Script Date: 4/23/2024 11:09:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KARDEX_DETALLE](
	[fecha] [date] NOT NULL,
	[id_kardex] [int] NOT NULL,
	[id_tipo_operacion] [int] NOT NULL,
	[id_detalle_kardex] [int] NOT NULL,
	[entrada_cantidad] [int] NULL,
	[entrada_valor_unitario] [decimal](10, 2) NULL,
	[entrada_valor_total] [decimal](10, 2) NULL,
	[salida_cantidad] [int] NULL,
	[salida_valor_unitario] [decimal](10, 2) NULL,
	[salida_valor_total] [decimal](10, 2) NULL,
	[saldos_cantidad] [int] NULL,
	[saldos_valor_unitario] [decimal](10, 2) NULL,
	[saldos_valor_total] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_kardex] ASC,
	[id_tipo_operacion] ASC,
	[id_detalle_kardex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[KARDEX_DETALLE]  WITH CHECK ADD FOREIGN KEY([id_kardex])
REFERENCES [dbo].[KARDEX_ENCABEZADO] ([id_kardex])
GO

ALTER TABLE [dbo].[KARDEX_DETALLE]  WITH CHECK ADD FOREIGN KEY([id_tipo_operacion])
REFERENCES [dbo].[TIPO_OPERACION] ([id_tipo_operacion])
GO

USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[KARDEX_ENCABEZADO]    Script Date: 4/23/2024 11:09:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KARDEX_ENCABEZADO](
	[id_kardex] [int] NOT NULL,
	[id_folio] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[serie_lote] [nvarchar](8) NOT NULL,
	[id_lote] [int] NOT NULL,
	[id_bodega] [int] NOT NULL,
	[id_metodo] [int] NOT NULL,
	[fecha_creacion] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_kardex] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[KARDEX_ENCABEZADO]  WITH CHECK ADD FOREIGN KEY([id_folio])
REFERENCES [dbo].[FOLIO] ([id_folio])
GO

ALTER TABLE [dbo].[KARDEX_ENCABEZADO]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[PRODUCTO] ([id_producto])
GO

USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[LOTE]    Script Date: 4/23/2024 11:09:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LOTE](
	[serie_lote] [nvarchar](8) NOT NULL,
	[id_lote] [int] NOT NULL,
	[id_bodega] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_tipo_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[fecha_ingreso] [date] NULL,
	[fecha_vencimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[serie_lote] ASC,
	[id_lote] ASC,
	[id_bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LOTE]  WITH CHECK ADD FOREIGN KEY([id_bodega])
REFERENCES [dbo].[BODEGA] ([id_bodega])
GO

ALTER TABLE [dbo].[LOTE]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[PRODUCTO] ([id_producto])
GO

ALTER TABLE [dbo].[LOTE]  WITH CHECK ADD FOREIGN KEY([id_tipo_producto])
REFERENCES [dbo].[TIPO_PRODUCTO] ([id_tipo_producto])
GO

USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[METODOLOGIA_INVENTARIO]    Script Date: 4/23/2024 11:09:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[METODOLOGIA_INVENTARIO](
	[id_inventario] [int] NOT NULL,
	[nombre_metodologia] [varchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 4/23/2024 11:10:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PRODUCTO](
	[id_producto] [int] NOT NULL,
	[id_tipo_producto] [int] NOT NULL,
	[nombre_producto] [nvarchar](128) NULL,
	[precio_unitario_producto] [decimal](10, 2) NULL,
	[SKU] [nvarchar](128) NULL,
	[codigo_barras] [nvarchar](128) NULL,
	[peso_kg] [decimal](7, 2) NULL,
	[detalles_producto] [nvarchar](512) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PRODUCTO]  WITH CHECK ADD FOREIGN KEY([id_tipo_producto])
REFERENCES [dbo].[TIPO_PRODUCTO] ([id_tipo_producto])
GO

USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[TIPO_OPERACION]    Script Date: 4/23/2024 11:10:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TIPO_OPERACION](
	[id_tipo_operacion] [int] NOT NULL,
	[nombre_operacion] [varchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_operacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [PRUEBA_C]
GO

/****** Object:  Table [dbo].[TIPO_PRODUCTO]    Script Date: 4/23/2024 11:10:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TIPO_PRODUCTO](
	[id_tipo_producto] [int] NOT NULL,
	[nombre_tipo_producto] [nvarchar](128) NULL,
	[detalles_tipo_producto] [nvarchar](512) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

