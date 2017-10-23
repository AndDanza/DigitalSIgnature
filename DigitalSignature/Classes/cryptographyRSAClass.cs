using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature.Classes
{
    public class cryptographyRSAClass
    {
        RSACryptoServiceProvider rsaKeys;

        public cryptographyRSAClass()
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
