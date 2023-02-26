USE [BeDB]
GO

/****** Object: Table [dbo].[Filme] Script Date: 25/02/2023 22:00:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Filme] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [Nome]          VARCHAR (50) NOT NULL,
    [Descricao]     VARCHAR (50) NULL,
    [AnoLancamento] INT          NULL
);


