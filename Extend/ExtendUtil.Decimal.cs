using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtil
{
    /// <summary>
    /// 扩展方法工具类-高精度浮点数
    /// </summary>
    public static partial class ExtendUtil
    {
        /// <summary>
        /// 转换为高精度浮点数，null会转为0
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>高精度浮点数</returns>
        public static decimal ToDecimal(this string data)
        {
            if (data.IsNullOrEmpty())
            {
                return 0;
            }

            return decimal.TryParse(data, out decimal result) ? result : 0;
        }

        /// <summary>
        /// 转换为高精度浮点数，null会转为0
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>高精度浮点数</returns>
        public static decimal ToDecimal<T>(this T data) where T : struct
        {
            return decimal.TryParse(data.ToString(), out decimal result) ? result : 0;
        }

        /// <summary>
        /// 转换为高精度浮点数，null会转为0
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>高精度浮点数</returns>
        public static decimal ToDecimal<T>(this T? data) where T : struct
        {
            return data.HasValue ? ToDecimal(data.Value) : 0;
        }

        /// <summary>
        /// 转换为高精度浮点数，并按指定的小数位数四舍五入，null会转为0
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>高精度浮点数</returns>
        public static decimal ToDecimal(this string data, int digits = 2)
        {
            return Math.Round(ToDecimal(data), digits, MidpointRounding.AwayFromZero);
        }


        /// <summary>
        /// 转换为高精度浮点数，并按指定的小数位数四舍五入，null会转为0
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>高精度浮点数</returns>
        public static decimal ToDecimal<T>(this T data, int digits = 2) where T : struct
        {
            return Math.Round(ToDecimal(data), digits, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 转换为高精度浮点数，并按指定的小数位数四舍五入，null会转为0
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>高精度浮点数</returns>
        public static decimal ToDecimal<T>(this T? data, int digits = 2) where T : struct
        {
            return data.HasValue ? ToDecimal(data.Value, digits) : 0;
        }

        /// <summary>
        /// 转换为可空高精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空高精度浮点数</returns>
        public static decimal? ToDecimalOrNull(this string data)
        {
            if (data == null)
            {
                return null;
            }

            bool isValid = decimal.TryParse(data, out decimal result);
            if (isValid)
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// 转换为可空高精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空高精度浮点数</returns>
        public static decimal? ToDecimalOrNull<T>(this T data) where T : struct
        {
            bool isValid = decimal.TryParse(data.ToString(), out decimal result);
            if (isValid)
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// 转换为可空高精度浮点数
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空高精度浮点数</returns>
        public static decimal? ToDecimalOrNull<T>(this T? data) where T : struct
        {
            return data.HasValue ? ToDecimalOrNull(data.Value) : null;
        }

        /// <summary>
        /// 转换为可空高精度浮点数，并按指定的小数位数四舍五入
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>可空高精度浮点数</returns>
        public static decimal? ToDecimalOrNull(this string data, int digits = 2)
        {
            decimal? result = ToDecimalOrNull(data);
            if (!result.HasValue)
            {
                return null;
            }
            return Math.Round(result.Value, digits, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 转换为可空高精度浮点数，并按指定的小数位数四舍五入
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>可空高精度浮点数</returns>
        public static decimal? ToDecimalOrNull<T>(this T data, int digits = 2) where T : struct
        {
            decimal? result = ToDecimalOrNull(data.ToString());
            if (!result.HasValue)
            {
                return null;
            }
            return Math.Round(result.Value, digits, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// 转换为可空高精度浮点数，并按指定的小数位数四舍五入
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="digits">小数位数</param>
        /// <returns>可空高精度浮点数</returns>
        public static decimal? ToDecimalOrNull<T>(this T? data, int digits = 2) where T : struct
        {
            return data.HasValue ? ToDecimalOrNull(data.Value, digits) : null;
        }
    }
}
