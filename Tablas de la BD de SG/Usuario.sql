USE [SG906]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 02/10/2019 19:14:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuario](
	[usuario_id] [tinyint] IDENTITY(1,1) NOT NULL,
	[usuario_nombre] [nchar](10) NULL,
	[usuario_rol] [tinyint] NOT NULL,
	[usuario_pass] [nchar](20) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Roles] FOREIGN KEY([usuario_rol])
REFERENCES [dbo].[Roles] ([rol_id])
GO

ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Roles]
GO


