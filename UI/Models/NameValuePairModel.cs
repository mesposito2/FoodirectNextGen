using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{


    public class NameValuePairListModel : List<NameValuePairModel>
    {
        public NameValuePairListModel()
        {
        }

        //there is actually a way to do this on the List - Yada Yada Yada 
        //but hardcoded an easy method in the time it would take me to look up how to do it
        public string FindValue(string name)
        {
            string retVal = "";
            foreach (var o in this)
            {
                if (o.Name.ToUpper()==name.ToUpper())
                {
                    retVal = o.Value;
                    break;
                }
            }
            return retVal;
        }
    }
    
    public class NameValuePairModel
    {

        public string Name { get; set; }
        public string Value { get; set; }

        public NameValuePairModel ()
        {

        }
        public NameValuePairModel(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
    

}