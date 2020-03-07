using SqlSugar;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CommonUtil
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class DbContext
    {
        /// <summary>
        /// 用来处理Db操作
        /// </summary>
        protected SqlSugarClient Db;

        /// <summary>
        /// 初始化数据库上下文实例
        /// </summary>
        public DbContext()
        {
            List<DbConnection> dbList = ListGetDbConnection();

            if (dbList.Count == 0)
            {
                throw new ArgumentNullException("未配置数据库连接字符串");
            }

            List<ConnectionConfig> connectionList = ListGetConnectionConfig(dbList);

            Db = new SqlSugarClient(connectionList);
        }

        /// <summary>
        /// 获取配置文件的数据库集合
        /// </summary>
        /// <returns></returns>
        private List<DbConnection> ListGetDbConnection()
        {
            if (!ConfigUtil.IsExist(DbConstants.PROJECT_DB_CONNECTION))
            {
                throw new ArgumentNullException("未在配置文件中找到DbConnection!!!");
            }
            List<DbConnection> dbList = new List<DbConnection>();
            var dbConfigList = ConfigUtil.GetChildren(DbConstants.PROJECT_DB_CONNECTION);

            var dbConfigListor = dbConfigList.GetEnumerator();

            while (dbConfigListor.MoveNext())
            {
                var item = dbConfigListor.Current;

                var key = ConfigUtil.GetValue<string>($"{item.Path}:{DbConstants.PROJECT_DB_CONNECTION_KEY}");
                var connectionString = ConfigUtil.GetValue<string>($"{item.Path}:{DbConstants.PROJECT_DB_CONNECTION_CONNECTIONSTRING}");
                var dbType = ConfigUtil.GetValue<string>($"{item.Path}:{DbConstants.PROJECT_DB_CONNECTION_DB_TYPE}");

                dbList.Add(new DbConnection
                {
                    Key = key,
                    ConnectionString = connectionString,
                    DbType = dbType
                });
            }

            return dbList;
        }

        /// <summary>
        /// 获取数据库链接集合
        /// </summary>
        /// <param name="dbList">数据库配置集合</param>
        /// <returns></returns>
        private List<ConnectionConfig> ListGetConnectionConfig(List<DbConnection> dbList)
        {
            List<ConnectionConfig> connectionList = new List<ConnectionConfig>();

            foreach (DbConnection item in dbList)
            {
                ConnectionConfig connectionConfig = new ConnectionConfig
                {
                    ConfigId = item.Key,
                    ConnectionString = item.ConnectionString,
                    DbType = GetDbType(item.DbType),
                    IsAutoCloseConnection = true,
                    AopEvents = GetAopEvents()
                };

                connectionList.Add(connectionConfig);
            }

            return connectionList;
        }

        /// <summary>
        /// 获取数据库类型,默认PostgreSQL
        /// </summary>
        /// <param name="type">MySql/SqlServer/Sqlite/Oracle/PostgreSQL</param>
        /// <returns></returns>
        private DbType GetDbType(string type)
        {
            return Enum.TryParse(type, out DbType dbType) ? dbType : DbType.PostgreSQL;
        }

        /// <summary>
        /// 获取AOP事件
        /// </summary>
        /// <returns></returns>
        private AopEvents GetAopEvents()
        {
            AopEvents events = new AopEvents
            {
                //执行SQL前触发
                OnLogExecuting = (sql, pars) =>
                {
                },

                //执行SQL完触发
                OnLogExecuted = (sql, pars) =>
                {
                    //SQL执行时间
                    TimeSpan excuteTime = Db.Ado.SqlExecutionTime;

                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine($"SQL：{sql}");
                    sb.AppendLine($"SQL参数：{string.Join(",", pars?.Select(it => it.ParameterName + ":" + it.Value))}");
                    sb.AppendLine($"SQL执行时间：{excuteTime}");

#if DEBUG
                    Debug.WriteLine(sb.ToString(), "SQL执行日志");
#else
                    LogUtil.Info(sb.ToString(), "SQL执行日志");
#endif
                },

                //执行SQL出错触发
                OnError = (exp) =>
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine($"SQL：{exp.Sql}");
                    sb.AppendLine($"SQL参数：{exp.Parametres}");
                    sb.AppendLine($"异常信息：{exp.Message}");

#if DEBUG
                    Debug.WriteLine(sb.ToString(), "SQL执行错误日志");
#else
                    LogUtil.Error(sb.ToString(), "SQL执行错误日志", exp);
#endif
                },

                ////数据变化事件触发
                //OnDiffLogEvent = it =>
                //{
                //    var editBeforeData = it.BeforeData;
                //    var editAfterData = it.AfterData;
                //    var sql = it.Sql;
                //    var parameter = it.Parameters;
                //    var businessData = it.BusinessData;
                //    var time = it.Time;
                //    //enum insert 、update and delete  
                //    var diffType = it.DiffType;

                //    StringBuilder sb = new StringBuilder();

                //    sb.AppendLine($"事件业务参数：{businessData}");
                //    sb.AppendLine($"修改前值：{Db.Utilities.SerializeObject(editBeforeData)}");
                //    sb.AppendLine($"修改为值：{Db.Utilities.SerializeObject(editAfterData)}");

                //    LogUtil.Info(sb.ToString(), "SQL执行日志");

                //    //Console.WriteLine(businessData);
                //    //Console.WriteLine(editBeforeData[0].Columns[1].Value);
                //    //Console.WriteLine("to");
                //    //Console.WriteLine(editAfterData[0].Columns[1].Value);
                //    //Write logic
                //}
            };

            return events;
        }
    }
}
