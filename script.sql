USE [teste]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 11/6/2016 4:07:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curso](
	[idCurso] [int] IDENTITY(1,1) NOT NULL,
	[idPeriodo] [int] NOT NULL,
	[total] [nvarchar](16) NULL,
	[nome_curso] [varchar](50) NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[idCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Disciplina]    Script Date: 11/6/2016 4:07:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disciplina](
	[idDisciplina] [int] IDENTITY(1,1) NOT NULL,
	[nome_disciplina] [nvarchar](50) NULL,
	[aulas_teoricas] [int] NULL,
	[aulas_praticas] [int] NULL,
	[hora_relogio] [int] NULL,
	[numero_credito] [int] NULL,
 CONSTRAINT [PK_Disciplina] PRIMARY KEY CLUSTERED 
(
	[idDisciplina] ASC
)WITH (PAD_INDEX = ON, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 1) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Periodo]    Script Date: 11/6/2016 4:07:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periodo](
	[idPeriodo] [int] IDENTITY(1,1) NOT NULL,
	[idDisciplina] [int] NOT NULL,
	[numero_periodo] [int] NOT NULL,
 CONSTRAINT [PK_Periodo] PRIMARY KEY CLUSTERED 
(
	[idPeriodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Periodo_Curso] FOREIGN KEY([idPeriodo])
REFERENCES [dbo].[Periodo] ([idPeriodo])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Periodo_Curso]
GO
ALTER TABLE [dbo].[Periodo]  WITH CHECK ADD  CONSTRAINT [FK_Disciplina_Periodo] FOREIGN KEY([idDisciplina])
REFERENCES [dbo].[Disciplina] ([idDisciplina])
GO
ALTER TABLE [dbo].[Periodo] CHECK CONSTRAINT [FK_Disciplina_Periodo]
GO
