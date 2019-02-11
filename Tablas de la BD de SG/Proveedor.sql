USE [SG906]
GO

/****** Object:  Table [dbo].[Proveedor]    Script Date: 02/10/2019 18:35:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] NULL,
	[razon_social] [varchar](50) NULL,
	[correo_electronico] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
	[proveedor] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


