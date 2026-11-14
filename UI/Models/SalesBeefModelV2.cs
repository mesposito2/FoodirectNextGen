using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u=CSA.UTILITY.MyUtility;


namespace UI.MODELS
{
    public class SalesBeefModelV2
    {
        public string Mode { get; set; }
        public WeeklySpecialsListModel WeeklySpecialsListModel {get;set;}
        public BeefSpecialsListModelV2 BeefSpecialsListModel {get;set;}
        public ProduceSpecialsListModel ProduceSpecialsListModel { get; set; }
        public PersonModel PersonModel { get; set; }
       

    }
}
