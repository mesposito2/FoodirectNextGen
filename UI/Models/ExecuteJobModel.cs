using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace UI.MODELS
{
    public class ExecuteJobModel
    {
        public string JobType  { get; set; }
        public string JobXParm { get; set; }
        public string JobXParm2 { get; set; }

    }
}