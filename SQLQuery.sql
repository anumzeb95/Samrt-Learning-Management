/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Duration]
	  ,[Teacher]
      ,[Description]
      
  FROM [SLMSystem].[dbo].[Courses]