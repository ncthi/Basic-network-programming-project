using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace RSA
{
    public class RSAKeys
    {
        public static RSACryptoServiceProvider ImportPrivateKey(RSACryptoServiceProvider csp)
        {
            //lấy đường dẫn thư mục server
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            //Lấy đường dẫn key
            string keyPath = basePath + "\\key\\privateKey.pem";
            string pem = File.ReadAllText(keyPath);
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricCipherKeyPair KeyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)KeyPair.Private);
            csp.ImportParameters(rsaParams);
            return csp;
        }
        public static string DecryptData(byte[] encryptedDataBytes)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            // Giải mã dữ liệu bằng khóa bí mật RSA
            csp = ImportPrivateKey(csp);
            byte[] decryptedDataBytes = csp.Decrypt(encryptedDataBytes, false);
            string plainText = Encoding.UTF8.GetString(decryptedDataBytes);
            return plainText;
        }

    }
}

