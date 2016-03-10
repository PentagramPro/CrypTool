using CryptCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptRSA
{
    public class RsaSettings : ISettings
    {
        public byte[] Modulus, Exponent;
    }
}
