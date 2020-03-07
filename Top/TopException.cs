using System;

namespace CommonUtil
{
    /// <summary>
    /// 业务异常
    /// </summary>
    public class TopException : Exception
    {
        /// <summary>
        /// 业务异常错误码
        /// </summary>
        public int Code { get; private set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public TopException() : base() { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg">错误信息</param>
        public TopException(string msg) : base(msg)
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="innerException">子错误信息</param>
        public TopException(string msg, Exception innerException) : base(msg, innerException)
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="code">错误码</param>
        public TopException(string msg, TopResultEnum code) : base(msg)
        {
            this.Code = (int)code;
        }
    }
}
