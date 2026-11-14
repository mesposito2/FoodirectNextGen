using FDSHARED;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoodirectV5.Tests
{
    [TestClass]
    public class SecurityCoreTests
    {
        [TestMethod]
        public void Key_IsConfigured_FromAppSettings()
        {
            Assert.IsTrue(SecurityCore.IsKeyConfigured);
        }

        [DataTestMethod]
        [DataRow("FredMastertest")]
        [DataRow("Nomad!28")]
        [DataRow("ünïcødé & symbols <>\"'")]
        [DataRow("a")]
        public void EncryptThenDecrypt_RoundTrips(string plain)
        {
            var cipher = SecurityCore.EncryptText(plain);

            Assert.AreNotEqual(plain, cipher, "ciphertext must differ from plaintext");
            Assert.AreEqual(plain, SecurityCore.DecryptText(cipher));
        }

        [TestMethod]
        public void Encrypt_IsDeterministic_ForSameInput()
        {
            // Login compares by decrypting, but existing stored values rely on a stable key/salt.
            Assert.AreEqual(SecurityCore.EncryptText("same"), SecurityCore.EncryptText("same"));
        }

        [TestMethod]
        public void EmptyString_StaysEmpty()
        {
            Assert.AreEqual("", SecurityCore.EncryptText(""));
            Assert.AreEqual("", SecurityCore.DecryptText(""));
        }
    }
}
