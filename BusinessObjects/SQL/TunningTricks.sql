select * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UN_PriceMaster_custid_productcode]')

ALTER TABLE [dbo].[PriceMaster] DROP CONSTRAINT [PK_PriceMaster]


ALTER TABLE [dbo].[PriceMasterPOST] DROP CONSTRAINT [UN_PriceMaster_custid_productcode]

select * FROM sys.objects WHERE nAME LIKE 'un%' 
SELECT OBJECT_ID(N'[dbo].[UN_PriceMaster_custid_productcode]')

SELECT OBJECT_ID(N'[dbo].[PriceMasterPOST]')
SELECT OBJECT_ID(N'[dbo].[PriceMaster]')

404196490

ALTER TABLE [dbo].[PriceMaster] ADD  CONSTRAINT [UN_PriceMaster_custid_productcode] UNIQUE NONCLUSTERED 
(
	[CustID] ASC,
	[productcode] ASC
)


exec sp_updatestats

dbcc freeproccache

CREATE NONCLUSTERED INDEX [nci_msft_1_prods_BC595877655FB489730549AFE82C0AED] ON [dbo].[prods] ([catid], [isMaster], [PresentInLastImport], [description]) INCLUDE ([AdjCost], [AvgCost], [brandcode], [casecount], [keywords], [lbcs], [lbpc], [OnPriceList], [productcode], [ProductCodeSub], [qtyonhand], [scatid], [weight], [weight_type]) WITH (ONLINE = ON)
CREATE NONCLUSTERED INDEX [nci_msft_1_wta_po_line_15F988C4B40E04835A3A761CED5B1630] ON [dbo].[wta_po_line] ([poid]) WITH (ONLINE = ON)
CREATE NONCLUSTERED INDEX [nci_msft_1_PriceMaster_711B26012D6E20ADAD0B863C8ADB1C98] ON [dbo].[PriceMaster] ([CustID]) INCLUDE ([lbcs], [lbpc], [productcode]) WITH (ONLINE = ON)