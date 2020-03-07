namespace CommonUtil
{
    /// <summary>
    /// </summary>
    public class DbConnection
    {
        /// <summary>
        /// 数据库简称,键,唯一不可重复
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DbType { get; set; }

        /// <summary>
        /// 数据库链接字符串
        /// </summary>
        public string ConnectionString { get; set; }
    }
}
