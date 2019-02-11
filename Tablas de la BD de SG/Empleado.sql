USE [SG906]
GO

/****** Object:  Table [dbo].[Empleado]    Script Date: 02/10/2019 18:34:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Empleado](
	[empleado_id] [int] NOT NULL,
	[empleado_nombre] [varchar](74) NOT NULL,
	[empleado_apellido_paterno] [varchar](50) NOT NULL,
	[empleado_apellido_materno] [varchar](50) NOT NULL,
	[empleado_RFC] [varchar](50) NOT NULL,
	[empleado_domicilio] [text] NOT NULL,
	[empleado_salario] [decimal](18, 0) NOT NULL,
	[empleado_telefono] [varchar](20) NOT NULL,
	[empleado_user_id] [nchar](10) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


