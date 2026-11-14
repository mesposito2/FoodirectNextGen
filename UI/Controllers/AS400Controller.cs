using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UI.OBJECTS;
using BusinessObjects;

namespace UI.Controllers
{

    public class AS400Controller : ApiController
    {

        

        /// <summary>
        /// Usage: http://localhost:6887/xapi/AS400/geteowstatus
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult GetEOWStatus()
        {
            var msg = "";
            var status = "";
            var retval = false;

            


            try
            {

                UI.OBJECTS.SecurityHelper.ThrowAPIBadSourceIP();

                retval = OBJECTS.AS400Product.GetEOWStatus(ref status, ref msg);
                if (!retval)
                {
                    msg = "XAPI/AS400EOW - GET -  Could not get the EOW Status: " + msg;
                    throw new System.Exception( msg);

                }
            }
            catch (System.Exception ex)
            {
                LogHelper.WebLogAdd(WebMsgType.ERR, ex.Message, WebLogAction.SYSTEM_ERROR);

                return base.InternalServerError(ex);
            }

            return Ok(status);

        }
        /// <summary>
        /// http://localhost:6887/xapi/AS400/seteowstatus?status=Y
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult SetEOWStatus(string status)
        {
            var msg = "";
            var retval = false;

            try
            {

                UI.OBJECTS.SecurityHelper.ThrowAPIBadSourceIP();

                retval = OBJECTS.AS400Product.SetEOWStatus(status, ref msg);
                if (!retval)
                {
                    msg = "XAPI/AS400EOW - SET -  Could not set the EOW Status: " + msg;
                    throw new System.Exception(msg);
                   

                }
            }
            catch (System.Exception ex)
            {
                LogHelper.WebLogAdd(WebMsgType.ERR, ex.Message, WebLogAction.SYSTEM_ERROR);
                return base.InternalServerError(ex);
            }

            return Ok("AS400 EOW Status was set to: " + status + " OK");

        }
    }
}

