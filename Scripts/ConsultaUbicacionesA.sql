USE [PROD_ACTIVEIDSMART]
GO
/****** Object:  StoredProcedure [dbo].[ConsultaUbicacionesA]    Script Date: 7 jun. 2021 02:39:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ConsultaUbicacionesA] @IdPerfilEmpresa INT
AS
BEGIN
	SELECT IdUbicacionA, Nombre, Descripcion  
	FROM UbicacionA
	WHERE IdPerfilEmpresa = @IdPerfilEmpresa
END
