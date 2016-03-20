using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;
using CryptCommon;

namespace CryptDES
{
    public class DesLogic
    {
        byte[] Encrypt3DES(byte[] data, byte[] key, CipherMode mode, bool encrypt)
        {
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = key;
            tdes.Mode = mode;
            tdes.Padding = PaddingMode.None;
            tdes.IV = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            

            ICryptoTransform cTransform = encrypt ? tdes.CreateEncryptor() : tdes.CreateDecryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(data, 0, data.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            return resultArray;
        }

        public byte[] Encrypt(byte[] data, DesSettings settings)
        {
            byte[] res = Encrypt3DES(data, settings.Key, settings.Mode, settings.Encrypt);

            return res;
        }
    }
}
