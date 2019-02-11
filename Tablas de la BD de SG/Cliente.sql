USE [SG906]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 02/10/2019 18:34:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] NULL,
	[razon_social] [varchar](50) NULL,
	[correo_electronico] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
	[proveedor] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


