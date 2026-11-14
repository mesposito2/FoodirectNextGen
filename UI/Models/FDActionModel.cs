using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using u = CSA.UTILITY.MyUtility;


namespace UI.MODELS
{

    #region FDACTION 

    public class FDActionModel
    {

        public string Token { get; set; }
        public string Description { get; set; }
        public string LastRunStart { get; set; }
        public string LastRun { get; set; }
        public string LastRunDuration { get; set; }

        public string LastLogFile { get; set; }
        public string LastResult { get; set; }
        public string LastMsg { get; set; }


        public FDActionModel()
        {
        }

        public FDActionModel(BusinessObjects.FdactionBO item)
        {
            Token = item.Token;
            Description = item.Description;
            LastRun = "";
            if (item.Lastrun.HasValue)
            {
                LastRun = item.Lastrun.Value.ToShortDateString() + " " + item.Lastrun.Value.ToShortTimeString();
            }
            LastLogFile = item.Lastlogfile;
            LastMsg = item.Lastmsg;

            LastResult = "";
            if (item.Lastresult.HasValue)
            {
                if (item.Lastresult.Value == 0) LastResult = "OK";
                if (item.Lastresult.Value == 1) LastResult = "ERROR";
                if (item.Lastresult.Value == 2) LastResult = "WARNING";
                if (item.Lastresult.Value == 3) LastResult = "INPROGRESS";
                if (item.Lastresult.Value == 4) LastResult = "PREPROCESS";

            }

            //4/22/2024 - Put in the start date and duration
            LastRunStart = item.LastRunStart.HasValue ?
                item.LastRunStart.Value.ToShortDateString() + " " + item.LastRunStart.Value.ToShortTimeString() :
                "";

            LastRunDuration = "";
            if (item.LastRunStart.HasValue && item.Lastrun.HasValue)
            {
                var ts = item.Lastrun.Value - item.LastRunStart.Value;
                //LastRunDuration = // ts.ToString("c");

                 LastRunDuration=ts.ToString(@"hh\:mm\:ss");
            }


        }
    }//end class 
     /// <summary>
     /// FDAction View Model 
     /// </summary>
    public class FDActionViewModel
    {
        public List<FDActionModel> Items
        {
            get;
            set;
        }

        public FDActionViewModel(BusinessObjects.FdactionCollection list)
        {

            Items = new List<FDActionModel>();

            foreach (var i in list)
            {
                Items.Add(new MODELS.FDActionModel(i));
            }


        }
    }//end class 

    #endregion

    #region FDACTIONHISTORY

    public class FDACTIONHistoryModel
    {

        public string Token { get; set; }
        public string Description { get; set; }
        public string LastRunStart { get; set; }
        public string LastRun { get; set; }
        public string LastRunDuration { get; set; }

        public string LastLogFile { get; set; }
        public string LastResult { get; set; }
        public string LastMsg { get; set; }


        public FDACTIONHistoryModel()
        {
        }

        public FDACTIONHistoryModel(BusinessObjects.FDACTIONHistoryBO item)
        {
            Token = item.Token;
            Description = item.Description;
            LastRun = "";
            if (item.Lastrun.HasValue)
            {
                LastRun = item.Lastrun.Value.ToShortDateString() + " " + item.Lastrun.Value.ToShortTimeString();
            }
            LastLogFile = item.Lastlogfile;
            LastMsg = item.Lastmsg;

            LastResult = "";
            if (item.Lastresult.HasValue)
            {
                if (item.Lastresult.Value == 0) LastResult = "OK";
                if (item.Lastresult.Value == 1) LastResult = "ERROR";
                if (item.Lastresult.Value == 2) LastResult = "WARNING";
                if (item.Lastresult.Value == 3) LastResult = "INPROGRESS";

            }


            //4/22/2024 - Pu in the start date.
            LastRunStart = item.LastRunStart.HasValue ?
                item.LastRunStart.Value.ToShortDateString() + " " + item.LastRunStart.Value.ToShortTimeString() :
                "";

            LastRunDuration = "";
            if (item.LastRunStart.HasValue && item.Lastrun.HasValue)
            {
                var ts = item.Lastrun.Value - item.LastRunStart.Value;
                //LastRunDuration = // ts.ToString("c");

                LastRunDuration = ts.ToString(@"hh\:mm\:ss");
            }



        }
    }// end class 

    /// <summary>
    /// FDAction History View <Model
    /// </summary>
    public class FDACTIONHistoryViewModel
    {
        public List<FDACTIONHistoryModel> Items
        {
            get;
            set;
        }

        public FDACTIONHistoryViewModel(BusinessObjects.FDACTIONHistoryCollection list)
        {

            Items = new List<FDACTIONHistoryModel>();

            foreach (var i in list)
            {
                Items.Add(new MODELS.FDACTIONHistoryModel(i));
            }
        }
    } //class
} //name space
#endregion



