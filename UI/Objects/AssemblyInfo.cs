using System;
using System.Configuration;
using System.Reflection;
using u = CSA.UTILITY.MyUtility;

	/// <summary>
	/// Summary description for MyConfig.
	/// </summary>

namespace UI.OBJECTS
{
    public static class ApplicationInfo
    {
        private static System.Reflection.Assembly executingAssembly;
        private static DateTime? compileDate;
        private static System.Version executingAssemblyVersion;
        private static string  executingAssemblyProduct="";

        /// <summary>
        /// Gets the executing assembly.
        /// </summary>
        /// <value>The executing assembly.</value>
        public static System.Reflection.Assembly ExecutingAssembly
        {
            get { return executingAssembly ?? (executingAssembly = System.Reflection.Assembly.GetExecutingAssembly()); }
        }

        /// <summary>
        /// Gets the executing assembly version.
        /// </summary>
        /// <value>The executing assembly version.</value>
        public static string  ExecutingAssemblyProduct
        {
            get
            {
                if (string.IsNullOrEmpty(executingAssemblyProduct))
                {

                    object[] attrs = ExecutingAssembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                    if (attrs.Length == 1)
                    {
                        executingAssemblyProduct= u.ObjToString(   ((AssemblyTitleAttribute)attrs[0]).Title);
                    }
                }
                return executingAssemblyProduct;
            }
        }

       /// <summary>
        /// Gets the executing assembly version.
        /// </summary>
        /// <value>The executing assembly version.</value>
        public static System.Version ExecutingAssemblyVersion
        {
            get { return executingAssemblyVersion ?? (executingAssemblyVersion = ExecutingAssembly.GetName().Version); }
        }
        
        /// <summary>
        /// Gets the compile date of the currently executing assembly.
        /// </summary>
        /// <value>The compile date.</value>
        public static System.DateTime CompileDate
        {
            get
            {
                if (!compileDate.HasValue)
                    compileDate = retrieveLinkerTimestamp(ExecutingAssembly.Location);
                return compileDate ?? new System.DateTime();
            }
        }
        /// <summary>
        /// Retrieves the linker timestamp.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        /// <remarks>http://www.codinghorror.com/blog/2005/04/determining-build-date-the-hard-way.html</remarks>
        private static System.DateTime retrieveLinkerTimestamp(string filePath)
        {
            const int peHeaderOffset = 60;
            const int linkerTimestampOffset = 8;
            var b = new byte[2048];
            System.IO.FileStream s = null;
            try
            {
                s = new System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                s.Read(b, 0, 2048);
            }
            finally
            {
                if (s != null)
                    s.Close();
            }
            var dt = new System.DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(System.BitConverter.ToInt32(b, System.BitConverter.ToInt32(b, peHeaderOffset) + linkerTimestampOffset));
            return dt.AddHours(System.TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours);
        }
    }

}