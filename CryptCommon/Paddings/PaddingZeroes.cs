using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptCommon.Interfaces;

namespace CryptCommon.Paddings
{
    public class PaddingZeroes : IPadding
    {
        public override string ToString()
        {
            return "Pad with zeroes";
        }

        public byte[] GeneratePadding(byte[] src, int lengthMultiplier)
        {
            int padLen = lengthMultiplier-src.Length%lengthMultiplier;

            if (padLen == lengthMultiplier)
                padLen = 0;

            byte[] res = new byte[padLen];

            Parallel.For(0, padLen, i => res[i] = 0);
            return res;
        }
    }
}
