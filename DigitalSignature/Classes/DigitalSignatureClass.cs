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
            string signature = rsaObject.SignDocumentRSA(digest);

            return signature;
        }

        public string SignDocument(string toSign)
        {
            byte[] toSignDigest = GetDigest(toSign);

            string signedDoc = SignWithRSA(toSignDigest);

            return signedDoc;
        }

        /// <summary>
        /// Metoda za validaciju koja upravlja objektom asimetričnog kriptiranja
        /// </summary>
        /// <param name="digest">Sažetak zapisan u bajtovima</param>
        /// <param name="signature">String parametar sa potpisom</param>
        /// <returns></returns>
        private bool DocumentValidation(byte[] digest, string signature)
        {
            AsymmetricCryptography rsaObject = new AsymmetricCryptography(true);
            bool valid = rsaObject.ValidateDocumentRSA(digest, signature);

            return valid;
        }

        /// <summary>
        /// Glavna metoda validacije koja kontrolira cijel psotupak
        /// </summary>
        /// <param name="toValidate">String parametar koji sadrži ulazni tekst</param>
        /// <returns></returns>
        public bool ValidateDocument(string toValidate)
        {
            string[] signedDocument = BreakDocument(toValidate);

            byte[] digest = GetDigest(signedDocument[1]);
            string signature = signedDocument[0];

            bool isValid = DocumentValidation(digest, signature);

            return isValid;
        }

        /// <summary>
        /// Parsira učitani dokument tako da je u prvom redu potpis, a sve dalje predtavlja originalni tekst.
        /// </summary>
        /// <param name="toValidate">String parametar koji sadrži ulazni tekst</param>
        /// <returns></returns>
        private string[] BreakDocument(string toValidate)
        {
            string[] returnDocParts = new string[2];

            returnDocParts[0] = toValidate.Remove(toValidate.IndexOf("\r\n"));
            returnDocParts[1] = toValidate.Remove(0, toValidate.IndexOf("\r\n")+2);

            return returnDocParts;
        }
    }
}
