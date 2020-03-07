namespace CommonUtil
{
    /// <summary>
    /// 生成报文
    /// </summary>
    public class TopResult
    {
        /// <summary>
        /// 生成返回报文
        /// </summary>
        /// <param name="response">返回数据</param>
        /// <param name="isSuccess">是否执行成功</param>
        /// <param name="code">错误码</param>
        /// <param name="msg">描述</param>
        /// <returns></returns>
        public static TopResultDTO<T> GetTopResultDTO<T>(T response, bool isSuccess, int code, string msg)
        {
            return new TopResultDTO<T>
            {
                Success = isSuccess,
                Code = code,
                Msg = msg,
                Response = response
            };
        }

        /// <summary>
        /// 生成返回报文
        /// </summary>
        /// <param name="response">返回数据</param>
        /// <param name="isSuccess">是否执行成功</param>
        /// <param name="code">错误码</param>
        /// <param name="msg">描述</param>
        /// <param name="currentPage">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="totalCount">总数</param>
        /// <returns></returns>
        public static TopResultDTO<TopPageResultDTO<T>> GetTopPageResultDTO<T>(T response, bool isSuccess, int code, string msg, int currentPage, int pageSize, int totalCount)
        {
            return new TopResultDTO<TopPageResultDTO<T>>
            {
                Success = isSuccess,
                Code = code,
                Msg = msg,
                Response = new TopPageResultDTO<T>
                {
                    CurrentPage = currentPage,
                    TotalCount = totalCount,
                    PageSize = pageSize,
                    Data = response
                }
            };
        }

        /// <summary>
        /// 生成返回报文
        /// </summary>
        /// <param name="isSuccess">是否执行成功</param>
        /// <param name="code">错误码</param>
        /// <param name="msg">描述</param>
        /// <returns></returns>
        public static TopResultDTO<T> GetTopResultDTO<T>(bool isSuccess, int code, string msg)
        {
            return new TopResultDTO<T>
            {
                Success = isSuccess,
                Code = code,
                Msg = msg,
            };
        }
    }
}
