USE [SG906]
GO

/****** Object:  Table [dbo].[producto]    Script Date: 02/10/2019 18:34:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[producto](
	[codigo_producto] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](500) NOT NULL,
	[costo_estandar] [decimal](18, 0) NOT NULL,
	[precio_venta] [decimal](18, 0) NOT NULL,
	[precio_sin_iva] [decimal](18, 0) NOT NULL,
	[codigo_alterno] [varchar](50) NOT NULL,
	[nombre_alterno] [varchar](50) NOT NULL,
	[descripcion_corta] [varchar](250) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


