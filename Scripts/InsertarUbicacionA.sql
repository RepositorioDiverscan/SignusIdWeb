USE [PROD_ACTIVEIDSMART]
GO

/****** Object:  StoredProcedure [dbo].[InsertarUbicacionA]    Script Date: 7 jun. 2021 03:09:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsertarUbicacionA] @Nombre VARCHAR(150)
	,@Descripcion VARCHAR(250)
	,@IdPerfilEmpresa INT
	,@Respuesta VARCHAR(200) OUTPUT
AS
BEGIN
	INSERT INTO UbicacionA (
		Nombre
		,Descripcion
		,IdPerfilEmpresa
		)
	VALUES (
		@Nombre
		,@Descripcion
		,@IdPerfilEmpresa
		)

	SET @Respuesta = 'Registrado'
END