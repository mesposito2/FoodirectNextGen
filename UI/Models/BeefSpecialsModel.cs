using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u=CSA.UTILITY.MyUtility;


namespace UI.MODELS
{
    public class BeefLabelModel
    {

        public string ListsID { get; set; }
        public int DisplayOrder { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }


        public BeefLabelModel()
        {
        }

        public BeefLabelModel(BusinessObjects.ListsBO item)
        {
            ListsID = item.ListsID.ToString();
            Code = item.Lvalue2;
            Name = item.Lvalue; // +item.Lname;
            DisplayOrder = u.ObjToInt(item.Lname);
        }
    }

    /// <summary>
    ///  Beef Itemm
    /// </summary>
    public class BeefSpecialsModel
    {

        public string BeefID { get; set; }
        public string Description { get; set; }
        public string Productcode1 { get; set; }
        public string Productcode2 { get; set; }
        public string Productcode3 { get; set; }
        public string Productcode4 { get; set; }
        public string Productcode5 { get; set; }
        public string Productcode6 { get; set; }
        public string Productcode7 { get; set; }
        public string Productcode8 { get; set; }
        public string Productcode9 { get; set; }
        public string Productcode10 { get; set; }
        public string Productcode11 { get; set; }

        public string Price1 { get; set; }
        public string Price2 { get; set; }
        public string Price3 { get; set; }
        public string Price4 { get; set; }
        public string Price5 { get; set; }
        public string Price6 { get; set; }
        public string Price7 { get; set; }
        public string Price8 { get; set; }
        public string Price9 { get; set; }
        public string Price10 { get; set; }
        public string Price11 { get; set; }
        
        public bool IsMaster1 { get; set; }
        public bool IsMaster2 { get; set; }
        public bool IsMaster3 { get; set; }
        public bool IsMaster4 { get; set; }
        public bool IsMaster5 { get; set; }
        public bool IsMaster6 { get; set; }
        public bool IsMaster7 { get; set; }
        public bool IsMaster8 { get; set; }
        public bool IsMaster9 { get; set; }
        public bool IsMaster10 { get; set; }
        public bool IsMaster11 { get; set; }

        public int OnCurrentOrder1 { get; set; }
        public int OnCurrentOrder2 { get; set; }
        public int OnCurrentOrder3 { get; set; }
        public int OnCurrentOrder4 { get; set; }
        public int OnCurrentOrder5 { get; set; }
        public int OnCurrentOrder6 { get; set; }
        public int OnCurrentOrder7 { get; set; }
        public int OnCurrentOrder8 { get; set; }
        public int OnCurrentOrder9 { get; set; }
        public int OnCurrentOrder10 { get; set; }
        public int OnCurrentOrder11 { get; set; }
        
        public int Casecount1 {get; set;}
        public int Casecount2 { get; set; }
        public int Casecount3 { get; set; }
        public int Casecount4 { get; set; }
        public int Casecount5 { get; set; }
        public int Casecount6 { get; set; }
        public int Casecount7 { get; set; }
        public int Casecount8 { get; set; }
        public int Casecount9 { get; set; }
        public int Casecount10 { get; set; }
        public int Casecount11 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BeefSpecialsModel()
        {

        }
        public BeefSpecialsModel(BusinessObjects.VwBeefBO beef)
        {
            double? t;

            BeefID = u.ObjToString(beef.BeefID.ToString());
            Description = beef.Description;

            Casecount1 = u.ObjToInt(beef.Casecount1);
            IsMaster1 = u.ObjToBool(beef.IsMaster1);
            OnCurrentOrder1 = u.ObjToInt(beef.OnCurrentOrder1);
            Productcode1 = u.ObjToString(beef.Pcode1);
            t = beef.Price1;
            Price1 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}",t.Value) : "";

            Casecount2 = u.ObjToInt(beef.Casecount2);
            IsMaster2 = u.ObjToBool(beef.IsMaster2);
            OnCurrentOrder2 = u.ObjToInt(beef.OnCurrentOrder2);
            Productcode2 = u.ObjToString(beef.Pcode2);
            t = beef.Price2;
            Price2 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount3 = u.ObjToInt(beef.Casecount3);
            IsMaster3 = u.ObjToBool(beef.IsMaster3);
            OnCurrentOrder3 = u.ObjToInt(beef.OnCurrentOrder3);
            Productcode3 = u.ObjToString(beef.Pcode3);
            t = beef.Price3;
            Price3 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount4 = u.ObjToInt(beef.Casecount4);
            IsMaster4 = u.ObjToBool(beef.IsMaster4);
            OnCurrentOrder4 = u.ObjToInt(beef.OnCurrentOrder4);
            Productcode4 = u.ObjToString(beef.Pcode4);
            t = beef.Price4;
            Price4 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount5 = u.ObjToInt(beef.Casecount5);
            IsMaster5 = u.ObjToBool(beef.IsMaster5);
            OnCurrentOrder5 = u.ObjToInt(beef.OnCurrentOrder5);
            Productcode5 = u.ObjToString(beef.Pcode5);
            t = beef.Price5;
            Price5 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount6 = u.ObjToInt(beef.Casecount6);
            IsMaster6 = u.ObjToBool(beef.IsMaster6);
            OnCurrentOrder6 = u.ObjToInt(beef.OnCurrentOrder6);
            Productcode6 = u.ObjToString(beef.Pcode6);
            t = beef.Price6;
            Price6 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount7 = u.ObjToInt(beef.Casecount7);
            IsMaster7 = u.ObjToBool(beef.IsMaster7);
            OnCurrentOrder7 = u.ObjToInt(beef.OnCurrentOrder7);
            Productcode7 = u.ObjToString(beef.Pcode7);
            t = beef.Price7;
            Price7 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount8 = u.ObjToInt(beef.Casecount8);
            IsMaster8 = u.ObjToBool(beef.IsMaster8);
            OnCurrentOrder8 = u.ObjToInt(beef.OnCurrentOrder8);
            Productcode8 = u.ObjToString(beef.Pcode8);
            t = beef.Price8;
            Price8 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount9 = u.ObjToInt(beef.Casecount9);
            IsMaster9 = u.ObjToBool(beef.IsMaster9);
            OnCurrentOrder9 = u.ObjToInt(beef.OnCurrentOrder9);
            Productcode9 = u.ObjToString(beef.Pcode9);
            t = beef.Price9;
            Price9 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount10 = u.ObjToInt(beef.Casecount10);
            IsMaster10 = u.ObjToBool(beef.IsMaster10);
            OnCurrentOrder10 = u.ObjToInt(beef.OnCurrentOrder10);
            Productcode10 = u.ObjToString(beef.Pcode10);
            t = beef.Price10;
            Price10 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

            Casecount11 = u.ObjToInt(beef.Casecount11);
            IsMaster11 = u.ObjToBool(beef.IsMaster11);
            OnCurrentOrder11 = u.ObjToInt(beef.OnCurrentOrder11);
            Productcode11 = u.ObjToString(beef.Pcode11);
            t = beef.Price11;
            Price11 = t.HasValue && t.Value != 0 ? string.Format("{0:0.00}", t.Value) : "";

        }

    }
    /// <summary>
    /// Old Product List Model
    /// </summary>
    public class BeefSpecialsViewModel
    {

        public List<BeefSpecialsModel> BeefItems
        {
            get;
            set;
        }
        public List<BeefLabelModel> LabelItems
        {
            get;
            set;
        }

        public BeefSpecialsViewModel(BusinessObjects.ListsCollection list, BusinessObjects.VwBeefCollection beef)
        {

            LabelItems = new List<BeefLabelModel>();
            BeefItems = new List<BeefSpecialsModel>();

            foreach (var l in list)
            {
                LabelItems.Add(new MODELS.BeefLabelModel(l));
            }
            LabelItems.Sort((x, y) => x.DisplayOrder.CompareTo(y.DisplayOrder));

                

            foreach (var b in beef)
            {
                BeefItems.Add(new MODELS.BeefSpecialsModel(b));
            }

        }
    }
}
