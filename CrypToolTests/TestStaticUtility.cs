using System;
using CryptCommon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrypToolTests
{
    [TestClass]
    public class TestStaticUtility
    {
        [TestMethod]
        public void ByteToString()
        {
            string res;
            res = Utils.ArrayToString(new byte[] {0x54, 0xAF, 0xD5, 0x3E});
            Assert.AreEqual(res,"54afd53e");
        }

        [TestMethod]
        public void StringToByte()
        {
            byte[] res;
            res = Utils.StringToArray("005f2a4600");

            CollectionAssert.AreEqual(new byte[] {0x00,0x5f,0x2a,0x46,0x00},res);

            res = Utils.StringToArray("005F2A4600");
            CollectionAssert.AreEqual(new byte[] { 0x00, 0x5f, 0x2a, 0x46, 0x00 },res);

            res = Utils.StringToArray("00");
            CollectionAssert.AreEqual(new byte[] { 0x00},res);

            res = Utils.StringToArray("");
            Assert.AreEqual(0, res.Length);

            try
            {
                Utils.StringToArray("az");
                Assert.Fail();
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
