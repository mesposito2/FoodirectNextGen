using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u = CSA.UTILITY.MyUtility;
using System.ComponentModel.DataAnnotations;

namespace UI.MODELS
{

    public class PersonQueryAndViewModel
    {
        public PersonXParmsModel XparmsModel { get; set; }
        public PersonViewModel ViewModel { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        
        public PersonQueryAndViewModel(PersonXParmsModel x, PersonViewModel v)
        {
            Page = 1;
            PageSize = 20;
            XparmsModel = x;
            ViewModel = v;
        }

    }
    
    public class PersonXParmsModel
    {
        public string QueryType { get; set; }
        public string Filter { get; set; }
        public string SortField { get; set; }
        public string SortOrder { get; set; }
        public string Title { get; set; }
        public string Search { get; set; }


        public PersonXParmsModel()
        {

            QueryType = "'ALL'";
            Filter = "''";
            Title = "Memberships";
            Search = "";
        }

    }

        
    public class PersonModel
    {
        [Display(Name = "Customer ID")]
        [StringLength(6, MinimumLength = 6)]
        [Required(ErrorMessage = "Please enter a Unique Customer ID")]
        public string CustID { get; set; }
   
        [Display(Name = "Business Name")]
        [Required(ErrorMessage = "Please enter the Business Name")]
        public string BizName { get; set; }

        [Display(Name = "Contact Name")]


        [Required(ErrorMessage = "Please a Contact Name")]
        public string ContactName { get; set; }

        //accessflags

        public string AccessDescription { get; set; }


       public OBJECTS.FDLegacyRoles AccessType { get; set; }

        public string Flags { get; set; }
        public bool Active { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        [Display(Name = "Can Create Web Orders?")]
        [Required(ErrorMessage = "Please enter a value..")]
        public bool CanOrder { get; set; }

        [Display(Name = "Can View Inventory Details?")]
        [Required(ErrorMessage = "Please enter a value.")]
        public bool CanViewInventoryDetails{get; set;}


        //5/13/2023 - New Fields for Chain
        [Display(Name = "If Order Guide Exists use it")]
        [Required(ErrorMessage = "Please enter a value.")]
        public bool UseProdCustGuide { get; set; }
        public string ChainCode { get; set; }


        [StringLength(12, MinimumLength = 5)]
        [Display(Name = "Internet/Login ID")]
        [Required(ErrorMessage = "Please a Unique Internet/Login ID")]
        public string Internetid { get; set; }

        public string Password { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a value.")]
        [StringLength(12, MinimumLength = 6)]
        public string DecryptedPassword { get; set; }



        public string SalesTaxType { get; set; }
        public string SalesTaxRegion { get; set; }
        public string XEmail1 { get; set; }
        public string XEmail2 { get; set; }
        public string XEmail3 { get; set; }
        public string XEmail4 { get; set; }
        public string LastBookFile { get; set; }
        public bool IsLastBookFile { get; set; }
        public string RightsDetails { get; set; }




        /// <summary>
        /// 
        /// </summary>
        public PersonModel()
        {
            this.BizName = "";
            this.CustID = "";
            this.ContactName = "";
            this.LastBookFile = "";
            this.IsLastBookFile = false;
            this.Flags = "ACTIVE";

        }
        public PersonModel(string custid)
        {
            var p = new BusinessObjects.UsersBO();
            if (!p.LoadByPrimaryKey(custid))
            {
                throw new ApplicationException("Could not find the customer with ID: " + custid);
            }
            populateFromBo(p);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bllPerson"></param>
        public PersonModel(DataRow dr)
        {
            var o = new BusinessObjects.UsersBO(dr);
            populateFromBo(o);
        }
        public PersonModel(BusinessObjects.UsersBO bllPerson)
        {
            populateFromBo(bllPerson);
        }
        private void populateFromBo(BusinessObjects.UsersBO bllPerson)
        {
            this.BizName = bllPerson.Bizname;
            this.CustID = bllPerson.Custid;
            this.ContactName = bllPerson.Contactname;
            this.LastBookFile= bllPerson.LastBookFile;
            this.IsLastBookFile = u.ObjToString(LastBookFile) != "";
            this.Flags = "ACTIVE";
            this.Active = true;
            if (bllPerson.Flags == 1)
            {
                this.Flags = "ACTIVE NONWEB";
            }
            else if (bllPerson.Flags==2)
            {
                this.Flags = "INACTIVE";
                this.Active = false;
            }

            //accessflags
            var r = (OBJECTS.FDLegacyRoles)   bllPerson.Type.Value;
            this.AccessType = r;
            this.AccessDescription = "Member (" + r.ToString()+")"; 

            this.Address = bllPerson.Address1 + " " + bllPerson.Address2;
            this.City = bllPerson.City;
            this.State = bllPerson.State;
            this.Zip = bllPerson.Zip + " " + bllPerson.Zip4;
            this.Telephone = bllPerson.Telephone;
            this.Fax = bllPerson.Fax;
            this.Cell = bllPerson.Cell;
            this.Email = bllPerson.Email;
            this.CanOrder = bllPerson.CanOrder.HasValue ? u.ObjToBool(bllPerson.CanOrder) : false;
            this.UseProdCustGuide=bllPerson.UseProdCustGuide.HasValue ? u.ObjToBool(bllPerson.UseProdCustGuide) : false;
            this.ChainCode = u.ObjToString(bllPerson.ChainCode);

            this.CanViewInventoryDetails = bllPerson.CanViewInventoryDetails.HasValue ? u.ObjToBool(bllPerson.CanViewInventoryDetails.Value) : false;
            this.RightsDetails = "Can Order:" + (CanOrder ? "Yes" : "No") + "-Inv Details:" + (CanViewInventoryDetails ? "Yes" : "No")+ "-Use Order Guide:" + (UseProdCustGuide? "Yes" : "No");

            this.Internetid = bllPerson.Internetid;
            this.Password = bllPerson.Password;
            this.DecryptedPassword = OBJECTS.SecurityHelper.Decrypt(this.Password);
            var b = u.ObjToBool(bllPerson.SalesTaxType.HasValue?bllPerson.SalesTaxType.Value:0);
            this.SalesTaxRegion = "N/A";
            double salesTaxRate = bllPerson.GetSalesTaxRate();

            this.SalesTaxType = b ? "Pays Sales Tax" : "Does not pay Sales Tax";
            if (b)
            {

                this.SalesTaxRegion = bllPerson.SalesTaxRegion + " " + (100 * salesTaxRate).ToString() + " %";
            }
            this.XEmail1 = u.ObjToString(bllPerson.XEmail1);
            this.XEmail2 = u.ObjToString(bllPerson.XEmail2);
            this.XEmail3 = u.ObjToString(bllPerson.XEmail3);
            this.XEmail4 = u.ObjToString(bllPerson.XEmail4);


        }
    }

    /// <summary>
    /// Product View Model for Kendo - Contains Just a list 
    /// </summary>
    public class PersonViewModel
    {
        public List<PersonModel> Persons { get; set; }
        public int TotalCount { get; set; }
    }


    public class PersonListModel : List<PersonModel>
    {
        /// <summary>
        /// 
        /// </summary>
        public PersonListModel()
        {
        }
        public PersonListModel(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.Add(new MODELS.PersonModel(dr));
            }
        }
        public PersonListModel(List<BusinessObjects.UsersBO> bllPersons)
        {
            foreach (BusinessObjects.UsersBO bllPerson in bllPersons)
            {
                this.Add(new MODELS.PersonModel(bllPerson));
            }
        }
    }
}