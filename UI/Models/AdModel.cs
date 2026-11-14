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


    

    public class AdModel
    {


        public int AdID { get; set; }
        public string AdName { get; set; }
        public string AdImage { get; set; }
        public string AltText { get; set; }
        public bool Active { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdate { get; set; }
        /// 
        /// </summary>
        public AdModel()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bllPerson"></param>
        public AdModel(DataRow dr)
        {
            var o = new BusinessObjects.AdBO(dr);
            fromBO(o);
        }
        public AdModel(BusinessObjects.AdBO o)
        {
            fromBO(o);

        }
        void fromBO(BusinessObjects.AdBO o)
        {
            this.AdID = o.AdID.Value ;
            this.AdImage = o.AdImage;
            this.AltText = o.AltText;
            this.AdName = o.AdName;
            this.Active = u.ObjToBool(o.Active);
            this.LastUpdate = o.LastUpdate.Value.ToShortDateString()+" "+ o.LastUpdate.Value.ToShortTimeString();
            this.LastUpdatedBy = o.LastUpdatedBy;
            
        }
    }
    
    /// <summary>
    /// Product List Model
    /// </summary>
    public class AdListModel : List<AdModel>
    {
        public AdListModel()
        {
        }
        public AdListModel(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.Add(new MODELS.AdModel(dr));
            }
        }
        public AdListModel(List<BusinessObjects.AdBO> list)
        {
            foreach (BusinessObjects.AdBO l in list)
            {
                this.Add(new MODELS.AdModel(l));
            }
        }
    }
}
    
    

