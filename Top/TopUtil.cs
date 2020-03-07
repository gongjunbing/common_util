using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Snowflake.Core;

namespace CommonUtil
{
    /// <summary>
    /// 公共类
    /// </summary>
    public class TopUtil
    {
        #region 雪花算法
        /// <summary>
        /// snowflake对象
        /// </summary>
        private static IdWorker worker = new IdWorker(1, 1);

        /// <summary>
        /// 生成唯一Id
        /// </summary>
        /// <returns>string</returns>
        public static long GetId()
        {
            long snowId = worker.NextId();
            return snowId;
        } 
        #endregion

        /// <summary>  
        /// 获取程序集中的实现类对应的多个接口
        /// </summary>  
        /// <param name="assemblyName">程序集</param>
        /// <param name="ignoreName">忽略名称</param>
        /// <param name="whereExpression">where条件表达式</param>
        public static Dictionary<Type, Type> AssemblyLoad(string assemblyName, string ignoreName, Func<Type, bool> whereExpression)
        {
            Assembly assembly = Assembly.Load(assemblyName);
            IEnumerable<Type> typeEnumerable = assembly.ExportedTypes;

            //排除基类服务
            IEnumerator<Type> typeEnumerator = typeEnumerable.Where(whereExpression).GetEnumerator();

            Dictionary<Type, Type> result = new Dictionary<Type, Type>();

            while (typeEnumerator.MoveNext())
            {
                Type implementType = typeEnumerator.Current;

                Type interfaceType = implementType.GetInterfaces().Single(j => !j.Name.Contains(ignoreName));

                if (!result.ContainsKey(implementType))
                {
                    result.Add(implementType, interfaceType);
                }
            }

            return result;
        }

        /// <summary>
        /// 阳历转化为农历
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static string GetCNYear(int year, int month, int day)
        {
            string[] gan = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };
            string[] zhi = { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };
            string[] shengxiao = { "鼠", "牛", "虎", "免", "龙", "蛇", "马", "羊", "猴", "鸡", "狗", "猪" };
            ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();
            DateTime date = new DateTime(year, month, day);

            int nlyear = calendar.GetYear(date);

            //确定年份,基准1804为甲子年,鼠年
            //天干年
            string zy = string.Empty;
            //地支年
            string dy = string.Empty;
            //生肖年
            string sxnian = string.Empty;
            if (nlyear > 3)
            {
                int zhiyear = (nlyear - 4) % 10;
                int diyear = (nlyear - 4) % 12;
                zy = gan[zhiyear];
                dy = zhi[diyear];
                sxnian = shengxiao[diyear];
            }

            //转化的最终农历年
            string datestr = zy + dy + "(" + nlyear + ")" + "年" + "  生肖:" + sxnian;

            return datestr;
        }

        /// <summary>
        /// 阳历转化为农历
        /// </summary>
        /// <param name="time">阳历时间</param>
        /// <returns></returns>
        public static int[] GetCNTime(DateTime time)
        {
            ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();

            int nlyear = calendar.GetYear(time);
            int nlmonth = calendar.GetMonth(time);
            int nlday = calendar.GetDayOfMonth(time);

            //判断是否有闰月 ,leap=0即没有闰月
            int leapmonth = calendar.GetLeapMonth(nlyear);
            if (leapmonth > 0)
            {
                if (leapmonth <= nlmonth)
                {
                    nlmonth--;
                }
            }

            return new int[] { nlyear, nlmonth, nlday };
        }

        /// <summary>
        /// 获取从1970年1月1日到现在的毫秒总数。
        /// </summary>
        /// <returns>毫秒数</returns>
        public static long GetCurrentTimeMillis()
        {
            return (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }


    }
}
