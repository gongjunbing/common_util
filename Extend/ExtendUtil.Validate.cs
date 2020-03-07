using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommonUtil
{
    /// <summary>
    /// 扩展方法工具类
    /// </summary>
    public static partial class ExtendUtil
    {
        private static readonly Regex REG_CIDR = new Regex("^(\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3})/(\\d{1,2})$");

        /// <summary>
        /// 是否为null
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>bool</returns>
        public static bool IsNull(this object data)
        {
            return data == null;
        }

        /// <summary>
        /// 是否为空或仅有空白字符组成
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>bool</returns>
        public static bool IsNullOrEmpty(this string data)
        {
            return string.IsNullOrEmpty(data);
        }

        /// <summary>
        /// 是否为空或仅有空白字符组成
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>bool</returns>
        public static bool IsNullOrWhiteSpace(this string data)
        {
            return string.IsNullOrWhiteSpace(data);
        }

        /// <summary>
        /// 是否为空，null也算作空
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>bool</returns>
        public static bool IsNullOrEmpty(this Guid? data)
        {
            if (!data.HasValue)
            {
                return true;
            }
            return IsNullOrEmpty(data.Value);
        }

        /// <summary>
        /// 是否为空
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>bool</returns>
        public static bool IsNullOrEmpty(this Guid data)
        {
            if (data == Guid.Empty)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 判断一个字符串是否为合法数字(指定小数位数)
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="scale">小数位数</param>
        /// <returns>bool</returns>
        public static bool IsNumber(this string str, int scale)
        {
            string pattern = @"^\d*.\d{0," + scale + "}$";

            return Regex.IsMatch(str, pattern);
        }

        /// <summary>
        /// 判断是否是正确的手机号码格式
        /// </summary>
        /// <param name="txtPhone">手机号码</param>
        /// <returns>bool</returns>
        public static bool IsPhone(this string txtPhone)
        {
            string rule = @"^(1(([3457968][0-9])|(47)|[8][01236789]))\d{8}$";
            return Regex.IsMatch(txtPhone, rule);
        }

        /// <summary>
        /// 判断是否是正确的邮箱格式
        /// </summary>
        /// <param name="txtEmail">邮箱号码</param>
        /// <returns>bool</returns>
        public static bool IsEmail(this string txtEmail)
        {
            Regex rule = new Regex(@"^\s*([A-Za-z0-9_-]+(\.\w+)*@(\w+\.)+\w{2,5})\s*$");
            return rule.IsMatch(txtEmail);
        }

        /// <summary>
        /// 验证是否为url
        /// </summary>
        /// <param name="str">数据</param>
        /// <returns>bool</returns>
        public static bool IsUrl(this string str)
        {
            return Regex.IsMatch(str, @"^(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&$%\$#\=~])*$");
        }

        /// <summary>
        /// 验证是否为IP地址
        /// </summary>
        /// <param name="str">数据</param>
        /// <returns>bool</returns>
        public static bool IsIP(this string str)
        {
            return Regex.IsMatch(str, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }

        /// <summary>
        /// 验证ip是否在范围
        /// </summary>
        /// <param name="ipAddr"></param>
        /// <param name="cidrAddr"></param>
        /// <returns></returns>
        public static bool IsIpInRange(string ipAddr, string cidrAddr)
        {
            Match match = REG_CIDR.Match(cidrAddr);
            if (!match.Success)
            {
                throw new TopException("Invalid CIDR address: " + cidrAddr);
            }

            int[] minIpParts = new int[4];
            int[] maxIpParts = new int[4];
            string[] ipParts = match.Groups[1].Value.Split(new string[1] { "." }, StringSplitOptions.None);
            int intMask = int.Parse(match.Groups[2].Value);

            for (int i = 0; i < ipParts.Length; i++)
            {
                int ipPart = int.Parse(ipParts[i]);
                if (intMask > 8)
                {
                    minIpParts[i] = ipPart;
                    maxIpParts[i] = ipPart;
                    intMask -= 8;
                }
                else if (intMask > 0)
                {
                    minIpParts[i] = ipPart >> intMask;
                    maxIpParts[i] = ipPart | (0xFF >> intMask);
                    intMask = 0;
                }
                else
                {
                    minIpParts[i] = 1;
                    maxIpParts[i] = 0xFF - 1;
                }
            }

            string[] realIpParts = ipAddr.Split(new string[1] { "." }, StringSplitOptions.None);
            for (int i = 0; i < realIpParts.Length; i++)
            {
                int realIp = int.Parse(realIpParts[i]);
                if (realIp < minIpParts[i] || realIp > maxIpParts[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 值在的范围？
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <param name="begin">大于等于begin</param>
        /// <param name="end">小于等于end</param>
        /// <returns>bool</returns>
        public static bool IsInRange(this int thisValue, int begin, int end)
        {
            return thisValue >= begin && thisValue <= end;
        }

        /// <summary>
        /// 值在的范围？
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <param name="begin">大于等于begin</param>
        /// <param name="end">小于等于end</param>
        /// <returns>bool</returns>
        public static bool IsInRange(this DateTime thisValue, DateTime begin, DateTime end)
        {
            return thisValue >= begin && thisValue <= end;
        }

        /// <summary>
        /// 长度在范围？
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <param name="minLength">大于等于最小长度</param>
        /// <param name="maxLength">小于等于最大长度</param>
        /// <returns></returns>
        public static bool IsInRange(this string thisValue, long minLength, long maxLength)
        {
            return thisValue.Length >= minLength && thisValue.Length <= maxLength;
        }

        /// <summary>
        /// 在里面吗?
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="thisValue">数据</param>
        /// <param name="inValues">匹配范围</param>
        /// <returns>bool</returns>
        public static bool IsContains<T>(this T thisValue, params T[] inValues) where T : struct
        {
            return inValues.Contains(thisValue);
        }

        /// <summary>
        /// 在里面吗?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <param name="inValues">匹配范围</param>
        /// <returns>bool</returns>
        public static bool IsContains(this string thisValue, params string[] inValues)
        {
            return inValues.Any(it => thisValue.Contains(it));
        }

        /// <summary>
        /// 是否包含空白
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns></returns>
        public static bool IsContainsEmpty(this string thisValue)
        {
            if (thisValue.IsNullOrWhiteSpace()) return true;
            return Regex.IsMatch(thisValue, @"\s+");
        }

        /// <summary>
        /// 是零?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsZero(this int thisValue)
        {
            return thisValue == 0;
        }

        /// <summary>
        /// 是零?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsZero(this decimal thisValue)
        {
            return thisValue == 0;
        }

        /// <summary>
        /// 是零?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsZero(this double thisValue)
        {
            return thisValue == 0;
        }

        /// <summary>
        /// 是零?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsZero(this float thisValue)
        {
            return thisValue == 0;
        }

        /// <summary>
        /// 是INT?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsInt(this string thisValue)
        {
            return Regex.IsMatch(thisValue, @"^\d+$");
        }

        /// <summary>
        /// 不是INT?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsNoInt(this string thisValue)
        {
            return !Regex.IsMatch(thisValue, @"^\d+$");
        }

        /// <summary>
        /// 是时间?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsDateTime(this string thisValue)
        {
            DateTime outValue = DateTime.MinValue;
            return DateTime.TryParse(thisValue, out outValue);
        }

        /// <summary>
        /// 是身份证?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsIDcard(this string thisValue)
        {
            return Regex.IsMatch(thisValue, @"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
        }

        /// <summary>
        /// 是传真?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <returns>bool</returns>
        public static bool IsFax(this string thisValue)
        {
            return Regex.IsMatch(thisValue, @"^[+]{0,1}(\d){1,3}[ ]?([-]?((\d)|[ ]){1,12})+$");
        }

        /// <summary>
        /// 是适合正则匹配?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <param name="pattern">正则表达式</param>
        /// <returns>bool</returns>
        public static bool IsMatch(this string thisValue, string pattern)
        {
            Regex reg = new Regex(pattern);
            return reg.IsMatch(thisValue);
        }

        /// <summary>
        /// 是适合正则匹配?
        /// </summary>
        /// <param name="thisValue">数据</param>
        /// <param name="reg">正则表达式</param>
        /// <returns>bool</returns>
        public static bool IsMatch(this string thisValue, Regex reg)
        {
            return reg.IsMatch(thisValue);
        }


    }
}
