using Newtonsoft.Json;

namespace CommonUtil
{
    /// <summary>
    /// JSON工具类
    /// </summary>
    public static class JSONUtil
    {
        /// <summary>
        /// 把对象转换为JSON字符串。
        /// </summary>
        public static string ObjectToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// 把JSON字符串转换为对象。
        /// </summary>
        public static object JsonToObject(this string json)
        {
            return JsonConvert.DeserializeObject(json);
        }

        /// <summary>
        /// 把JSON字符串转换为对象。
        /// </summary>
        public static T JsonToObject<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
