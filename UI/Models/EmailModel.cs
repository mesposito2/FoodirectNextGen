using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{
    public class EmailModel
    {
        [Required(ErrorMessage = "Please enter a destination email address")]
        [Display(Name = "To")]
        [DataType(DataType.EmailAddress)]
        public string To{ get; set; }
 
        [Required(ErrorMessage = "Please enter a subject")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        [Display(Name = "Message")]
        public string  Message { get; set; }

    }
}