using System;
using System.Configuration;
using u = CSA.UTILITY.MyUtility;

	/// <summary>
	/// Summary description for MyConfig.
	/// </summary>

namespace UI.OBJECTS
{
    public enum Roles
    {
        GUEST = 0,
        MEMBER = 1,
        ADMIN = 2,
        SALES=3
    }


    public enum FDLegacyRoles
    {
        AMM_FDGUEST = 0,   //Foodirect Guest
        AMM_SFGUEST = 1,   //Foodproducts.net Guest - mte 4/9/2009 - jobber and fd customers
        AMM_JCUST = 2,   //Jobber/Wholesaler Customer - 4/15/2015 This is an 'E' in the new labeling - End Users

        AMM_CUST = 3,   //Foodirect 'Direct' Customer Unused - just make them a Jcust
        //4/15/2015 This is an 'W' in the new labeling - WHOLESALERS - These are now used, 


        AMM_FDADMIN = 4,  //Foodirect Super User (Jacksonr)
        AMM_SFSALES = 5,  //Foodproducts.net Sales Person (Sales1)
        AMM_FDCUST = 6,  //Foodirect Qual. Customer (CUST1 includes FDMDB)
        AMM_JOBBER = 7,   //Jobber/Wholesaler   4/15/2015 This is an 'J' in the new labeling - JOBBERS



        AMM_DRIVER = 8,  //Driver/Salesperson/(i.e. General User)
        AMM_VENDOR = 9  //Outside vendor    }
    }
    
    /*
    Const AMM_FDGUEST=0   'Foodirect Guest
Const AMM_SFGUEST=1   'Foodproducts.net Guest - mte 4/9/2009 - jobber and fd customers
Const AMM_JCUST =2   'Jobber/Wholesaler Customer
Const AMM_CUST = 3    'Foodirect 'Direct' Customer Unused - just make them a Jcust
Const AMM_FDADMIN =4  'Foodirect Super User (Jacksonr)
Const AMM_SFSALES =5  'Foodproducts.net Sales Person (Sales1)
Const AMM_FDCUST =6  'Foodirect Qual. Customer (CUST1 includes FDMDB)
Const AMM_JOBBER =7   'Jobber/Wholesaler

'for wta...
Const AMM_DRIVER = 8  'Driver/Salesperson/(i.e. General User)
Const AMM_VENDOR = 9  'Outside vendor
    */
    //VB code of PO States
    /*
        Public Enum POStatus
       poNew = 1
       poReady = 2
       poPosted = 3
       poPriced = 4
       poClosed = 5
    End Enum
    */

    public enum OrderStatus
    {
        NEW = 1,
        READY = 2,
        POSTED = 3,
        PRICED = 4,
        CLOSED = 5
    }

    public enum FDJobStatus
    {
        OK = 0,
        ERROR = 1,
        WARNING = 2,
        INPROGRESS = 3
    }
}