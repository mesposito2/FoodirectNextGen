using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoodirectV5.Tests
{
    /// <summary>
    /// Catches config mistakes that compile fine but crash the deployed site at startup.
    /// </summary>
    [TestClass]
    public class ConfigConsistencyTests
    {
        static string RepoRoot
        {
            get
            {
                var dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                while (dir != null && !File.Exists(Path.Combine(dir.FullName, "V5.Web.slnf"))) { dir = dir.Parent; }
                Assert.IsNotNull(dir, "Could not locate the repository root (V5.Web.slnf).");
                return dir.FullName;
            }
        }

        [DataTestMethod]
        [DataRow(@"UI\Web.config")]
        [DataRow(@"UI\Web.Release.config")]
        public void WebPagesVersionSetting_MatchesReferencedPackage(string configPath)
        {
            // "Conflicting versions of ASP.NET Web Pages detected" = HTTP 500 on every request.
            var pkg = XDocument.Load(Path.Combine(RepoRoot, @"UI\packages.config"))
                .Descendants("package").Single(p => (string)p.Attribute("id") == "Microsoft.AspNet.WebPages");
            var pkgMajor = new Version((string)pkg.Attribute("version")).Major;

            var setting = XDocument.Load(Path.Combine(RepoRoot, configPath))
                .Descendants("add").Single(a => (string)a.Attribute("key") == "webpages:Version");
            var configured = new Version((string)setting.Attribute("value"));

            Assert.AreEqual(pkgMajor, configured.Major,
                configPath + " webpages:Version=" + configured + " but Microsoft.AspNet.WebPages package is " + pkg.Attribute("version").Value);
        }

        [TestMethod]
        public void ReleaseTransform_RemovesDebugCompilation()
        {
            var doc = XDocument.Load(Path.Combine(RepoRoot, @"UI\Web.Release.config"));
            XNamespace xdt = "http://schemas.microsoft.com/XML-Document-Transform";
            var compilation = doc.Descendants("compilation").SingleOrDefault();
            Assert.IsNotNull(compilation, "Web.Release.config should transform <compilation>.");
            StringAssert.Contains((string)compilation.Attribute(xdt + "Transform") ?? "", "RemoveAttributes(debug)");
        }
    }
}
