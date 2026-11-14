/****** Object:  StoredProcedure [dbo].[prClosePriceMaster]    Script Date: 12/30/2024 12:47:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


--exec prClosePriceMaster


ALTER proc [dbo].[prClosePriceMaster] 
as 
Begin

--Kill all constraints on PriceMaster
IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriceMasterSTG]'))
BEGIN

print ('PriceMasterSTG DOES NOT exist - Process aborted.')
END
ELSE
BEGIN
print ('PriceMasterSTG exists - run through the process.')

BEGIN TRANSACTION
print ('Drop Constraint UN_PriceMaster_custid_productcode ')

/*
select OBJECT_ID(N'[dbo].[UN_PriceMaster_custid_productcode]')
select OBJECT_ID(N'[dbo].[PriceMaster]')
SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UN_PriceMaster_custid_productcode]')
*/

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE 
(object_id = OBJECT_ID(N'[dbo].[UN_PriceMaster_custid_productcode]'))
and
(parent_object_id = OBJECT_ID(N'[dbo].[PriceMaster]'))
)
BEGIN 
ALTER TABLE [dbo].[PriceMaster] DROP CONSTRAINT [UN_PriceMaster_custid_productcode]
print ('PRICEMASTER Drop Constraint UN_PriceMaster_custid_productcode - DONE')
END


IF  NOT EXISTS (SELECT * FROM sys.objects WHERE 
(object_id = OBJECT_ID(N'[dbo].[UN_PriceMaster_custid_productcode]'))
and
(parent_object_id = OBJECT_ID(N'[dbo].[PriceMasterPOST]'))
)
BEGIN 
ALTER TABLE [dbo].[PriceMasterPOST] DROP CONSTRAINT [UN_PriceMaster_custid_productcode]
print ('!!PRICEMASTERPOPST Drop Constraint UN_PriceMaster_custid_productcode - DONE - This constraint is not supposed to exist. As it should have been already dropped')
END


print ('Drop Constraint PK_PriceMaster')
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_PriceMaster]') )
ALTER TABLE [dbo].[PriceMaster] DROP CONSTRAINT [PK_PriceMaster] 
print ('Drop Constraint PK_PriceMaster - DONE')
COMMIT TRANSACTION


-- If PriceMasterPostExists - kill it 
print ('Drop PriceMasterPOST')
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriceMasterPOST]'))
DROP TABLE [dbo].[PriceMasterPOST]
print ('Drop PriceMasterPOST - DONE')

--Rename PriceMaster  to PriceMasterPOST
-- Rename PriceMasterSTG to PriceMaster 
-- Add Indexs and contriants back on 

print ('Rename PriceMaster to PriceMasterPOST ')
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriceMaster]'))
BEGIN
EXEC sp_rename PriceMaster, PriceMasterPOST;
END
print ('Rename PriceMaster to PriceMasterPOST - DONE')

print ('Rename PriceMasterSTG, PriceMaster')
--We know PriceMasterSTG exists
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriceMasterSTG]'))
EXEC sp_rename PriceMasterSTG, PriceMaster;
print ('Rename PriceMasterSTG, PriceMaster - DONE')




-- Add constrainty back
print ('Add UN_PriceMaster_custid_productcode to PriceMaster')
IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UN_PriceMaster_custid_productcode]'))
BEGIN
ALTER TABLE [dbo].[PriceMaster] ADD  CONSTRAINT [UN_PriceMaster_custid_productcode] UNIQUE NONCLUSTERED 
(
	[CustID] ASC,
	[productcode] ASC
)
END
print ('Add UN_PriceMaster_custid_productcode - DONE')

--Lets not Put the Primary Key Back. It is not really needed and seems take a long time to do 

/*
IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PK_PriceMaster]') AND type in (N'U'))
BEGIN
ALTER TABLE [dbo].[PriceMaster] ADD  CONSTRAINT [PK_PriceMaster] PRIMARY KEY CLUSTERED 
(
	[PriceMasterID] ASC
)
END
*/

END --PriceMasterSTG
END --Proc


GO


