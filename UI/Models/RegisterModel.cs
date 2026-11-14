using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using u = CSA.UTILITY.MyUtility;
using e = CSA.UTILITY.MyEncrypt;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{

    public class RegisterQueryAndViewModel
    {
        public RegisterXParmsModel XparmsModel { get; set; }
        public RegisterViewModel ViewModel { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public RegisterQueryAndViewModel(RegisterXParmsModel x, RegisterViewModel v)
        {
            Page = 1;
            PageSize = 20;
            XparmsModel = x;
            ViewModel = v;
        }

    }


    public class RegisterXParmsModel
    {
        public string QueryType { get; set; }
        public string Filter { get; set; }
        public string Title { get; set; }
        public string SortOrder { get; set; }
        public string SortField { get; set; }


        public RegisterXParmsModel()
        {

            QueryType = "'ALL'";
            Filter = "''";
            Title = "Registrations";
        }


    }


    public class RegisterModel
    {

        //100
        [Required(ErrorMessage = "Please enter your business name.")]
        [Display(Name = "Business Name")]
        [StringLength(100)]
        public string BusinessName { get; set; }

        [StringLength(100)]
        [Display(Name = "Business Type")]
        [Required(ErrorMessage = "Please select your business type.")]
        public string BusinessType { get; set; }

        [StringLength(100)]
        [Display(Name = "Business Size")]
        [Required(ErrorMessage = "Please select your business size.")]
        public string BusinessSize { get; set; }



        [StringLength(100)]
        [Display(Name = "Best Time to Contact?")]
        public string BestTimeToContact { get; set; }


        [StringLength(100)]
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; }

        [StringLength(100)]
        [Display(Name = "Address (cont)")]
        public string Address2 { get; set; }

        [StringLength(50)]
        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter a city.")]
        public string City { get; set; }

        [StringLength(2)]
        [Display(Name = "State")]
        [Required(ErrorMessage = "Please select a state.")]
        public string State { get; set; }


        [StringLength(10)]
        [Display(Name = "Zip")]
        [Required(ErrorMessage = "Please enter a zip.")]
        public string Zip { get; set; }

        [StringLength(100)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Pleae enter a contact first name.")]
        public string FName { get; set; }


        [StringLength(100)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a contact last name.")]
        public string LName { get; set; }

        [StringLength(100)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter your contact email address")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Must be a valid Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //25
        [StringLength(25)]
        [Required(ErrorMessage = "Please enter your contact phone")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [DataType(DataType.Password)]
        [StringLength(25)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a passowrd")]
        public string Password { get; set; }

        [Display(Name = "ID")]
        public int RegisterID { get; set; }

        [Display(Name = "Register Date")]
        public string CreateDate{ get; set; }


        /// <summary>
        /// 
        /// </summary>
        public RegisterModel()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bllPerson"></param>
        public RegisterModel(DataRow dr)
        {
            var o = new BusinessObjects.V5RegisterBO(dr);
            fromBO(o);
        }
        public RegisterModel(BusinessObjects.V5RegisterBO o)
        {
            fromBO(o);

        }
        void fromBO(BusinessObjects.V5RegisterBO o)
        {

            this.CreateDate = o.CreateDate;
            this.BusinessName = o.BusinessName;
            this.RegisterID = o.RegisterID.Value; ;
            this.BusinessType = o.BusinessType;

            this.BusinessSize = o.BusinessSize;

            this.BestTimeToContact = o.BestTimeToContact;

            this.Address = o.Address;

            this.Address2 = o.Address2;

            this.City = o.City;

            this.State = o.State;

            this.Zip = o.Zip;
            this.FName = o.FName;


            this.LName = o.LName;

            this.Email = o.Email;

            this.Phone = o.Phone;

            //since we changed decrypt to AES - the old ones can't be de-crypted
            //does not matter - as we don't use this form anymore anyway - 
            //only use the formsite ome
            //this.Password = UI.OBJECTS.SecurityHelper.Decrypt(u.ObjToString(o.Password));
            this.Password = "(unavailable)";
            
        }
    }
    /// <summary>
    /// Product View Model for Kendo - Contains Just a list 
    /// </summary>
    public class RegisterViewModel
    {
        public List<RegisterModel> Registrations { get; set; }
        public int TotalCount { get; set; }
    }



    /// <summary>
    /// Product List Model
    /// </summary>
    public class RegisterListModel : List<RegisterModel>
    {
        public RegisterListModel()
        {
        }
        public RegisterListModel(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.Add(new MODELS.RegisterModel(dr));
            }
        }
        public RegisterListModel(List<BusinessObjects.V5RegisterBO> list)
        {
            foreach (BusinessObjects.V5RegisterBO l in list)
            {
                this.Add(new MODELS.RegisterModel(l));
            }
        }
    }
}
    
    

