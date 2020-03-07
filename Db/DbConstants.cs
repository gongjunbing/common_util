using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtil
{
    /// <summary>
    /// 数据库常量
    /// </summary>
    public sealed class DbConstants
    {
        /// <summary>
        /// 数据库配置文件:配置关键字
        /// </summary>
        public const string PROJECT_DB_CONNECTION = "DbConnection";

        /// <summary>
        /// 数据库配置文件:数据库关键字
        /// </summary>
        public const string PROJECT_DB_CONNECTION_KEY = "Key";

        /// <summary>
        /// 数据库配置文件:数据库链接
        /// </summary>
        public const string PROJECT_DB_CONNECTION_CONNECTIONSTRING = "ConnectionString";

        /// <summary>
        /// 数据库配置文件:数据库类型
        /// </summary>
        public const string PROJECT_DB_CONNECTION_DB_TYPE = "DbType";
    }
}
