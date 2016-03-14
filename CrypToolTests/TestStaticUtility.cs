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
            res = StaticUtils.ByteArrayToString(new byte[] {0x54, 0xAF, 0xD5, 0x3E});
            Assert.AreEqual(res,"54afd53e");
        }

        [TestMethod]
        public void StringToByte()
        {
            byte[] res;
            res = StaticUtils.StringToByteArrayFastest("005f2a4600");

            CollectionAssert.AreEqual(new byte[] {0x00,0x5f,0x2a,0x46,0x00},res);

            res = StaticUtils.StringToByteArrayFastest("005F2A4600");
            CollectionAssert.AreEqual(new byte[] { 0x00, 0x5f, 0x2a, 0x46, 0x00 },res);

            res = StaticUtils.StringToByteArrayFastest("00");
            CollectionAssert.AreEqual(new byte[] { 0x00},res);

            res = StaticUtils.StringToByteArrayFastest("");
            Assert.AreEqual(0, res.Length);

            try
            {
                StaticUtils.StringToByteArrayFastest("az");
                Assert.Fail();
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
