/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT TOP 1000 [id_cliente] AS ID
      ,[nombre] AS 'NOMBRE'
      ,[apellido] AS 'APELLIDO'
      ,[telefono_fijo] AS 'TELEFONO FIJO'
      ,[telefono_movil] AS 'TELEFONO MOVIL'
      ,[email] AS 'EMAIL'
      ,[cuil] AS 'CUIL'
      ,[cuit] AS 'CUIT'
      ,[razon_social] AS 'RAZON SOCIAL'
      ,[direccion_id] AS 'DIRECCION'
      ,[tipo_cliente_id] AS 'TIPO CLIENTE'
  FROM [BD_Gestion].[dbo].[CLIENTES]