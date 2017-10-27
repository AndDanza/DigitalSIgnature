using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DigitalSignature.Classes
{
    public class AsymmetricCryptography
    {
        public AsymmetricCryptography(){}

        public void GenerateKeys()
        {
            using (RSACryptoServiceProvider rsaObject = new RSACryptoServiceProvider(1024))
            {
                string publicPrivateKey = rsaObject.ToXmlString(true);
                SaveKeysTxt("rsa_public_and_private_key", publicPrivateKey);

                string publicKey = rsaObject.ToXmlString(false);
                SaveKeysTxt("rsa_public_key", publicKey);
            }
        }

        public string EncryptDocumentRSA(string toEncrypt)
        {
            byte[] bytesEncrypted;
            byte[] bytesToEncrypt = Encoding.ASCII.GetBytes(toEncrypt);

            using (RSACryptoServiceProvider rsaObject = new RSACryptoServiceProvider(1024))
            {
                string xmlPublicKey = File.ReadAllText(@".\helpfile_rsa_public_key.txt");
                rsaObject.FromXmlString(xmlPublicKey);

                bytesEncrypted = rsaObject.Encrypt(bytesToEncrypt, false);
            }

            string encrypted = Convert.ToBase64String(bytesEncrypted);

            return encrypted;
        }

        public string DecryptDocumentRSA(string toDecrypt)
        {
            byte[] bytesDecrypted;
            byte[] bytesToDecrypt = Convert.FromBase64String(toDecrypt);

            using (RSACryptoServiceProvider rsaObject = new RSACryptoServiceProvider(1024))
            {
                string xmlPrivateKey = File.ReadAllText(@".\helpfile_rsa_public_and_private_key.txt");
                rsaObject.FromXmlString(xmlPrivateKey);

                bytesDecrypted = rsaObject.Decrypt(bytesToDecrypt, false);
            }

            string decrypted = Convert.ToBase64String(bytesDecrypted);

            return decrypted;
        }

        /// <summary>
        /// Metoda za pohranu Privatnog i javnog ključa
        /// </summary>
        /// <param name="title">Naslov datoteke</param>
        /// <param name="content">Sadržaj datoteke</param>
        private void SaveKeysTxt(string title, string content)
        {
            using (StreamWriter file = new StreamWriter(@".\helpfile_" + title + ".txt"))
            {
                file.Write(content);
            }
        }
    }
}
