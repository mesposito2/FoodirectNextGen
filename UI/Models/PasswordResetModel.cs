using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{
    public class PasswordResetModel
    {
        [Required(ErrorMessage = "Please enter an Email or Internet ID")]
        [Display(Name = "Email or Internet ID")]
        public string UserName { get; set; }
 

    }
}