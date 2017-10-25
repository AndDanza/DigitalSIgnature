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
        /// <summary>
        /// Učitani sadržaj datoteke pretvoren u byte[]
        /// </summary>
        private byte[] documentInBytes;

        /// <summary>
        /// Konstruktor klase koji pretvara string u byte[]
        /// </summary>
        /// <param name="docText">Sadržaj datoteke</param>
        public SHADigestClass(string docText)
        {
            documentInBytes = Encoding.UTF8.GetBytes(docText);
        }

        /// <summary>
        /// Metoda koja ne temelju ulaznog sadržaja tipa byte[] kreira hash te ga vraća u string obliku
        /// </summary>
        /// <returns>SHA1 sažetak pretvoren u string</returns>
        public string GetDigest()
        {
            byte[] digest;
            string stringDigest = "";

            using (SHA1CryptoServiceProvider sha1Digester = new SHA1CryptoServiceProvider())
            {
                digest = sha1Digester.ComputeHash(documentInBytes);
                stringDigest = ConvertToString(digest);
            }

            return stringDigest;
        }

        /// <summary>
        /// Metoda koja dobiveno polje tipa byte[] pretvara u string
        /// </summary>
        /// <param name="digest"></param>
        /// <returns></returns>
        private string ConvertToString(byte[] digest)
        {
            string outputString = "";

            outputString = BitConverter.ToString(digest);
            outputString = outputString.Replace("-", "");

            return outputString;
        }

        /// <summary>
        /// Pohranjuje string u TXT datoteku
        /// </summary>
        /// <param name="calculatedDigest">String za pohranu</param>
        /// <returns>Vraća true ako se funkcij izvršila uredu</returns>
        public bool SaveDigestInTxt(string calculatedDigest)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\sha1_digest.txt"))
            {
                file.WriteLine(calculatedDigest);
            }

            return true;
        }
    }
}
