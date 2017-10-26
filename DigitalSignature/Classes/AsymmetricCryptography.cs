using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature.Classes
{
    public class AsymmetricCryptography
    {
        RSACryptoServiceProvider rsaKeys;

        public AsymmetricCryptography()
        {
            rsaKeys= new RSACryptoServiceProvider();
        }

        public string getKeys()
        {
            string publicPrivateXml = rsaKeys.ToXmlString(true);
            return publicPrivateXml;

        }
    }
}
