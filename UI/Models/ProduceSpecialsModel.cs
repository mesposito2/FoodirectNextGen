using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u=CSA.UTILITY.MyUtility;


namespace UI.MODELS
{
    public class ProduceSpecialsModel
    {

        public string Line { get; set; }
        public int CaseCount1 { get; set; }
        
        public bool OnCurrentOrder1 { get; set; }
        public bool IsMaster1 { get; set; }
        public string Productcode1 { get; set; }
        public string Description1 { get; set; }
        public string Price1 { get; set; }
        public bool IsMaster2 { get; set; }

        public int CaseCount2 { get; set; }
        
        public bool OnCurrentOrder2 { get; set; }
        public string Productcode2 { get; set; }
        public string Description2 { get; set; }
        public string Price2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ProduceSpecialsModel()
        {

        }
        public ProduceSpecialsModel(BusinessObjects.VwProduceBO s1, BusinessObjects.VwProduceBO s2)
        {
            Line = s1.Line.HasValue ? s1.Line.Value.ToString() : "";
            
            IsMaster1 = u.ObjToBool(s1.IsMaster);
            OnCurrentOrder1 = u.ObjToBool(s1.OnCurrentOrder);
            CaseCount1 = u.ObjToInt(s1.Casecount);

            Productcode1 = u.ObjToString(s1.Productcode);
            //Description1 = u.ObjToString(s1.Sdescription);
            if (Productcode1=="SYS_LBL")
            {
                Description1 = u.ObjToString(s1.Sdescription);

                Description1 = Description1.Replace("*","");
            }
            else
            {
                Description1 =  s1.Sdescription;

            }
            Price1 = s1.Slbcs.HasValue & s1.Slbcs != 0 ? u.FormatCurrency(s1.Slbcs.Value) : "";

            if (s2 != null)
            {
                OnCurrentOrder2 = u.ObjToBool(s2.OnCurrentOrder);
                IsMaster2 = u.ObjToBool(s2.IsMaster);
                Productcode2 = u.ObjToString(s2.Productcode);
               
                CaseCount2 = u.ObjToInt(s2.Casecount);

                Price2 = s2.Slbcs.HasValue && s2.Slbcs != 0 ? u.FormatCurrency(s2.Slbcs.Value) : "";
                if (Productcode2 == "SYS_LBL")
                {
                    Description2 = u.ObjToString(s2.Sdescription);
                    Description2 = Description2.Replace("*", "");
                }
                else
                {
                    Description2 =  s2.Sdescription;

                }

            }
            else
            {
                Productcode2 = "";
                Description2 = "";
                Price2 = "";
            }
        }

    }
    /// <summary>
    /// Old Product List Model
    /// </summary>
    public class ProduceSpecialsListModel : List<ProduceSpecialsModel>
    {
        public ProduceSpecialsListModel(List<BusinessObjects.VwProduceBO> items)
        {

            var i = 0;
            while (i < items.Count)
            {

                BusinessObjects.VwProduceBO x = items[i];
                BusinessObjects.VwProduceBO y = null;
                i++;
                if (i < items.Count)
                {
                    y = items[i];

                }
                this.Add(new ProduceSpecialsModel(x, y));
                i++;
            }
        }
    }
}
