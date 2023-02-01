using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace BugritosXML
{
    public class Auth
    {
        public static string UserID, ProductID, TransactionID, EncryptedKey;
        public static void RandomID(int length)
        {
            Random random = new Random();
            var chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            UserID = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            ProductID = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            TransactionID = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
        }
        public static void RandomEncryptionKey()
        {
            int length = 8;
            Random random = new Random();
            var chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            EncryptedKey = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            StoreKey(EncryptedKey);
        }

        public static void EncryptFile(string input1, string input2)
        {
            byte[] plainContent = File.ReadAllBytes(input1);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.ASCII.GetBytes(input2);
                DES.Key = Encoding.ASCII.GetBytes(input2);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(input1, memStream.ToArray());
                }
            }
        }

        public static void DecryptFile(string input1, string input2)
        {
            byte[] encrypted = File.ReadAllBytes(input1);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.ASCII.GetBytes(input2);
                DES.Key = Encoding.ASCII.GetBytes(input2);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;


                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(encrypted, 0, encrypted.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(input1, memStream.ToArray());
                }
            }
        }

        public static void StoreKey(string input)
        {
            if (!File.Exists("key.txt"))
            {
                using (FileStream fs = File.Create("key.txt"))
                {
                    byte[] title = new UTF8Encoding(true).GetBytes(input);
                    fs.Write(title, 0, title.Length);
                }
            }
        }
        public static void ReadKey()
        {
            string text = File.ReadAllText("key.txt");
            EncryptedKey = text;
        }
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
         }
    }
}
