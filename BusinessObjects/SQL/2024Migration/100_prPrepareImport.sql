USE [fdv5]
GO

/****** Object:  StoredProcedure [dbo].[prImportPrepareProds]    Script Date: 11/24/2024 6:48:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- reset prod and cat for import
alter proc [dbo].[prImportPrepareProds] 
as 
Begin

if not exists(select catid from cat where catid='MI') 
BEGIN
insert into cat (catid,description) values ('MI','Miscellaneous')
END

if not exists(select scatid from catsub where scatid='MIS') 
BEGIN
   insert into catsub (scatid,description) values ('MIS','Miscellaneous')
END



update prods set PresentInLastImport=0
update prods set catid='MI'
update prods set scatid='MIS'

delete from catsub where scatid<>'MIS'
delete from cat where catid<>'MI'

-- Do some preparation for PriceMaster
-- If the table exists - Truncate it
-- Otherwise create it


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriceMasterSTG]') AND type in (N'U'))
BEGIN
   DROP TABLE [dbo].[PriceMasterSTG]
END
CREATE TABLE [dbo].[PriceMasterSTG](
	[PriceMasterID] [int] IDENTITY(1,1) NOT NULL,
	[CustID] [nvarchar](10) NULL,
	[productcode] [nvarchar](6) NOT NULL,
	[lbcs] [float] NOT NULL,
	[lbpc] [float] NULL,
	[CaseSourceCode] [nvarchar](1) NULL,
	[PieceSourceCode] [nvarchar](1) NULL
)





end



GO


