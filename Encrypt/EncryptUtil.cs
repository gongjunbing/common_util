using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CommonUtil
{
    /// <summary>
    /// 加解密帮助类
    /// </summary>
    public class EncryptUtil
    {
        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="parameters">参数</param>
        /// <param name="secret">密钥</param>
        /// <returns></returns>
        public static string SignRequest(IDictionary<string, string> parameters, string secret)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);

            // 第二步：把所有参数名和参数值串在一起
            StringBuilder query = new StringBuilder();

            query.Append(secret);

            foreach (KeyValuePair<string, string> kv in sortedParams)
            {
                if (!string.IsNullOrEmpty(kv.Key) && !string.IsNullOrEmpty(kv.Value))
                {
                    query.Append(kv.Key).Append(kv.Value);
                }
            }

            query.Append(secret);

            // 第三步：MD5加密
            byte[] bytes = Md5Encode(query.ToString());

            // 第四步：把二进制转化为大写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }
            return result.ToString();
        }

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <param name="key">密钥</param>
        /// <param name="iv">偏移量</param>
        /// <returns>加密后的密文</returns>
        public static string DesEncode(string str, string key, string iv)
        {
            if (str.IsNullOrEmpty() || key.IsNullOrEmpty() || iv.IsNullOrEmpty())
            {
                return null;
            }

            byte[] bKey = new byte[8];
            Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(8)), bKey, 8);
            byte[] bIv = new byte[8];
            Array.Copy(Encoding.UTF8.GetBytes(iv.PadRight(8)), bIv, 8);
            byte[] oldbytes = Encoding.UTF8.GetBytes(str);

            using (DESCryptoServiceProvider dcsp = new DESCryptoServiceProvider())
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    CryptoStream cs = new CryptoStream(ms, dcsp.CreateEncryptor(bKey, bIv), CryptoStreamMode.Write);
                    cs.Write(oldbytes, 0, oldbytes.Length);
                    cs.FlushFinalBlock();
                    byte[] newbytes = ms.ToArray();
                    cs.Dispose();//释放cs
                    return Convert.ToBase64String(newbytes);
                }
            }
        }

        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="str">需要解密的密文</param>
        /// <param name="key">密钥</param>
        /// <param name="iv">偏移量</param>
        /// <returns>解密后的字符串</returns>
        public static string DesDecode(string str, string key, string iv)
        {
            if (str.IsNullOrEmpty() || key.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return null;
            }
            byte[] bKey = new byte[8];
            Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(8)), bKey, 8);
            byte[] bIv = new byte[8];
            Array.Copy(Encoding.UTF8.GetBytes(iv.PadRight(8)), bIv, 8);
            byte[] oldbytes = Convert.FromBase64String(str);

            using (DESCryptoServiceProvider dcsp = new DESCryptoServiceProvider())
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    CryptoStream cs = new CryptoStream(ms, dcsp.CreateDecryptor(bKey, bIv), CryptoStreamMode.Write);
                    cs.Write(oldbytes, 0, oldbytes.Length);
                    cs.FlushFinalBlock();
                    byte[] newBytes = ms.ToArray();
                    cs.Dispose();
                    return Encoding.UTF8.GetString(newBytes);
                }
            }
        }

        /// <summary>
        /// Aes加密
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <param name="key">密钥,长度不够时空格补齐,超过时从左截取</param>
        /// <param name="iv">偏移量,长度不够时空格补齐,超过时从左截取</param>
        /// <param name="keyLenth">秘钥长度,16 24 32</param>
        /// <param name="aesMode">加密模式</param>
        /// <param name="aesPadding">填充方式</param>
        /// <returns></returns>
        public static string AesEncode(string str, string key, string iv, int keyLenth = 16, CipherMode aesMode = CipherMode.CBC, PaddingMode aesPadding = PaddingMode.PKCS7)
        {
            //对称加密和分组加密中的四种模式(ECB、CBC、CFB、OFB) 。
            if (str.IsNullOrEmpty() || key.IsNullOrEmpty() || iv.IsNullOrEmpty())
            {
                return null;
            }
            if (!new List<int> { 16, 24, 32 }.Contains(keyLenth))
            {
                return null;//密钥的长度，16位密钥 = 128位，24位密钥 = 192位，32位密钥 = 256位。
            }
            byte[] oldBytes = Encoding.UTF8.GetBytes(str);

            key = key.Length > keyLenth ? key.Substring(0, keyLenth) : key.Length < keyLenth ? key.PadRight(keyLenth) : key;
            iv = iv.Length > 16 ? iv.Substring(0, 16) : iv.Length < 16 ? iv.PadRight(16) : iv;
            byte[] bKey = Encoding.UTF8.GetBytes(key);
            byte[] bIv = Encoding.UTF8.GetBytes(iv);

            RijndaelManaged rijalg = new RijndaelManaged
            {
                Mode = aesMode,
                Padding = aesPadding,
                Key = bKey,
                IV = bIv,
            };
            ICryptoTransform decryptor = rijalg.CreateEncryptor(rijalg.Key, rijalg.IV);
            byte[] rtByte = decryptor.TransformFinalBlock(oldBytes, 0, oldBytes.Length);
            return Convert.ToBase64String(rtByte);
        }

        /// <summary>
        /// Aes解密
        /// </summary>
        /// <param name="str">需要解密的字符串</param>
        /// <param name="key">密钥,长度不够时空格补齐,超过时从左截取</param>
        /// <param name="iv">偏移量,长度不够时空格补齐,超过时从左截取</param>
        /// <param name="keyLenth">秘钥长度,16 24 32</param>
        /// <param name="aesMode">解密模式</param>
        /// <param name="aesPadding">填充方式</param>
        /// <returns></returns>
        public static string AesDecode(string str, string key, string iv, int keyLenth = 16, CipherMode aesMode = CipherMode.CBC, PaddingMode aesPadding = PaddingMode.PKCS7)
        {
            if (str.IsNullOrEmpty() || key.IsNullOrEmpty() || iv.IsNullOrEmpty())
            {
                return null;
            }
            if (!new List<int> { 16, 24, 32 }.Contains(keyLenth))
            {
                return null;//密钥的长度，16位密钥 = 128位，24位密钥 = 192位，32位密钥 = 256位。
            }
            byte[] oldBytes = Convert.FromBase64String(str);

            key = key.Length > keyLenth ? key.Substring(0, keyLenth) : key.Length < keyLenth ? key.PadRight(keyLenth) : key;
            iv = iv.Length > 16 ? iv.Substring(0, 16) : iv.Length < 16 ? iv.PadRight(16) : iv;
            byte[] bKey = Encoding.UTF8.GetBytes(key);
            byte[] bIv = Encoding.UTF8.GetBytes(iv);

            RijndaelManaged rijalg = new RijndaelManaged
            {
                Mode = aesMode,
                Padding = aesPadding,
                Key = bKey,
                IV = bIv,
            };
            ICryptoTransform decryptor = rijalg.CreateDecryptor(rijalg.Key, rijalg.IV);
            byte[] rtByte = decryptor.TransformFinalBlock(oldBytes, 0, oldBytes.Length);
            return Encoding.UTF8.GetString(rtByte);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">明文</param>
        /// <param name="isBase64">密文采用Base64还是等效16进制字符串</param>
        /// <returns>密文</returns>
        public static string Md5Encode(string str, bool isBase64 = false)
        {
            if (str.IsNullOrEmpty())
            {
                return null;
            }
            byte[] oldBytes = Encoding.UTF8.GetBytes(str);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] newBytes = md5.ComputeHash(oldBytes);
            string result = isBase64 ? Convert.ToBase64String(newBytes) : BitConverter.ToString(newBytes).Replace("-", "");
            return result;
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">明文</param>
        /// <returns>密文</returns>
        public static byte[] Md5Encode(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            return bytes;
        }

        /// <summary>
        /// 哈希加密
        /// </summary>
        /// <param name="str">明文</param>
        /// <param name="isBase64">密文采用Base64还是等效16进制字符串</param>
        /// <param name="lenth">选择哈希加密类型:1,256,384,512</param>
        /// <returns>密文</returns>
        public static string ShaEncode(string str, int lenth = 1, bool isBase64 = true)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            byte[] oldBytes;
            byte[] newBytes;
            switch (lenth)
            {
                case 1:
                    {
                        SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
                        oldBytes = Encoding.UTF8.GetBytes(str);
                        newBytes = sha.ComputeHash(oldBytes);
                        sha.Dispose();
                    }
                    break;
                case 256:
                    {
                        SHA256CryptoServiceProvider sha = new SHA256CryptoServiceProvider();
                        oldBytes = Encoding.UTF8.GetBytes(str);
                        newBytes = sha.ComputeHash(oldBytes);
                        sha.Dispose();
                    }
                    break;
                case 384:
                    {
                        SHA384CryptoServiceProvider sha = new SHA384CryptoServiceProvider();
                        oldBytes = Encoding.UTF8.GetBytes(str);
                        newBytes = sha.ComputeHash(oldBytes);
                        sha.Dispose();
                    }
                    break;
                case 512:
                    {
                        SHA512CryptoServiceProvider sha = new SHA512CryptoServiceProvider();
                        oldBytes = Encoding.UTF8.GetBytes(str);
                        newBytes = sha.ComputeHash(oldBytes);
                        sha.Dispose();
                    }
                    break;
                default: return null;
            }
            string result = isBase64 ? Convert.ToBase64String(newBytes) : BitConverter.ToString(newBytes).Replace("-", "");
            return result;
        }
    }
}