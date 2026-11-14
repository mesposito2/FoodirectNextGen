-- =======================================================================================
-- Create User as DBO template for Azure SQL Database and Azure Synapse Analytics Database
-- =======================================================================================
-- For login login_name, create a user in the database
--use fdv5 
CREATE USER FDSQL
	FOR LOGIN FDSQL
	WITH DEFAULT_SCHEMA = FDV5
GO

-- =======================================================================================
-- Create Microsoft Entra User for Azure SQL Database and Azure Synapse Analytics Database
-- =======================================================================================
-- For login <login_name, sysname, login_name>, create a user in the database
-- CREATE USER <Microsoft_Entra_User, sysname, user_name>
--    [   { FOR | FROM } LOGIN <Microsoft_Entra_Principal_Login, sysname, login_name>  ]  
--    | FROM EXTERNAL PROVIDER
--    [ WITH DEFAULT_SCHEMA = <default_schema, sysname, dbo> ]
-- GO


-- Add user to the database owner role
EXEC sp_addrolemember db_owner, FDSQL

/*
-- Add user to the database owner role
EXEC sp_addrolemember N'db_owner', N'<user_name, sysname, user_name>'
GO
*/