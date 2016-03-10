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

        static byte[] TurnOut(byte[] src)
        {
            int n = src.Length;
            byte[] res = new byte[n + 1];
            for (int i = 0; i < n; i++)
            {
                res[n - i - 1] = src[i];
            }
            res[n] = 0;
            return res;
        }

        byte[] EncryptRSA(byte[] data, byte[] mod, byte[] exp)
        {
            BigInteger bigMod = new BigInteger(TurnOut(mod));
            BigInteger bigExp = new BigInteger(TurnOut(exp));
            BigInteger bigData = new BigInteger(TurnOut(data));
            return TurnOut(BigInteger.ModPow(bigData, bigExp, bigMod).ToByteArray());
        }

        public byte[] Encrypt(byte[] input, RsaSettings settings)
        {
            return EncryptRSA(input, settings.Modulus, settings.Exponent);
        }
    }
}
