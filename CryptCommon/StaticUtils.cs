using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace CryptCommon
{
  public class StaticUtils
  {
    public static byte[] StringToByteArrayFastest(string hex)
    {
      if (hex.Length % 2 == 1)
        throw new Exception("The binary key cannot have an odd number of digits");

      byte[] arr = new byte[hex.Length >> 1];

      for (int i = 0; i < hex.Length >> 1; ++i)
      {
        arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
      }

      return arr;
    }

    public static int GetHexVal(char hex)
    {
      int val = (int)hex;
      //Or the two combined, but a bit slower:
      return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
    }

    public static string ByteArrayToString(byte[] ba)
    {
      StringBuilder hex = new StringBuilder(ba.Length * 2);
      foreach (byte b in ba)
        hex.AppendFormat("{0:x2}", b);
      return hex.ToString();
    }

    static byte[] TurnOut(byte[] src)
    {
      int n = src.Length;
      byte[] res = new byte[n + 1];
      for (int i = 0; i < n; i++)
      {
        res[n - i-1] = src[i];
      }
      res[n] = 0;
      return res;

    }
    public static byte[] EncryptRSA(byte[] data, byte[] mod, byte[] exp)
    {

      BigInteger bigMod = new BigInteger(TurnOut(mod));
      BigInteger bigExp = new BigInteger(TurnOut(exp));
      BigInteger bigData = new BigInteger(TurnOut(data));
      return TurnOut(BigInteger.ModPow(bigData, bigExp, bigMod).ToByteArray());
    }

    public static byte[] Encrypt3DES(byte[] data, byte[] key, CipherMode mode, bool encrypt)
    {
      TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
      tdes.Key = key;
      tdes.Mode = mode;
      tdes.Padding = PaddingMode.None;
      tdes.IV = new byte[] {0,0,0,0,0,0,0,0};

      ICryptoTransform cTransform = encrypt? tdes.CreateEncryptor() : tdes.CreateDecryptor();
      //transform the specified region of bytes array to resultArray
      byte[] resultArray =
        cTransform.TransformFinalBlock(data, 0,   data.Length);
      //Release resources held by TripleDes Encryptor
      tdes.Clear();
      return resultArray;
    }

    
  }
}
