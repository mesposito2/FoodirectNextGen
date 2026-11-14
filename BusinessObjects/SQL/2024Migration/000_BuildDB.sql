USE [fdv5]
GO
/****** Object:  UserDefinedFunction [dbo].[GetGroupCodes]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetGroupCodes]
(
    @productCode varchar(10)
)
RETURNS varchar(max)
AS
BEGIN
    declare @output varchar(max)
    select @output = COALESCE(@output + ', ', '') + ga.groupcode
    from groupa ga 
	join groupd gd on gd.groupcode=ga.groupcode 
	where  ga.productcode=@ProductCode

    return @output
END
GO
/****** Object:  UserDefinedFunction [dbo].[IntHasValue]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[IntHasValue]
(
    @value int
)
RETURNS int
AS
BEGIN
    declare @retVal int 
    set @retVal=0
    if IsNull(@value,0)=0
      set @retVal= 0
    else if @value>0
       set @retVal=1
     
     return @retVal
END
GO
/****** Object:  Table [dbo].[salep]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salep](
	[custid] [nvarchar](50) NULL,
	[colnum] [int] NULL,
	[line] [int] NULL,
	[productcode] [nvarchar](10) NULL,
	[sdescription] [nvarchar](100) NULL,
	[slbcs] [float] NULL,
	[sjlbcs] [float] NULL,
	[salepID] [int] IDENTITY(10,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[salepID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prods]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prods](
	[productcode] [nvarchar](6) NOT NULL,
	[description] [nvarchar](255) NULL,
	[brandcode] [nvarchar](2) NULL,
	[catid] [nvarchar](3) NULL,
	[scatid] [nvarchar](3) NULL,
	[weight] [float] NULL,
	[lbpc] [float] NULL,
	[lbcs] [float] NULL,
	[casecount] [int] NULL,
	[jlbpc] [float] NULL,
	[jlbcs] [float] NULL,
	[onsale] [bit] NULL,
	[onsalesheet] [bit] NULL,
	[onsale_nw] [bit] NULL,
	[onsalesheet_nw] [bit] NULL,
	[sale_lbcs] [float] NULL,
	[sale_jlbcs] [float] NULL,
	[sale_pos] [int] NULL,
	[sale_col] [int] NULL,
	[sale_lbcs_nw] [float] NULL,
	[sale_jlbcs_nw] [float] NULL,
	[sale_pos_nw] [int] NULL,
	[sale_col_nw] [int] NULL,
	[luc] [float] NULL,
	[qtyonhand] [int] NULL,
	[negative] [nvarchar](1) NULL,
	[weight_type] [nvarchar](1) NULL,
	[AvgCost] [float] NULL,
	[AdjCost] [float] NULL,
	[MasterCode] [varchar](6) NULL,
	[isMaster] [bit] NOT NULL,
	[jobber_onsale] [bit] NULL,
	[jobber_onsalesheet] [bit] NULL,
	[jobber_onsale_nw] [bit] NULL,
	[jobber_onsalesheet_nw] [bit] NULL,
	[jobber_sale_lbcs] [float] NULL,
	[jobber_sale_jlbcs] [float] NULL,
	[jobber_sale_pos] [int] NULL,
	[jobber_sale_col] [int] NULL,
	[jobber_sale_lbcs_nw] [float] NULL,
	[jobber_sale_jlbcs_nw] [float] NULL,
	[jobber_sale_pos_nw] [int] NULL,
	[jobber_sale_col_nw] [int] NULL,
	[NextCost] [float] NULL,
	[NextPODueDate] [datetime] NULL,
	[NextQtyDue] [float] NULL,
	[LastPOCost] [float] NULL,
	[keywords] [varchar](1000) NULL,
	[taxable] [varchar](1) NULL,
	[OnPriceList] [bit] NULL,
	[PresentInLastImport] [bit] NOT NULL,
	[ProductCodeSub] [varchar](6) NULL,
	[DoNotSell] [bit] NULL,
	[ArrowProd] [bit] NULL,
 CONSTRAINT [pk_prods_productcode] PRIMARY KEY CLUSTERED 
(
	[productcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwSaleP]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vwSaleP] as 

SELECT 0 as onCurrentOrder
       ,p.IsMaster
	   ,p.casecount
       ,s.custid
      ,s.colnum
      ,s.line
      ,s.productcode
      ,s.sdescription
      ,s.slbcs
      ,s.sjlbcs
      ,s.salepID
  FROM [dbo].[salep] s
  left join prods p on s.productCode=p.productcode


GO
/****** Object:  Table [dbo].[produce]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produce](
	[custid] [nvarchar](50) NULL,
	[colnum] [int] NULL,
	[line] [int] NULL,
	[productcode] [nvarchar](10) NULL,
	[sdescription] [nvarchar](100) NULL,
	[slbcs] [float] NULL,
	[sjlbcs] [float] NULL,
	[produceID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[produceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwProduce]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[vwProduce] as 

SELECT 0 as onCurrentOrder
      ,p.IsMaster
	  ,p.Casecount
      ,s.custid
      ,s.colnum
      ,s.line
      ,s.productcode
      ,s.sdescription
      ,s.slbcs
      ,s.sjlbcs
      ,s.produceID
  FROM [dbo].[produce] s
  left join prods p on s.productCode=p.productcode


GO
/****** Object:  Table [dbo].[beef]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beef](
	[description] [nvarchar](50) NULL,
	[pcode1] [nvarchar](10) NULL,
	[price1] [float] NULL,
	[pcode2] [nvarchar](10) NULL,
	[price2] [float] NULL,
	[pcode3] [nvarchar](10) NULL,
	[price3] [float] NULL,
	[pcode4] [nvarchar](10) NULL,
	[price4] [float] NULL,
	[pcode5] [nvarchar](10) NULL,
	[price5] [float] NULL,
	[jprice1] [float] NULL,
	[jprice2] [float] NULL,
	[jprice3] [float] NULL,
	[jprice4] [float] NULL,
	[jprice5] [float] NULL,
	[pcode6] [nvarchar](10) NULL,
	[price6] [float] NULL,
	[jprice6] [float] NULL,
	[price7] [float] NULL,
	[price8] [float] NULL,
	[price9] [float] NULL,
	[price10] [float] NULL,
	[jprice7] [float] NULL,
	[jprice8] [float] NULL,
	[jprice9] [float] NULL,
	[jprice10] [float] NULL,
	[pcode7] [nvarchar](10) NULL,
	[pcode8] [nvarchar](10) NULL,
	[pcode9] [nvarchar](10) NULL,
	[pcode10] [nvarchar](10) NULL,
	[price11] [float] NULL,
	[jprice11] [float] NULL,
	[pcode11] [nvarchar](10) NULL,
	[beefID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__beef__962B3638318258D2] PRIMARY KEY CLUSTERED 
(
	[beefID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwBeef]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE view [dbo].[vwBeef] as 

SELECT 
        0 as onCurrentOrder1
	   ,0 as onCurrentOrder2
	   ,0 as onCurrentOrder3
       ,0 as onCurrentOrder4
       ,0 as onCurrentOrder5
       ,0 as onCurrentOrder6
       ,0 as onCurrentOrder7
       ,0 as onCurrentOrder8
       ,0 as onCurrentOrder9
       ,0 as onCurrentOrder10
	   ,0 as onCurrentOrder11

,m1.description as description1
,m2.description as description2
,m3.description as description3
,m4.description as description4
,m5.description as description5
,m6.description as description6
,m7.description as description7
,m8.description as description8
,m9.description as description9
,m10.description as description10
,m11.description as description11


	   ,m1.catid as catid1
 	   ,m2.catid as catid2
 	   ,m3.catid as catid3
	   ,m4.catid as catid4
	   ,m5.catid as catid5
	   ,m6.catid as catid6
	   ,m7.catid as catid7
	   ,m8.catid as catid8
	   ,m9.catid as catid9
	   ,m10.catid as catid10
	   ,m11.catid as catid11
	  
	   ,m1.scatid as scatid1
 	   ,m2.scatid as scatid2
 	   ,m3.scatid as scatid3
	   ,m4.scatid as scatid4
	   ,m5.scatid as scatid5
	   ,m6.scatid as scatid6
	   ,m7.scatid as scatid7
	   ,m8.scatid as scatid8
	   ,m9.scatid as scatid9
	   ,m10.scatid as scatid10
	   ,m11.scatid as scatid11
	   

       ,m1.IsMaster as IsMaster1
 	   ,m2.IsMaster as IsMaster2
 	   ,m3.IsMaster as IsMaster3
	   ,m4.IsMaster as IsMaster4
	   ,m5.IsMaster as IsMaster5
	   ,m6.IsMaster as IsMaster6
	   ,m7.IsMaster as IsMaster7
	   ,m8.IsMaster as IsMaster8
	   ,m9.IsMaster as IsMaster9
	   ,m10.IsMaster as IsMaster10
	   ,m11.IsMaster as IsMaster11

	   ,m1.Casecount as Casecount1
	   ,m2.Casecount as Casecount2
       ,m3.Casecount as Casecount3
       ,m4.Casecount as Casecount4
       ,m5.Casecount as Casecount5
       ,m6.Casecount as Casecount6
       ,m7.Casecount as Casecount7
       ,m8.Casecount as Casecount8
       ,m9.Casecount as Casecount9
       ,m10.Casecount as Casecount10
       ,m11.Casecount as Casecount11
	   ,b.description
       ,[pcode1]
      ,[price1]
      ,[pcode2]
      ,[price2]
      ,[pcode3]
      ,[price3]
      ,[pcode4]
      ,[price4]
      ,[pcode5]
      ,[price5]
      ,[jprice1]
      ,[jprice2]
      ,[jprice3]
      ,[jprice4]
      ,[jprice5]
      ,[pcode6]
      ,[price6]
      ,[jprice6]
      ,[price7]
      ,[price8]
      ,[price9]
      ,[price10]
      ,[jprice7]
      ,[jprice8]
      ,[jprice9]
      ,[jprice10]
      ,[pcode7]
      ,[pcode8]
      ,[pcode9]
      ,[pcode10]
      ,[price11]
      ,[jprice11]
      ,[pcode11]
      ,[beefID]
  FROM [dbo].[beef] as b

left join prods m1 on m1.productcode=b.pcode1 and IsNull(b.Pcode1,'')<>''
left join prods m2 on m2.productcode=b.pcode2 and IsNull(b.Pcode2,'')<>''
left join prods m3 on m3.productcode=b.pcode3  and IsNull(b.Pcode3,'')<>''
left join prods m4 on m4.productcode=b.pcode4  and IsNull(b.Pcode4,'')<>''
left join prods m5 on m5.productcode=b.pcode5  and IsNull(b.Pcode5,'')<>''
left join prods m6 on m6.productcode=b.pcode6   and IsNull(b.Pcode6,'')<>''
left join prods m7 on m7.productcode=b.pcode7  and IsNull(b.Pcode7,'')<>''
left join prods m8 on m8.productcode=b.pcode8  and IsNull(b.Pcode8,'')<>''
left join prods m9 on m9.productcode=b.pcode9   and IsNull(b.Pcode9,'')<>''
left join prods m10 on m10.productcode=b.pcode10  and IsNull(b.Pcode10,'')<>''
left join prods m11 on m11.productcode=b.pcode11  and IsNull(b.Pcode11,'')<>''






GO
/****** Object:  Table [dbo].[wta_ager]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_ager](
	[mid] [nvarchar](6) NULL,
	[custid] [nvarchar](6) NULL,
	[ager1] [float] NULL,
	[ager2] [float] NULL,
	[ager3] [float] NULL,
	[ager4] [float] NULL,
	[total] [float] NULL,
	[lastupdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[custid] [nvarchar](10) NOT NULL,
	[type] [smallint] NULL,
	[internetid] [nvarchar](10) NULL,
	[access] [int] NULL,
	[notes] [nvarchar](100) NULL,
	[altcode] [nvarchar](50) NULL,
	[jobberid] [nvarchar](6) NULL,
	[bizname] [nvarchar](100) NULL,
	[contactname] [nvarchar](50) NULL,
	[address1] [nvarchar](50) NULL,
	[address2] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[state] [nvarchar](50) NULL,
	[zip] [nvarchar](10) NULL,
	[zip4] [nvarchar](10) NULL,
	[telephone] [nvarchar](30) NULL,
	[fax] [nvarchar](30) NULL,
	[cell] [nvarchar](30) NULL,
	[faxmachine] [smallint] NULL,
	[email] [nvarchar](100) NULL,
	[sendfax] [bit] NOT NULL,
	[sendemail] [bit] NOT NULL,
	[sendmail] [bit] NOT NULL,
	[flags] [int] NULL,
	[custcatb] [nvarchar](10) NULL,
	[custcatb_roll] [nvarchar](10) NULL,
	[source] [int] NULL,
	[pMargin] [int] NULL,
	[pPageCol] [int] NULL,
	[pFontSize] [int] NULL,
	[pFont] [nvarchar](40) NULL,
	[accpay] [int] NULL,
	[salesheetlabel] [nvarchar](250) NULL,
	[password] [nvarchar](30) NULL,
	[wta_route_rid] [int] NULL,
	[sales_tax_type] [int] NULL,
	[qbid] [nvarchar](50) NULL,
	[foodirect_qbid] [nvarchar](50) NULL,
	[sales_tax_region] [nvarchar](10) NULL,
	[invoice_ager] [bit] NULL,
	[wta_access] [int] NULL,
	[wta_lock] [int] NULL,
	[BeefMarkup] [float] NULL,
	[GroupCode] [varchar](1) NULL,
	[taxable] [varchar](1) NULL,
	[SlmInit] [varchar](2) NULL,
	[SlmName] [varchar](30) NULL,
	[CanOrder] [bit] NULL,
	[TierCode] [varchar](1) NULL,
	[TierPCT] [int] NULL,
	[XEmail1] [varchar](100) NULL,
	[XEmail2] [varchar](100) NULL,
	[XEmail3] [varchar](100) NULL,
	[XEmail4] [varchar](100) NULL,
	[ager_current] [float] NULL,
	[ager_week1] [float] NULL,
	[ager_week2] [float] NULL,
	[ager_week3] [float] NULL,
	[ager_week4] [float] NULL,
	[ager_week5] [float] NULL,
	[ager_week6] [float] NULL,
	[lastBookFile] [varchar](500) NULL,
	[CanViewInventoryDetails] [bit] NULL,
	[ChainCode] [nvarchar](10) NULL,
	[UseProdCustGuide] [bit] NOT NULL,
 CONSTRAINT [pk_users_custid] PRIMARY KEY CLUSTERED 
(
	[custid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[myview_userager]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[myview_userager]
AS
SELECT     dbo.users.*, dbo.wta_ager.custid AS c1, dbo.wta_ager.ager1 AS Expr1, dbo.wta_ager.ager2 AS Expr2, dbo.wta_ager.ager3 AS Expr3, 
                      dbo.wta_ager.ager4 AS Expr4, dbo.wta_ager.total AS Expr5
FROM         dbo.users LEFT OUTER JOIN
                      dbo.wta_ager ON dbo.users.custid = dbo.wta_ager.custid
GO
/****** Object:  Table [dbo].[wta_catalog]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_catalog](
	[prodid] [int] IDENTITY(1000,1) NOT NULL,
	[mid] [nvarchar](10) NULL,
	[productcode] [nvarchar](20) NULL,
	[description] [nvarchar](255) NULL,
	[vendormid] [nvarchar](10) NULL,
	[vendorname] [nvarchar](100) NULL,
	[vendorcode] [nvarchar](20) NULL,
	[vendordescription] [nvarchar](255) NULL,
	[vendorcasecount] [int] NULL,
	[wlbcs] [float] NULL,
	[wlbpc] [float] NULL,
	[rlbcs] [float] NULL,
	[rlbpc] [float] NULL,
	[taxable] [int] NULL,
	[lastwlbcs] [float] NULL,
	[lastwlbpc] [float] NULL,
	[weight] [float] NULL,
	[casecount] [int] NULL,
	[scatid] [nvarchar](6) NULL,
	[catid] [nvarchar](6) NULL,
	[createdate] [datetime] NULL,
	[lastupdate] [datetime] NULL,
	[active] [int] NULL,
	[xtype] [nvarchar](50) NULL,
	[comment] [nvarchar](255) NULL,
	[weight_type] [nvarchar](1) NULL,
	[um_style] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MYVIEW_PRODS_WTA]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE VIEW [dbo].[MYVIEW_PRODS_WTA]
AS
SELECT wta_catalog.productcode, wta_catalog.description, 
    prods.brandcode, wta_catalog.catid, wta_catalog.scatid, 
    wta_catalog.weight, wta_catalog.wlbpc AS lbpc, 
    wta_catalog.wlbcs AS lbcs, wta_catalog.casecount, 
    wta_catalog.rlbpc AS jlbpc, wta_catalog.rlbcs AS jlbcs, 
    prods.onsale, prods.onsalesheet, prods.onsale_nw, 
    prods.onsalesheet_nw, prods.sale_lbcs, prods.sale_jlbcs, 
    prods.sale_pos, prods.sale_col, prods.sale_lbcs_nw, 
    prods.sale_jlbcs_nw, prods.sale_pos_nw, prods.sale_col_nw, 
    prods.luc, prods.qtyonhand, prods.negative, wta_catalog.mid, 
    prods.keywords,
    wta_catalog.vendorcode, wta_catalog.vendormid
FROM dbo.wta_catalog LEFT OUTER JOIN
    dbo.prods ON 
    dbo.prods.productcode = dbo.wta_catalog.vendorcode
GO
/****** Object:  Table [dbo].[cat]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cat](
	[catid] [nvarchar](3) NOT NULL,
	[description] [nvarchar](255) NULL,
 CONSTRAINT [PK_cat] PRIMARY KEY CLUSTERED 
(
	[catid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catsub]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catsub](
	[scatid] [nvarchar](3) NOT NULL,
	[description] [nvarchar](255) NULL,
 CONSTRAINT [PK_catsub] PRIMARY KEY CLUSTERED 
(
	[scatid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwProds]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vwProds] as 
select
p.productcode
,p.description
,p.brandcode
,c.description as CategoryName
,cs.description as SubCategoryName
,c.catid
,p.scatid
,p.keywords
,p.weight
,p.weight_type
,p.lbpc
,p.lbcs
,p.casecount
,p.OnPriceList
,p.PresentInLastImport
,p.qtyonhand
,p.AdjCost
,p.AvgCost
,p.ProductCodeSub
,dbo.GetGroupCodes(p.productcode) as GroupCode

from prods p
join cat c on c.catid=p.catid 
left join catsub cs on p.scatid=cs.scatid

-- 9/11/2015 - Added IsMaster at this level...
where p.productCode<>'' and isMaster=0



GO
/****** Object:  View [dbo].[MYVIEW_PRODS]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

/****** Object:  View dbo.MYVIEW_PRODS    Script Date: 7/1/2008 2:50:13 PM ******/
CREATE  VIEW [dbo].[MYVIEW_PRODS]
AS
--select * from prods where IsMaster=1 

-- 7/9/2008 if has master code - and the master code is on the sales sheet
-- then the prouct should be set to be on sale with the master values unless the 
-- the product is explicitly on sale itself


SELECT  

-- This week

case 
when  prods.IsMaster=1 or prods.onsalesheet=1 then  prods.onsalesheet
when IsNull(prods2.onsalesheet,0)=1  then 1
else 0
end as onsalesheet,

-- normal
case 
when  prods.IsMaster=1 or prods.onsalesheet=1 then  prods.sale_lbcs
when IsNull(prods2.onsalesheet,0)=1  then prods2.sale_lbcs
else prods.sale_lbcs
end as sale_lbcs,

-- jobber
case 
when  prods.IsMaster=1 or prods.onsalesheet=1 then  prods.sale_jlbcs
when IsNull(prods2.onsalesheet,0)=1  then prods2.sale_jlbcs
else prods.sale_jlbcs
end as sale_jlbcs,


-- Next week
case 
when  prods.IsMaster=1 or prods.onsalesheet_nw=1 then  prods.onsalesheet_nw
when IsNull(prods2.onsalesheet_nw,0)=1  then 1
else 0
end as onsalesheet_nw,

-- normal
case 
when  prods.IsMaster=1 or prods.onsalesheet=1 then  prods.sale_lbcs_nw
when IsNull(prods2.onsalesheet,0)=1  then prods2.sale_lbcs_nw
else prods.sale_lbcs_nw
end as sale_lbcs_nw,

-- jobber
case 
when  prods.IsMaster=1 or prods.onsalesheet=1 then  prods.sale_jlbcs_nw
when IsNull(prods2.onsalesheet,0)=1  then prods2.sale_jlbcs_nw
else prods.sale_jlbcs_nw
end as sale_jlbcs_nw,



         prods.[productcode] 
	,prods.[description]
	,prods.[brandcode]
	,prods.[catid] 
	,prods.[scatid]
	,prods.[weight]
	,prods.[lbpc]
	,prods.[lbcs]
	,prods.[casecount]
	,prods.[jlbpc] 
	,prods.[jlbcs] 
	,prods.[onsale] 
	,prods.[onsale_nw] 
--	,prods.[sale_lbcs] 
--	,prods.[sale_jlbcs]
	,prods.[sale_pos]
	,prods.[sale_col]
--	,prods.[sale_lbcs_nw] 
--	,prods.[sale_jlbcs_nw]
	,prods.[sale_pos_nw] 
	,prods.[sale_col_nw] 
	,prods.[luc] [float]
	,prods.[qtyonhand] 
	,prods.[negative] 
	,prods.[weight_type]
	,prods.[AvgCost] 
	,prods.[AdjCost] 
	,prods.[MasterCode] 
	,prods.[isMaster]
    ,prods.keywords
 
,prods.productcode AS vendorcode
,'FOODD' AS vendormid

FROM prods 

left join prods as prods2 on prods.mastercode=prods2.productcode
GO
/****** Object:  Table [dbo].[wta_cat]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_cat](
	[mid] [nvarchar](6) NULL,
	[parentid] [nvarchar](10) NULL,
	[catid] [nvarchar](10) NOT NULL,
	[description] [nvarchar](100) NULL,
	[active] [smallint] NULL,
	[lastupdate] [datetime] NULL,
	[createdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MYVIEW_CAT1]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE VIEW [dbo].[MYVIEW_CAT1]
AS
SELECT *
FROM (SELECT mid = 'FOODD', catid, source = 'FD', 
          description
      FROM cat
      UNION
      SELECT mid, catid, source = 'WTA', description
      FROM wta_cat
      WHERE parentid = '' AND active <> 0) x1
GO
/****** Object:  View [dbo].[MYVIEW_CAT2]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE VIEW [dbo].[MYVIEW_CAT2]
AS
SELECT *
FROM (SELECT mid = 'FOODD', substring(scatid, 1, 2) AS parentid, 
          scatid, source = 'FD', description
      FROM catsub
      UNION
      SELECT mid, parentid, catid, source = 'WTA', 
          description
      FROM wta_cat
      WHERE parentid <> '' AND active <> 0) x1
GO
/****** Object:  Table [dbo].[PriceMaster]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceMaster](
	[PriceMasterID] [int] IDENTITY(1,1) NOT NULL,
	[CustID] [nvarchar](10) NULL,
	[productcode] [nvarchar](6) NOT NULL,
	[lbcs] [float] NOT NULL,
	[lbpc] [float] NULL,
	[CaseSourceCode] [nvarchar](1) NULL,
	[PieceSourceCode] [nvarchar](1) NULL,
 CONSTRAINT [PK_PriceMaster] PRIMARY KEY CLUSTERED 
(
	[PriceMasterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_PriceMaster_custid_productcode] UNIQUE NONCLUSTERED 
(
	[CustID] ASC,
	[productcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vwPriceMaster]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vwPriceMaster]
as
select custid,productcode,lbcs,lbpc from pricemaster
union
(
select users.custid,productcode,prods.lbcs,prods.lbpc from users,prods
where jobberid='FOODD'
)


GO
/****** Object:  Table [dbo].[accday]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accday](
	[jobberid] [nvarchar](20) NULL,
	[thisday] [smalldatetime] NULL,
	[bill] [float] NULL,
	[pay] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[accpay]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accpay](
	[aid] [int] IDENTITY(1000,1) NOT NULL,
	[cdate] [smalldatetime] NULL,
	[jobberid] [nvarchar](6) NULL,
	[custid] [nvarchar](6) NULL,
	[jnumber] [nvarchar](30) NULL,
	[week] [smalldatetime] NULL,
	[debit] [float] NULL,
	[credit] [float] NULL,
	[comment] [nvarchar](255) NULL,
	[flags] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ad]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ad](
	[AdID] [int] IDENTITY(1,1) NOT NULL,
	[AdName] [varchar](100) NOT NULL,
	[AdImage] [varchar](100) NOT NULL,
	[AltText] [varchar](100) NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[LastUpdatedBy] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Ad] PRIMARY KEY CLUSTERED 
(
	[AdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_Ad_AdImage] UNIQUE NONCLUSTERED 
(
	[AdImage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[adminprice_unused]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adminprice_unused](
	[mid] [nvarchar](10) NULL,
	[type] [nvarchar](1) NULL,
	[icode] [nvarchar](10) NULL,
	[dcase] [float] NULL,
	[pcase] [float] NULL,
	[dpiece] [float] NULL,
	[ppiece] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[beefadj]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beefadj](
	[jobberid] [nvarchar](50) NULL,
	[A1] [float] NULL,
	[A2] [float] NULL,
	[A3] [float] NULL,
	[A4] [float] NULL,
	[A5] [float] NULL,
	[A6] [float] NULL,
	[A7] [float] NULL,
	[A8] [float] NULL,
	[A9] [float] NULL,
	[A10] [float] NULL,
	[A11] [float] NULL,
	[A12] [float] NULL,
	[A13] [float] NULL,
	[A14] [float] NULL,
	[A15] [float] NULL,
	[A16] [float] NULL,
	[A17] [float] NULL,
	[A18] [float] NULL,
	[A19] [float] NULL,
	[A20] [float] NULL,
	[B1] [float] NULL,
	[B2] [float] NULL,
	[B3] [float] NULL,
	[B4] [float] NULL,
	[B5] [float] NULL,
	[B6] [float] NULL,
	[B7] [float] NULL,
	[B8] [float] NULL,
	[B9] [float] NULL,
	[B10] [float] NULL,
	[B11] [float] NULL,
	[B12] [float] NULL,
	[B13] [float] NULL,
	[B14] [float] NULL,
	[B15] [float] NULL,
	[B16] [float] NULL,
	[B17] [float] NULL,
	[B18] [float] NULL,
	[B19] [float] NULL,
	[B20] [float] NULL,
	[C1] [float] NULL,
	[C2] [float] NULL,
	[C3] [float] NULL,
	[C4] [float] NULL,
	[C5] [float] NULL,
	[C6] [float] NULL,
	[C7] [float] NULL,
	[C8] [float] NULL,
	[C9] [float] NULL,
	[C10] [float] NULL,
	[C11] [float] NULL,
	[C12] [float] NULL,
	[C13] [float] NULL,
	[C14] [float] NULL,
	[C15] [float] NULL,
	[C16] [float] NULL,
	[C17] [float] NULL,
	[C18] [float] NULL,
	[C19] [float] NULL,
	[C20] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[beefadj_roll]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beefadj_roll](
	[jobberid] [nvarchar](50) NULL,
	[A1] [float] NULL,
	[A2] [float] NULL,
	[A3] [float] NULL,
	[A4] [float] NULL,
	[A5] [float] NULL,
	[A6] [float] NULL,
	[A7] [float] NULL,
	[A8] [float] NULL,
	[A9] [float] NULL,
	[A10] [float] NULL,
	[A11] [float] NULL,
	[A12] [float] NULL,
	[A13] [float] NULL,
	[A14] [float] NULL,
	[A15] [float] NULL,
	[A16] [float] NULL,
	[A17] [float] NULL,
	[A18] [float] NULL,
	[A19] [float] NULL,
	[A20] [float] NULL,
	[B1] [float] NULL,
	[B2] [float] NULL,
	[B3] [float] NULL,
	[B4] [float] NULL,
	[B5] [float] NULL,
	[B6] [float] NULL,
	[B7] [float] NULL,
	[B8] [float] NULL,
	[B9] [float] NULL,
	[B10] [float] NULL,
	[B11] [float] NULL,
	[B12] [float] NULL,
	[B13] [float] NULL,
	[B14] [float] NULL,
	[B15] [float] NULL,
	[B16] [float] NULL,
	[B17] [float] NULL,
	[B18] [float] NULL,
	[B19] [float] NULL,
	[B20] [float] NULL,
	[C1] [float] NULL,
	[C2] [float] NULL,
	[C3] [float] NULL,
	[C4] [float] NULL,
	[C5] [float] NULL,
	[C6] [float] NULL,
	[C7] [float] NULL,
	[C8] [float] NULL,
	[C9] [float] NULL,
	[C10] [float] NULL,
	[C11] [float] NULL,
	[C12] [float] NULL,
	[C13] [float] NULL,
	[C14] [float] NULL,
	[C15] [float] NULL,
	[C16] [float] NULL,
	[C17] [float] NULL,
	[C18] [float] NULL,
	[C19] [float] NULL,
	[C20] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[beefcat]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beefcat](
	[jobberid] [nvarchar](50) NULL,
	[custid] [nvarchar](10) NULL,
	[P1] [float] NULL,
	[P2] [float] NULL,
	[P3] [float] NULL,
	[P4] [float] NULL,
	[P5] [float] NULL,
	[P6] [float] NULL,
	[P7] [float] NULL,
	[P8] [float] NULL,
	[P9] [float] NULL,
	[P10] [float] NULL,
	[P11] [float] NULL,
	[P12] [float] NULL,
	[P13] [float] NULL,
	[P14] [float] NULL,
	[P15] [float] NULL,
	[P16] [float] NULL,
	[P17] [float] NULL,
	[P18] [float] NULL,
	[P19] [float] NULL,
	[P20] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[beefcat_roll]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beefcat_roll](
	[jobberid] [nvarchar](50) NULL,
	[custid] [nvarchar](10) NULL,
	[P1] [float] NULL,
	[P2] [float] NULL,
	[P3] [float] NULL,
	[P4] [float] NULL,
	[P5] [float] NULL,
	[P6] [float] NULL,
	[P7] [float] NULL,
	[P8] [float] NULL,
	[P9] [float] NULL,
	[P10] [float] NULL,
	[P11] [float] NULL,
	[P12] [float] NULL,
	[P13] [float] NULL,
	[P14] [float] NULL,
	[P15] [float] NULL,
	[P16] [float] NULL,
	[P17] [float] NULL,
	[P18] [float] NULL,
	[P19] [float] NULL,
	[P20] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookConfig]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookConfig](
	[BookConfigID] [int] IDENTITY(1,1) NOT NULL,
	[IsCurrent] [bit] NOT NULL,
	[ShowPrices] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[Createdby] [varchar](50) NOT NULL,
	[LastUpdatedby] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BookConfig] PRIMARY KEY CLUSTERED 
(
	[BookConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookConfigAd]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookConfigAd](
	[BookConfigAdID] [int] IDENTITY(1,1) NOT NULL,
	[BookConfigID] [int] NOT NULL,
	[PageNum] [int] NOT NULL,
	[AdID] [int] NOT NULL,
 CONSTRAINT [PK_BookConfigAd] PRIMARY KEY CLUSTERED 
(
	[BookConfigAdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_BookConfigAd_BookConfigID_PageNum] UNIQUE NONCLUSTERED 
(
	[BookConfigID] ASC,
	[PageNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catmarg]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catmarg](
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[catid] [nvarchar](10) NULL,
	[dmarg] [float] NULL,
	[pmarg] [float] NULL,
	[sdmarg] [float] NULL,
	[spmarg] [float] NULL,
	[pdmarg] [float] NULL,
	[ppmarg] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catmarg_roll]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catmarg_roll](
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[catid] [nvarchar](10) NULL,
	[dmarg] [float] NULL,
	[pmarg] [float] NULL,
	[sdmarg] [float] NULL,
	[spmarg] [float] NULL,
	[pdmarg] [float] NULL,
	[ppmarg] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catneg]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catneg](
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[catid] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catneg_roll]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catneg_roll](
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[catid] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chain]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chain](
	[ChainID] [int] IDENTITY(1,1) NOT NULL,
	[ChainCode] [nvarchar](10) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[LastUpdatedBy] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ChainID] PRIMARY KEY CLUSTERED 
(
	[ChainID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_Chain_ChainCode] UNIQUE NONCLUSTERED 
(
	[ChainCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Favorite]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Favorite](
	[FavoriteID] [int] IDENTITY(1,1) NOT NULL,
	[custID] [nvarchar](10) NOT NULL,
	[productCode] [nvarchar](6) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[LastUpdatedBy] [varchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Favorite] PRIMARY KEY CLUSTERED 
(
	[FavoriteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_favorite_productcode_custid] UNIQUE NONCLUSTERED 
(
	[productCode] ASC,
	[custID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FDACTION]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FDACTION](
	[FDActionID] [int] IDENTITY(1,1) NOT NULL,
	[token] [nvarchar](50) NULL,
	[description] [nvarchar](255) NULL,
	[lastlogfile] [nvarchar](50) NULL,
	[lastrun] [datetime] NULL,
	[lastresult] [decimal](18, 0) NULL,
	[lastmsg] [nvarchar](255) NULL,
	[msgfile] [nvarchar](255) NULL,
	[active] [bit] NULL,
	[LastRunStart] [datetime] NULL,
 CONSTRAINT [PK_FDACTION] PRIMARY KEY CLUSTERED 
(
	[FDActionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FDACTIONHistory]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FDACTIONHistory](
	[FDActionHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[token] [nvarchar](50) NULL,
	[description] [nvarchar](255) NULL,
	[lastlogfile] [nvarchar](50) NULL,
	[lastrun] [datetime] NULL,
	[lastresult] [decimal](18, 0) NULL,
	[lastmsg] [nvarchar](255) NULL,
	[msgfile] [nvarchar](255) NULL,
	[active] [bit] NULL,
	[LastRunStart] [datetime] NULL,
 CONSTRAINT [PK_FDACTIONHISTORY] PRIMARY KEY CLUSTERED 
(
	[FDActionHistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[groupa]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groupa](
	[groupcode] [nvarchar](2) NULL,
	[productcode] [nvarchar](6) NULL,
	[brandcode] [nvarchar](2) NULL,
	[scatid] [nvarchar](3) NULL,
	[GroupaID] [int] IDENTITY(10,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[groupd]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groupd](
	[groupcode] [nvarchar](2) NOT NULL,
	[description] [nvarchar](255) NULL,
 CONSTRAINT [PK_groupd] PRIMARY KEY CLUSTERED 
(
	[groupcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hitlog]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hitlog](
	[htime] [smalldatetime] NULL,
	[ip] [nvarchar](50) NULL,
	[page] [nvarchar](50) NULL,
	[refer] [nvarchar](255) NULL,
	[custid] [nvarchar](50) NULL,
	[cname] [nvarchar](50) NULL,
	[role] [nvarchar](50) NULL,
	[rolename] [nvarchar](50) NULL,
	[mid] [nvarchar](10) NULL,
	[membername] [nvarchar](50) NULL,
	[eventid] [int] NULL,
	[data] [nvarchar](255) NULL,
	[source] [int] NULL,
	[browser] [nvarchar](255) NULL,
	[qs] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jobep]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jobep](
	[custid] [nvarchar](50) NULL,
	[colnum] [int] NULL,
	[line] [int] NULL,
	[productcode] [nvarchar](10) NULL,
	[sdescription] [nvarchar](100) NULL,
	[slbcs] [float] NULL,
	[sjlbcs] [float] NULL,
	[jobep_id] [int] IDENTITY(10,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[jobep_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jobep_nw]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jobep_nw](
	[custid] [nvarchar](50) NULL,
	[colnum] [int] NULL,
	[line] [int] NULL,
	[productcode] [nvarchar](10) NULL,
	[sdescription] [nvarchar](100) NULL,
	[slbcs] [float] NULL,
	[sjlbcs] [float] NULL,
	[jobep_nw_id] [int] IDENTITY(10,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[jobep_nw_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[keyvalue]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[keyvalue](
	[thiskey] [nvarchar](100) NULL,
	[type] [nvarchar](10) NULL,
	[value] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lists]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lists](
	[lid] [int] NULL,
	[lname] [nvarchar](100) NULL,
	[lvalue] [nvarchar](100) NULL,
	[lvalue2] [nvarchar](100) NULL,
	[listsID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[listsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[custid] [nvarchar](6) NULL,
	[type] [smallint] NULL,
	[internetid] [nvarchar](10) NULL,
	[access] [int] NULL,
	[notes] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menuitems]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menuitems](
	[mid] [int] IDENTITY(1,1) NOT NULL,
	[tid] [int] NULL,
	[name] [nvarchar](50) NULL,
	[link] [nvarchar](200) NULL,
	[dorder] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menutabs]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menutabs](
	[tid] [int] IDENTITY(1,1) NOT NULL,
	[source] [int] NULL,
	[roletype] [int] NULL,
	[tab] [nvarchar](50) NULL,
	[dorder] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[midi]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[midi](
	[mid] [int] IDENTITY(1000,1) NOT NULL,
	[midifile] [nvarchar](50) NULL,
	[description] [nvarchar](100) NULL,
	[flags] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProdCustGuide]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdCustGuide](
	[ProdCustGuideID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [nvarchar](6) NOT NULL,
	[CustID] [nvarchar](10) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](50) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[LastUpdatedBy] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProdCustGuide] PRIMARY KEY CLUSTERED 
(
	[ProdCustGuideID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prodmarg]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prodmarg](
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[productid] [nvarchar](10) NULL,
	[dmarg] [float] NULL,
	[pmarg] [float] NULL,
	[sdmarg] [float] NULL,
	[spmarg] [float] NULL,
	[pdmarg] [float] NULL,
	[ppmarg] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prodmarg_roll]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prodmarg_roll](
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[productid] [nvarchar](10) NULL,
	[dmarg] [float] NULL,
	[pmarg] [float] NULL,
	[sdmarg] [float] NULL,
	[spmarg] [float] NULL,
	[pdmarg] [float] NULL,
	[ppmarg] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prodneg]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prodneg](
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[productid] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prodneg_roll]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prodneg_roll](
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[productid] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[type] [int] NULL,
	[access] [int] NULL,
	[name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[saleadj]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saleadj](
	[jobberid] [nvarchar](5) NULL,
	[productcode] [nvarchar](6) NULL,
	[a] [float] NULL,
	[b] [float] NULL,
	[c] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[saleadj_roll]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saleadj_roll](
	[jobberid] [nvarchar](5) NULL,
	[productcode] [nvarchar](6) NULL,
	[a] [float] NULL,
	[b] [float] NULL,
	[c] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salecat]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salecat](
	[custid] [nvarchar](10) NULL,
	[productcode] [nvarchar](10) NULL,
	[cat] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salecat_roll]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salecat_roll](
	[custid] [nvarchar](10) NULL,
	[productcode] [nvarchar](10) NULL,
	[cat] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salep_nw]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salep_nw](
	[custid] [nvarchar](50) NULL,
	[colnum] [int] NULL,
	[line] [int] NULL,
	[productcode] [nvarchar](10) NULL,
	[sdescription] [nvarchar](100) NULL,
	[slbcs] [float] NULL,
	[sjlbcs] [float] NULL,
	[salep_nw_id] [int] IDENTITY(10,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[salep_nw_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesBeefConfig]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesBeefConfig](
	[SalesBeefConfigID] [int] IDENTITY(1,1) NOT NULL,
	[IsCurrent] [bit] NOT NULL,
	[Title] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[Createdby] [varchar](50) NOT NULL,
	[LastUpdatedby] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SalesBeefConfig] PRIMARY KEY CLUSTERED 
(
	[SalesBeefConfigID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesBeefConfigAd]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesBeefConfigAd](
	[SalesBeefConfigAdID] [int] IDENTITY(1,1) NOT NULL,
	[SalesBeefConfigID] [int] NOT NULL,
	[PageNum] [int] NOT NULL,
	[AdID] [int] NOT NULL,
 CONSTRAINT [PK_SalesBeefConfigAd] PRIMARY KEY CLUSTERED 
(
	[SalesBeefConfigAdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_SalesBeefConfigAd_SalesBeefConfigID_PageNum] UNIQUE NONCLUSTERED 
(
	[SalesBeefConfigID] ASC,
	[PageNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[speed]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[speed](
	[custid] [nvarchar](10) NULL,
	[productcode] [nvarchar](6) NULL,
	[scatid] [nvarchar](3) NULL,
	[lastdate] [smalldatetime] NOT NULL,
	[qty] [int] NOT NULL,
	[uom] [nvarchar](2) NULL,
	[lastprice] [float] NOT NULL,
	[speedID] [int] IDENTITY(10,1) NOT NULL,
 CONSTRAINT [PK__speed__14EF7A6957A801BA] PRIMARY KEY CLUSTERED 
(
	[speedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[system]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[system](
	[str1] [nvarchar](255) NULL,
	[str2] [nvarchar](255) NULL,
	[str3] [nvarchar](255) NULL,
	[bool1] [bit] NULL,
	[bool2] [bit] NULL,
	[bool3] [bit] NULL,
	[int1] [int] NULL,
	[int2] [int] NULL,
	[int3] [int] NULL,
	[dbl1] [int] NULL,
	[dbl2] [int] NULL,
	[dbl3] [int] NULL,
	[displaypriceexpire] [datetime] NULL,
	[lastfposcdate] [datetime] NULL,
	[lastfposversion] [int] NULL,
	[lastfdpfile] [int] NULL,
	[systemID] [uniqueidentifier] NOT NULL,
	[systemUCODE] [varchar](50) NOT NULL,
	[lastUpdate] [datetime] NULL,
	[lastUpdatedBy] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[systemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_System_systemUCODE] UNIQUE NONCLUSTERED 
(
	[systemUCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersBook]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersBook](
	[UsersBookID] [int] IDENTITY(1,1) NOT NULL,
	[custID] [nvarchar](10) NOT NULL,
	[PDFPartialURL] [varchar](100) NOT NULL,
	[PDFFile] [varchar](100) NOT NULL,
	[GenerateDate] [datetime] NOT NULL,
	[GenerateStatusCode] [varchar](50) NOT NULL,
	[GenerateMessage] [varchar](1000) NOT NULL,
	[GenerateURL] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[UserTypeID] [smallint] NOT NULL,
	[UserType] [varchar](100) NOT NULL,
	[UserTypeCD] [varchar](100) NOT NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[UserTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[V5EmailBlast]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[V5EmailBlast](
	[EmailBlastID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedByDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](100) NOT NULL,
	[SendDate] [datetime] NULL,
	[StatusUCODE] [varchar](100) NOT NULL,
	[Subject] [varchar](100) NOT NULL,
	[EmailFrom] [varchar](100) NULL,
	[ToUCODE] [varchar](100) NOT NULL,
	[ToOther] [varchar](500) NULL,
	[ToSent] [varchar](max) NULL,
	[Body] [varchar](max) NULL,
	[OrginalEmailBlastID] [int] NULL,
	[LogFile] [varchar](100) NULL,
 CONSTRAINT [PK_V5EmailBlast] PRIMARY KEY CLUSTERED 
(
	[EmailBlastID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[V5EmailBlastAttachment]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[V5EmailBlastAttachment](
	[EmailBlastAttachmentID] [int] IDENTITY(1,1) NOT NULL,
	[EmailBlastID] [int] NOT NULL,
	[CreatedByDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](100) NOT NULL,
	[AttachmentPath] [varchar](500) NOT NULL,
	[OriginalFileName] [varchar](500) NULL,
 CONSTRAINT [PK_V5EmailBlastAttachment] PRIMARY KEY CLUSTERED 
(
	[EmailBlastAttachmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[V5Hash]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[V5Hash](
	[HashItemID] [int] IDENTITY(1,1) NOT NULL,
	[HashGUID] [varchar](500) NOT NULL,
	[HashKey] [varchar](100) NOT NULL,
	[HashValue] [varchar](max) NOT NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_V5Hash] PRIMARY KEY CLUSTERED 
(
	[HashItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_HashGuid_HashKey] UNIQUE NONCLUSTERED 
(
	[HashGUID] ASC,
	[HashKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[V5JobMasterRun]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[V5JobMasterRun](
	[JobMasterRunID] [int] IDENTITY(1,1) NOT NULL,
	[CreatedByDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](100) NOT NULL,
	[Status_Ucode] [varchar](100) NOT NULL,
	[Parameters] [varchar](255) NOT NULL,
	[Output] [varchar](max) NULL,
	[RunDateTime] [datetime] NULL,
 CONSTRAINT [PK_V5JobMasterRun] PRIMARY KEY CLUSTERED 
(
	[JobMasterRunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[V5Register]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[V5Register](
	[RegisterID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](100) NULL,
	[LName] [varchar](100) NULL,
	[Address] [varchar](100) NULL,
	[City] [varchar](50) NULL,
	[State] [char](2) NULL,
	[Zip] [varchar](10) NULL,
	[BusinessName] [varchar](100) NULL,
	[BusinessType] [varchar](100) NULL,
	[BusinessSize] [varchar](100) NULL,
	[BestTimeToContact] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Phone] [varchar](25) NULL,
	[Country] [varchar](25) NULL,
	[ID_DATA] [varchar](25) NULL,
	[UserName] [varchar](25) NULL,
	[Password] [varchar](25) NULL,
	[StatusUCode] [varchar](25) NULL,
	[LastUpdateBy] [varchar](100) NULL,
	[LastUpdate] [varchar](100) NOT NULL,
	[CreatedBy] [varchar](100) NOT NULL,
	[CreateDate] [varchar](100) NOT NULL,
	[Address2] [varchar](100) NULL,
 CONSTRAINT [PK_Register] PRIMARY KEY CLUSTERED 
(
	[RegisterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[v5SalesMan]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[v5SalesMan](
	[SalesManID] [int] IDENTITY(1,1) NOT NULL,
	[Initial] [varchar](2) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Email] [varchar](100) NULL,
	[LastUpdatedBy] [varchar](100) NOT NULL,
	[LastUpdate] [date] NOT NULL,
	[CreatedBy] [varchar](100) NOT NULL,
	[CreatedByDate] [date] NOT NULL,
	[active] [bit] NULL,
 CONSTRAINT [PK_v5SalesMan] PRIMARY KEY CLUSTERED 
(
	[SalesManID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_v5SalesMan_Initial] UNIQUE NONCLUSTERED 
(
	[Initial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[v5WebLog]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[v5WebLog](
	[WeblogID] [int] IDENTITY(1,1) NOT NULL,
	[ip] [varchar](20) NULL,
	[createDateTime] [datetime] NOT NULL,
	[message] [ntext] NOT NULL,
	[type] [varchar](20) NULL,
	[action] [varchar](100) NULL,
	[User] [varchar](100) NULL,
	[Page] [varchar](500) NULL,
	[Reported] [bit] NULL,
	[IsAjax] [bit] NULL,
	[HttpReferer] [varchar](300) NULL,
	[HttpUserAgent] [varchar](300) NULL,
	[Https] [varchar](10) NULL,
	[ResponseCode] [int] NULL,
	[IsNotFound] [bit] NULL,
 CONSTRAINT [PK_webLog] PRIMARY KEY CLUSTERED 
(
	[WeblogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_action_queue]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_action_queue](
	[qid] [int] IDENTITY(1000,1) NOT NULL,
	[status] [int] NULL,
	[actiondatetime] [datetime] NULL,
	[document_type] [int] NULL,
	[document_id] [nvarchar](50) NULL,
	[action] [int] NULL,
	[lastactionresult] [int] NULL,
	[lastactiondatetime] [datetime] NULL,
	[actionlog] [nvarchar](255) NULL,
	[xfile] [nvarchar](255) NULL,
	[custid] [nvarchar](6) NULL,
	[mid] [nvarchar](6) NULL,
	[bizname] [nvarchar](100) NULL,
	[contactname] [nvarchar](100) NULL,
	[email] [nvarchar](50) NULL,
	[telephone] [nvarchar](50) NULL,
	[fax] [nvarchar](50) NULL,
	[type] [int] NULL,
	[runinterval] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_alerts]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_alerts](
	[aid] [int] IDENTITY(1000,1) NOT NULL,
	[mid] [nvarchar](10) NULL,
	[createdate] [datetime] NULL,
	[createdby] [nvarchar](50) NULL,
	[atype] [int] NULL,
	[productcode] [nvarchar](10) NULL,
	[documentType] [int] NULL,
	[documentid] [int] NULL,
	[document_num] [int] NULL,
	[alevel] [int] NULL,
	[msg] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_balance_sheet]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_balance_sheet](
	[bsid] [int] IDENTITY(1000,1) NOT NULL,
	[mid] [nvarchar](10) NULL,
	[postdate] [datetime] NULL,
	[duedate] [datetime] NULL,
	[wsalestaxdue] [float] NULL,
	[wamountdue] [float] NULL,
	[salestaxdue] [float] NULL,
	[amountdue] [float] NULL,
	[amountpaid] [float] NULL,
	[label] [nvarchar](255) NULL,
	[type] [int] NULL,
	[document_id] [int] NULL,
	[document_num] [int] NULL,
	[comment] [nvarchar](255) NULL,
	[createdate] [datetime] NULL,
	[createdby] [nvarchar](6) NULL,
	[createdbyname] [nvarchar](100) NULL,
	[lastupdate] [datetime] NULL,
	[lastupdateby] [nvarchar](6) NULL,
	[lastupdatebyname] [nvarchar](100) NULL,
	[cvid] [nvarchar](10) NULL,
	[cvname] [nvarchar](100) NULL,
	[qbexport] [int] NULL,
	[qbexport_date] [datetime] NULL,
	[qbexport_comment] [nvarchar](255) NULL,
	[qbexport_result] [int] NULL,
	[qbexport_txnid] [nvarchar](50) NULL,
 CONSTRAINT [PK_wta_balance_sheet] PRIMARY KEY NONCLUSTERED 
(
	[bsid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_catalog_N_save]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_catalog_N_save](
	[prodid] [int] NOT NULL,
	[mid] [nvarchar](10) NULL,
	[productcode] [nvarchar](20) NULL,
	[description] [nvarchar](255) NULL,
	[vendormid] [nvarchar](10) NULL,
	[vendorname] [nvarchar](100) NULL,
	[vendorcode] [nvarchar](20) NULL,
	[vendordescription] [nvarchar](255) NULL,
	[vendorcasecount] [int] NULL,
	[wlbcs] [float] NULL,
	[wlbpc] [float] NULL,
	[rlbcs] [float] NULL,
	[rlbpc] [float] NULL,
	[taxable] [int] NULL,
	[lastwlbcs] [float] NULL,
	[lastwlbpc] [float] NULL,
	[weight] [float] NULL,
	[casecount] [int] NULL,
	[scatid] [nvarchar](6) NULL,
	[catid] [nvarchar](6) NULL,
	[createdate] [datetime] NULL,
	[lastupdate] [datetime] NULL,
	[active] [int] NULL,
	[xtype] [nvarchar](50) NULL,
	[comment] [nvarchar](255) NULL,
	[weight_type] [nvarchar](1) NULL,
	[um_style] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_favorites]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_favorites](
	[fid] [decimal](18, 0) NULL,
	[mid] [nvarchar](10) NULL,
	[custid] [nvarchar](10) NULL,
	[name] [nvarchar](100) NULL,
	[frequency] [decimal](18, 0) NULL,
	[lastdate] [datetime] NULL,
	[comment] [nvarchar](255) NULL,
	[createdate] [datetime] NULL,
	[createdby] [nvarchar](10) NULL,
	[createdbyname] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_favorites_item]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_favorites_item](
	[fid] [char](10) NOT NULL,
	[productcode] [nvarchar](15) NULL,
	[um] [nvarchar](10) NULL,
	[qty] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_fdpx_struct]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_fdpx_struct](
	[tableid] [nvarchar](3) NULL,
	[fnum] [int] NULL,
	[fname] [nvarchar](20) NULL,
	[length] [int] NULL,
	[startpos] [int] NULL,
	[endpos] [int] NULL,
	[fdesc] [nvarchar](100) NULL,
	[structID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[structID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_FDPX_fname] UNIQUE NONCLUSTERED 
(
	[tableid] ASC,
	[fname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_inventory]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_inventory](
	[iid] [int] IDENTITY(1000,1) NOT NULL,
	[iSourceID] [int] NULL,
	[mid] [nvarchar](10) NULL,
	[qty] [float] NULL,
	[weight] [float] NULL,
	[um] [nvarchar](50) NULL,
	[casecount] [int] NULL,
	[createdate] [datetime] NULL,
	[createdby] [nvarchar](10) NULL,
	[createdbyname] [nvarchar](100) NULL,
	[poid] [int] NULL,
	[polid] [int] NULL,
	[ponum] [int] NULL,
	[status] [int] NULL,
	[wprice] [float] NULL,
	[assigneddate] [datetime] NULL,
	[assignedby] [nvarchar](10) NULL,
	[assignedbyname] [nvarchar](100) NULL,
	[lastupdate] [datetime] NULL,
	[lastupdateby] [nvarchar](10) NULL,
	[lastupdatebyname] [nvarchar](100) NULL,
	[tid] [int] NULL,
	[tlid] [int] NULL,
	[invoice_id] [int] NULL,
	[customer] [nvarchar](100) NULL,
	[customerid] [nvarchar](10) NULL,
	[productcode] [nvarchar](20) NULL,
	[description] [nvarchar](255) NULL,
	[vendorcode] [nvarchar](20) NULL,
	[vendordescription] [nvarchar](255) NULL,
	[vendormid] [nvarchar](10) NULL,
	[vendorname] [nvarchar](100) NULL,
	[note] [nvarchar](255) NULL,
	[breakable] [smallint] NULL,
	[jwitem] [nvarchar](1) NULL,
	[um_style] [int] NULL,
	[productweight] [float] NULL,
	[wasbroken] [int] NULL,
	[brokenIID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_lists]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_lists](
	[lid] [int] IDENTITY(1000,1) NOT NULL,
	[description] [nvarchar](255) NULL,
	[type] [int] NULL,
	[mid] [nvarchar](6) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_po]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_po](
	[mid] [nvarchar](10) NOT NULL,
	[status] [int] NULL,
	[vendormid] [nvarchar](50) NULL,
	[vendorname] [nvarchar](50) NULL,
	[vendoraddress] [nvarchar](255) NULL,
	[createdby] [nvarchar](6) NULL,
	[createdbyname] [nvarchar](100) NULL,
	[lastupdateby] [nvarchar](6) NULL,
	[lastupdatebyname] [nvarchar](100) NULL,
	[createdate] [datetime] NULL,
	[lastupdate] [datetime] NULL,
	[postdate] [datetime] NULL,
	[pocomment] [nvarchar](255) NULL,
	[shipdate] [datetime] NULL,
	[FDRCustid] [nvarchar](6) NULL,
	[FDRInvoice] [nvarchar](50) NULL,
	[FDRSalesMan] [nvarchar](2) NULL,
	[FDRLugger] [nvarchar](2) NULL,
	[MerchTotal] [float] NULL,
	[TaxTotal] [float] NULL,
	[WeightTotal] [float] NULL,
	[FreightTotal] [float] NULL,
	[FDRChecker] [nvarchar](2) NULL,
	[returndate] [datetime] NULL,
	[source] [int] NULL,
	[sentstatus] [int] NULL,
	[sentdate] [datetime] NULL,
	[sentmessage] [nvarchar](255) NULL,
	[sentmethod] [int] NULL,
	[routeid] [int] NULL,
	[routename] [nvarchar](100) NULL,
	[poid] [int] IDENTITY(10,1) NOT NULL,
	[statusUCode] [varchar](20) NOT NULL,
	[requested_delivery_time] [datetime] NULL,
	[ponum] [varchar](200) NOT NULL,
	[LogisticsModel] [varchar](1) NULL,
	[NameComment] [varchar](255) NULL,
	[TotalRebate] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[poid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_po_line]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_po_line](
	[poid] [int] NOT NULL,
	[line_num] [int] NULL,
	[productcode] [nvarchar](15) NULL,
	[productdescription] [nvarchar](255) NULL,
	[productaltcode] [nvarchar](15) NULL,
	[productaltdescription] [nvarchar](255) NULL,
	[vendorcode] [nvarchar](15) NULL,
	[vendordescription] [nvarchar](255) NULL,
	[vendoraltcode] [nvarchar](15) NULL,
	[vendoraltdescription] [nvarchar](255) NULL,
	[um] [nvarchar](2) NULL,
	[qty] [float] NULL,
	[wprice] [float] NULL,
	[weight] [float] NULL,
	[casecount] [int] NULL,
	[truck_comment] [nvarchar](255) NULL,
	[vendor_comment] [nvarchar](38) NULL,
	[status] [int] NULL,
	[state] [int] NULL,
	[multiple_weights] [smallint] NULL,
	[amount] [float] NULL,
	[taxamount] [float] NULL,
	[CreateDate] [datetime] NULL,
	[jwitem] [nvarchar](1) NULL,
	[xtype] [nvarchar](10) NULL,
	[taxable] [int] NULL,
	[um_style] [int] NULL,
	[productweight] [float] NULL,
	[mw_buffer] [varchar](1000) NULL,
	[SourceTicketInfo] [nvarchar](1000) NULL,
	[polid] [int] IDENTITY(10,1) NOT NULL,
	[catid] [nvarchar](3) NULL,
	[scatid] [nvarchar](3) NULL,
	[LineTypeUCode] [varchar](30) NULL,
	[weight_type] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[polid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_po_line_weight]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_po_line_weight](
	[polwid] [int] IDENTITY(1000,1) NOT NULL,
	[polid] [int] NULL,
	[iid] [int] NULL,
	[qty] [float] NULL,
	[weight] [float] NULL,
	[createdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_reports]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_reports](
	[rid] [numeric](18, 0) IDENTITY(1000,1) NOT NULL,
	[displayorder] [float] NULL,
	[title] [nvarchar](255) NULL,
	[tag] [nvarchar](50) NULL,
	[description] [nvarchar](255) NULL,
	[flags] [numeric](18, 0) NULL,
	[active] [smallint] NULL,
	[sortfields] [nvarchar](255) NULL,
	[sortlabels] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_route]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_route](
	[rid] [int] IDENTITY(1000,1) NOT NULL,
	[mid] [nvarchar](6) NULL,
	[name] [nvarchar](100) NULL,
	[description] [nvarchar](255) NULL,
	[driver1] [nvarchar](6) NULL,
	[driver2] [nvarchar](6) NULL,
	[active] [int] NULL,
	[createdate] [datetime] NULL,
	[lastupdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_sales_tax]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_sales_tax](
	[code] [nvarchar](10) NULL,
	[description] [nvarchar](100) NULL,
	[rate] [float] NULL,
	[sid] [int] IDENTITY(10,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UN_wta_sales_tax_code] UNIQUE NONCLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_ticket]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_ticket](
	[tid] [int] NOT NULL,
	[invoice_id] [int] NULL,
	[mid] [nvarchar](6) NULL,
	[custid] [nvarchar](6) NULL,
	[offline] [int] NULL,
	[customername] [nvarchar](100) NULL,
	[createdate] [datetime] NULL,
	[lastupdate] [datetime] NULL,
	[postdate] [datetime] NULL,
	[duedate] [datetime] NULL,
	[createdby] [nvarchar](6) NULL,
	[createdbyname] [nvarchar](100) NULL,
	[lastupdateby] [nvarchar](6) NULL,
	[lastupdatebyname] [nvarchar](100) NULL,
	[salesmanid] [nvarchar](6) NULL,
	[salesmanname] [nvarchar](100) NULL,
	[terms] [int] NULL,
	[shipmethod] [nvarchar](50) NULL,
	[paymethod] [nvarchar](100) NULL,
	[custrec] [nvarchar](100) NULL,
	[cust_note] [nvarchar](255) NULL,
	[vendor_note] [nvarchar](255) NULL,
	[route_note] [nvarchar](255) NULL,
	[status] [int] NULL,
	[shipaddress] [nvarchar](255) NULL,
	[billaddress] [nvarchar](255) NULL,
	[WTaxTotal] [float] NULL,
	[WMerchTotal] [float] NULL,
	[MerchTotal] [float] NULL,
	[TaxTotal] [float] NULL,
	[WeightTotal] [float] NULL,
	[FreightTotal] [float] NULL,
	[routeid] [int] NULL,
	[routename] [nvarchar](100) NULL,
	[phone] [nvarchar](30) NULL,
	[templatetype] [int] NULL,
	[templatetitle] [nvarchar](255) NULL,
	[templatefrequency] [int] NULL,
	[templatelastdate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_ticket_line]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_ticket_line](
	[tid] [int] NULL,
	[tlid] [int] IDENTITY(1000,1) NOT NULL,
	[line_num] [int] NULL,
	[productcode] [nvarchar](15) NULL,
	[productdescription] [nvarchar](255) NULL,
	[productaltcode] [nvarchar](15) NULL,
	[productaltdescription] [nvarchar](255) NULL,
	[qty] [float] NULL,
	[rprice] [float] NULL,
	[wprice] [float] NULL,
	[wtaxamount] [float] NULL,
	[taxamount] [float] NULL,
	[wamount] [float] NULL,
	[amount] [float] NULL,
	[weight] [float] NULL,
	[casecount] [int] NULL,
	[vendorcasecount] [int] NULL,
	[totalcost] [float] NULL,
	[truck_comment] [nvarchar](255) NULL,
	[vendor_comment] [nvarchar](255) NULL,
	[cust_comment] [nvarchar](255) NULL,
	[status] [int] NULL,
	[state] [int] NULL,
	[um] [nvarchar](10) NULL,
	[vendorcode] [nvarchar](15) NULL,
	[vendormid] [nvarchar](10) NULL,
	[vendorname] [nvarchar](100) NULL,
	[vendordescription] [nvarchar](255) NULL,
	[vendoraltcode] [nvarchar](15) NULL,
	[vendoraltdescription] [nvarchar](255) NULL,
	[multiple_weights] [smallint] NULL,
	[custid] [nvarchar](10) NULL,
	[customername] [nvarchar](100) NULL,
	[directprice] [bit] NULL,
	[poid] [int] NULL,
	[CreateDate] [datetime] NULL,
	[xtype] [nvarchar](50) NULL,
	[taxable] [int] NULL,
	[um_style] [int] NULL,
	[productweight] [float] NULL,
	[forceprice] [int] NULL,
	[jwitem] [nvarchar](1) NULL,
	[templatex] [int] NULL,
	[wasbroken] [int] NULL,
	[recordcheck] [timestamp] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wta_ticket_line_weight]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wta_ticket_line_weight](
	[tlwid] [int] IDENTITY(1000,1) NOT NULL,
	[iid] [int] NULL,
	[tlid] [int] NULL,
	[createdate] [datetime] NULL,
	[weight] [float] NULL,
	[qty] [float] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ad] ADD  CONSTRAINT [DF_Ad_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Ad] ADD  CONSTRAINT [DF_Ad_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[Ad] ADD  CONSTRAINT [DF_Ad_Active]  DEFAULT ((1)) FOR [Active]
GO
ALTER TABLE [dbo].[BookConfig] ADD  CONSTRAINT [DF_BookConfig_IsCurrent]  DEFAULT ((1)) FOR [IsCurrent]
GO
ALTER TABLE [dbo].[BookConfig] ADD  CONSTRAINT [DF_BookConfig_ShowPrices]  DEFAULT ((1)) FOR [ShowPrices]
GO
ALTER TABLE [dbo].[BookConfig] ADD  CONSTRAINT [DF_BookConfig_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[BookConfig] ADD  CONSTRAINT [DF_BookConfig_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[Chain] ADD  CONSTRAINT [DF_Chain_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Chain] ADD  CONSTRAINT [DF_Chain_CreatedBy]  DEFAULT ('SYS') FOR [CreatedBy]
GO
ALTER TABLE [dbo].[Chain] ADD  CONSTRAINT [DF_Chain_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[Chain] ADD  CONSTRAINT [DF_Chain_LastUpdatedBy]  DEFAULT ('SYS') FOR [LastUpdatedBy]
GO
ALTER TABLE [dbo].[Favorite] ADD  CONSTRAINT [DF_Favorite_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[Favorite] ADD  CONSTRAINT [DF_Favorite_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[FDACTION] ADD  CONSTRAINT [DF__FDACTION__active__66EA454A]  DEFAULT ((0)) FOR [active]
GO
ALTER TABLE [dbo].[FDACTIONHistory] ADD  CONSTRAINT [DF__FDACTIONHISTORY__active__66EA454A]  DEFAULT ((0)) FOR [active]
GO
ALTER TABLE [dbo].[ProdCustGuide] ADD  CONSTRAINT [DF_ProdCustGuide_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ProdCustGuide] ADD  CONSTRAINT [DF_ProdCustGuide_CreatedBy]  DEFAULT ('SYS') FOR [CreatedBy]
GO
ALTER TABLE [dbo].[ProdCustGuide] ADD  CONSTRAINT [DF_ProdCustGuide_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[ProdCustGuide] ADD  CONSTRAINT [DF_ProdCustGuide_LastUpdatedBy]  DEFAULT ('SYS') FOR [LastUpdatedBy]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_onsale]  DEFAULT (0) FOR [onsale]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_onsalesheet]  DEFAULT (0) FOR [onsalesheet]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_onsale_nw]  DEFAULT (0) FOR [onsale_nw]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_onsalesheet_nw]  DEFAULT (0) FOR [onsalesheet_nw]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_sale_lbcs]  DEFAULT (0) FOR [sale_lbcs]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_sale_jlbcs]  DEFAULT (0) FOR [sale_jlbcs]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_sale_pos]  DEFAULT (0) FOR [sale_pos]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_sale_col]  DEFAULT (0) FOR [sale_col]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_sale_lbcs_nw]  DEFAULT (0) FOR [sale_lbcs_nw]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_sale_jlbcs_nw]  DEFAULT (0) FOR [sale_jlbcs_nw]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_sale_pos_nw]  DEFAULT (0) FOR [sale_pos_nw]
GO
ALTER TABLE [dbo].[prods] ADD  CONSTRAINT [DF_prods_sale_col_nw]  DEFAULT (0) FOR [sale_col_nw]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [AvgCost]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [AdjCost]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [isMaster]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_onsale]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_onsalesheet]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_onsale_nw]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_onsalesheet_nw]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_sale_lbcs]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_sale_jlbcs]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_sale_pos]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_sale_col]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_sale_lbcs_nw]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_sale_jlbcs_nw]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_sale_pos_nw]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT (0) FOR [jobber_sale_col_nw]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT ('N') FOR [taxable]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT ((0)) FOR [OnPriceList]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT ((0)) FOR [DoNotSell]
GO
ALTER TABLE [dbo].[prods] ADD  DEFAULT ((0)) FOR [ArrowProd]
GO
ALTER TABLE [dbo].[SalesBeefConfig] ADD  CONSTRAINT [DF_SalesBeefConfig_IsCurrent]  DEFAULT ((1)) FOR [IsCurrent]
GO
ALTER TABLE [dbo].[SalesBeefConfig] ADD  CONSTRAINT [DF_SalesBeefConfig_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[SalesBeefConfig] ADD  CONSTRAINT [DF_SalesBeefConfig_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[system] ADD  CONSTRAINT [DF_system_systemID]  DEFAULT (newid()) FOR [systemID]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_access]  DEFAULT (0) FOR [access]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_faxmachine]  DEFAULT (0) FOR [faxmachine]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_sendfax]  DEFAULT (0) FOR [sendfax]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_sendemail]  DEFAULT (0) FOR [sendemail]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_sendmail]  DEFAULT (0) FOR [sendmail]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_flags]  DEFAULT (0) FOR [flags]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_source]  DEFAULT (0) FOR [source]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_pMargin]  DEFAULT (2) FOR [pMargin]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_pPageCol]  DEFAULT (110) FOR [pPageCol]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_pFontSize]  DEFAULT (9) FOR [pFontSize]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_pFont]  DEFAULT ('Courier New') FOR [pFont]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_accpay]  DEFAULT (0) FOR [accpay]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_salesheetlabel]  DEFAULT ('') FOR [salesheetlabel]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_password]  DEFAULT ('') FOR [password]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_invoice_ager_1]  DEFAULT (0) FOR [invoice_ager]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [BeefMarkup]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ('N') FOR [taxable]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [CanOrder]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [ager_current]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [ager_week1]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [ager_week2]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [ager_week3]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [ager_week4]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [ager_week5]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [ager_week6]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_CanViewInventoryDetails]  DEFAULT ((0)) FOR [CanViewInventoryDetails]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((0)) FOR [UseProdCustGuide]
GO
ALTER TABLE [dbo].[V5Hash] ADD  CONSTRAINT [DF_V5Hash_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[V5JobMasterRun] ADD  CONSTRAINT [DF_V5JobMasterRun_CreatedByDate]  DEFAULT (getdate()) FOR [CreatedByDate]
GO
ALTER TABLE [dbo].[V5JobMasterRun] ADD  CONSTRAINT [DF_V5JobMasterRun_CreatedBy]  DEFAULT ('SYS') FOR [CreatedBy]
GO
ALTER TABLE [dbo].[V5Register] ADD  DEFAULT ('PENDING') FOR [StatusUCode]
GO
ALTER TABLE [dbo].[V5Register] ADD  DEFAULT ('SYS') FOR [LastUpdateBy]
GO
ALTER TABLE [dbo].[V5Register] ADD  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[V5Register] ADD  DEFAULT ('SYS') FOR [CreatedBy]
GO
ALTER TABLE [dbo].[V5Register] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[v5SalesMan] ADD  CONSTRAINT [DF_v5SalesMan_LastUpdatedBy]  DEFAULT ('SYS') FOR [LastUpdatedBy]
GO
ALTER TABLE [dbo].[v5SalesMan] ADD  CONSTRAINT [DF_v5SalesMan_LastUpdate]  DEFAULT (getdate()) FOR [LastUpdate]
GO
ALTER TABLE [dbo].[v5SalesMan] ADD  CONSTRAINT [DF_v5SalesMan_CreatedBy]  DEFAULT ('SYS') FOR [CreatedBy]
GO
ALTER TABLE [dbo].[v5SalesMan] ADD  CONSTRAINT [DF_v5SalesMan_CreatedByDate]  DEFAULT (getdate()) FOR [CreatedByDate]
GO
ALTER TABLE [dbo].[v5SalesMan] ADD  DEFAULT ((0)) FOR [active]
GO
ALTER TABLE [dbo].[v5WebLog] ADD  CONSTRAINT [DF_rrLog_createDateTime]  DEFAULT (getdate()) FOR [createDateTime]
GO
ALTER TABLE [dbo].[v5WebLog] ADD  DEFAULT ((0)) FOR [Reported]
GO
ALTER TABLE [dbo].[v5WebLog] ADD  DEFAULT ((0)) FOR [IsAjax]
GO
ALTER TABLE [dbo].[v5WebLog] ADD  DEFAULT ('') FOR [HttpReferer]
GO
ALTER TABLE [dbo].[v5WebLog] ADD  DEFAULT ('') FOR [HttpUserAgent]
GO
ALTER TABLE [dbo].[v5WebLog] ADD  DEFAULT ('') FOR [Https]
GO
ALTER TABLE [dbo].[v5WebLog] ADD  DEFAULT ((0)) FOR [ResponseCode]
GO
ALTER TABLE [dbo].[v5WebLog] ADD  DEFAULT ((0)) FOR [IsNotFound]
GO
ALTER TABLE [dbo].[wta_ager] ADD  CONSTRAINT [DF_wta_ager_lastupdate]  DEFAULT (getdate()) FOR [lastupdate]
GO
ALTER TABLE [dbo].[wta_alerts] ADD  CONSTRAINT [DF_wta_alerts_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_balance_sheet] ADD  CONSTRAINT [DF_wta_balance_sheet_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_cat] ADD  CONSTRAINT [DF_wta_cat_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_catalog] ADD  CONSTRAINT [DF_wta_catalog_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_fdpx_struct] ADD  CONSTRAINT [DF_wta_fdpx_struct_structID]  DEFAULT (newid()) FOR [structID]
GO
ALTER TABLE [dbo].[wta_inventory] ADD  CONSTRAINT [DF_wta_inventory_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_inventory] ADD  CONSTRAINT [DF_wta_inventory_createdbyname]  DEFAULT (0) FOR [createdbyname]
GO
ALTER TABLE [dbo].[wta_inventory] ADD  CONSTRAINT [DF_wta_inventory_poid]  DEFAULT (0) FOR [poid]
GO
ALTER TABLE [dbo].[wta_inventory] ADD  CONSTRAINT [DF_wta_inventory_polid]  DEFAULT (0) FOR [polid]
GO
ALTER TABLE [dbo].[wta_inventory] ADD  CONSTRAINT [DF_wta_inventory_tid]  DEFAULT (0) FOR [tid]
GO
ALTER TABLE [dbo].[wta_inventory] ADD  CONSTRAINT [DF_wta_inventory_tlid]  DEFAULT (0) FOR [tlid]
GO
ALTER TABLE [dbo].[wta_inventory] ADD  CONSTRAINT [DF_wta_inventory_invoice_id]  DEFAULT (0) FOR [invoice_id]
GO
ALTER TABLE [dbo].[wta_po] ADD  CONSTRAINT [DF_wta_po_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_po] ADD  CONSTRAINT [def_lastupdate]  DEFAULT (getdate()) FOR [lastupdate]
GO
ALTER TABLE [dbo].[wta_po] ADD  CONSTRAINT [def_postdate]  DEFAULT (getdate()) FOR [postdate]
GO
ALTER TABLE [dbo].[wta_po] ADD  DEFAULT ('D') FOR [LogisticsModel]
GO
ALTER TABLE [dbo].[wta_po_line] ADD  CONSTRAINT [DF_wta_po_line_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[wta_po_line_weight] ADD  CONSTRAINT [DF_wta_po_line_weight_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_route] ADD  CONSTRAINT [DF_wta_route_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_ticket] ADD  CONSTRAINT [DF_wta_ticket_offline]  DEFAULT (0) FOR [offline]
GO
ALTER TABLE [dbo].[wta_ticket] ADD  CONSTRAINT [DF_wta_ticket_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[wta_ticket] ADD  CONSTRAINT [DF_wta_ticket_istemplate]  DEFAULT (0) FOR [templatetype]
GO
ALTER TABLE [dbo].[wta_ticket_line] ADD  CONSTRAINT [DF_wta_ticket_line_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[wta_ticket_line] ADD  CONSTRAINT [DF_wta_ticket_line_templatex]  DEFAULT (0) FOR [templatex]
GO
ALTER TABLE [dbo].[wta_ticket_line_weight] ADD  CONSTRAINT [DF_wta_ticket_line_weight_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[BookConfigAd]  WITH CHECK ADD  CONSTRAINT [FK_BookConfigAd_AdID] FOREIGN KEY([AdID])
REFERENCES [dbo].[Ad] ([AdID])
GO
ALTER TABLE [dbo].[BookConfigAd] CHECK CONSTRAINT [FK_BookConfigAd_AdID]
GO
ALTER TABLE [dbo].[BookConfigAd]  WITH CHECK ADD  CONSTRAINT [FK_BookConfigAd_BookConfigID] FOREIGN KEY([BookConfigID])
REFERENCES [dbo].[BookConfig] ([BookConfigID])
GO
ALTER TABLE [dbo].[BookConfigAd] CHECK CONSTRAINT [FK_BookConfigAd_BookConfigID]
GO
ALTER TABLE [dbo].[Favorite]  WITH CHECK ADD  CONSTRAINT [FK_favorite_custid] FOREIGN KEY([custID])
REFERENCES [dbo].[users] ([custid])
GO
ALTER TABLE [dbo].[Favorite] CHECK CONSTRAINT [FK_favorite_custid]
GO
ALTER TABLE [dbo].[groupa]  WITH CHECK ADD  CONSTRAINT [FK_groupa_groupcode] FOREIGN KEY([groupcode])
REFERENCES [dbo].[groupd] ([groupcode])
GO
ALTER TABLE [dbo].[groupa] CHECK CONSTRAINT [FK_groupa_groupcode]
GO
ALTER TABLE [dbo].[groupa]  WITH CHECK ADD  CONSTRAINT [FK_groupa_productcode] FOREIGN KEY([productcode])
REFERENCES [dbo].[prods] ([productcode])
GO
ALTER TABLE [dbo].[groupa] CHECK CONSTRAINT [FK_groupa_productcode]
GO
ALTER TABLE [dbo].[PriceMaster]  WITH CHECK ADD  CONSTRAINT [FK_pricemaster_custid] FOREIGN KEY([CustID])
REFERENCES [dbo].[users] ([custid])
GO
ALTER TABLE [dbo].[PriceMaster] CHECK CONSTRAINT [FK_pricemaster_custid]
GO
ALTER TABLE [dbo].[PriceMaster]  WITH CHECK ADD  CONSTRAINT [FK_pricemaster_productcode] FOREIGN KEY([productcode])
REFERENCES [dbo].[prods] ([productcode])
GO
ALTER TABLE [dbo].[PriceMaster] CHECK CONSTRAINT [FK_pricemaster_productcode]
GO
ALTER TABLE [dbo].[prods]  WITH CHECK ADD  CONSTRAINT [FK_prods_catid] FOREIGN KEY([catid])
REFERENCES [dbo].[cat] ([catid])
GO
ALTER TABLE [dbo].[prods] CHECK CONSTRAINT [FK_prods_catid]
GO
ALTER TABLE [dbo].[prods]  WITH CHECK ADD  CONSTRAINT [FK_prods_scatid] FOREIGN KEY([scatid])
REFERENCES [dbo].[catsub] ([scatid])
GO
ALTER TABLE [dbo].[prods] CHECK CONSTRAINT [FK_prods_scatid]
GO
ALTER TABLE [dbo].[SalesBeefConfigAd]  WITH CHECK ADD  CONSTRAINT [FK_SalesBeefConfigAd_AdID] FOREIGN KEY([AdID])
REFERENCES [dbo].[Ad] ([AdID])
GO
ALTER TABLE [dbo].[SalesBeefConfigAd] CHECK CONSTRAINT [FK_SalesBeefConfigAd_AdID]
GO
ALTER TABLE [dbo].[SalesBeefConfigAd]  WITH CHECK ADD  CONSTRAINT [FK_SalesBeefConfigAd_SalesBeefConfigID] FOREIGN KEY([SalesBeefConfigID])
REFERENCES [dbo].[SalesBeefConfig] ([SalesBeefConfigID])
GO
ALTER TABLE [dbo].[SalesBeefConfigAd] CHECK CONSTRAINT [FK_SalesBeefConfigAd_SalesBeefConfigID]
GO
ALTER TABLE [dbo].[speed]  WITH CHECK ADD  CONSTRAINT [FK_speed_custid] FOREIGN KEY([custid])
REFERENCES [dbo].[users] ([custid])
GO
ALTER TABLE [dbo].[speed] CHECK CONSTRAINT [FK_speed_custid]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_sales_tax_region] FOREIGN KEY([sales_tax_region])
REFERENCES [dbo].[wta_sales_tax] ([code])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_sales_tax_region]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_UserType] FOREIGN KEY([type])
REFERENCES [dbo].[UserType] ([UserTypeID])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_UserType]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [UN_Users_ChainCode] FOREIGN KEY([ChainCode])
REFERENCES [dbo].[Chain] ([ChainCode])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [UN_Users_ChainCode]
GO
ALTER TABLE [dbo].[UsersBook]  WITH CHECK ADD  CONSTRAINT [FK_UsersBook_CustID] FOREIGN KEY([custID])
REFERENCES [dbo].[users] ([custid])
GO
ALTER TABLE [dbo].[UsersBook] CHECK CONSTRAINT [FK_UsersBook_CustID]
GO
ALTER TABLE [dbo].[wta_po]  WITH CHECK ADD  CONSTRAINT [FK_wta_po_mid] FOREIGN KEY([mid])
REFERENCES [dbo].[users] ([custid])
GO
ALTER TABLE [dbo].[wta_po] CHECK CONSTRAINT [FK_wta_po_mid]
GO
ALTER TABLE [dbo].[wta_po_line]  WITH CHECK ADD  CONSTRAINT [FK_wta_po_line_poid] FOREIGN KEY([poid])
REFERENCES [dbo].[wta_po] ([poid])
GO
ALTER TABLE [dbo].[wta_po_line] CHECK CONSTRAINT [FK_wta_po_line_poid]
GO
/****** Object:  StoredProcedure [dbo].[prAddFavorite]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prAddFavorite] 
/*
select * from users
select * from prods
select * from favorite
exec prAddFavorite '16HDL','17850','test'
*/

@productCode varchar(20),
@custID as varchar(20), 
@custName as varchar(50)
as 
Begin
declare @favoriteID as int

select @favoriteID=favoriteID from favorite where productCode=@productCode and custID=@custID

if IsNull(@favoriteID,0)=0
Begin
   insert into favorite (custId,productCode,CreatedBy,LastUpdatedBy) values (@custID,@productCode,@custName,@custName)
End 

end



GO
/****** Object:  StoredProcedure [dbo].[prDelFavorite]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prDelFavorite] 
/*
select * from users
select * from prods
select * from favorite
exec prAddFavorite '16HDL','17850','test'
exec prdelFavorite 'FOODD','FTC20'
*/

@productCode varchar(20),
@custID as varchar(20) 
as 
Begin
declare @favoriteID as int

select @favoriteID=favoriteID from favorite where productCode=@productCode and custID=@custID

if IsNull(@favoriteID,0)<>0
Begin
   delete from favorite where favoriteID=@favoriteID
End 

end



GO
/****** Object:  StoredProcedure [dbo].[prImportPrepareProds]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- reset prod and cat for import
create proc [dbo].[prImportPrepareProds] 
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

end



GO
/****** Object:  StoredProcedure [dbo].[prMaint]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prMaint]
AS
BEGIN

print 'count of records in V5WebLog Before'
select COUNT(*) from V5weblog


print '-----Truncate Web Log Records------'
declare @CutOffDate as DateTime
set @CutOffDate= DATEADD (yy , -1 , GETDATE() )

print 'delete all v5WebLog Records that are older than '+cast(@cutOffDate as varchar(100))

delete from V5weblog where createDateTime<@CutOffDate

print 'count of records in V5WebLog After'
select COUNT(*) from V5weblog



print '-----Truncate hash Records------'
declare @CutOffDate2 as DateTime
set @CutOffDate2= DATEADD (d , -1 , GETDATE() )


print 'count of records in V5Hash After'
select COUNT(*) from V5Hash

print 'delete all v5Hash Records that are older than '+cast(@cutOffDate2 as varchar(100))

delete from V5Hash where createDate<@CutOffDate2

print 'count of records in V5Hash After'
select COUNT(*) from V5Hash


END
GO
/****** Object:  StoredProcedure [dbo].[prUpdateSalesMan]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[prUpdateSalesMan] 
as 
Begin
INSERT INTO v5SalesMan
           ([Initial]
           ,[Name]
           ,[Email]
		   ,active
		   )

select  slmInit,slmname,'jasonlevine@foodirect.com',1  from 

(select distinct slmname, slminit from users)
as x
left join v5SalesMan s on s.Initial=x.SlmInit
where IsNull(x.SlmInit,'')<>'' and IsNull(s.Initial,'')=''

--delete from v5SalesMan where SalesManID>6
--select * from v5SalesMan
--exec prUpdateSalesMan
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CUSTSCRUB]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CUSTSCRUB]   

@Pcustid  as varchar(10) 
AS

begin tran

delete from accpay where custid=@Pcustid
delete from beefcat where custid=@Pcustid
delete from beefcat_roll where custid=@Pcustid
delete from catmarg where custid=@Pcustid
delete from catmarg_roll where custid=@Pcustid
delete from catneg where custid=@Pcustid
delete from catneg_roll where custid=@Pcustid
delete from login where custid=@Pcustid
delete from prodmarg where custid=@Pcustid
delete from prodmarg_roll where custid=@Pcustid
delete from prodneg where custid=@Pcustid
delete from prodneg_roll where custid=@Pcustid
delete from salecat where custid=@Pcustid
delete from salecat_roll where custid=@Pcustid
delete from salep where custid=@Pcustid
--delete from speed where custid=@Pcustid -- probably not used
delete from favorite where custid=@Pcustid
delete from PriceMaster where custid=@Pcustid
delete from users where custid=@Pcustid


-- 3/27/2011 - these tables have the referential issues 
-- but we can leave this as is for now 
-- Add the new Book PDF Log table
delete from UsersBook  where custID=@Pcustid


commit tran

select custid=@Pcustid
GO
/****** Object:  StoredProcedure [dbo].[sp_Get_Paged_Recordset]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--declare @tx as int 
--exec sp_Get_Paged_Recordset 1,100,'select * from vwProds','productcode asc',@tx

--drop PROCEDURE [dbo].[sp_Get_Paged_Recordset]

CREATE PROCEDURE [dbo].[sp_Get_Paged_Recordset]( 
@PageNumber INT 
,@PageSize INT 
,@CoreSql VARCHAR(MAX) 
,@OrderBy VARCHAR(MAX) 
,@TotalRecords INT OUTPUT) 

AS

DECLARE
 @StartRowIndex VARCHAR(100) 
DECLARE
 @EndRowIndex VARCHAR(100) 
DECLARE
 @Sql NVARCHAR(Max) 
-------------------------------------

-- Paging math.

-------------------------------------
 
SET
 @StartRowIndex = Cast((((@PageNumber - 1) * @PageSize) + 1) AS VARCHAR(100)) 
SET
 @EndRowIndex = Cast(((@StartRowIndex + @PageSize) - 1) AS VARCHAR(100)) 
PRINT
 'StartRowIndex: ' + @StartRowIndex + ' EndRowIndex: ' + @EndRowIndex 
-------------------------------------

-- Find the total number of records.

-------------------------------------
 
SET
 @Sql = N'SELECT @TotalRecords = Count(*) FROM (' + @CoreSql + ') AS x' 
EXEC
 sp_executesql @Sql, N'@TotalRecords INT OUTPUT', @TotalRecords OUTPUT 
PRINT
 'TotalRecords: ' + Cast(@TotalRecords AS VARCHAR(100)) 
-------------------------------------

-- Load the recordset.

-------------------------------------
 
SET
 @Sql = N' 
SELECT * 

FROM 

(SELECT ROW_NUMBER() 

OVER (ORDER BY '
 + @OrderBy + ') AS Row_Num, * 
FROM ('
 + @CoreSql + ') AS x) AS y 
WHERE y.Row_Num >= '
 + @StartRowIndex + ' AND y.Row_Num <= ' + @EndRowIndex 
EXEC
 sp_executesql @Sql 
 

GO
/****** Object:  StoredProcedure [dbo].[SP_JOBBERSCRUB]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

--exec SP_JOBBERSCRUB 83486
--SELECT * FROM FAVORITE WHERE custID='83486'


CREATE PROCEDURE [dbo].[SP_JOBBERSCRUB]
-- Like Customer scrub - Goes and deletes all records of a Jobber -
-- Does not delete all the customer links
-- Those should be done first for each Jobbers customer with Customer Scrub
-- note  - most tables would have already been emptied by the customer scrub
@Pjobberid  as varchar(10)
AS
begin tran
delete from accday where jobberid=@Pjobberid
delete from accday where jobberid=@Pjobberid
delete from accpay where jobberid=@Pjobberid
delete from accpay where jobberid=@Pjobberid
delete from beefadj where jobberid=@Pjobberid
delete from beefadj_roll where jobberid=@Pjobberid
delete from beefcat where jobberid=@Pjobberid
delete from beefcat_roll where jobberid=@Pjobberid
delete from catneg where mid=@Pjobberid
delete from catneg_roll where mid=@Pjobberid
delete from catmarg where mid=@Pjobberid
delete from catmarg_roll where mid=@Pjobberid
delete from prodmarg where mid=@Pjobberid
delete from prodmarg_roll where mid=@Pjobberid
delete from prodneg where mid=@Pjobberid
delete from prodneg_roll where mid=@Pjobberid
delete from saleadj where jobberid=@Pjobberid
delete from saleadj_roll where jobberid=@Pjobberid

-- mte ADD 2/3/20123
DELETE FROM  FAVORITE WHERE custID=@Pjobberid

delete from users where custid=@Pjobberid
delete from users where jobberid=@Pjobberid


commit tran
select jobberid=@Pjobberid


GO
/****** Object:  StoredProcedure [dbo].[sp_pl]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO



CREATE PROCEDURE [dbo].[sp_pl]  
AS
select * from prods

GO
/****** Object:  StoredProcedure [dbo].[SP_ProductUpdateMasterCodes]    Script Date: 7/30/2024 9:09:31 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO



/****** Object:  Stored Procedure dbo.SP_ProductUpdateMasterCodes    Script Date: 6/30/2008 11:42:25 PM ******/
CREATE PROCEDURE [dbo].[SP_ProductUpdateMasterCodes]
 AS
Begin Tran 


-- Look for all Product codes referenced in someones mastercode field
update prods set ismaster=1 
from prods p join
--select * from prods p join 
(
select distinct MasterCode from prods where masterCode<>''
) as s
on s.mastercode=p.productcode

-- Now anyone who was leftover who just has an M in their master code field
update prods set ismaster=1 where MasterCode='M'




commit Tran

GO
