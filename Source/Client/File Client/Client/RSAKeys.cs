using System;
using System.IO;
using System.Security.Cryptography;
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
            string pem = File.ReadAllText("publicKey.pem");
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricKeyParameter publicKey = (AsymmetricKeyParameter)pr.ReadObject();
            RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaKeyParameters)publicKey);

            csp.ImportParameters(rsaParams);
            return csp;
        }

        //public static RSACryptoServiceProvider ImportPrivateKey(RSACryptoServiceProvider csp)
        //{
        //    string pem = @"\publicKey.pem";
        //    PemReader pr = new PemReader(new StringReader(pem));
        //    AsymmetricCipherKeyPair KeyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
        //    RSAParameters rsaParams = DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)KeyPair.Private);

        //    csp.ImportParameters(rsaParams);
        //    return csp;
        //}

        public static byte[] EncryptData(RSACryptoServiceProvider csp, byte[] data)
        {
            // Mã hóa dữ liệu bằng khóa công khai RSA
            byte[] encryptedData = csp.Encrypt(data, false);
            return encryptedData;
        }

        public static byte[] DecryptData(RSACryptoServiceProvider csp, byte[] encryptedData)
        {
            // Giải mã dữ liệu bằng khóa bí mật RSA
            byte[] decryptedData = csp.Decrypt(encryptedData, false);
            return decryptedData;
        }        
        
    }
}

