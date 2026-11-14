using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{
    public class ContactMessageModel
    {

        //[StringLength(100)]
        [Display(Name = "Email")] 
        //[Required(ErrorMessage = "Email Required")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
     
        //[StringLength(1000)]
        //[Required(ErrorMessage = "Message Required")]
        [Display(Name = "Message")]
        //[DataType(DataType.MultilineText)]
        public string Message { get; set; }
	 
       
    }
}