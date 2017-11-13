using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Classes
{
    class SHADigestClass
    {
        /// <summary>
        /// Učitani sadržaj datoteke pretvoren u niz byteova
        /// </summary>
        private byte[] documentInBytes;
        private byte[] byteHash;

        /// <summary>
        /// Konstruktor klase koji pretvara string u byte[]
        /// </summary>
        /// <param name="docText">Tekstualni sadržaj datoteke</param>
        public SHADigestClass(string docText)
        {
            documentInBytes = Encoding.UTF8.GetBytes(docText);
        }

        /// <summary>
        /// Metoda koja pokreće izračun hash-a te ga vraća u string obliku
        /// </summary>
        /// <returns>SHA1 sažetak pretvoren u string</returns>
        public void GetDigest()
        {
            byte[] digest;

            using (SHA1CryptoServiceProvider sha1Digester = new SHA1CryptoServiceProvider())
            {
                digest = sha1Digester.ComputeHash(documentInBytes);
            }

            byteHash = digest;
        }

        /// <summary>
        /// Metoda koja dobiveno polje tipa byte[] pretvara u string
        /// </summary>
        /// <param name="digest"></param>
        /// <returns></returns>
        public string GetStringDigest()
        {
            string outputString = "";

            outputString = BitConverter.ToString(byteHash);
            outputString = outputString.Replace("-", "");

            return outputString;
        }

        public byte[] GetByteDigest()
        {
            return byteHash;
        }
    }
}
