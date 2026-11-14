using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.OBJECTS
{
    public class MyGridColumn
    {
       public string FieldName { get; set; }
       public string FieldProperty { get; set; }
       public bool DoSort { get; set; }
       public bool PictureString { get; set; }
       public int ColSize { get; set; } 
    }

    public class GridHelper
    {
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}