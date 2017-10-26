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
        private byte[] symetricKey;
        private byte[] initializationVector;

        public SymmetricCryptography(bool keyExists)
        {
            if (!keyExists)
            {
                GenerateKeyandIV();
                StoreKeyandIV();
            }
        }

        private void GenerateKeyandIV()
        {
            using (AesCryptoServiceProvider aesObject = new AesCryptoServiceProvider())
            {
                aesObject.GenerateKey();
                symetricKey = aesObject.Key;

                aesObject.GenerateIV();
                initializationVector = aesObject.IV;
            }
        }

        public void StoreKeyandIV()
        {
            string key = Convert.ToBase64String(symetricKey);
            string vector = Convert.ToBase64String(initializationVector);

            using (StreamWriter file = new StreamWriter(@".\helpfile_aes_key_vector.txt"))
            {
                file.WriteLine(key);
                file.WriteLine(vector);
            }
        }

        public string EncryptDocumentAES(string toEncrypt)
        {
            byte[] encrypted;

            using (AesManaged aesObject = new AesManaged())
            {
                aesObject.Key = symetricKey;
                aesObject.IV = initializationVector;
                aesObject.Padding = PaddingMode.PKCS7;
                ICryptoTransform encryptor = aesObject.CreateEncryptor();

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(toEncrypt);
                        }
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }

            return Convert.ToBase64String(encrypted);
        }

        private void LoadKeyAndVector()
        {
            string key, vector;

            using (StreamReader reader = new StreamReader("helpfile_aes_key_vector.txt"))
            {
                key = reader.ReadLine();
                vector = reader.ReadLine();
            }

            symetricKey = Convert.FromBase64String(key);
            initializationVector = Convert.FromBase64String(vector);
        }


        public string DecryptDocumentAES(string toDecrypt)
        {
            string decrypted;

            using (AesManaged aesObject = new AesManaged())
            {
                LoadKeyAndVector();

                aesObject.Key = symetricKey;
                aesObject.IV = initializationVector;
                aesObject.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesObject.CreateDecryptor();
                
                byte[] bytesToEncrypt = Convert.FromBase64String(toDecrypt);

                using (MemoryStream msDecrypt = new MemoryStream(bytesToEncrypt))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream and place them in a string.
                            decrypted = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decrypted;
        }
    }
}
