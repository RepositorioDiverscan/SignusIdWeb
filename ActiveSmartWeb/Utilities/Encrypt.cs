using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ActiveSmartWeb.Utilities
{
    public class Encrypt
    {
        private static string _secKey = "password drowssap";

        public static string Decrypting(string cipherString, bool useHashing)
        {
            try
            {
                byte[] bytes;
                var inputBuffer = Convert.FromBase64String(cipherString);
                new AppSettingsReader();
                var s = _secKey;
                if (useHashing)
                {
                    var provider = new MD5CryptoServiceProvider();
                    bytes = provider.ComputeHash(Encoding.UTF8.GetBytes(s));
                    provider.Clear();
                }
                else
                {
                    bytes = Encoding.UTF8.GetBytes(s);
                }
                var provider2 = new TripleDESCryptoServiceProvider
                {
                    Key = bytes,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                var buffer3 = provider2.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
                provider2.Clear();
                return Encoding.UTF8.GetString(buffer3);
            }
            catch (Exception exception)
            {
                CLErrores.EscribirError(exception.Message, exception.StackTrace);
                return null;
            }
        }

        public static string Encrypting(string toEncrypt, bool useHashing)
        {
            try
            {
                byte[] buffer;
                var bytes = Encoding.UTF8.GetBytes(toEncrypt);
                var s = _secKey;
                if (useHashing)
                {
                    var provider = new MD5CryptoServiceProvider();
                    buffer = provider.ComputeHash(Encoding.UTF8.GetBytes(s));
                    provider.Clear();
                }
                else
                {
                    buffer = Encoding.UTF8.GetBytes(s);
                }
                var provider2 = new TripleDESCryptoServiceProvider
                {
                    Key = buffer,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                var inArray = provider2.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
                provider2.Clear();
                return Convert.ToBase64String(inArray, 0, inArray.Length);
            }
            catch (Exception exception)
            {
                CLErrores.EscribirError(exception.Message, exception.StackTrace);
                return null;
            }
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }


        public static string EncriptarSHA3_512(string str)
        {
            //Codigo Para Encriptar la contraseña en SHA512



            var hashAlgorithm = new Org.BouncyCastle.Crypto.Digests.Sha3Digest(512);



            // Choose correct encoding based on your string);
            byte[] input = Encoding.ASCII.GetBytes(str);


            hashAlgorithm.BlockUpdate(input, 0, input.Length);



            byte[] result = new byte[64]; // 512 / 8 = 64
            hashAlgorithm.DoFinal(result, 0);



            string hashString = BitConverter.ToString(result);
            hashString = hashString.Replace("-", "").ToLowerInvariant();

            return hashString;
        }
    }
}