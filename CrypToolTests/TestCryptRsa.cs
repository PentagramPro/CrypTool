using System;
using CryptCommon;
using CryptRSA;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrypToolTests
{
    [TestClass]
    public class TestCryptRsa
    {
        [TestMethod]
        public void RsaTurnOut()
        {
            byte[] res = RsaLogic.TurnOut(new byte[] {0x1, 0x2, 0x3},false);
            CollectionAssert.AreEqual(new byte[] {0x3,0x2,0x1},res);

            res = RsaLogic.TurnOut(new byte[] { 0x1 },false);
            CollectionAssert.AreEqual(new byte[] { 0x1 }, res);

            res = RsaLogic.TurnOut(new byte[] { 0x1, 0x2 },false);
            CollectionAssert.AreEqual(new byte[] { 0x2, 0x1 }, res);

            res = RsaLogic.TurnOut(new byte[] { 0x1, 0x2, 0x3,0x4,0x5,0x6 },true);
            CollectionAssert.AreEqual(new byte[] { 0x6,0x5,0x4,0x3, 0x2, 0x1, 0x0 }, res);
        }

        [TestMethod]
        public void EncryptRsaSimple()
        {
            RsaLogic logic = new RsaLogic();
            RsaSettings settings = new RsaSettings();
            settings.Exponent = new byte[] {0x05};
            settings.Modulus = new byte[] { 0x15 };

            byte[] res = logic.Encrypt(new byte[] {0x09}, settings);
            CollectionAssert.AreEqual(new byte[] {0x12}, res );


            settings.Exponent = new byte[] { 0xdf };
            settings.Modulus = new byte[] { 0x05, 0x31 };

           res = logic.Encrypt(new byte[] { 0x01, 0x0e }, settings);
            CollectionAssert.AreEqual(new byte[] { 0x04, 0x6e }, res);

        }

        [TestMethod]
        public void EncryptRsa()
        {
            RsaLogic logic = new RsaLogic();
            RsaSettings settings = new RsaSettings();

            settings.Exponent = StaticUtils.StringToByteArrayFastest("010001");
            settings.Modulus =
                StaticUtils.StringToByteArrayFastest(
                    "a379fcfde7063a64753694df5c4eefbc7168dfa307cf4ee99cc0467af739bf536f5385c77e9ab67f5cb35d4d745f6bdf61c9a773e36d937095ab3d838a30fa0bad82b9c3a25ab3aabe8a18b9d7d914df6ad4f1a262ca1af63f197900d731200e2c6b148a7ca9c46c7705f3550f63420d9e0c0c207591e9e73f24f948306d5fd5");
            byte[] res = logic.Encrypt(StaticUtils.StringToByteArrayFastest("83964f"),
                settings);

            CollectionAssert.AreEqual(StaticUtils.StringToByteArrayFastest(
                "3ba2c9a361aaa6285a0717423f10e18cfc4e81db51fc2b3bb02df5b80867fc4b3e689b9eaac9a0d2a92411d06929e0fbd39e37126a1bd71934c746c179323793176281fe185905b90b03e6af0676bb51847f6b0367e88d96f8eedb9ccbb4206ee1bfad039c8c975a28927ecec9c2dcba840a55c460846b8c1503db4b0453b829"
                ), res);
        }
    }
}
