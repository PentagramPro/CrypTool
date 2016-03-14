using System;

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
			val -= (val < 58 ? 48 : (val < 97 ? 55 : 87));
			if (val < 0 || val > 15)
				throw new Exception("Wrong character: "+hex);
			return val;
		}

		public static string ByteArrayToString(byte[] ba)
		{
			StringBuilder hex = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
				hex.AppendFormat("{0:x2}", b);
			return hex.ToString();
		}

        /*
		public static byte[] Encrypt3DES(byte[] data, byte[] key, CipherMode mode, bool encrypt)
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
		}*/


	}
}
