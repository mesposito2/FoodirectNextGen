using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using u = CSA.UTILITY.MyUtility;
using e = CSA.UTILITY.MyEncrypt;
using BusinessObjects;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{


    public class SalesmanModel
    {


        public int SalesmanID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Initials { get; set; }
        public Boolean Active { get; set; }
        /// 
        /// </summary>
        public SalesmanModel()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bllPerson"></param>
        public SalesmanModel(DataRow dr)
        {
            var o = new BusinessObjects.V5SalesManBO(dr);
            fromBO(o);
        }
        public SalesmanModel(BusinessObjects.V5SalesManBO o)
        {
            fromBO(o);

        }
        void fromBO(BusinessObjects.V5SalesManBO o)
        {
            this.SalesmanID = o.SalesManID.Value;
            this.Email = o.Email;
            this.Name = o.Name;
            this.Initials = o.Initial;
            this.Active = u.ObjToBool(o.Active.Value);
           

        }
    }
    

    /// <summary>
    /// Product List Model
    /// </summary>
    public class SalesmanListModel : List<SalesmanModel>
    {
        public SalesmanListModel()
        {
        }
        public SalesmanListModel(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.Add(new MODELS.SalesmanModel(dr));
            }
        }
        public SalesmanListModel(List<BusinessObjects.V5SalesManBO> list)
        {
            foreach (BusinessObjects.V5SalesManBO l in list)
            {
                this.Add(new MODELS.SalesmanModel(l));
            }
        }
        public SalesmanListModel(BusinessObjects.V5SalesManCollection list)
        {
            foreach (BusinessObjects.V5SalesManBO l in list)
            {
                this.Add(new MODELS.SalesmanModel(l));
            }
        }

    }
}
    
    

