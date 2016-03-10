using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptCommon.Interfaces
{
    public interface IDataFormat
    {
		byte[] ParseString(string str);
		string ToString(byte[] data);
    }
}
