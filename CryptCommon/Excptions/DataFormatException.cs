using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptCommon.Excptions
{
	public class DataFormatException : Exception
	{
		public DataFormatException(string msg) : base(msg) { }
	}
}
