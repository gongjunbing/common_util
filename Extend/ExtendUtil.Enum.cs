using System.ComponentModel;

namespace CommonUtil
{
    /// <summary>
    /// 枚举扩展方法
    /// </summary>
    public static partial class ExtendUtil
    {
        /// <summary>
        /// 获取枚举的描述
        /// </summary>
        /// <param name="value">数据</param>
        /// <returns>string</returns>
        public static string GetDescription(this System.Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            return value.ToString();

        }

        /// <summary>
        /// 获取枚举的value
        /// </summary>
        /// <param name="value">数据</param>
        /// <returns>int</returns>
        public static int ToInt(this System.Enum value)
        {
            return value.GetHashCode();
        }

        /// <summary>
        /// 获取枚举字符串
        /// </summary>
        /// <param name="enumName"></param>
        /// <returns></returns>
        public static string GetEnumName(this System.Enum enumName)
        {
            return enumName.ToString();
        }

        /// <summary>
        /// 获取枚举字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumName<T>(this int enumValue)
        {
            return System.Enum.GetName(typeof(T), enumValue);
        }

        /// <summary>
        /// 获取枚举描述
        /// </summary>
        /// <typeparam name="T">枚举类型</typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetDescription<T>(this string enumValue)
        {
            System.Reflection.FieldInfo field = typeof(T).GetField(enumValue);
            //获取描述属性
            object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            //当描述属性没有时，直接返回名称
            if (objs == null || objs.Length == 0)
            {
                return "";
            }
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute)objs[0];
            return descriptionAttribute.Description;
        }
    }
}
