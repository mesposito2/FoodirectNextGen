using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{
    public class MyGridColumn
    {
        public string FieldName { get; set; }
        public string FieldProperty { get; set; }
        public bool DoSort { get; set; }
        public int ColSize { get; set; }
        public List<string> Roles { get; set; }
        public bool ShowAdmin { get; set; }
        public bool ShowMember { get; set; }
        public bool HideField { get; set; }
        public string CssClass { get; set; }

        /*
        public MyGridColumn()
        {
            FieldName = "";
            FieldProperty = "";
            DoSort = true;
            ColSize = 0;
            Roles = null;
        }
        */
    }

    public class GridFilter
    {
        public string Operator { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
    }

    public class GridFilters
    {
        public List<GridFilter> Filters { get; set; }
        public string Logic { get; set; }
    }

    public class GridSort
    {
        public string Field { get; set; }
        public string Dir { get; set; }
    }
    /// <summary>
    /// aut complete structures..
    /// </summary>
    public class AutoCompleteFilters
    {
        public string logic { get; set; }
        public List<AutoCompleteFilter> filters { get; set; }

    }
    public class AutoCompleteFilter
    {
        //public string Operator { get; set; }
        public string field { get; set; }
        public string value { get; set; }
        public Boolean ignoreCase { get; set; }
    }

}