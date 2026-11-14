using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u=CSA.UTILITY.MyUtility;


namespace UI.MODELS
{
    public class ProduceSpecialsPrintModel
    {
        public ProduceSpecialsListModel ProduceSpecialsListModel {get;set;}
        public PersonModel PersonModel { get; set; }
    }
}
