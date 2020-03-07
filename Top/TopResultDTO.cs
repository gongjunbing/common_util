namespace CommonUtil
{
    /// <summary>
    /// 公共返回
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TopResultDTO<T>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 返回报文
        /// </summary>
        public T Response { get; set; }
    }
}
