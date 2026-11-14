using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using BusinessObjects;

namespace UI.MODELS
{
    public  abstract class  BaseModel
    {

        public string DisplayAction
        {
            get;
            set;
        }
        public string DisplayMsgType
        {
            get;
            set;
        }
        public string DisplayMsg
        {
            get;
            set;
        }
        public BaseModel()
        {
            DisplayAction = "";
            DisplayMsg = "test";
            DisplayMsgType = "";
        }
        public void SetDisplayMsg(WebMsgType type, string msg, WebLogAction action )
        {
            this.DisplayAction=action.ToString();
            this.DisplayMsgType = action.ToString();
            this.DisplayMsg = msg;
            
        }


        
    }
}