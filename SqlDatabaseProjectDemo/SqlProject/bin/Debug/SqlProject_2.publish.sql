﻿/*
Deployment script for DemoDb

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DemoDb"
:setvar DefaultFilePrefix "DemoDb"
:setvar DefaultDataPath "C:\Users\Zakaria\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\Zakaria\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'The following operation was generated from a refactoring log file 92ff6224-d37e-48d1-938e-e43765106570';

PRINT N'Rename [dbo].[Person].[Id] to PersonId';


GO
EXECUTE sp_rename @objname = N'[dbo].[Person].[Id]', @newname = N'PersonId', @objtype = N'COLUMN';


GO
PRINT N'Altering View [dbo].[FullPerson]...';


GO
ALTER VIEW [dbo].[FullPerson]
	AS
	SELECT [p].PersonId as PersonId, [p].[FirstName], [p].[LastName], [a].[Id] as AddressId,  [a].[City], [a].[StreeAddress], [a].[ZipCode]
	from dbo.Person p
	left join dbo.Address a
	on  p.PersonId = a.PersonId
GO
PRINT N'Altering Procedure [dbo].[spPerson_FilterByLastName]...';


GO
ALTER PROCEDURE [dbo].[spPerson_FilterByLastName]
	@LastName nvarchar(50)
	
AS
	begin
	 select PersonId, [FirstName], [LastName]
	 from dbo.Person 
	 where LastName = @LastName;
	end
GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '92ff6224-d37e-48d1-938e-e43765106570')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('92ff6224-d37e-48d1-938e-e43765106570')

GO

GO
PRINT N'Update complete.';


GO
