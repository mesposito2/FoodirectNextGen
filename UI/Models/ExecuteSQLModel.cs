using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Data;


namespace UI.MODELS
{
    public class ExecuteSQLModel
    {
        [Required(ErrorMessage = "Please enter a SQL Statement to Execute")]
        public string SQL { get; set; }
        public string SelectDataSource { get; set; }
        public string Message { get; set; }
        public DataSet SQLDataSet { get; set; }

        public ExecuteSQLModel()
        {
        }

        public ExecuteSQLModel (string sql)
        {
            SQL = sql;
            Message = "";
            SQLDataSet = null;
           
        }

    }

}