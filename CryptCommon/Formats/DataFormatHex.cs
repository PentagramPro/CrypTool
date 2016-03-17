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
	    private int length = 0;

	    public DataFormatHex()
	    {
	    }

	    public DataFormatHex(int length)
	    {
	        this.length = length;
	    }

	    public byte[] ParseString(string str) 
		{
            if(length>0 && str.Length!=length*2)
                throw new DataFormatException("Length must be equal to "+length);

			try {
				return Utils.StringToArray(str);
			}
			catch(Exception e)
			{
				throw new DataFormatException(e.Message);
			}
		}

		public string ToString(byte[] data)
		{
			return Utils.ArrayToString(data);
		}

		public override string ToString()
		{
			return "HEX";
		}
	}
}
