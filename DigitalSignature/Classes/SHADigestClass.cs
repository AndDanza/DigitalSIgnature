using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Classes
{
    class SHADigestClass
    {
        private byte[] documentInBytes;

        public SHADigestClass(string docText)
        {
            documentInBytes = Encoding.UTF8.GetBytes(docText);
        }

        public string getDigest()
        {
            byte[] digest;
            string stringDigest = "";

            using (SHA1CryptoServiceProvider sha1Digester = new SHA1CryptoServiceProvider())
            {
                digest = sha1Digester.ComputeHash(documentInBytes);
                stringDigest = BitConverter.ToString(digest);
                stringDigest = stringDigest.Replace("-","");
            }

            return stringDigest;
        }

        public bool saveDigestInTxt(string calculatedDigest)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\sha1_digest.txt"))
            {
                file.WriteLine(calculatedDigest);
            }

            return true;
        }
    }
}
