USE [fdv5]
GO

/****** Object:  StoredProcedure [dbo].[prImportPrepareProds]    Script Date: 11/24/2024 6:31:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- reset prod and cat for import
alter proc [dbo].[prClosePriceMaster] 
as 
Begin

--Kill all constraints on PriceMaster
ALTER TABLE [dbo].[PriceMaster] DROP CONSTRAINT [UN_PriceMaster_custid_productcode]

ALTER TABLE [dbo].[PriceMaster] DROP CONSTRAINT [PK_PriceMaster] 


-- If PriceMasterPostExists - kill it 

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PriceMasterPOST]') AND type in (N'U'))
DROP TABLE [dbo].[PriceMasterPOST]

--Rename PriceMaster  to PriceMasterPOST
-- Rename PriceMasterSTG to PriceMaster 
-- Add Indexs and contriants back on 


BEGIN TRAN
EXEC sp_rename PriceMaster, PriceMasterPOST;
EXEC sp_rename PriceMasterSTG, PriceMaster;
COMMIT





-- Add constrainty back
ALTER TABLE [dbo].[PriceMaster] ADD  CONSTRAINT [UN_PriceMaster_custid_productcode] UNIQUE NONCLUSTERED 
(
	[CustID] ASC,
	[productcode] ASC
)


ALTER TABLE [dbo].[PriceMaster] ADD  CONSTRAINT [PK_PriceMaster] PRIMARY KEY CLUSTERED 
(
	[PriceMasterID] ASC
)



-- Reindex the table?

--select count(*) from priceMaster


end



GO


