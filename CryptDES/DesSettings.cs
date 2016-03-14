using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;
using CryptCommon.Interfaces;

namespace CryptDES
{
    public class DesSettings : ISettings
    {
        public CipherMode Mode;
        public byte[] Key;
        public bool Encrypt;
    }
}
