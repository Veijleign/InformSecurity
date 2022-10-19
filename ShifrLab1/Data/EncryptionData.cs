using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Globalization;

namespace ShifrLab1.Data
{
    class encryptionData
    {
        private readonly string _keyPath = @"AesKey.txt";
        private byte[] _aesKey;
        private static readonly Encoding encoding = Encoding.UTF8;

        public encryptionData(string key)
        {
        }

        public byte[] encryptData(string text) // CryptoApi encrypting
        {
            Aes aes = Aes.Create();
            aes.GenerateIV();
            aes.GenerateKey();

            _aesKey = aes.Key;

            GenKey(aes.Key);
            TakeKey();

            aes.Key = _aesKey;
            byte[] encrypted;
            ICryptoTransform crypt = aes.CreateEncryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(text);
                    }
                }
                encrypted = ms.ToArray();
            }

            return encrypted.Concat(aes.IV).ToArray();
        }

        public string decryptData(byte[] hashedData)
        {
            TakeKey();

            byte[] bytesIv = new byte[16];
            byte[] mess = new byte[hashedData.Length - 16];
            for (int i = hashedData.Length - 16, j = 0; i < hashedData.Length; i++, j++)
                bytesIv[j] = hashedData[i];
            for (int i = 0; i < hashedData.Length - 16; i++)
                mess[i] = hashedData[i];
            Aes aes = Aes.Create();
            aes.Key = _aesKey;
            aes.IV = bytesIv;
            string text = "";
            byte[] data = mess;
            ICryptoTransform crypt = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (CryptoStream cs = new CryptoStream(ms, crypt, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        text = sr.ReadToEnd();
                    }
                }
            }
            return text;

        }

        private void GenKey(byte[] aesKey)
        {
            string aesKeyStr = string.Empty;

            foreach (var x in aesKey)
            {
                if (aesKeyStr == "")
                {
                    aesKeyStr = $"{Convert.ToInt32(x)}";
                }
                else
                    aesKeyStr = $"{aesKeyStr}|{Convert.ToInt32(x)}";
            }

            if (!File.Exists(_keyPath))
            {
                using (File.Create(_keyPath));
            }
            using (StreamWriter writer = new StreamWriter(_keyPath, false))
            {
                writer.WriteLine(aesKeyStr);
            }

        }

        private void TakeKey()
        {
            string aesKey = "";
            using (StreamReader reader = new StreamReader(_keyPath))
            {
                aesKey = reader.ReadToEnd();
            }
            int[] intByte = aesKey.Split('|').Select(_ => int.Parse(_, NumberStyles.Integer)).ToArray();
            byte[] keyByte = new byte[32];
            for(var i =0; i < 32; i++)
            {
                keyByte[i] = (byte)intByte[i];
            }
            _aesKey = keyByte;
        }

    }
}
