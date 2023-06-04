using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;


namespace RSA
{
    public class RSAKeys
    {     

        public static RSACryptoServiceProvider ImportPublicKey(RSACryptoServiceProvider csp)
        {
            //lấy đường thư mục clent
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            //Lấy đường dẫn key
            string keyPath = basePath + "\\key\\publicKey.pem";
            string pem = File.ReadAllText(keyPath);
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricKeyParameter publicKey = (AsymmetricKeyParameter)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaKeyParameters)publicKey);

            csp.ImportParameters(rsaParams);
            return csp;
        }
        public static byte[] EncryptData(string data)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            byte[] dataBytes = new byte[2048*32];
            dataBytes = Encoding.UTF8.GetBytes(data);
            csp=ImportPublicKey(csp);
            // Mã hóa dữ liệu bằng khóa công khai RSA
            byte[] encryptedDataBytes = csp.Encrypt(dataBytes, false);
            return encryptedDataBytes;
        }
    }
}

