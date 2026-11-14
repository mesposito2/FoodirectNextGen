using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{
    public class SalesMessageModel
    {
        public int POLID { get; set; }


        [StringLength(1000)]
        [Required(ErrorMessage = "Message Required")]
        [Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }


    }
}