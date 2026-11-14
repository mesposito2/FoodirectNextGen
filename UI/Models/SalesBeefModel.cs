using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u=CSA.UTILITY.MyUtility;


namespace UI.MODELS
{
    public class SalesBeefModel
    {
        public string Mode { get; set; }
        public WeeklySpecialsListModel WeeklySpecialsListModel {get;set;}
        public BeefSpecialsViewModel BeefSpecialsViewModel {get;set;}
        public PersonModel PersonModel { get; set; }
       

    }
}
