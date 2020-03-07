using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace CommonUtil
{
    /// <summary>
    /// Long强后转
    /// </summary>
    public class LongConvert : JsonConverter
    {
        /// <summary>
        /// 
        /// </summary>
        public LongConvert()
        {
        }
        /// <summary>
        /// 转成string类型
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.ToString());
        }

        /// <summary>
        /// 转换
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }
            JToken jt = JValue.ReadFrom(reader);
            return jt.Value<long>();
        }


        /// <summary>
        /// 判断类型是否long
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            if (typeof(long).Equals(objectType) || typeof(long?).Equals(objectType))
            {
                return true;
            }
            return false;
        }
    }
}
