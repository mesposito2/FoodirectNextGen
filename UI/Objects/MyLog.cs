using System;
using System.IO;
using u = CSA.UTILITY.MyUtility;


namespace UI.OBJECTS
{
    public class MyLog
    {
        #region Member Variables

        //private static bool isInitialized=false;

        #endregion

        #region Constructors


        private MyLog()
        {

        }
        #endregion


        #region Public Methods

        public static void Msg(string Info)
        {
            MsgX(".", Info, null);
        }
        public static void OkMsg(string Info)
        {
            MsgX(".", Info, null);
        }
        public static void WarningMsg(string Info)
        {
            MsgX("*", Info, null);
        }

        public static void ErrMsg(string Info)
        {
            //send email here
            MsgX("!", Info, null);

        }
        public static void ErrMsg(string Info, Exception ex)
        {
            //send email here
            MsgX("!", Info, ex);
        }
        private static void MsgX(string pre, string info, Exception ex)
        {
            try
            {

                string fileName = Config.LogPath + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                //StreamWriter sw = File.AppendAllText(fileName,);

                //sw.WriteLine(pre+" "+info);
                //if (ex!=null)
                //{
                //sw.WriteLine(ex.Message);
                //sw.WriteLine(ex.StackTrace);
                //}
                //sw.Close();
                string buffer = pre + " " + u.Untrim(DateTime.Now.ToShortTimeString(), 15) + info + "\r\n";
                if (ex != null)
                {
                    buffer += ex.Message + "\r\n";
                    buffer += ex.ToString() + "\r\n";

                }
                File.AppendAllText(fileName, buffer);

            }
            catch (System.Exception exx)
            {
                //throw new System.Exception("Error Logging: " + info , exx);
            }
        }



        #endregion

        #region Protected & Private Methods

        //private static void InitTraceLog(string logFileDirectory)
        //{
        //    StringBuilder sb= new StringBuilder();
        //    sb.Append(logFileDirectory);		   
        //    sb.Append("\\MyLog");
        //    sb.Append(DateTime.Now.ToString("yyyyMMdd_hhmmss"));
        //    sb.Append(".txt");


        //    Stream logFile = File.Create(sb.ToString() );
        //    TextWriterTraceListener logList = new TextWriterTraceListener(logFile);
        //    Trace.AutoFlush = true;
        //    Trace.Listeners.Add(logList);

        //    //create console output
        //    TextWriterTraceListener logConsole = new TextWriterTraceListener(Console.Out);
        //    Trace.Listeners.Add(logConsole);

        //}
        #endregion
    }
}