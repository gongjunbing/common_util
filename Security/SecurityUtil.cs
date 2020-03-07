using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace CommonUtil
{
    /// <summary>
    /// 安全工具类
    /// </summary>
    public abstract class SecurityUtil
    {
        private static readonly char[] CA = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();
        private static readonly int[] IA = InitIA();
        private static readonly int KeySize = 128;
        private static readonly int BlockSize = 128;
        private static readonly byte[] IvBytes = Encoding.UTF8.GetBytes("0102030405060708");//初始向量

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        private static int[] InitIA()
        {
            int len = 256;
            int[] a = new int[len];
            for (int i = 0; i < len; i++)
            {
                a[i] = -1;
            }

            for (int i = 0, iS = CA.Length; i < iS; i++)
            {
                a[CA[i]] = i;
            }
            a['='] = 0;
            return a;
        }

        /// <summary>
        /// 判断是否base64值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsBase64Value(string str)
        {
            // Check special case
            int sLen = str != null ? str.Length : 0;
            if (sLen == 0)
                return false;

            // Count illegal characters (including '\r', '\n') to know what size the returned array will be,
            // so we don't have to reallocate & copy it later.
            int sepCnt = 0; // Number of separator characters. (Actually illegal characters, but that's a bonus...)
            for (int i = 0; i < sLen; i++)  // If input is "pure" (I.e. no line separators or illegal chars) base64 this loop can be commented out.
            {
                char currentChar = str[i];
                if (currentChar >= IA.Length)
                {
                    return false;
                }

                if (IA[currentChar] < 0)
                {
                    sepCnt++;
                }

            }


            // Check so that legal chars (including '=') are evenly divideable by 4 as specified in RFC 2045.
            if ((sLen - sepCnt) % 4 != 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 生成滑动窗口
        /// </summary>
        /// <param name="input">数据</param>
        /// <param name="slideSize">分词大小</param>
        /// <returns>分词元素</returns>
        public static List<string> GetSlideWindows(string input, int slideSize)
        {
            List<string> windows = new List<string>();
            int startIndex = 0;
            int endIndex = 0;
            int currentWindowSize = 0;
            string currentWindow = null;

            while (endIndex < input.Length || currentWindowSize > slideSize)
            {
                bool startsWithLetterOrDigit;
                if (currentWindow == null)
                {
                    startsWithLetterOrDigit = false;
                }
                else
                {
                    startsWithLetterOrDigit = IsLetterOrDigit(currentWindow[0]);
                }

                if (endIndex == input.Length && !startsWithLetterOrDigit)
                {
                    break;
                }

                if (currentWindowSize == slideSize && !startsWithLetterOrDigit && IsLetterOrDigit(input[endIndex]))
                {
                    endIndex++;
                    currentWindow = input.Substring(startIndex, endIndex - startIndex);
                    currentWindowSize = 5;

                }
                else
                {
                    if (endIndex != 0)
                    {
                        if (startsWithLetterOrDigit)
                        {
                            currentWindowSize -= 1;
                        }
                        else
                        {
                            currentWindowSize -= 2;
                        }
                        startIndex++;
                    }

                    while (currentWindowSize < slideSize && endIndex < input.Length)
                    {
                        char currentChar = input[endIndex];
                        if (IsLetterOrDigit(currentChar))
                        {
                            currentWindowSize += 1;
                        }
                        else
                        {
                            currentWindowSize += 2;
                        }
                        endIndex++;
                    }
                    currentWindow = input.Substring(startIndex, endIndex - startIndex);

                }
                windows.Add(currentWindow);
            }
            return windows;
        }

        /// <summary>
        /// 判断是否小写字母
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static bool IsLetterOrDigit(char x)
        {
            if (0 <= x && x <= 127)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 压缩
        /// </summary>
        /// <param name="input"></param>
        /// <param name="toLength"></param>
        /// <returns></returns>
        private static byte[] Compress(byte[] input, int toLength)
        {
            if (toLength < 0)
            {
                return null;
            }
            byte[] output = new byte[toLength];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = 0;
            }

            for (int i = 0; i < input.Length; i++)
            {
                int index_output = i % toLength;
                output[index_output] ^= input[i];
            }

            return output;
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <param name="encode">编码方式</param>
        /// <returns></returns>
        public static string EncodeBase64(string source, Encoding encode)
        {
            byte[] bytes = encode.GetBytes(source);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        /// 
        /// <seealso cref="SecurityUtil.EncodeBase64(string,Encoding)">  
        /// 参看SecurityUtil.EncodeBase64(string,Encoding)方法的说明 </seealso>  
        public static string EncodeBase64(string source)
        {
            return EncodeBase64(source, Encoding.UTF8);
        }

        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <param name="key">密钥</param>
        /// <param name="iv">偏移量</param>
        /// <returns>加密后的密文</returns>
        public static string DesEncrypt(string str, string key, string iv)
        {
            if (str.IsNullOrEmpty() || key.IsNullOrEmpty() || iv.IsNullOrEmpty())
            {
                return null;
            }
            var bKey = new Byte[8];
            Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(8)), bKey, 8);
            var bIv = new Byte[8];
            Array.Copy(Encoding.UTF8.GetBytes(iv.PadRight(8)), bIv, 8);
            var oldbytes = Encoding.UTF8.GetBytes(str);

            using (var dcsp = new DESCryptoServiceProvider())//using(){}:{}语句执行完后会将()中的释放,相当于dcsp.Dispose();
            {
                using (var ms = new MemoryStream())
                {
                    var cs = new CryptoStream(ms, dcsp.CreateEncryptor(bKey, bIv), CryptoStreamMode.Write);
                    cs.Write(oldbytes, 0, oldbytes.Length);
                    cs.FlushFinalBlock();
                    var newbytes = ms.ToArray();
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
        public static string DesDecrypt(string str, string key, string iv)
        {
            if (str.IsNullOrEmpty() || key.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return null;
            }
            var bKey = new Byte[8];
            Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(8)), bKey, 8);
            var bIv = new Byte[8];
            Array.Copy(Encoding.UTF8.GetBytes(iv.PadRight(8)), bIv, 8);
            var oldbytes = Convert.FromBase64String(str);

            using (var dcsp = new DESCryptoServiceProvider())
            {
                using (var ms = new MemoryStream())
                {
                    var cs = new CryptoStream(ms, dcsp.CreateDecryptor(bKey, bIv), CryptoStreamMode.Write);
                    cs.Write(oldbytes, 0, oldbytes.Length);
                    cs.FlushFinalBlock();
                    var newBytes = ms.ToArray();
                    cs.Dispose();
                    return Encoding.UTF8.GetString(newBytes);
                }
            }
        }

        /// <summary>
        /// AES加密 
        /// </summary>
        /// <param name="context">待加密的内容</param>
        /// <param name="keyBytes">加密密钥</param>
        /// <returns></returns>
        public static string AesEncrypt(string context, byte[] keyBytes)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();

            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;
            rijndaelCipher.KeySize = KeySize;
            rijndaelCipher.BlockSize = KeySize;


            // 加密密钥
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = IvBytes;

            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();

            byte[] plainText = Encoding.UTF8.GetBytes(context);
            byte[] cipherBytes = transform.TransformFinalBlock(plainText, 0, plainText.Length);
            return Convert.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="context"></param>
        /// <param name="keyBytes"></param>
        /// <returns></returns>
        public static string AesDecrypt(string context, byte[] keyBytes)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();

            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;
            rijndaelCipher.KeySize = KeySize;
            rijndaelCipher.BlockSize = BlockSize;

            byte[] encryptedData = Convert.FromBase64String(context);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = IvBytes;

            ICryptoTransform transform = rijndaelCipher.CreateDecryptor();

            byte[] plainText = transform.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
            return Encoding.UTF8.GetString(plainText);
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
        public static string AesEncrypt(string str, string key, string iv, int keyLenth = 16, CipherMode aesMode = CipherMode.CBC, PaddingMode aesPadding = PaddingMode.PKCS7)
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
            var oldBytes = Encoding.UTF8.GetBytes(str);

            key = key.Length > keyLenth ? key.Substring(0, keyLenth) : key.Length < keyLenth ? key.PadRight(keyLenth) : key;
            iv = iv.Length > 16 ? iv.Substring(0, 16) : iv.Length < 16 ? iv.PadRight(16) : iv;
            var bKey = Encoding.UTF8.GetBytes(key);
            var bIv = Encoding.UTF8.GetBytes(iv);

            var rijalg = new RijndaelManaged
            {
                Mode = aesMode,
                Padding = aesPadding,
                Key = bKey,
                IV = bIv,
            };
            var decryptor = rijalg.CreateEncryptor(rijalg.Key, rijalg.IV);
            var rtByte = decryptor.TransformFinalBlock(oldBytes, 0, oldBytes.Length);
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
        public static string AesDecrypt(string str, string key, string iv, int keyLenth = 16, CipherMode aesMode = CipherMode.CBC, PaddingMode aesPadding = PaddingMode.PKCS7)
        {
            if (str.IsNullOrEmpty() || key.IsNullOrEmpty() || iv.IsNullOrEmpty())
            {
                return null;
            }
            if (!new List<int> { 16, 24, 32 }.Contains(keyLenth))
            {
                return null;//密钥的长度，16位密钥 = 128位，24位密钥 = 192位，32位密钥 = 256位。
            }
            var oldBytes = Convert.FromBase64String(str);

            key = key.Length > keyLenth ? key.Substring(0, keyLenth) : key.Length < keyLenth ? key.PadRight(keyLenth) : key;
            iv = iv.Length > 16 ? iv.Substring(0, 16) : iv.Length < 16 ? iv.PadRight(16) : iv;
            var bKey = Encoding.UTF8.GetBytes(key);
            var bIv = Encoding.UTF8.GetBytes(iv);

            var rijalg = new RijndaelManaged
            {
                Mode = aesMode,
                Padding = aesPadding,
                Key = bKey,
                IV = bIv,
            };
            var decryptor = rijalg.CreateDecryptor(rijalg.Key, rijalg.IV);
            var rtByte = decryptor.TransformFinalBlock(oldBytes, 0, oldBytes.Length);
            return Encoding.UTF8.GetString(rtByte);
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">明文</param>
        /// <param name="isBase64">密文采用Base64还是等效16进制字符串</param>
        /// <returns>密文</returns>
        public static string MD5Encrypt(string str, bool isBase64 = false)
        {
            if (str.IsNullOrEmpty())
            {
                return null;
            }
            var oldBytes = Encoding.UTF8.GetBytes(str);
            MD5 md5 = new MD5CryptoServiceProvider();
            var newBytes = md5.ComputeHash(oldBytes);
            var result = isBase64 ? Convert.ToBase64String(newBytes) : BitConverter.ToString(newBytes).Replace("-", "");
            return result;
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">明文</param>
        /// <returns>密文</returns>
        public static byte[] MD5Encrypt(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            return bytes;
        }

        /// <summary>
        /// HmacMD5加密
        /// </summary>
        /// <param name="encryptText"></param>
        /// <param name="encryptKey"></param>
        /// <returns></returns>
        public static byte[] HmacMD5Encrypt(String encryptText, byte[] encryptKey)
        {
            HMACMD5 hmac = new HMACMD5(encryptKey);
            byte[] bytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(encryptText));
            return bytes;
        }

        /// <summary>
        /// 生成BASE64(H_MAC)
        /// </summary>
        /// <param name="encryptText">被签名的字符串</param>
        /// <param name="encryptKey">秘钥</param>
        /// <returns></returns>
        public static string HmacMD5EncryptToBase64(string encryptText, byte[] encryptKey)
        {
            return Convert.ToBase64String(HmacMD5Encrypt(encryptText, encryptKey));
        }

        /// <summary>
        /// 生成BASE64(H_MAC),压缩H_MAC值
        /// </summary>
        /// <param name="encryptText"></param>
        /// <param name="encryptKey"></param>
        /// <param name="compressLen"></param>
        /// <returns></returns>
        public static string HmacMD5EncryptToBase64(string encryptText, byte[] encryptKey, int compressLen)
        {
            return Convert.ToBase64String(Compress(HmacMD5Encrypt(encryptText, encryptKey), compressLen));
        }

        /// <summary>
        /// 签名.MD5加密，32位大写
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="secret"></param>
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
            byte[] bytes = MD5Encrypt(query.ToString());

            // 第四步：把二进制转化为大写的十六进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("X2"));
            }
            return result.ToString();
        }

    }
}
