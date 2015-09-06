using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public static class RSACipher
    {
        public static RSA GenerateKeyPair()
        {
            var rsa = new RSACryptoServiceProvider(2048);
            return rsa;
        }

        public static byte[] Encrypt(byte [] plainText, string key)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            return rsa.Encrypt(plainText, true);
        }

        public static byte[] Decrypt(byte [] cipherBytes, string key)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(key);
            return rsa.Decrypt(cipherBytes, true);
        }
    }
    public static class StringCipher
    {
        public static string GenerateKey()
        {
            string password;
            byte[] salt;
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // Buffer storage.
                byte[] data = new byte[32];

                rng.GetBytes(data);
                password = BitConverter.ToInt32(data, 0).ToString();
                salt = new byte[16];
                
            }
            const int Iterations = 300;
            int keyBytes = 32;
            var keyGenerator = new Rfc2898DeriveBytes(password, salt, Iterations);
            return BitConverter.ToInt32(keyGenerator.GetBytes(keyBytes), 0).ToString();
        }
        // This constant string is used as a "salt" value for the PasswordDeriveBytes function calls.
        // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
        // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("pg872tha65k0d2e3");

        // This constant is used to determine the keysize of the encryption algorithm.
        private const int keysize = 256;

        public static string Encrypt(string plainText, string passPhrase)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
            {
                byte[] keyBytes = password.GetBytes(keysize / 8);
                using (RijndaelManaged symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.Mode = CipherMode.CBC;
                    using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                byte[] cipherTextBytes = memoryStream.ToArray();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            using (PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null))
            {
                byte[] keyBytes = password.GetBytes(keysize / 8);
                using (RijndaelManaged symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.Mode = CipherMode.CBC;
                    using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes))
                    {
                        using (MemoryStream memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }
    }
}
