using System.ComponentModel;

namespace CommonUtil
{
    /// <summary>
    /// 公共返回枚举
    /// </summary>
    public enum TopResultEnum
    {
        /// <summary>
        /// 成功
        /// </summary>
        [Description("ok")]
        OK = 200,

        /// <summary>
        /// 登录失效
        /// </summary>
        [Description("登录失效")]
        Unauthorized = 401,

        /// <summary>
        /// 没有权限
        /// </summary>
        [Description("没有权限")]
        Forbidden = 403,

        /// <summary>
        /// HTTP请求错误
        /// </summary>
        [Description("HTTP请求错误")]
        HttpMehtodError = 405,

        /// <summary>
        /// 普通错误
        /// </summary>
        [Description("普通错误")]
        ErrorGeneral = 700,

        /// <summary>
        /// 抛出异常的错误
        /// </summary>
        [Description("系统出现问题，程序猿正在抢救..")]
        ErrorException = 500,

        /// <summary>
        /// 参数错误
        /// </summary>
        [Description("参数错误")]
        ErrorParams = 701,

        /// <summary>
        /// 时间戳错误
        /// </summary>
        [Description("时间戳错误")]
        ErrorTimestamp = 702,

        /// <summary>
        /// 签名错误
        /// </summary>
        [Description("签名错误")]
        ErrorSign = 703,

        /// <summary>
        /// 令牌错误
        /// </summary>
        [Description("令牌错误")]
        ErrorToken = 704,

        /// <summary>
        /// 未定义返回类型
        /// </summary>
        [Description("未定义返回类型")]
        UndefinedResponseType = 705,

        /// <summary>
        /// 未定义权限
        /// </summary>
        [Description("未定义权限")]
        UndefinedAuthority = 708,

        /// <summary>
        /// 未继承基类返回
        /// </summary>
        [Description("未继承基类返回")]
        ErrorBaseType = 706,

        /// <summary>
        /// 未使用统一命名空间
        /// </summary>
        [Description("未使用统一命名空间")]
        ErrorNameSpace = 707,
    }
}
