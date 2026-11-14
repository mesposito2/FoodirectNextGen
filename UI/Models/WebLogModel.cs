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


    public class WebLogQueryAndViewModel
    {
        public WebLogXParmsModel XparmsModel { get; set; }
        public WebLogViewModel ViewModel { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public WebLogQueryAndViewModel(WebLogXParmsModel x, WebLogViewModel v)
        {
            Page = 1;
            PageSize = 20;
            XparmsModel = x;
            ViewModel = v;
        }

    }



    public class WebLogXParmsModel
    {
        public string QueryType { get; set; }
        public string Filter { get; set; }
        public string Title { get; set; }
        public string SortField { get; set; }
        public string SortOrder { get; set; }



        public WebLogXParmsModel()
        {

            QueryType = "'ALL'";
            Filter = "''";
            Title = "Registrations";
        }


    }


    public class WebLogModel
    {


        public int WeblogID { get; set; }
        public string CreateDateTime { get; set; }
        public string IP { get; set; }
        public string Type { get; set; }
        public string Action { get; set; }
        public string User { get; set; }
        public string Page { get; set; }
        public string Message { get; set; }
        public string ShortMsg { get; set; }


        public bool Reported { get; set; }
        public bool IsAjax { get; set; }
        public string HttpReferer { get; set; }
        public string HttpUserAgent { get; set; }
        public string Https { get; set; }
        public int ResponseCode { get; set; }
        public bool IsNotFound { get; set; }
        
        /// </summary>
        public WebLogModel()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bllPerson"></param>
        public WebLogModel(DataRow dr)
        {
            var o = new BusinessObjects.V5WebLogBO(dr);
            fromBO(o);
        }
        public WebLogModel(BusinessObjects.V5WebLogBO o)
        {
            fromBO(o);

        }
        void fromBO(BusinessObjects.V5WebLogBO o)
        {
            this.WeblogID = o.WeblogID.Value;
            this.CreateDateTime = o.CreateDateTime.Value.ToShortDateString() + " " + o.CreateDateTime.Value.ToShortTimeString(); 
            this.IP = o.Ip;

            this.Type = o.Type;

            this.Action = o.Action;

            this.User = o.User;

            this.Page = o.Page;

            this.Message = o.Message;
            this.ShortMsg = u.Untrim(o.Message,200).Trim() + "...";

            this.Reported = u.ObjToBool(o.Reported);
            this.IsAjax = u.ObjToBool(o.IsAjax);
            this.HttpReferer=  u.ObjToString(o.HttpReferer);
            this.HttpUserAgent = u.ObjToString(o.HttpUserAgent);
            this.Https = u.ObjToString(o.Https);
            this.ResponseCode = u.ObjToInt(o.ResponseCode);
            this.IsNotFound = u.ObjToBool(o.IsNotFound);






        }
}
    /// <summary>
    /// Product View Model for Kendo - Contains Just a list 
    /// </summary>
    public class WebLogViewModel
    {
        public List<WebLogModel> Logs { get; set; }
        public int TotalCount { get; set; }
    }



    /// <summary>
    /// Product List Model
    /// </summary>
    public class WebLogListModel : List<WebLogModel>
    {
        public WebLogListModel()
        {
        }
        public WebLogListModel(DataSet ds)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                this.Add(new MODELS.WebLogModel(dr));
            }
        }
        public WebLogListModel(List<BusinessObjects.V5WebLogBO> list)
        {
            foreach (BusinessObjects.V5WebLogBO l in list)
            {
                this.Add(new MODELS.WebLogModel(l));
            }
        }
    }
}
    
    

