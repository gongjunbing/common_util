namespace CommonUtil
{
    /// <summary>
    /// 数据库枚举
    /// </summary>
    public class DbEnum
    {
        /// <summary>
        /// 排序枚举
        /// </summary>
        public enum OrderType
        {
            /// <summary>
            /// 升序
            /// </summary>
            Asc,
            /// <summary>
            /// 降序
            /// </summary>
            Desc
        }

        /// <summary>
        /// 联表枚举
        /// </summary>
        public enum JoinType
        {
            /// <summary>
            /// 内连接
            /// </summary>
            Inner = 0,
            /// <summary>
            /// 左连接
            /// </summary>
            Left = 1,
            /// <summary>
            /// 右链接
            /// </summary>
            Right = 2
        }
    }
}
