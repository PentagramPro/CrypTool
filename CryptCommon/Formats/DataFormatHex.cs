using CryptCommon.Excptions;
using CryptCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptCommon.Formats
{
	public class DataFormatHex : IDataFormat
	{
		public byte[] ParseString(string str) 
		{
			try {
				return StaticUtils.StringToByteArrayFastest(str);
			}
			catch(Exception e)
			{
				throw new DataFormatException(e.Message);
			}
		}

		public string ToString(byte[] data)
		{
			return StaticUtils.ByteArrayToString(data);
		}

		public override string ToString()
		{
			return "HEX";
		}
	}
}
