using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtil
{
    /// <summary>
    /// 扩展方法工具类
    /// </summary>
    public static partial class ExtendUtil
    {
        #region bool 布尔值
        /// <summary>
        /// 获取可空布尔值，支持转换0-1，是-否，yes-no
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空布尔值</returns>
        public static bool ToBool(this string data)
        {
            switch (data.ToLower())
            {
                case "0":
                    return false;
                case "1":
                    return true;
                case "是":
                    return true;
                case "否":
                    return false;
                case "yes":
                    return true;
                case "no":
                    return false;
                case "true":
                    return true;
                case "false":
                    return false;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 获取可空布尔值，支持转换0-1，是-否
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空布尔值</returns>
        public static bool ToBool<T>(this T data) where T : struct
        {
            switch (data.ToInt())
            {
                case 0:
                    return false;
                case 1:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 获取可空布尔值，支持转换0-1，是-否
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空布尔值</returns>
        public static bool ToBool<T>(this T? data) where T : struct
        {
            switch (data.ToInt())
            {
                case 0:
                    return false;
                case 1:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 转换为可空布尔值
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空布尔值</returns>
        public static bool? ToBoolOrNull(this string data)
        {
            if (data == null)
            {
                return null;
            }

            bool isValid = bool.TryParse(data, out bool result);
            if (isValid)
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// 转换为可空布尔值
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空布尔值</returns>
        public static bool? ToBoolOrNull<T>(this T data) where T : struct
        {
            return ToBoolOrNull(data.ToString());
        }

        /// <summary>
        /// 转换为可空布尔值
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空布尔值</returns>
        public static bool? ToBoolOrNull<T>(this T? data) where T : struct
        {
            return ToBoolOrNull(SafeGetValue(data));
        }


        #endregion

        #region string 字符串
        /// <summary>
        ///  转换为字符串，null会转为string.Empty
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>字符串</returns>
        public static string ToStringEx(this object data)
        {
            return data == null ? string.Empty : data.ToString();
        }

        /// <summary>
        /// 加强版转换为字符串，并去除两边空格，null会转为string.Empty
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>字符串</returns>
        public static string ToStringExTrim(this object data)
        {
            return ToStringEx(data).Trim();
        }
        #endregion

        /// <summary>
        /// 安全的返回值
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="data">数据</param>
        /// <returns>泛型</returns>
        public static T SafeGetValue<T>(this T? data) where T : struct
        {
            return data ?? default(T);
        }

        /// <summary>
        /// 元转换为分
        /// </summary>
        /// <param name="sender">元</param>
        /// <returns>分</returns>
        public static int ToFee(this double sender)
        {
            return (int)(sender * 100).ToDecimal();
        }

        /// <summary>
        /// 元转换为分
        /// </summary>
        /// <param name="sender">元</param>
        /// <returns>分</returns>
        public static int ToFee(this decimal sender)
        {
            return (int)(sender * 100);
        }

        /// <summary>
        /// 可为空的元转换为分
        /// </summary>
        /// <param name="sender">元</param>
        /// <returns>分</returns>
        public static int? ToFee(this double? sender)
        {
            return !sender.HasValue ? null : (int?)sender.Value.ToFee();
        }

        /// <summary>
        /// 可为空的元转换为分
        /// </summary>
        /// <param name="sender">元</param>
        /// <returns>分</returns>
        public static int? ToFee(this decimal? sender)
        {
            return sender == null ? null : (int?)sender.Value.ToFee();
        }

        /// <summary>
        /// 分转换为元
        /// </summary>
        /// <param name="fee">分</param>
        /// <returns>元</returns>
        public static double ByFee(this int fee)
        {
            return (double)(fee / 100.0M);
        }

        /// <summary>
        /// 可为空分转换为元
        /// </summary>
        /// <param name="fee">分</param>
        /// <returns>元</returns>
        public static double? ByFee(this int? fee)
        {
            return fee == null ? null : (double?)fee.Value.ByFee();
        }

        /// <summary>
        /// 价格获取小数点后面的值(重构)
        /// </summary>
        /// <param name="price">价格数字分</param>
        /// <returns>小数点后面的值</returns>
        public static string ToPriceXiaoshu(this int? price)
        {
            return (price ?? 0).ToPriceXiaoshu();
        }

        /// <summary>
        /// 价格获取小数点后面的值
        /// </summary>
        /// <param name="price">价格数字分</param>
        /// <returns>小数点后面的值</returns>
        public static string ToPriceXiaoshu(this int price)
        {
            int xs = price % 100;
            return xs < 10 ? ("0" + xs.ToString()) : xs.ToString();
        }

        /// <summary>
        /// 除法运算，得到百分数，会四舍五入
        /// </summary>
        /// <param name="dividend">被除数</param>
        /// <param name="divisor">除数</param>
        /// <param name="digital">小数点后几位，默认4位</param>
        /// <param name="defaultValue">除数为0时默认值，默认--</param>
        /// <returns></returns>
        public static string ToPercent(decimal dividend, decimal divisor, int digital = 4, string defaultValue = "--")
        {
            if (divisor == 0)
            {
                return defaultValue;
            }

            string percent = (Math.Round(dividend / divisor, digital, MidpointRounding.AwayFromZero) * 100).ToString().TrimEnd('0').TrimEnd('.');

            return $"{percent}%";
        }

        /// <summary>
        /// 字符串切割
        /// </summary>
        /// <param name="data"></param>
        /// <param name="separatorChar"></param>
        /// <returns></returns>
        public static string[] Split(this string data, char separatorChar)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }
            return data.Split(new char[] { separatorChar }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// 转换为驼峰格式
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToCamelStyle(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }

            char[] chars = data.ToCharArray();
            StringBuilder buf = new StringBuilder(chars.Length);
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 0)
                {
                    buf.Append(char.ToLower(chars[i]));
                }
                else
                {
                    buf.Append(chars[i]);
                }
            }
            return buf.ToString();
        }

        /// <summary>
        /// 转换为 _ 形式
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToUnderlineStyle(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }

            StringBuilder buf = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                char c = data[i];
                if (char.IsUpper(c))
                {
                    if (i > 0)
                    {
                        buf.Append("_");
                    }
                    buf.Append(char.ToLower(c));
                }
                else
                {
                    buf.Append(c);
                }
            }
            return buf.ToString();
        }

        /// <summary>
        /// 清除字典中值为空的项。
        /// </summary>
        /// <param name="dict">待清除的字典</param>
        /// <returns>清除后的字典</returns>
        public static IDictionary<string, T> CleanupDictionary<T>(this IDictionary<string, T> dict)
        {
            IDictionary<string, T> newDict = new Dictionary<string, T>(dict.Count);

            foreach (KeyValuePair<string, T> kv in dict)
            {
                if (kv.Value != null)
                {
                    newDict.Add(kv.Key, kv.Value);
                }
            }
            return newDict;
        }
    }
}
