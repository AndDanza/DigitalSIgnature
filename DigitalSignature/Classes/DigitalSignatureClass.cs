using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Classes
{
    class DigitalSignatureClass
    {
        public DigitalSignatureClass() { }

        private byte[] GetDigest(string originalText)
        {
            SHADigestClass shaObject = new SHADigestClass(originalText);
            shaObject.GetDigest();
            byte[] digest = shaObject.GetByteDigest();

            return digest;
        }

        private string SignWithRSA(byte[] digest)
        {
            AsymmetricCryptography rsaObject = new AsymmetricCryptography(true);
            rsaObject.GenerateKeys();
            string signature = rsaObject.SignDocument(digest);

            return signature;
        }

        public string SignDocument(string toSign)
        {
            byte[] toSignDigest = GetDigest(toSign);

            string signedDoc = SignWithRSA(toSignDigest);

            return signedDoc;
        }
    }
}
