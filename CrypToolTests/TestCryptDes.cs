using System;
using System.Security.Cryptography;
using CryptCommon;
using CryptDES;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrypToolTests
{
    [TestClass]
    public class TestCryptDes
    {
        [TestMethod]
        public void EncryptECB()
        {
            DesSettings settings = new DesSettings();
            settings.Encrypt = true;
            settings.Mode = CipherMode.ECB;

            Test(settings, "07A72507A1793E7AEF1F75762CD5700E", "C47A5BE97A1CD30140F7D63E8AFDD5B5",
               "5368C73BB8E6E206B5C6CD09240433DF");
        }

        [TestMethod]
        public void DecryptECB()
        {
            DesSettings settings = new DesSettings();
            settings.Encrypt = false;
            settings.Mode = CipherMode.ECB;

            Test(settings, "07A72507A1793E7AEF1F75762CD5700E",
               "5368C73BB8E6E206B5C6CD09240433DF", "C47A5BE97A1CD30140F7D63E8AFDD5B5");
        }

        

        void Test(DesSettings settings, string key, string data, string expectedRes)
        {
            DesLogic logic = new DesLogic();

            settings.Key = Utils.StringToArray(key);
            byte[] res = logic.Encrypt(Utils.StringToArray(data), settings);
            string strRes = Utils.ArrayToString(res).ToUpper();

            Assert.AreEqual(expectedRes,strRes);
        }
    }
}
