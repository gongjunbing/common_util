namespace CommonUtil
{
    /// <summary>
    /// 公共常量
    /// </summary>
    public sealed class TopConstants
    {
        /// <summary>
        /// 项目日志配置
        /// </summary>
        public const string PROJECT_LOG_CONFIG = "Logging";

        /// <summary>
        /// 精确日期个刷
        /// </summary>
        public const string DATE_FORMAT = "yyyy/MM/dd";

        /// <summary>
        /// 精确秒格式化
        /// </summary>
        public const string DATE_TIME_FORMAT = "yyyy/MM/dd HH:mm:ss";
        /// <summary>
        /// 精确毫秒格式化
        /// </summary>
        public const string DATE_TIME_MS_FORMAT = "yyyy/MM/dd HH:mm:ss.fff";

        /// <summary>
        /// xml文件类型
        /// </summary>
        public const string XML_FILE_TYPE = ".xml";

        /// <summary>
        /// utf8编码
        /// </summary>
        public const string CHARSET_UTF8 = "utf-8";
        /// <summary>
        /// json请求报文
        /// </summary>
        public const string CONTENT_TYPE_APPLICATION_JSON = "application/json";

        /// <summary>
        /// form请求报文
        /// </summary>
        public const string CONTENT_TYPE_FORM = "application/x-www-form-urlencoded";

        /// <summary>
        /// html输出报文
        /// </summary>
        public const string CONTENT_TYPE_TEXT_HTML = "text/html";
        /// <summary>
        /// api路由
        /// </summary>
        public const string API_ROUTE = "api/[controller]/[action]";
        /// <summary>
        /// 开放api路由
        /// </summary>
        public const string OPEN_API_ROUTE = "api/[controller]/[action]";
        /// <summary>
        /// 微服务api路由
        /// </summary>
        public const string Service_API_ROUTE = "[controller]/[action]";
        /// <summary>
        /// GET请求
        /// </summary>
        public const string HTTP_GET = "GET";
        /// <summary>
        /// POST请求
        /// </summary>
        public const string HTTP_POST = "POST";

        /// <summary>
        /// 输出报文-ok
        /// </summary>
        public const string TOP_RESULT_OK = "ok";
        /// <summary>
        /// 输出报文-登录失效
        /// </summary>
        public const string TOP_RESULT_UNAUTHORIZED = "登录失效";
        /// <summary>
        /// 输出报文-没有权限
        /// </summary>
        public const string TOP_RESULT_FORBIDDEN = "没有权限";
        /// <summary>
        /// 输出报文-普通错误
        /// </summary>
        public const string TOP_RESULT_ERROR_GENERAL = "普通错误";
        /// <summary>
        /// 输出报文-异常
        /// </summary>
        public const string TOP_RESULT_ERROR_EXCEPTION = "系统出现问题，程序猿正在抢救..";
        /// <summary>
        /// 输出报文-参数错误
        /// </summary>
        public const string TOP_RESULT_ERROR_PARAMS = "参数错误";
        /// <summary>
        /// 输出报文-时间戳错误
        /// </summary>
        public const string TOP_RESULT_ERROR_TIMESTAMP = "时间戳错误";
        /// <summary>
        /// 输出报文-签名错误
        /// </summary>
        public const string TOP_RESULT_ERROR_SIGN = "签名错误";
        /// <summary>
        /// 输出报文-令牌错误
        /// </summary>
        public const string TOP_RESULT_ERROR_TOKEN = "令牌错误";
        /// <summary>
        /// 输出报文-HTTP请求错误
        /// </summary>
        public const string TOP_RESULT_ERROR_HTTP_METHOD_ERROR = "HTTP请求错误";

        /// <summary>
        /// 输出报文-未定义返回类型
        /// </summary>
        public const string TOP_RESULT_ERROR_UNDEFINED_RESPONSE_TYPE = "未定义返回类型";

        /// <summary>
        /// 输出报文-未定义权限
        /// </summary>
        public const string TOP_RESULT_ERROR_UNDEFINED_AUTHORITY = "未定义权限";

        /// <summary>
        /// 输出报文-未继承基类返回
        /// </summary>
        public const string TOP_RESULT_ERROR_BASE_TYPE = "未继承基类返回";

        /// <summary>
        /// 输出报文-未使用统一命名空间
        /// </summary>
        public const string TOP_RESULT_ERROR_NAMESPACE = "未使用统一命名空间";

        /// <summary>
        /// Swagger名称
        /// </summary>
        public const string SWAGGER_NAME = "v1";

        /// <summary>
        /// 开放ApiSwagger名称
        /// </summary>
        public const string SWAGGER_OPEN_NAME = "v1";

        /// <summary>
        /// Swagger版本
        /// </summary>
        public const string SWAGGER_VERSION = "v1";

        /// <summary>
        /// 开放ApiSwagger版本
        /// </summary>
        public const string SWAGGER_OPEN_VERSION = "v1";

        /// <summary>
        /// Swagger标题
        /// </summary>
        public const string SWAGGER_TITLE = "Api接口文档";

        /// <summary>
        /// 开放ApiSwagger标题
        /// </summary>
        public const string SWAGGER_OPEN_TITLE = "Api接口文档";

        /// <summary>
        /// SwaggerJSON文件
        /// </summary>
        public const string SWAGGER_JSON_URL = "/swagger/v1/swagger.json";

        /// <summary>
        /// SwaggerJSON文件
        /// </summary>
        public const string SWAGGER_OPEN_JSON_URL = "/swagger/v1/swagger.json";

        /// <summary>
        /// 页码最小值
        /// </summary>
        public const int PAGE_INDEX_MIN = 1;

        /// <summary>
        /// 页码最大值
        /// </summary>
        public const int PAGE_INDEX_MAX = 999999;

        /// <summary>
        /// 整数最大值
        /// </summary>
        public const int INT_MAX = 999999;

        /// <summary>
        /// 页大小最小值
        /// </summary>
        public const int PAGE_SIZE_MIN = 1;

        /// <summary>
        /// 页大小最大值
        /// </summary>
        public const int PAGE_SIZE_MAX = 100;

        /// <summary>
        /// 批量操作最大值
        /// </summary>
        public const int BATHCH_SIZE_MAX = 200;


        /// <summary>
        /// 允许上传文件的白名单Key
        /// </summary>
        public const string FILE_TYPE_CONFIG = "FileType";

        /// <summary>
        /// 图片格式校验正则
        /// </summary>
        public const string IMAGE_REGEX = "(bmp)|(png)|(gif)|(jpg)|(jpeg)";

        /// <summary>
        /// 文件格式校验正则
        /// </summary>
        public const string FILE_REGEX = "(doc)|(docx)|(xls)|(xlsx)";

        /// <summary>
        /// 图片大小最大值，单位Bit
        /// </summary>
        public const int IMAGE_SIZE_MAX = 10485760;

        /// <summary>
        /// 
        /// </summary>
        public const string JWT_ISSUSER = "";

        /// <summary>
        /// 
        /// </summary>
        public const string JWT_AUDIENCE = "";

        /// <summary>
        /// JWT密钥
        /// </summary>
        public const string JWT_SECRET_KEY = "";

        /// <summary>
        /// 京东服务端接口地址
        /// </summary>
        public const string JD_SERVER_URL = "";

        /// <summary>
        /// 京东应用APPKey
        /// </summary>
        public const string JD_APP_KEY = "";

        /// <summary>
        /// 京东应用密钥
        /// </summary>
        public const string JD_APP_SECRET = "";

        /// <summary>
        /// 请求日志埋点
        /// </summary>
        public const string LOG_KEY = "operate";
    }
}
