USE [SG906]
GO

/****** Object:  Table [dbo].[ventas_detalle_temporal]    Script Date: 02/10/2019 19:15:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ventas_detalle_temporal](
	[id_detalle_temp] [int] NOT NULL,
	[folio] [int] NOT NULL,
	[producto] [varchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[importe] [decimal](18, 2) NOT NULL,
	[iva] [decimal](18, 2) NOT NULL,
	[descuento] [decimal](18, 2) NOT NULL,
	[importe_total] [decimal](18, 2) NOT NULL,
	[caja_nombre] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


