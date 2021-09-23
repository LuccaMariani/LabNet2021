SELECT TOP (1000)
      [TITULO]as 'T�tulo Curso'
      ,[DOCENTE_DNI] as 'DNI Docente'
	  ,[DOCENTE_APELLIDO] as 'Apellido Docente'
      ,[FECHA_INICIO] as 'Fecha de Inicio'
	  ,[FECHA_FIN] as 'Fecha de Fin'
      ,[ALUMNO_DNI] as 'DNI Alumno'
	  ,[ALUMNO_APELLIDO] as 'Apellido Alumno'
	  ,[ALUMNO_NOMBRE] as 'Nombre Alumno'
	  ,[ALUMNO_NOTA] as 'Nota Alumno'
  FROM [AcademiaCursos].[ACADEMIA].[REGISTRO] 

  INNER JOIN [ACADEMIA].[ALUMNO] 
  ON [ACADEMIA].[REGISTRO].[ALUMNO_ID] = [ACADEMIA].[ALUMNO].[ID]

  INNER JOIN [ACADEMIA].[DOCENTE] 
  ON [ACADEMIA].[REGISTRO].[DOCENTE_ID] = [ACADEMIA].[DOCENTE].[ID]

  INNER JOIN [ACADEMIA].CURSO 
  ON [ACADEMIA].[REGISTRO].CURSO_ID = [ACADEMIA].CURSO.ID

  WHERE [ACADEMIA].[REGISTRO].[ALUMNO_NOTA] < 4 
  AND FECHA_INICIO > '2015-01-01'
  AND FECHA_FIN < '2016-01-01'