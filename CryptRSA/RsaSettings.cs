using CryptCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptRSA
{
    public class RsaSettings : Settings
    {
        public byte[] Modulus, Exponent;
    }
}
