using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptCommon.Interfaces
{
    public interface IPadding
    {
        byte[] GeneratePadding(byte[] src, int lengthMultiplier);
    }
}
