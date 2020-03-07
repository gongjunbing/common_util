namespace CommonUtil
{
    /// <summary>
    /// 分页公共返回
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TopPageResultDTO<T>
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public T Data { get; set; }
    }
}
