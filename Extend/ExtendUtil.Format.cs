namespace CommonUtil
{
    /// <summary>
    /// 格式化扩展方法
    /// </summary>
    public static partial class ExtendUtil
    {
        /// <summary>
        /// 获取格式化字符串
        /// </summary>
        /// <param name="number">数值</param>
        /// <param name="defaultValue">空值显示的默认文本</param>
        /// <returns>string</returns>
        public static string Format(this int number, string defaultValue = "--")
        {
            return number == 0 ? defaultValue : number.ToString();
        }

        /// <summary>
        /// 获取格式化字符串
        /// </summary>
        /// <param name="number">数值</param>
        /// <param name="defaultValue">空值显示的默认文本</param>
        /// <returns>string</returns>
        public static string Format(this int? number, string defaultValue = "--")
        {
            return Format(SafeGetValue(number), defaultValue);
        }

        /// <summary>
        /// 获取格式化字符串
        /// </summary>
        /// <param name="number">数值</param>
        /// <param name="defaultValue">空值显示的默认文本</param>
        /// <returns>string</returns>
        public static string Format(this decimal number, string defaultValue = "--")
        {
            return number == 0 ? defaultValue : string.Format("{0:0.##}", number);
        }

        /// <summary>
        /// 获取格式化字符串
        /// </summary>
        /// <param name="number">数值</param>
        /// <param name="defaultValue">空值显示的默认文本</param>
        /// <returns>string</returns>
        public static string Format(this decimal? number, string defaultValue = "--")
        {
            return Format(SafeGetValue(number), defaultValue);
        }

        /// <summary>
        /// 获取格式化字符串
        /// </summary>
        /// <param name="number">数值</param>
        /// <param name="defaultValue">空值显示的默认文本</param>
        /// <returns>string</returns>
        public static string Format(this double number, string defaultValue = "--")
        {
            return number == 0 ? defaultValue : string.Format("{0:0.##}", number);
        }

        /// <summary>
        /// 获取格式化字符串
        /// </summary>
        /// <param name="number">数值</param>
        /// <param name="defaultValue">空值显示的默认文本</param>
        /// <returns>string</returns>
        public static string Format(this double? number, string defaultValue = "--")
        {
            return Format(SafeGetValue(number), defaultValue);
        }

        /// <summary>
        /// 获取格式化字符串,带￥
        /// </summary>
        /// <param name="number">数值</param>
        /// <returns>string</returns>
        public static string FormatRmb(this decimal number)
        {
            return number == 0 ? "￥0" : string.Format("{0:0.##}", number);
        }

        /// <summary>
        /// 获取格式化字符串,带￥
        /// </summary>
        /// <param name="number">数值</param>
        /// <returns>string</returns>
        public static string FormatRmb(this decimal? number)
        {
            return FormatRmb(SafeGetValue(number));
        }

        /// <summary>
        /// 获取格式化字符串,带%
        /// </summary>
        /// <param name="number"></param>
        /// <returns>string</returns>
        public static string FormatPercent(this decimal number)
        {
            return number == 0 ? string.Empty : string.Format("{0:0.##}%", number);
        }

        /// <summary>
        /// 获取格式化字符串,带%
        /// </summary>
        /// <param name="number"></param>
        /// <returns>string</returns>
        public static string FormatPercent(this decimal? number)
        {
            return FormatPercent(SafeGetValue(number));
        }

        /// <summary>
        /// 获取格式化字符串,带%
        /// </summary>
        /// <param name="number"></param>
        /// <returns>string</returns>
        public static string FormatPercent(this double number)
        {
            return number == 0 ? string.Empty : string.Format("{0:0.##}%", number);
        }

        /// <summary>
        /// 获取格式化字符串,带%
        /// </summary>
        /// <param name="number"></param>
        /// <returns>string</returns>
        public static string FormatPercent(this double? number)
        {
            return FormatPercent(SafeGetValue(number));
        }
    }
}
