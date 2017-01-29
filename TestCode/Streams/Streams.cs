using System;
using System.IO;
using System.Security.Cryptography;

namespace TestCode.Streams
{
    public class Streams
    {
        private byte[] key;
        private byte[] iv;

        public string EncryptString(string text)
        {
            string encryptText;

            SelectKeyAndIV(out key, out iv);

            return EncryptStringHelper(text, key, iv);
            
        }

        public string DescriptString(string text)
        {
            return DescriptStringHelper(text, key, iv);
        }

        private void SelectKeyAndIV(out byte[] key, out byte[]iv)
        {
            var algorithm = TripleDES.Create();
            algorithm.GenerateKey();
            algorithm.GenerateIV();

            iv = algorithm.IV;
            key = algorithm.Key;
        }

        private string EncryptStringHelper(string text, byte[] key, byte[] iv)
        {
            var serviceProvider = new TripleDESCryptoServiceProvider();

            using (MemoryStream m = new MemoryStream())
            
                using (CryptoStream cry = new CryptoStream(m, serviceProvider.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                
                    using (StreamWriter writer = new StreamWriter(cry))
                    {
                        writer.Write(text);

                        writer.Flush();

                        cry.FlushFinalBlock();

                        return GetText(m);
                    }
                
            
            
        }

        private string GetText(MemoryStream stream)
        {
            byte[] buffer = stream.ToArray();
            return Convert.ToBase64String(buffer, 0, buffer.Length);
        }

        private string DescriptStringHelper(string text, byte[] key, byte[] iv)
        {
            var serviceProvider = new TripleDESCryptoServiceProvider();

            byte[] byteText = Convert.FromBase64String(text);

            using (MemoryStream m = new MemoryStream(byteText))
            using (CryptoStream cryproStream = new CryptoStream(m, serviceProvider.CreateDecryptor(key, iv), CryptoStreamMode.Read))
            using (StreamReader reader = new StreamReader(cryproStream))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
