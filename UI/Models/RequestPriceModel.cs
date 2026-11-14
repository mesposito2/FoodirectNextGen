using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{
    public class RequestPriceModel
    {

     
        public string SalesManName { get; set; }
        public string SalesManEmailAddress { get; set; }
        public string ProductCode { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Business Size")]
        public string Message { get; set; }
	 
    
    }
}