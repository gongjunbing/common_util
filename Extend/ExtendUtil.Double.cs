using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtil
{
    /// <summary>
    /// 扩展方法工具类-双精度浮点数
    /// </summary>
    public static partial class ExtendUtil
    {
        /// <summary>
        /// 数据转换为双精度浮点数，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>双精度浮点数</returns>
        public static double ToDouble(this string data)
        {
            if (data.IsNullOrEmpty())
            {
                return 0;
            }
            return double.TryParse(data, out double result) ? result : 0;
        }

        /// <summary>
        /// 数据转换为双精度浮点数，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>双精度浮点数</returns>
        public static double ToDouble<T>(this T data) where T : struct
        {
            return double.TryParse(data.ToStringEx(), out double result) ? result : 0;
        }

        /// <summary>
        /// 数据转换为双精度浮点数，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>双精度浮点数</returns>
        public static double ToDouble<T>(this T? data) where T : struct
        {
            return data.HasValue ? ToDouble(data.Value) : 0;
        }

        /// <summary>
        /// 转换为双精度浮点数，并按指定的位数四舍五入，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>双精度浮点数</returns>
        public static double ToDouble(this string data, int digits)
        {
            return Math.Round(ToDouble(data), digits, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 转换为双精度浮点数，并按指定的位数四舍五入，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>双精度浮点数</returns>
        public static double ToDouble<T>(this T data, int digits) where T : struct
        {
            return Math.Round(ToDouble(data), digits, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 转换为双精度浮点数，并按指定的位数四舍五入，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>双精度浮点数</returns>
        public static double ToDouble<T>(this T? data, int digits) where T : struct
        {
            return data.HasValue ? ToDouble(data.Value, digits) : 0;
        }

        /// <summary>
        /// 转换为可空的双精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空的双精度浮点数</returns>
        public static double? ToDoubleOrNull(this string data)
        {
            if (data == null)
            {
                return null;
            }
            bool isValid = double.TryParse(data.ToString(), out double result);
            if (isValid)
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// 转换为可空的双精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空的双精度浮点数</returns>
        public static double? ToDoubleOrNull<T>(this T data) where T : struct
        {
            bool isValid = double.TryParse(data.ToString(), out double result);
            if (isValid)
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// 转换为可空的双精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空的双精度浮点数</returns>
        public static double? ToDoubleOrNull<T>(this T? data) where T : struct
        {
            return data.HasValue ? ToDoubleOrNull(data.Value) : null;
        }
    }
}
