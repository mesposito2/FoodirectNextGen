using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using UI.EXPERTPDF;
using u = CSA.UTILITY.MyUtility;
using System.Net;
namespace FDSHARED
{
    public class HashHelper
    {
        public static string Set(Dictionary<string, string> hash)
        {

            string guid = Guid.NewGuid().ToString();
            foreach (string key in hash.Keys)
            {
                var o = new BusinessObjects.V5HashBO();
                o.HashGUID = guid;
                o.HashKey = key;
                o.HashValue = hash[key];
                o.Save();      
            }

            return guid;
        }
        public static Dictionary<string, string> Get(string GUID)
        {
            var col = new BusinessObjects.V5HashCollection();
            var hash = new Dictionary<string, string>();
            var q = new BusinessObjects.V5HashQuery();
            q.Where(q.HashGUID.Equal(GUID));
            if (col.Load(q))
            {
               foreach (BusinessObjects.V5HashBO o in col)
               {
                   hash.Add(o.HashKey, o.HashValue);
               }
            }
            return hash;
        }
  
    }
}