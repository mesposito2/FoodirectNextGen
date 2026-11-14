using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

using u = CSA.UTILITY.MyUtility;
using System.Net;
using ExpertPdf.HtmlToPdf;
namespace UI.OBJECTS
{
    public class MyHelper
    {

        public static string StrExtract(string str, string delim, int position)
        {
            string retVal = "";
            string[] a = str.Split(delim[0]);
            if (!( a.Length-1< position))
            {
                retVal = (a[position]).Trim();
            }
            
            return retVal;
        }
        public static string GetPropValueString(object src, string propName)
        {
            return u.ObjToString(src.GetType().GetProperty(propName).GetValue(src, null));
        }


        public static DateTime  GetNextWeekDay()
        {
            var retDate = DateTime.Now.AddDays(1);
            do 
            {
                if (retDate.DayOfWeek==DayOfWeek.Saturday || retDate.DayOfWeek==DayOfWeek.Sunday)
                {
                    retDate = retDate.AddDays(1);
                }
                else
                {
                    break;
                }
            } while (true);

            return retDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceURL"></param>
        /// <param name="targetHTMLFile"></param>
        /// <param name="htmlString"></param>
        public static void URLToHTML(string sourceURL, string targetHTMLFile, ref string htmlString)
        {
            WebClient wc = new WebClient();
            byte[] b = wc.DownloadData(sourceURL);

            //save to a file just to have
            if (targetHTMLFile != "")
            {
                u.ByteArrayToFile(b, targetHTMLFile);
            }
            //also return the buffer
            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
            htmlString = enc.GetString(b);
            b = null;
            wc = null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetTitleFromHTML(string file)
        {
            Match m = Regex.Match(file, @"<title>\s*(.+?)\s*</title>");
            if (m.Success)
            {
                return m.Groups[1].Value;
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string CreateFileName(string title)
        {
            title = title.ToUpper();
            title = title.Replace(" ", "_");
            char[] x = System.IO.Path.GetInvalidPathChars();
            char[] y = System.IO.Path.GetInvalidFileNameChars();
            foreach (char c in x)
            {
                title = title.Replace(c.ToString(), "");
            }
            foreach (char c in y)
            {
                title = title.Replace(c.ToString(), "");
            }
            return title;
        }
        /// <summary>
        /// This is explicitly for HTML file name
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static string CreateHTMLFileName(string title)
        {
            title = title.ToUpper();

            char[] h = { '#', '%', '$', '{', '}', '\\','<','>','*','?','/',' ','$','!','\'','"', ':', '@', '+', '~', '`', '|', '=' };
            char[] x = System.IO.Path.GetInvalidPathChars();
            char[] y = System.IO.Path.GetInvalidFileNameChars();

            foreach (char c in h)
            {
                title = title.Replace(c.ToString(), "");
            }

            foreach (char c in x)
            {
                title = title.Replace(c.ToString(), "");
            }
            foreach (char c in y)
            {
                title = title.Replace(c.ToString(), "");
            }
            return title;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="datein"></param>
        /// <returns></returns>
        public static string MakeSimpleDateTimeString(DateTime? datein)
        {
            if (datein.HasValue && datein.Value != DateTime.MinValue)
            {
                return MakeSimpleDateTimeString(datein.Value);
            }
            return "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datein"></param>
        /// <returns></returns>
        public static string MakeSimpleDateTimeString(DateTime datein)
        {
            string ret = "";
            ret += datein.ToShortDateString();
            if (datein.TimeOfDay != (new TimeSpan(0)))
            {
                ret += " "+datein.ToShortTimeString();
            }
            return ret;
        }
        /// <summary>
        /// Parse up the date - comes in YYMMDD format 
        /// with a trailing 0 as the 7th byte. 
        /// This same methos is used on the Oder Import - but did a cut and paste for inventory here... 
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public static DateTime MakeDateFromFD(string sd)
        {
            DateTime retVal = new DateTime();
            if (sd != null && sd.Length >= 6)
            {
                var century = DateTime.Now.Year.ToString().Substring(0, 2);

                int y = u.ObjToInt(century + sd.Substring(0, 2));
                int m = u.ObjToInt(sd.Substring(2, 2));
                int d = u.ObjToInt(sd.Substring(4, 2));
                retVal = new DateTime(y, m, d);

            }
            return retVal;
        }

    }
}