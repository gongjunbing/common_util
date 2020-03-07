using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.Binder;
using System.Collections.Generic;

namespace CommonUtil
{
    /// <summary>
    /// 配置工具类
    /// </summary>
    public class ConfigUtil
    {
        /// <summary>
        /// 配置项容器
        /// </summary>
        public static IConfiguration Configuration { get; set; }

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static ConfigUtil()
        {
            string fileName = "appsettings.json";

            string directory = AppContext.BaseDirectory;
            directory = directory.Replace("\\", "/");

            string filePath = $"{directory}/{fileName}";
            if (!File.Exists(filePath))
            {
                int length = directory.IndexOf("/bin");
                filePath = $"{directory.Substring(0, length)}/{fileName}";
            }

            Configuration = new ConfigurationBuilder()
                .Add(new JsonConfigurationSource { Path = fileName, ReloadOnChange = true })
                .Build();
        }

        /// <summary>
        /// 读取配置文件值
        /// </summary>
        /// <typeparam name="T">指定类型</typeparam>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static T GetValue<T>(string key)
        {
            return GetValue(key, default(T));
        }

        /// <summary>
        /// 读取配置文件值
        /// </summary>
        /// <typeparam name="T">指定类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="defaultValue">如果未找到该键，则过载允许你提供默认值</param>
        /// <returns></returns>
        public static T GetValue<T>(string key, T defaultValue)
        {
            return Configuration.GetValue<T>(key, defaultValue);
        }

        /// <summary>
        /// 判断是否存在key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool IsExist(string key)
        {
            return Configuration.GetSection(key).Exists();
        }

        /// <summary>
        /// 判断是否存在key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static IEnumerable<IConfigurationSection> GetChildren(string key)
        {
            return Configuration.GetSection(key).GetChildren();
        }
    }
}
