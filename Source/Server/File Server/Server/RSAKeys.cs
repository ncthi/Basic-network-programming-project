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
        public static RSACryptoServiceProvider ImportPrivateKey(RSACryptoServiceProvider csp)
        {
            string pem = File.ReadAllText(@"\privateKey.pem");
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricCipherKeyPair KeyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)KeyPair.Private);

            csp.ImportParameters(rsaParams);
            return csp;
        }
        //public static RSACryptoServiceProvider ImportPublicKey(RSACryptoServiceProvider csp)
        //{
        //    string pem = File.ReadAllText(@"\publicKey.pem");
        //    PemReader pr = new PemReader(new StringReader(pem));
        //    AsymmetricKeyParameter publicKey = (AsymmetricKeyParameter)pr.ReadObject();
        //    RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaKeyParameters)publicKey);

        //    csp.ImportParameters(rsaParams);
        //    return csp;
        //}
        public static string EncryptData(string data)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            // Mã hóa dữ liệu bằng khóa công khai RSA
            byte[] encryptedDataBytes = csp.Encrypt(dataBytes, false);
            string encryptedData = Convert.ToBase64String(encryptedDataBytes);

            return encryptedData;
        }

        public static string DecryptData(string encryptedData)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            byte[] encryptedDataBytes = Convert.FromBase64String(encryptedData);

            // Giải mã dữ liệu bằng khóa bí mật RSA
            byte[] decryptedDataBytes = csp.Decrypt(encryptedDataBytes, false);
            string decryptedData = Encoding.UTF8.GetString(decryptedDataBytes);

            return decryptedData;
        }

    }
}

