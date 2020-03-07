using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace CommonUtil
{
    /// <summary>
    /// Lambda扩展方法
    /// </summary>
    public static partial class ExtendUtil
    {
        /// <summary>
        /// 若符合条件，执行where
        /// </summary>
        /// <typeparam name="T">IQueryable</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="predicate">where表达式</param>
        /// <returns></returns>
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, bool condition, Expression<Func<T, bool>> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }

        /// <summary>
        /// 若符合条件，执行where
        /// </summary>
        /// <typeparam name="T">IQueryable</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="predicate">where表达式</param>
        /// <returns></returns>
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, bool condition, Expression<Func<T, int, bool>> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }

        /// <summary>
        /// 若符合条件，执行where
        /// </summary>
        /// <typeparam name="T">IEnumerable</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="predicate">where表达式</param>
        /// <returns></returns>
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool condition, Func<T, bool> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }

        /// <summary>
        /// 若符合条件，执行where
        /// </summary>
        /// <typeparam name="T">IEnumerable</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="predicate">where表达式</param>
        /// <returns></returns>
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source, bool condition, Func<T, int, bool> predicate)
        {
            return condition ? source.Where(predicate) : source;
        }

        /// <summary>
        /// 自定义排序
        /// </summary>
        /// <typeparam name="TSource">IQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="orderByEnum">排序枚举</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderBy<TSource, Tkey>(this IQueryable<TSource> source, OrderByEnum orderByEnum, Expression<Func<TSource, Tkey>> keySelector)
        {
            return OrderByEnum.ASC == orderByEnum ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
        }

        /// <summary>
        /// 若符合条件，则自定义排序
        /// </summary>
        /// <typeparam name="TSource">IQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="orderByEnum">排序枚举</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderByIf<TSource, Tkey>(this IQueryable<TSource> source, bool condition, OrderByEnum orderByEnum, Expression<Func<TSource, Tkey>> keySelector)
        {
            return condition ? OrderByEnum.ASC == orderByEnum ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector)
                             : (IOrderedQueryable<TSource>)source;
        }

        /// <summary>
        /// 满足条件执行true情况排序，否则执行false情况排序
        /// </summary>
        /// <typeparam name="TSource">IQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="trueOrderByEnum">true情况排序枚举</param>
        /// <param name="falseOrderByEnum">false情况排序枚举</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderByIf<TSource, Tkey>(this IQueryable<TSource> source, bool condition, OrderByEnum trueOrderByEnum, OrderByEnum falseOrderByEnum, Expression<Func<TSource, Tkey>> keySelector)
        {
            return condition ? OrderByEnum.ASC == trueOrderByEnum ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector)
                             : OrderByEnum.ASC == falseOrderByEnum ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
        }

        /// <summary>
        /// 满足条件执行true情况排序，否则执行false情况排序
        /// </summary>
        /// <typeparam name="TSource">IQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="orderByEnum">排序枚举</param>
        /// <param name="trueKeySelector">true排序表达式</param>
        /// <param name="falseKeySelector">false排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderByIf<TSource, Tkey>(this IQueryable<TSource> source, bool condition, OrderByEnum orderByEnum, Expression<Func<TSource, Tkey>> trueKeySelector, Expression<Func<TSource, Tkey>> falseKeySelector)
        {
            return condition ? OrderByEnum.ASC == orderByEnum ? source.OrderBy(trueKeySelector) : source.OrderByDescending(trueKeySelector)
                             : OrderByEnum.ASC == orderByEnum ? source.OrderBy(falseKeySelector) : source.OrderByDescending(falseKeySelector);
        }

        /// <summary>
        /// 若符合条件，升序排序
        /// </summary>
        /// <typeparam name="TSource">IQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderByAscIf<TSource, Tkey>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, Tkey>> keySelector)
        {
            return condition ? source.OrderBy(keySelector) : (IOrderedQueryable<TSource>)source;
        }

        /// <summary>
        /// 若符合true条件，升序true排序表达式
        /// </summary>
        /// <typeparam name="TSource">IQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="trueKeySelector">true排序表达式</param>
        /// <param name="falseKeySelector">false排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderByAscIf<TSource, Tkey>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, Tkey>> trueKeySelector, Expression<Func<TSource, Tkey>> falseKeySelector)
        {
            return condition ? source.OrderBy(trueKeySelector) : source.OrderBy(falseKeySelector);
        }

        /// <summary>
        /// 若符合条件，降序排序
        /// </summary>
        /// <typeparam name="TSource">IQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderByDescendingIf<TSource, Tkey>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, Tkey>> keySelector)
        {
            return condition ? source.OrderByDescending(keySelector) : (IOrderedQueryable<TSource>)source;
        }

        /// <summary>
        /// 若符合true条件，降序true排序表达式
        /// </summary>
        /// <typeparam name="TSource">IQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="trueKeySelector">true排序表达式</param>
        /// <param name="falseKeySelector">false排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> OrderByDescendingIf<TSource, Tkey>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, Tkey>> trueKeySelector, Expression<Func<TSource, Tkey>> falseKeySelector)
        {
            return condition ? source.OrderByDescending(trueKeySelector) : source.OrderByDescending(falseKeySelector);
        }

        /// <summary>
        /// 若符合条件，true排序类型排序
        /// </summary>
        /// <typeparam name="TSource">IOrderedQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="trueOrderByEnum">true排序类型</param>
        /// <param name="falseOrderByEnum">false排序类型</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> ThenByIf<TSource, Tkey>(this IOrderedQueryable<TSource> source, bool condition, OrderByEnum trueOrderByEnum, OrderByEnum falseOrderByEnum, Expression<Func<TSource, Tkey>> keySelector)
        {
            return condition ? OrderByEnum.ASC == trueOrderByEnum ? source.ThenBy(keySelector) : source.ThenByDescending(keySelector)
                             : OrderByEnum.ASC == falseOrderByEnum ? source.ThenBy(keySelector) : source.ThenByDescending(keySelector);
        }

        /// <summary>
        /// 若符合条件，true排序表达式排序
        /// </summary>
        /// <typeparam name="TSource">IOrderedQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="orderByEnum">条件</param>
        /// <param name="trueKeySelector">true排序表达式</param>
        /// <param name="falseKeySelector">false排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> ThenByIf<TSource, Tkey>(this IOrderedQueryable<TSource> source, bool condition, OrderByEnum orderByEnum, Expression<Func<TSource, Tkey>> trueKeySelector, Expression<Func<TSource, Tkey>> falseKeySelector)
        {
            return condition ? OrderByEnum.ASC == orderByEnum ? source.OrderBy(trueKeySelector) : source.ThenByDescending(trueKeySelector)
                             : OrderByEnum.ASC == orderByEnum ? source.OrderBy(falseKeySelector) : source.ThenByDescending(falseKeySelector);
        }

        /// <summary>
        /// 若符合条件，升序
        /// </summary>
        /// <typeparam name="TSource">IOrderedQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> ThenByAscIf<TSource, Tkey>(this IOrderedQueryable<TSource> source, bool condition, Expression<Func<TSource, Tkey>> keySelector)
        {
            return condition ? source.ThenBy(keySelector) : source;
        }

        /// <summary>
        /// 若符合true条件，true表达式升序
        /// </summary>
        /// <typeparam name="TSource">IOrderedQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="trueKeySelector">true排序表达式</param>
        /// <param name="falseKeySelector">true排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> ThenByAscIf<TSource, Tkey>(this IOrderedQueryable<TSource> source, bool condition, Expression<Func<TSource, Tkey>> trueKeySelector, Expression<Func<TSource, Tkey>> falseKeySelector)
        {
            return condition ? source.ThenBy(trueKeySelector) : source.ThenBy(falseKeySelector);
        }

        /// <summary>
        /// 若符合true条件，true表达式降序
        /// </summary>
        /// <typeparam name="TSource">IOrderedQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> ThenByDescendingIf<TSource, Tkey>(this IOrderedQueryable<TSource> source, bool condition, Expression<Func<TSource, Tkey>> keySelector)
        {
            return condition ? source.ThenByDescending(keySelector) : source;
        }

        /// <summary>
        /// 若符合条件，降序
        /// </summary>
        /// <typeparam name="TSource">IOrderedQueryable</typeparam>
        /// <typeparam name="Tkey">排序关键字</typeparam>
        /// <param name="source">数据源</param>
        /// <param name="condition">条件</param>
        /// <param name="trueKeySelector">true排序表达式</param>
        /// <param name="falseKeySelector">true排序表达式</param>
        /// <returns></returns>
        public static IOrderedQueryable<TSource> ThenByDescendingIf<TSource, Tkey>(this IOrderedQueryable<TSource> source, bool condition, Expression<Func<TSource, Tkey>> trueKeySelector, Expression<Func<TSource, Tkey>> falseKeySelector)
        {
            return condition ? source.ThenByDescending(trueKeySelector) : source.ThenByDescending(falseKeySelector);
        }

    }

    /// <summary>
    /// 排序类型枚举
    /// </summary>
    public enum OrderByEnum
    {
        /// <summary>
        /// 升序
        /// </summary>
        [Description("升序")]
        ASC,
        /// <summary>
        /// 降序
        /// </summary>
        [Description("降序")]
        DESCENDING
    }
}
