/****** Script para el comando SelectTopNRows de SSMS  ******/
/*SELECT TOP 1000 [id]
      ,[nombre]
      ,[apellido]
      ,[edad]
  FROM [Padron].[dbo].[Personas]*/

  SELECT* /*TOP 3*/ /*nombre, apellido, edad*/ /*El SELECT* me devuelve la base de datos tal cual fue cargada*/
  FROM Padron.dbo.Personas
  /*WHERE id > 0
  ORDER BY apellido ASC, nombre DESC */

  /*INSERT INTO Padron.dbo.Personas
  (nombre, apellido, edad)
  values
  ('Carlitos', 'Robertez', 123)*/

  UPDATE Padron.dbo.Personas
  SET nombre = 'Benito',
      apellido = 'Camela',
	  edad = 34
  WHERE id = 7

  UPDATE Padron.dbo.Personas
  SET nombre = 'Rafael',
      apellido = 'Cogorno',
	  edad = 4
  WHERE id = 8

  DELETE from Padron.dbo.Personas
  WHERE id = 6