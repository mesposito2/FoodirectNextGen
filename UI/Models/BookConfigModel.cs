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
    public class BookConfigModel
    {

        public MODELS.NameValuePairListModel Ads { get; set; }
        public int BookConfigID { get; set; }
        public bool ShowPrices { get; set; }
        public BookConfigAdListModel AdList { get; set; }

        public BookConfigModel()
        {
            
        }
        public void SetAds(BusinessObjects.AdCollection col)
        {
            var nvp = new NameValuePairListModel();
            foreach (BusinessObjects.AdBO o in col)
            {
                nvp.Add(new NameValuePairModel(o.AdName, o.AdID.ToString()));
            }
            this.Ads = nvp;

            //now make sure that the AdList Model is updated... 
            if (AdList != null)
            {
                foreach (var i in AdList)
                {
                    string adName = nvp.FindValue(i.AdID.ToString());
                    i.AdName = adName;
                }
            }
        }
    }

    public class BookConfigAdModel
    {
        public int BookConfigAdID { get; set; }
        public int BookConfigID { get; set; }
        public int AdID { get; set; }
        public string AdName { get; set; }
        public int PageNum { get; set; }

        public BookConfigAdModel(DataRow dr)
        {
            var o = new BusinessObjects.BookConfigAdBO(dr);
            fromBO(o);
        }
        public BookConfigAdModel(BusinessObjects.BookConfigAdBO o)
        {
            fromBO(o);

        }
        void fromBO(BusinessObjects.BookConfigAdBO o)
        {
            this.BookConfigAdID = o.BookConfigAdID.Value;
            this.BookConfigID = o.BookConfigID.Value;
            this.AdID = o.AdID.Value;
            this.AdName = ""; //Needs to be done with SetAds 
            this.PageNum = o.PageNum.Value;
        }
    }

    public class BookConfigAdListModel : List<BookConfigAdModel>
    {
        public BookConfigAdListModel()
        {
        }
        public BookConfigAdListModel(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.Add(new MODELS.BookConfigAdModel(dr));
            }
        }
        public BookConfigAdListModel(List<BusinessObjects.BookConfigAdBO> list)
        {
            foreach (BusinessObjects.BookConfigAdBO l in list)
            {
                this.Add(new MODELS.BookConfigAdModel(l));
            }
        }
    }
}

    

