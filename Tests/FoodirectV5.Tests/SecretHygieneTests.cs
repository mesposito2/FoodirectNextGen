using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoodirectV5.Tests
{
    /// <summary>
    /// Guards against secrets creeping back into files that are committed to Git.
    /// Real values belong in UI\Web.secrets.config locally (untracked) and, on the IIS VM, in
    /// C:\Foodirect\shared\config (Web.secrets.config + connectionStrings.config).
    /// </summary>
    [TestClass]
    public class SecretHygieneTests
    {
        static readonly string[] SecretKeys = { "SMTPPWD", "EXPERTPDF", "RECAPTCHA_SECRET", "FD_ENCRYPTION_KEY", "LOGIN_COOKIE_KEY" };

        // Keep in sync with the "local-only config" block in .gitignore. These never reach Git or CI.
        static readonly Regex LocalOnlyFile = new Regex(
            @"^(Web\.secrets\.config|connectionStrings\.config|Web\.MIKE.*\.config|WebProdTEST\.config|SecurityCore\.Fallback\.cs|CookieHelper\.Fallback\.cs)$",
            RegexOptions.IgnoreCase);

        static string RepoRoot
        {
            get
            {
                var dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                while (dir != null && !File.Exists(Path.Combine(dir.FullName, "V5.Web.slnf")))
                {
                    dir = dir.Parent;
                }
                Assert.IsNotNull(dir, "Could not locate the repository root (V5.Web.slnf).");
                return dir.FullName;
            }
        }

        [DataTestMethod]
        [DataRow(@"UI\Web.config")]
        [DataRow(@"UI\Web.Release.config")]
        public void TrackedConfig_HasNoSecretAppSettingValues(string relativePath)
        {
            var doc = XDocument.Load(Path.Combine(RepoRoot, relativePath));
            var offenders = doc.Descendants("add")
                .Where(e => SecretKeys.Contains((string)e.Attribute("key")))
                .Where(e => !string.IsNullOrWhiteSpace((string)e.Attribute("value")))
                .Select(e => (string)e.Attribute("key"))
                .ToList();

            Assert.AreEqual(0, offenders.Count, relativePath + " contains secret values for: " + string.Join(", ", offenders));
        }

        [DataTestMethod]
        [DataRow(@"UI\Web.config")]
        [DataRow(@"UI\Web.Release.config")]
        public void TrackedConfig_ConnectionStringsHaveNoPasswords(string relativePath)
        {
            var doc = XDocument.Load(Path.Combine(RepoRoot, relativePath));
            var offenders = doc.Descendants("connectionStrings").Descendants("add")
                .Where(e => Regex.IsMatch((string)e.Attribute("connectionString") ?? "", @"(?i)(password|pwd)\s*="))
                .Select(e => (string)e.Attribute("name"))
                .ToList();

            Assert.AreEqual(0, offenders.Count, relativePath + " has credentials in connection strings: " + string.Join(", ", offenders));
        }

        [TestMethod]
        public void Source_HasNoHardcodedSecrets()
        {
            var patterns = new[]
            {
                new Regex(@"SG\.[A-Za-z0-9_\-]{16,}\.[A-Za-z0-9_\-]{16,}"),      // SendGrid API key
                new Regex(@"6L[A-Za-z0-9_\-]{38}(?=[""'])"),                      // reCAPTCHA key literal in code
                new Regex(@"(?i)\bPASSWORD\s*=\s*'(?!\$\()[^']{4,}'"),            // SQL: CREATE LOGIN ... PASSWORD = 'literal'
                new Regex(@"(const|static readonly)\s+string\s+\w*KEY\s*=\s*""[^""]{12,}""")  // hardcoded crypto keys (MYKEY, LOGINCOOKIEKEY...)
            };
            var roots = new[] { "UI", "FDShared", "BusinessObjects" }.Select(r => Path.Combine(RepoRoot, r));
            var files = roots.Where(Directory.Exists)
                .SelectMany(r => Directory.EnumerateFiles(r, "*.*", SearchOption.AllDirectories))
                .Where(f => Regex.IsMatch(f, @"\.(cs|config|sql)$", RegexOptions.IgnoreCase))
                .Where(f => !Regex.IsMatch(f, @"\\(bin|obj)\\", RegexOptions.IgnoreCase))
                .Where(f => !LocalOnlyFile.IsMatch(Path.GetFileName(f))) // untracked by design (.gitignore)
                .ToList();

            var hits = files.Where(f => patterns.Any(p => p.IsMatch(File.ReadAllText(f))))
                .Select(f => f.Substring(RepoRoot.Length + 1))
                .ToList();

            Assert.AreEqual(0, hits.Count, "Possible hardcoded secrets in: " + string.Join(", ", hits));
        }
    }
}
