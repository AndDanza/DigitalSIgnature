using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignature.Classes
{
    class SymmetricCryptography
    {
        byte[] simetricKey;
        byte[] initializationVector;

        public SymmetricCryptography()
        {
            GenerateKeyandIV();
            StoreKeyandIV();
        }

        private void GenerateKeyandIV()
        {
            using (AesCryptoServiceProvider aesObject = new AesCryptoServiceProvider())
            {
                aesObject.GenerateKey();
                simetricKey = aesObject.Key;

                aesObject.GenerateIV();
                initializationVector = aesObject.IV;
            }
        }

        public void StoreKeyandIV()
        {
            string key = Convert.ToBase64String(simetricKey);
            string vector = Convert.ToBase64String(initializationVector);

            using (StreamWriter file = new StreamWriter(@".\helpfile_aes_key_vector.txt"))
            {
                file.WriteLine(key + "\r\n" + vector);
            }
        }

        public string EncryptDocumentAES()
        {
            byte[] encrypted;

            using (AesCryptoServiceProvider aesObject = new AesCryptoServiceProvider())
            {
                aesObject.Key = simetricKey;
                aesObject.IV = initializationVector;
                ICryptoTransform encryptor = aesObject.CreateEncryptor(aesObject.Key, aesObject.IV);

                string toEncrypt = UploadedDocumentClass.GetFileContent();
                byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(toEncrypt);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(bytesToEncrypt);
                        }

                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encrypted);
        }

        public void DecryptDocumentAES()
        {
            
        }
    }
}
