using System;

using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace CryptCommon
{
	public class StaticUtils
	{
        

		public static byte[] StringToByteArrayFastest(string hex)
		{
		    hex = hex.Replace(" ", "");

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

    }
}
