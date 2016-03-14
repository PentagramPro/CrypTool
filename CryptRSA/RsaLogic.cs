using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CryptRSA
{
    public class RsaLogic
    {

        public static byte[] TurnOut(byte[] src, bool addZero)
        {
            int n = src.Length;
            byte[] res = new byte[n + (addZero?1:0)];
            for (int i = 0; i < n; i++)
            {
                res[n - i-1] = src[i];
            }
            if(addZero)
                res[n] = 0;
            return res;
        }

        byte[] EncryptRSA(byte[] data, byte[] mod, byte[] exp)
        {
            BigInteger bigMod = new BigInteger(TurnOut(mod,true));
            BigInteger bigExp = new BigInteger(TurnOut(exp,true));
            BigInteger bigData = new BigInteger(TurnOut(data,true));
            return TurnOut(BigInteger.ModPow(bigData, bigExp, bigMod).ToByteArray(),false);
        }

        public byte[] Encrypt(byte[] input, RsaSettings settings)
        {
            return EncryptRSA(input, settings.Modulus, settings.Exponent);
        }
    }
}
