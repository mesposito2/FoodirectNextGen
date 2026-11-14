USE [fdv5]
GO

/****** Object:  StoredProcedure [dbo].[prImportPrepareProds]    Script Date: 11/24/2024 6:31:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- reset prod and cat for import
create proc [dbo].[prClosePriceMaster] 
as 
Begin

--Kill all constraints on PriceMaster
-- If PriceMasterPostExists - kill it 
--Rename PriceMaster  to PriceMasterPOST
-- Rename PriceMasterSTG to PriceMaster 
-- Add Indexs and contriants back on 
-- Reindex the table

select count(*) from priceMaster


end



GO


