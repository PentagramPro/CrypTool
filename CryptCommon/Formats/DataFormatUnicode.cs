using CryptCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptCommon.Formats
{
	public class DataFormatUnicode : IDataFormat
	{
		public byte[] ParseString(string str)
		{
			return Encoding.Unicode.GetBytes(str);
		}

		public string ToString(byte[] data)
		{
			return Encoding.Unicode.GetString(data);
		}


		public override string ToString()
		{
			return "UNICODE";
		}
	}
}
