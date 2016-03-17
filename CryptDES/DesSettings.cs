using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;
using CryptCommon.Interfaces;


namespace CryptDES
{
    [DataContract]
    public class DesSettings : Settings
    {
        [DataMember] public CipherMode Mode;
        [DataMember] public byte[] Key;
        [DataMember] public bool Encrypt;
    }
}
