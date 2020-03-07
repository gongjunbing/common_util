namespace CommonUtil
{
    /// <summary>
    /// 扩展方法工具类-整型
    /// </summary>
    public static partial class ExtendUtil
    {
        /// <summary>
        /// 转换为1或0
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>true:1;false:0</returns>
        public static int ToInt(this bool data)
        {
            return data ? 1 : 0;
        }

        /// <summary>
        /// 数据转换为整型，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>整型</returns>
        public static int ToInt(this string data)
        {
            if (data.IsNullOrEmpty())
            {
                return 0;
            }

            return int.TryParse(data, out int result) ? result : 0;

        }

        /// <summary>
        /// 数据转换为整型，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>整型</returns>
        public static int ToInt<T>(this T data) where T : struct
        {
            return int.TryParse(data.ToString(), out int result) ? result : 0;
        }

        /// <summary>
        /// 数据转换为整型，null会转为0！
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>整型</returns>
        public static int ToInt<T>(this T? data) where T : struct
        {
            return data.HasValue ? ToInt(data.Value) : 0;
        }

        /// <summary>
        /// 转换为可空整型
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns>可空整型</returns>
        public static int? ToIntOrNull(this string data)
        {
            if (data == null)
            {
                return null;
            }

            bool isValid = int.TryParse(data, out int result);
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
        /// <returns>可空整型</returns>
        public static int? ToIntOrNull<T>(this T data) where T : struct
        {
            bool isValid = int.TryParse(data.ToString(), out int result);
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
        /// <returns>可空整型</returns>
        public static int? ToIntOrNull<T>(this T? data) where T : struct
        {
            return data.HasValue ? ToIntOrNull(data.Value) : null;
        }
    }
}
