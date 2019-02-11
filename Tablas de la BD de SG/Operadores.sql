USE [SG906]
GO

/****** Object:  Table [dbo].[Operadores]    Script Date: 02/10/2019 18:34:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Operadores](
	[operador_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[operador_usuario_id] [tinyint] NULL,
 CONSTRAINT [PK_operadores] PRIMARY KEY CLUSTERED 
(
	[operador_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Operadores]  WITH CHECK ADD  CONSTRAINT [FK_operadores2] FOREIGN KEY([operador_usuario_id])
REFERENCES [dbo].[Usuario] ([usuario_id])
GO

ALTER TABLE [dbo].[Operadores] CHECK CONSTRAINT [FK_operadores2]
GO


