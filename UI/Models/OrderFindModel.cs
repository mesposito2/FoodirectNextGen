using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{

    public class OrderFindModel
    {
        public OrderFindModel()
        {
            Items = new List<MODELS.OrderItemModel>();
        }

        [Required(ErrorMessage = "Please enter Order Information")]
        [Display(Name = "Enter Foodirect or Web Order ID")]
        public string OrderInfo { get; set; }

        public List<MODELS.OrderItemModel> Items{get;set;}
       
    }
}