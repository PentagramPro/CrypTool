using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptHashes
{
    interface IHashLogic
    {
        byte[] Calc(byte[] data);
    }

    public class Md5Logic : IHashLogic
    {
        private MD5 md5;

        public Md5Logic()
        {
            md5 = MD5.Create(); 
        }

        public byte[] Calc(byte[] data)
        {
            return md5.ComputeHash(data);
        }
    }

    public class Sha1Logic : IHashLogic
    {
        private SHA1 sha1;

        public Sha1Logic()
        {
            sha1 = SHA1.Create();
        }

        public byte[] Calc(byte[] data)
        {
            return sha1.ComputeHash(data);
        }
    }
}
