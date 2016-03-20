using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptCommon.Interfaces;

namespace CryptCommon.Paddings
{
    public class PaddingEmv : IPadding
    {
        public override string ToString()
        {
            return "EMV padding";
        }

        public byte[] GeneratePadding(byte[] src, int lengthMultiplier)
        {
            int padLen = lengthMultiplier-src.Length%lengthMultiplier;
            
            byte[] res = new byte[padLen];
            Parallel.For(0, padLen, i => res[i] = 0);
            res[0] = 0x80;
            return res;
        }
    }
}
