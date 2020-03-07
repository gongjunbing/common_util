using System;
using System.Text;

namespace CommonUtil
{
    /// <summary>
    /// 扩展方法工具类/日期
    /// </summary>
    public static partial class ExtendUtil
    {
        /// <summary>
        /// 转换为日期，null会转为DateTime最小值
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>日期</returns>
        public static DateTime ToDateTime(this string data)
        {
            if (data.IsNullOrEmpty())
            {
                return DateTime.MinValue;
            }

            return DateTime.TryParse(data, out DateTime result) ? result : DateTime.MinValue;
        }

        /// <summary>
        /// 转换为可空日期
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空日期</returns>
        public static DateTime? ToDatetimeOrNull(this string data)
        {
            if (data.IsNullOrEmpty())
            {
                return null;
            }

            return DateTime.TryParse(data, out DateTime result) ? (DateTime?)result : null;
        }

        /// <summary>
        /// 获取格式化时间字符串，带时分秒，格式：yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        /// <returns>yyyy/MM/dd HH:mm:ss</returns>
        public static string ToDateTimeString(this DateTime dateTime, bool isRemoveSecond = false)
        {
            if (isRemoveSecond)
            {
                return dateTime.ToString("yyyy/MM/dd HH:mm");
            }
            else
            {
                return dateTime.ToString("yyyy/MM/dd HH:mm:ss");
            }
        }

        /// <summary>
        /// 获取格式化时间字符串，带时分秒，格式：yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>yyyy/MM/dd HH:mm:ss</returns>
        public static string ToDateTimeStringWithOutMinute(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy/MM/dd HH");
        }

        /// <summary>
        /// 获取格式化时间字符串，带时分秒，格式：yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        /// <returns>yyyy/MM/dd HH:mm:ss</returns>
        public static string ToDateTimeString(this DateTime? dateTime, bool isRemoveSecond = false)
        {
            return dateTime.HasValue ? ToDateTimeString(dateTime.Value, isRemoveSecond) : string.Empty;
        }

        /// <summary>
        /// 获取格式化时间字符串，不带时分秒，格式：yyyy/MM/dd
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>yyyy/MM/dd</returns>
        public static string ToDateString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy/MM/dd");
        }

        /// <summary>
        /// 获取格式化时间字符串，不带时分秒，格式：yyyy/MM/dd
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>yyyy/MM/dd</returns>
        public static string ToDateString(this DateTime? dateTime)
        {
            return dateTime.HasValue ? ToDateString(dateTime.Value) : string.Empty;
        }

        /// <summary>
        /// 获取格式化时间字符串，不带年月日，格式：HH:mm:ss
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>HH:mm:ss</returns>
        public static string ToTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("HH:mm:ss");
        }

        /// <summary>
        /// 获取格式化时间字符串，不带年月日，格式：HH:mm:ss
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>HH:mm:ss</returns>
        public static string ToTimeString(this DateTime? dateTime)
        {
            return dateTime.HasValue ? ToTimeString(dateTime.Value) : string.Empty;
        }

        /// <summary>
        /// 获取格式化字符串，带毫秒，格式：yyyy/MM/dd HH:mm:ss.fff
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>yyyy/MM/dd HH:mm:ss.fff"</returns>
        public static string ToMillisecondString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy/MM/dd HH:mm:ss.fff");
        }

        /// <summary>
        /// 获取格式化字符串，带毫秒，格式：yyyy/MM/dd HH:mm:ss.fff
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>yyyy/MM/dd HH:mm:ss.fff</returns>
        public static string ToMillisecondString(this DateTime? dateTime)
        {
            return dateTime.HasValue ? ToMillisecondString(dateTime.Value) : string.Empty;
        }

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式：yyyy年MM月dd日
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>yyyy年MM月dd日</returns>
        public static string ToCNDateString(this DateTime dateTime)
        {
            return string.Format("{0}年{1}月{2}日", dateTime.Year, dateTime.Month, dateTime.Day);
        }

        /// <summary>
        /// 获取格式化字符串，不带时分秒，格式：yyyy年MM月dd日
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <returns>yyyy年MM月dd日</returns>
        public static string ToCNDateString(this DateTime? dateTime)
        {
            return dateTime.HasValue ? ToCNDateString(dateTime.Value) : string.Empty;
        }

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式：yyyy年MM月dd日 HH时mm分ss秒
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        /// <returns>yyyy年MM月dd日 HH时mm分ss秒</returns>
        public static string ToCNDateTimeString(this DateTime dateTime, bool isRemoveSecond = false)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0}年{1}月{2}日", dateTime.Year, dateTime.Month, dateTime.Day);
            result.AppendFormat(" {0}时{1}分", dateTime.Hour, dateTime.Minute);
            if (!isRemoveSecond)
            {
                result.AppendFormat("{0}秒", dateTime.Second);
            }
            return result.ToString();
        }

        /// <summary>
        /// 获取格式化字符串，带时分秒，格式：yyyy年MM月dd日 HH时mm分ss秒
        /// </summary>
        /// <param name="dateTime">日期</param>
        /// <param name="isRemoveSecond">是否移除秒</param>
        /// <returns>yyyy年MM月dd日 HH时mm分ss秒</returns>
        public static string ToCNDateTimeString(this DateTime? dateTime, bool isRemoveSecond = false)
        {
            return dateTime.HasValue ? ToCNDateTimeString(dateTime.Value, isRemoveSecond) : string.Empty;
        }

        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="unixTime">整型数字</param>
        /// <returns>DateTime</returns>
        public static DateTime ToDateTimeSeconds(this long unixTime)
        {
            var dto = DateTimeOffset.FromUnixTimeSeconds(unixTime);
            return dto.ToLocalTime().DateTime;
        }

        /// <summary>
        /// 将Unix时间戳转换为DateTime类型时间
        /// </summary>
        /// <param name="unixTime">整型数字</param>
        /// <returns>DateTime</returns>
        public static DateTime ToDateTime(this long unixTime)
        {
            var dto = DateTimeOffset.FromUnixTimeMilliseconds(unixTime);
            return dto.ToLocalTime().DateTime;
        }

        /// <summary>
        /// 将DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>long</returns>   
        public static long EncodeUnix(this DateTime time)
        {
            return new DateTimeOffset(time).ToUnixTimeSeconds();
        }

        /// <summary>
        /// 将DateTime时间格式转换为Unix时间戳格式（毫秒）
        /// </summary>
        /// <param name="time">DateTime时间</param>
        /// <returns>long</returns>   
        public static long EncodeUnixMillisecond(this DateTime time)
        {
            return new DateTimeOffset(time).ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// 获取指定星期的日期
        /// </summary>
        /// <param name="dt">时间</param>
        /// <param name="weekday">星期</param>
        /// <param name="Number">下周：1，下下周：2，上周：0</param>
        /// <returns>DateTime</returns>
        public static DateTime GetWeekUpOfDate(this DateTime dt, int weekday, int Number)
        {
            int wd1 = weekday;
            int wd2 = (int)dt.DayOfWeek;
            return wd2 == wd1 ? dt.AddDays(7 * Number) : dt.AddDays(7 * Number / wd2 + wd1);
        }
    }
}
