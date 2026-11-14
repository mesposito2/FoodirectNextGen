using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using u = CSA.UTILITY.MyUtility;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace FDSHARED
{
    /// <summary>
    /// AES helper used for stored passwords and the auth token.
    /// The key is NOT kept in source control. It is resolved, in order, from:
    ///   1. appSetting "FD_ENCRYPTION_KEY" (Azure App Service setting, or UI\Web.secrets.config locally)
    ///   2. SecurityCore.Fallback.cs - an untracked local file (see SecurityCore.Fallback.cs.example)
    /// If neither is present, encrypt/decrypt throws so a misconfigured deployment fails loudly.
    /// </summary>
    public partial class SecurityCore
    {
        public const string KeySettingName = "FD_ENCRYPTION_KEY";

        static partial void GetFallbackKey(ref string key);

        static string _key;

        /// <summary>True when an encryption key is available (used by the /health endpoint).</summary>
        public static bool IsKeyConfigured
        {
            get { return !string.IsNullOrEmpty(ResolveKey()); }
        }

        static string ResolveKey()
        {
            if (!string.IsNullOrEmpty(_key)) { return _key; }
            string key = ConfigurationManager.AppSettings[KeySettingName];
            if (string.IsNullOrEmpty(key)) { GetFallbackKey(ref key); }
            if (!string.IsNullOrEmpty(key)) { _key = key; }
            return key;
        }

        static string MYKEY
        {
            get
            {
                var key = ResolveKey();
                if (string.IsNullOrEmpty(key))
                {
                    throw new ConfigurationErrorsException("Encryption key not configured. Set the '" + KeySettingName + "' app setting.");
                }
                return key;
            }
        }

        #region Public_Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static public string EncryptText(string input)
        {
            if (input == string.Empty)
                return "";


            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(MYKEY);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public string DecryptText(string input)
        {
            if (input == string.Empty)
                return "";

            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(MYKEY);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
        #endregion
        #region Private_Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytesToBeEncrypted"></param>
        /// <param name="passwordBytes"></param>
        /// <returns></returns>
        static private byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytesToBeDecrypted"></param>
        /// <param name="passwordBytes"></param>
        /// <returns></returns>
        static private byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }
        #endregion
    }
}
