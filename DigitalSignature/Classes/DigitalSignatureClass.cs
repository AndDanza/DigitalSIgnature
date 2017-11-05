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

        private string GetDigest(string originalText)
        {
            SHADigestClass shaObject = new SHADigestClass(originalText);
            string digest = shaObject.GetDigest();

            return digest;
        }

        private void SignWithRSA()
        {
            AsymmetricCryptography rsaObject = new AsymmetricCryptography(true);
            rsaObject.EncryptDocumentRSA("");
        }

        public string SignDocument(string toSign)
        {
            string toSignDigest = GetDigest(toSign);

            SignWithRSA();

            return "";
        }
    }
}
