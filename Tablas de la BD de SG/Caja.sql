USE [SG906]
GO

/****** Object:  Table [dbo].[Caja]    Script Date: 02/10/2019 18:33:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Caja](
	[cajas_id] [int] NOT NULL,
	[cajas_nombre] [varchar](50) NOT NULL,
	[cajas_sucursal] [int] NOT NULL,
	[cajas_operador] [int] NOT NULL,
	[cajas_status] [int] NOT NULL,
	[caajas_efectivo] [decimal](18, 0) NOT NULL,
	[cajas_tarjeta_debito] [decimal](18, 0) NOT NULL,
	[cajas_tarjeta_credito] [decimal](18, 0) NOT NULL,
	[cajas_valor_vales] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_cajas] PRIMARY KEY CLUSTERED 
(
	[cajas_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Caja]  WITH CHECK ADD  CONSTRAINT [FK_operadores] FOREIGN KEY([cajas_operador])
REFERENCES [dbo].[Operadores] ([operador_id])
GO

ALTER TABLE [dbo].[Caja] CHECK CONSTRAINT [FK_operadores]
GO

ALTER TABLE [dbo].[Caja]  WITH CHECK ADD  CONSTRAINT [FK_sucursal] FOREIGN KEY([cajas_sucursal])
REFERENCES [dbo].[Sucursales] ([sucursal_id])
GO

ALTER TABLE [dbo].[Caja] CHECK CONSTRAINT [FK_sucursal]
GO


