USE [SG906]
GO

/****** Object:  Table [dbo].[ventas_detalle]    Script Date: 02/10/2019 19:14:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ventas_detalle](
	[folio] [int] NULL,
	[producto] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[importe] [decimal](18, 2) NULL,
	[iva] [decimal](18, 2) NULL,
	[descuento] [decimal](18, 2) NULL,
	[importe_total] [decimal](18, 2) NULL,
	[caja_nombre] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


