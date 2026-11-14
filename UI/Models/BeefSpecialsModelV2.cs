using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u=CSA.UTILITY.MyUtility;


namespace UI.MODELS
{
    /// <summary>
    /// temp Item for pass 1
    /// </summary>
    public class tempItem
    {
        public bool IsMaster { get; set; }
        public bool OnCurrentOrder { get; set; }
        public string Productcode { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int CaseCount { get; set; }
        public string Cat { get; set; }
    }
    public class BeefSpecialsModelV2
    {
   
        public string Line { get; set; }
        public bool OnCurrentOrder1 { get; set; }
        public bool IsMaster1 { get; set; }
        public int CaseCount1 { get; set; }
        
        public string Productcode1 { get; set; }
        public string Description1 { get; set; }
        public string Price1 { get; set; }
        
        public bool IsMaster2 { get; set; }
        
        public bool OnCurrentOrder2 { get; set; }
        public string Productcode2 { get; set; }
        public string Description2 { get; set; }
        public string Price2 { get; set; }
        public int CaseCount2 { get; set; }
        


        /// <summary>
        /// 
        /// </summary>
        public BeefSpecialsModelV2()
        {

            Productcode1 = "";
            Description1 = "";
            Price1 = "";
            Productcode2 = "";
            Description2 = "";
            Price2 = "";
        }
        public BeefSpecialsModelV2(int line, tempItem col1, tempItem col2)
        {
            Line = line.ToString();

            Productcode1 = "SYS_LBL";
            Description1 = "";
            Price1 = "";
            Productcode2 = "SYS_LBL";
            Description2 = "";
            Price2 = "";


            if (col1 != null)
            {
                IsMaster1 = col1.IsMaster;
                OnCurrentOrder1 = col1.OnCurrentOrder;
                Productcode1 = col1.Productcode;
                Description1 = col1.Description;
                if (col1.Productcode!="SYS_LBL")
                    Description1 =  col1.Description;
                CaseCount1 = col1.CaseCount;
                Price1 = col1.Price;
            }
            if (col2 != null)
            {
                IsMaster2 = col2.IsMaster;
                OnCurrentOrder2 = col2.OnCurrentOrder;
                Productcode2 = col2.Productcode;
                Description2 = col2.Description;
                if (col2.Productcode != "SYS_LBL")
                    Description2 = col2.Description;
             
                CaseCount2 = col2.CaseCount;
                Price2 = col2.Price;
            }
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    public class BeefSpecialsListModelV2 : List<BeefSpecialsModelV2>
    {
        string makeCatID(string catid, string scatid)
        {
            if (!string.IsNullOrEmpty(catid))
                return catid;
            if (!string.IsNullOrEmpty(scatid) && scatid.Length == 3)
            {
                return scatid.Substring(0, 2);
            }
            return "XX";

        }

        public BeefSpecialsListModelV2(List<BusinessObjects.VwBeefBO> items)
        {
           //beef layout map
            var blmCol1=new Dictionary<string,List<tempItem>>();
            var blmCol2=new Dictionary<string,List<tempItem>>();
            var blmOther=new Dictionary<string,List<tempItem>>();

     


//Col 1
//chucks '05'
//Rounds=38
//Ribs -- 43
//COL2
//Lions '39'
//tenderlions=39N - rolled into lions for now. 
//Thin meats - 49
//Grinds 22
//OFFALS - O7


            blmCol1.Add("05",new List<tempItem>());
            blmCol1.Add("38",new List<tempItem>());
            blmCol1.Add("43",new List<tempItem>());
            blmCol1.Add("07", new List<tempItem>());
           
            blmCol2.Add("39",new List<tempItem>());
            blmCol2.Add("49",new List<tempItem>());
            blmCol2.Add("22",new List<tempItem>());
            blmCol2.Add("03", new List<tempItem>());
            blmCol2.Add("21", new List<tempItem>());
            blmCol2.Add("23", new List<tempItem>());
            blmOther.Add("XX", new List<tempItem>());


            var i = 0;
            //step 1 - enumerate through the list and colate for each category
            
            while (i < items.Count)
            {
                //Item 1
                if (items[i].Price1.HasValue && items[i].Price1.Value != 0)
                {
                    var c = makeCatID(items[i].Catid1, items[i].Scatid1); 
                    
                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster1);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder1);
                    ti.Productcode = u.ObjToString(items[i].Pcode1);
                    ti.Description = u.ObjToString(items[i].Description1);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount1);
                    ti.Price = u.FormatCurrency(items[i].Price1.Value);
                    ti.Cat = items[i].Catid1 + "-" + items[i].Scatid1;
                    thisList.Add(ti);
                }

                //Item 2
                if (items[i].Price2.HasValue && items[i].Price2.Value != 0)
                {
                    var c = makeCatID(items[i].Catid2, items[i].Scatid2);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster2);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder2);
                    ti.Productcode = u.ObjToString(items[i].Pcode2);
                    ti.Description = u.ObjToString(items[i].Description2);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount2);
                    ti.Price = u.FormatCurrency(items[i].Price2.Value);
                    ti.Cat = items[i].Catid2 + "-" + items[i].Scatid2; 
                    thisList.Add(ti);
                }

                //Item 3
                if (items[i].Price3.HasValue && items[i].Price3.Value != 0)
                {
                    var c = makeCatID(items[i].Catid3, items[i].Scatid3);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster3);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder3);
                    ti.Productcode = u.ObjToString(items[i].Pcode3);
                    ti.Description = u.ObjToString(items[i].Description3);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount3);
                    ti.Price = u.FormatCurrency(items[i].Price3.Value);
                    ti.Cat = items[i].Catid3 + "-" + items[i].Scatid3;
                    thisList.Add(ti);
                }

                //Item 4
                if (items[i].Price4.HasValue && items[i].Price4.Value != 0)
                {
                    var c = makeCatID(items[i].Catid4, items[i].Scatid4);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster4);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder4);
                    ti.Productcode = u.ObjToString(items[i].Pcode4);
                    ti.Description = u.ObjToString(items[i].Description4);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount4);
                    ti.Price = u.FormatCurrency(items[i].Price4.Value);
                    ti.Cat = items[i].Catid4 + "-" + items[i].Scatid4; 
                   
                    thisList.Add(ti);
                }

                //Item 5
                if (items[i].Price5.HasValue && items[i].Price5.Value != 0)
                {
                    var c = makeCatID(items[i].Catid5, items[i].Scatid5);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster5);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder5);
                    ti.Productcode = u.ObjToString(items[i].Pcode5);
                    ti.Description = u.ObjToString(items[i].Description5);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount5);
                    ti.Price = u.FormatCurrency(items[i].Price5.Value);
                    ti.Cat = items[i].Catid5 + "-" + items[i].Scatid5; 
                   
                    thisList.Add(ti);
                }

                //Item 6
                if (items[i].Price6.HasValue && items[i].Price6.Value != 0)
                {
                    var c = makeCatID(items[i].Catid6, items[i].Scatid6);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster6);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder6);
                    ti.Productcode = u.ObjToString(items[i].Pcode6);
                    ti.Description = u.ObjToString(items[i].Description6);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount6);
                    ti.Price = u.FormatCurrency(items[i].Price6.Value);
                    ti.Cat = items[i].Catid6 + "-" + items[i].Scatid6; 
                   
                    thisList.Add(ti);
                }
                //Item 7
                if (items[i].Price7.HasValue && items[i].Price7.Value != 0)
                {
                    var c = makeCatID(items[i].Catid7, items[i].Scatid7);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster7);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder7);
                    ti.Productcode = u.ObjToString(items[i].Pcode7);
                    ti.Description = u.ObjToString(items[i].Description7);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount7);
                    ti.Price = u.FormatCurrency(items[i].Price7.Value);
                    ti.Cat = items[i].Catid7 + "-" + items[i].Scatid7;

                    thisList.Add(ti);
                }

                //Item 8
                if (items[i].Price8.HasValue && items[i].Price8.Value != 0)
                {
                    var c = makeCatID(items[i].Catid8, items[i].Scatid8);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster8);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder8);
                    ti.Productcode = u.ObjToString(items[i].Pcode8);
                    ti.Description = u.ObjToString(items[i].Description8);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount8);
                    ti.Price = u.FormatCurrency(items[i].Price8.Value);
                    ti.Cat = items[i].Catid8 + "-" + items[i].Scatid8;

                    thisList.Add(ti);
                }
                //Item 9
                if (items[i].Price9.HasValue && items[i].Price9.Value != 0)
                {
                    var c = makeCatID(items[i].Catid9, items[i].Scatid9);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster9);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder9);
                    ti.Productcode = u.ObjToString(items[i].Pcode9);
                    ti.Description = u.ObjToString(items[i].Description9);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount9);
                    ti.Price = u.FormatCurrency(items[i].Price9.Value);
                    ti.Cat = items[i].Catid9 + "-" + items[i].Scatid9;

                    thisList.Add(ti);
                }

                //Item 10
                if (items[i].Price10.HasValue && items[i].Price10.Value != 0)
                {
                    var c = makeCatID(items[i].Catid10, items[i].Scatid10);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster10);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder10);
                    ti.Productcode = u.ObjToString(items[i].Pcode10);
                    ti.Description = u.ObjToString(items[i].Description10);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount10);
                    ti.Price = u.FormatCurrency(items[i].Price10.Value);
                    ti.Cat = items[i].Catid10 + "-" + items[i].Scatid10;

                    thisList.Add(ti);
                }

                //Item 11
                if (items[i].Price11.HasValue && items[i].Price11.Value != 0)
                {
                    var c = makeCatID(items[i].Catid11, items[i].Scatid11);

                    List<tempItem> thisList;
                    if (blmCol1.ContainsKey(c))
                        thisList = blmCol1[c];
                    else if (blmCol2.ContainsKey(c))
                        thisList = blmCol2[c];
                    else
                        thisList = blmOther["XX"];
                    var ti = new tempItem();
                    ti.IsMaster = u.ObjToBool(items[i].IsMaster11);
                    ti.OnCurrentOrder = u.ObjToBool(items[i].OnCurrentOrder11);
                    ti.Productcode = u.ObjToString(items[i].Pcode11);
                    ti.Description = u.ObjToString(items[i].Description11);
                    ti.CaseCount = u.ObjToInt(items[i].Casecount11);
                    ti.Price = u.FormatCurrency(items[i].Price11.Value);
                    ti.Cat = items[i].Catid11 + "-" + items[i].Scatid11;

                    thisList.Add(ti);
                }



                i++;
            }

            //now that we have everything mapped
            //lets start creating the model
            //int max=Math.Max(col1count,col2count);
            var col1=new List<tempItem>();
            var col2=new List<tempItem>();

            //col 1
            foreach (string key in blmCol1.Keys)
            {
               var ti= new tempItem();
               ti.Productcode="SYS_LBL";
               var o = new BusinessObjects.CatBO();
               if (!o.LoadByCatID(key))
                   ti.Description = "Catagory:" + key;
               else
                   ti.Description = o.Description;


               col1.Add(ti);
               foreach (var tix in blmCol1[key])
               {
                   col1.Add(tix);
               }
            }
  
            //col2
            foreach (string key in blmCol2.Keys)
            {
               var ti= new tempItem();
               ti.Productcode="SYS_LBL";

               var o = new BusinessObjects.CatBO();
               if (!o.LoadByCatID(key))
                   ti.Description = "Catagory:" + key;
               else
                   ti.Description = o.Description;

               col2.Add(ti);
               foreach (var tix in blmCol2[key])
               {
                   col2.Add(tix);
               }
            }
     
            //now figure out where the others should go
            var otherCol=col1;
            if (col1.Count>col2.Count)
            {
                otherCol=col2;
            }
            if (blmOther["XX"].Count > 0)
            {
                var ti = new tempItem();
                ti.Productcode = "SYS_LBL";
                ti.Description = "OTHER";
                otherCol.Add(ti);
                 
                foreach (var tix in blmOther["XX"])
                {
                    otherCol.Add(tix);
                }
            }

            //OK  - so now that we have the two columns colated etc. 
            //create the actual items for the model
            //the code above essentially retro fit the beef data from the 400
            //into the format of the sales sheet. Neither is effiecient. 
            //But front end sales (and new beef sheet) are already coded
            //to work with this model. 
             int max=Math.Max(col1.Count,col2.Count);
            for (i=0;i<max;i++)
            {
              tempItem ti1=null;
              tempItem ti2=null;
              if (i < col1.Count)
                    ti1=col1[i];
              if (i < col2.Count)
                    ti2=col2[i];

                this.Add(new BeefSpecialsModelV2(i + 1, ti1, ti2));
            }
        }
    }
}
