USE [PROD_ACTIVEIDSMART]
GO

/****** Object:  StoredProcedure [dbo].[ActualizaUbicacionA]    Script Date: 7 jun. 2021 03:10:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[ActualizaUbicacionA] @IdUbicacionA INT
	,@Nombre VARCHAR(150)
	,@Descripcion VARCHAR(200)
	,@Respuesta VARCHAR(200) OUTPUT
AS
BEGIN
	UPDATE UbicacionA
	SET Nombre = @Nombre
		,Descripcion = @Descripcion
	WHERE IdUbicacionA = @IdUbicacionA

	SET @Respuesta = 'Actualizado'
END