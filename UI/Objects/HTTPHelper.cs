using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Dynamic;
using u = CSA.UTILITY.MyUtility;

namespace UI.OBJECTS
{
    public class HTTPHelper
    {
        public static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// Validate an OAUTH access token
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="status"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool IsValidAccessToken(string accessToken, ref string status, ref string msg)
        {
            bool retVal = true;

            /* Example of an invalid token  */
            /*
            { "error":"invalid_client",
             "error_description":"AADSTS70002: Error validating credentials. AADSTS50011: The reply address 'http://localhost:3001/WebTest/OAUTHCallBackx' does not match the reply address 'http://localhost:3001/WebTest/OAUTHCallBack' provided when requesting Authorization code.\r\nTrace ID: 9802f63b-1ac8-43ff-a8ac-bf1e0af75200\r\nCorrelation ID: 0871b068-11de-4e4f-b7e7-aed5c4b9201b\r\nTimestamp: 2018-12-03 23:07:46Z","error_codes":[70002,50011],"timestamp":"2018-12-03 23:07:46Z","trace_id":"9802f63b-1ac8-43ff-a8ac-bf1e0af75200","correlation_id":"0871b068-11de-4e4f-b7e7-aed5c4b9201b"}
            */
            /* Example of a good token  */

            /*
            { "token_type":"Bearer",
              "scope":"User.Read",
              "expires_in":"3600",
              "ext_expires_in":"3600",
              "expires_on":"1543883934",
              "not_before":"1543880034","resource":"5701d576-6343-473e-9740-6bb697792038","access_token":"eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IndVTG1ZZnNxZFF1V3RWXy1oeFZ0REpKWk00USIsImtpZCI6IndVTG1ZZnNxZFF1V3RWXy1oeFZ0REpKWk00USJ9.eyJhdWQiOiI1NzAxZDU3Ni02MzQzLTQ3M2UtOTc0MC02YmI2OTc3OTIwMzgiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC9iNjJhMTgxMy0yZmRhLTQyNzgtYTFhZi05MWVlNzI2Nzc5YWUvIiwiaWF0IjoxNTQzODgwMDM0LCJuYmYiOjE1NDM4ODAwMzQsImV4cCI6MTU0Mzg4MzkzNCwiYWNyIjoiMSIsImFpbyI6IjQyUmdZUEIvdis0ank2WE01VHN1SmV6ejdFMWRZTDNxZGtPSlphQktiK0ZWNDZEKytCTUEiLCJhbXIiOlsicHdkIl0sImFwcGlkIjoiNTcwMWQ1NzYtNjM0My00NzNlLTk3NDAtNmJiNjk3NzkyMDM4IiwiYXBwaWRhY3IiOiIxIiwiZmFtaWx5X25hbWUiOiJFc3Bvc2l0byIsImdpdmVuX25hbWUiOiJNaWNoYWVsIiwiaXBhZGRyIjoiMTkyLjIzNC4xMzUuMzQiLCJuYW1lIjoiTWljaGFlbCBFc3Bvc2l0byIsIm9pZCI6IjYyODY4ZDI2LTA1ZjAtNDMzNi05YzdhLTZhMWFkNWE2NjNhOSIsInNjcCI6IlVzZXIuUmVhZCIsInN1YiI6Ilc2eFJtc1ZCdHg5c3Y3U2NEZFZNeUVZcnRKdWhGSF9sUFRaSl9Jb3ZOS0UiLCJ0aWQiOiJiNjJhMTgxMy0yZmRhLTQyNzgtYTFhZi05MWVlNzI2Nzc5YWUiLCJ1bmlxdWVfbmFtZSI6Im1pa2VAZXNwb3NpdG9ncm91cC5vbm1pY3Jvc29mdC5jb20iLCJ1cG4iOiJtaWtlQGVzcG9zaXRvZ3JvdXAub25taWNyb3NvZnQuY29tIiwidXRpIjoicEVMLU5peFJLMENWR19ZaDZ0VllBQSIsInZlciI6IjEuMCJ9.JwNxQurb-gvkAhhpnr3XDqVB_CYe4RWchoxddWZYsM8aS442j7yyvAweNhqDT_cyK7A99omGpak7E9IxDtsydRm_kmwXIVoeUV8_6MK-0kYJh4K2-ZD9M7Lwn5OnsjyUP8xPWjIyeFehU6AvlnjxRoE96-JsRmXX-WEOl1Bmkp7TUy-YH7AFT8MnlvmbDJDHmKxM8KyZXADc72_B_A3RQ9EYAiKhKLB3Lu2O0K_5jvLkwUBPHuyhd3eLW3AI-c8zCuWlPjfHisbJi86dyX7bLYIzY-91ee_ASwLv-wNXGxnp8SDyFw2faiYAcJ1Ab7E97ruAbLo8kFbLdpxzpQHihg","refresh_token":"AQABAAAAAAC5una0EUFgTIF8ElaxtWjTJB8LTDpU6CGTxX06nxB_gHAm3lKXwVLJySTzF1DdPYOGj4KK0Hx0qRYPTsvTkIugy88mvyuehWhbQUZ3H3JmOJFRi1dSyLIp7Q3smttIVGIBuGT-yDDdiSv5dfGjhXFrCtsQBx_4CVEti_pP2no4yI4n6wq5ENEkTjf2P6kG0cho6GHBrwHp4nEeKP3vG_yOba-5_tSsraWOY-NZcWU3kxXCogyZD7qO7rIVSjNAJVvidVwR2rz-ualRLEghEQ5_vqlAcQGhg8SjwIB0G_nFS_2XbCShaDMyJAtoFIMTOJf3WSzL5ta61NM5dQVMGShs5_sdftBMQj0oLaaHaKBynhE8-9Zgb2qPhWy2qXU91Om8_1upEX92ag2csDHdc8o102FXz9NmVYRjZXA_vEb24lfLFzR-ukI_40VczVn0CNwh3yRjCS1g4aXQPlhXoy097rUL5-anQ0TxFuA-pfIJCJ6ZhN-okvk1qf2mUAD1tP7YD_qDQyST6w-5k2kxdVD2FOc-gkwNDpEp6s0Tt4rr9F8626MEcr2AtjNEdZ0fcT_8AasoGOwG-xnNbtQfTHd25lWlnBGYODXhhmse4noR0wgZE6AbNWXupPoCUEfjDUNdFFsbyeRWfHAHRe-8XuYzxZJQvRXpPQoJOWhVyJO-4vvF56CGd6tYZbB0WnnQWEdJUhM1DPomw9SF2Mlei_atKsJ4Z4ZCtKXpkVH9kxd2CMKTns-DzvebHwo3XOLNUQMDTg3CcxzOJH-BDL-gErw3pLrUUhbbWpIeVWN4LddPOAQEgU_ZFbwPynYGBLlhY6MgAA","id_token":"eyJ0eXAiOiJKV1QiLCJhbGciOiJub25lIn0.eyJhdWQiOiI1NzAxZDU3Ni02MzQzLTQ3M2UtOTc0MC02YmI2OTc3OTIwMzgiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC9iNjJhMTgxMy0yZmRhLTQyNzgtYTFhZi05MWVlNzI2Nzc5YWUvIiwiaWF0IjoxNTQzODgwMDM0LCJuYmYiOjE1NDM4ODAwMzQsImV4cCI6MTU0Mzg4MzkzNCwiYW1yIjpbInB3ZCJdLCJmYW1pbHlfbmFtZSI6IkVzcG9zaXRvIiwiZ2l2ZW5fbmFtZSI6Ik1pY2hhZWwiLCJpcGFkZHIiOiIxOTIuMjM0LjEzNS4zNCIsIm5hbWUiOiJNaWNoYWVsIEVzcG9zaXRvIiwib2lkIjoiNjI4NjhkMjYtMDVmMC00MzM2LTljN2EtNmExYWQ1YTY2M2E5Iiwic3ViIjoiVzZ4Um1zVkJ0eDlzdjdTY0RkVk15RVlydEp1aEZIX2xQVFpKX0lvdk5LRSIsInRpZCI6ImI2MmExODEzLTJmZGEtNDI3OC1hMWFmLTkxZWU3MjY3NzlhZSIsInVuaXF1ZV9uYW1lIjoibWlrZUBlc3Bvc2l0b2dyb3VwLm9ubWljcm9zb2Z0LmNvbSIsInVwbiI6Im1pa2VAZXNwb3NpdG9ncm91cC5vbm1pY3Jvc29mdC5jb20iLCJ2ZXIiOiIxLjAifQ."}
            */


            JavaScriptSerializer jss = new JavaScriptSerializer();
            var d = jss.Deserialize<Dictionary<string, dynamic>>(accessToken);

            if (d.ContainsKey("error"))
            {
                retVal = false;
                status = "ERROR: " + d["error"];
                msg = d["error_description"];
            }

            return retVal;
        }

       

        public static string JSONToHTML(string json)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string html = "";
            var d = jss.Deserialize<Dictionary<string, object>>(json);
            if (d == null)
            {
                html = "Null JSON Object";
            }
            else
            {
                html = "<UL>";
                resolveEntry(d, ref html);
                html += "</UL>";
            }
            return html;
        }
        /// <summary>
        /// Recursively Parse an JSON Object to HTML
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="html"></param>
        static void resolveEntry(Dictionary<string, object> dic, ref string html)
        {
            foreach (KeyValuePair<string, object> entry in dic)
            {
                if (entry.Value is Dictionary<string, object>)
                {
                    html += "<LI><b>" + entry.Key + "</b></LI>\n";
                    html += "<UL>\n";
                    resolveEntry((Dictionary<string, object>)entry.Value, ref html);
                    html += "</UL>\n";

                }
                else if (entry.Value is ICollection)
                {
                    html += "<LI><b>" + entry.Key + "</b></LI>\n";
                    html += "<UL>\n";
                    foreach (var item in (ICollection)entry.Value)
                    {
                        if (item is Dictionary<string, object>)
                        {
                            resolveEntry((Dictionary<string, object>)entry.Value, ref html);
                        }
                        else
                        {
                            html += "<LI><B>" + item + "</b>";
                            if (entry.Key.Contains("_token"))
                            {
                                html += "<br/><a href='https://jwt.ms/#access_token=" + item + "' target='_blank'>View in JWT.MS</a>";
                            }
                            html += "</LI>";
                        }
                    }
                    html += "</UL>\n";

                }
                else
                {
                    html += "<LI><B>" + entry.Key + "</b>";
                    html += "&nbsp;:&nbsp;";
                    html += entry.Value ;
                    if (entry.Key.Contains("_token"))
                    {
                        html += "<br/><a href='https://jwt.ms/#access_token=" + entry.Value + "' target='_blank'>View in JWT.MS</a>";
                    }
                    html += "</LI>";
                }
            }
        }
    }
    

}
  
