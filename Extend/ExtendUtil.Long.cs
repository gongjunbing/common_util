namespace CommonUtil
{
    /// <summary>
    /// 扩展方法工具类-长整型
    /// </summary>
    public static partial class ExtendUtil
    {
        /// <summary>
        /// 数据转换为整型，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>整型long</returns>
        public static long ToLong(this string data)
        {
            if (data == null)
            {
                return 0;
            }

            return long.TryParse(data, out long result) ? result : 0;
        }

        /// <summary>
        /// 数据转换为整型，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>整型long</returns>
        public static long ToLong<T>(this T data) where T : struct
        {
            return long.TryParse(data.ToString(), out long result) ? result : 0;
        }

        /// <summary>
        /// 数据转换为整型，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>整型long</returns>
        public static long ToLong<T>(this T? data) where T : struct
        {
            return data.HasValue ? ToLong(data.Value) : 0;
        }

        /// <summary>
        /// 转换为可空整型，null会转为0
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空整型long</returns>
        public static long? ToLongOrNull(this string data)
        {
            if (data == null)
            {
                return null;
            }

            bool isValid = long.TryParse(data, out long result);
            if (isValid)
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// 转换为可空整型
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空整型long</returns>
        public static long? ToLongOrNull<T>(this T data) where T : struct
        {
            bool isValid = long.TryParse(data.ToString(), out long result);
            if (isValid)
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// 转换为可空整型
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空整型long</returns>
        public static long? ToLongOrNull<T>(this T? data) where T : struct
        {
            return data.HasValue ? ToLongOrNull(data.Value) : null;
        }
    }
}
