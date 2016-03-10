using CryptCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptCommon.Formats
{
	public class DataFormatAscii : IDataFormat
	{
		public byte[] ParseString(string str)
		{
			return Encoding.ASCII.GetBytes(str);
		}

		public string ToString(byte[] data)
		{
			return Encoding.ASCII.GetString(data);
		}

		public override string ToString()
		{
			return "ASCII";
		}
	}
}
