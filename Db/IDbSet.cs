using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CommonUtil
{
    /// <summary>
    ///  数据库操作扩展接口
    /// </summary>
    public interface IDbSet<T> where T : class, new()
    {
        #region Avg函数
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        TResult Avg<TResult>(Expression<Func<T, TResult>> avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="where">where函数表达式</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        TResult Avg<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="tableName">表名</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        TResult Avg<TResult>(string tableName, Expression<Func<T, TResult>> avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="tableName">表名</param>
        /// <param name="where">where函数表达式</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        TResult Avg<TResult>(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="tableName">表名</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        TResult Avg<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="tableName">表名</param>
        /// <param name="where">where函数表达式</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        TResult Avg<TResult>(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> avg);

        #endregion

        #region Sum函数
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="where"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        TResult Sum<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> sum);
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        TResult Sum<TResult>(string tableName, Expression<Func<T, TResult>> sum);
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        TResult Sum<TResult>(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> sum);
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        TResult Sum<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> sum);
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        TResult Sum<TResult>(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> sum);

        #endregion

        #region Min函数
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="min"></param>
        /// <returns></returns>
        TResult Min<TResult>(Expression<Func<T, TResult>> min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="where"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        TResult Min<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        TResult Min<TResult>(string tableName, Expression<Func<T, TResult>> min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        TResult Min<TResult>(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        TResult Min<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        TResult Min<TResult>(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> min);

        #endregion

        #region Max函数
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="max"></param>
        /// <returns></returns>
        TResult Max<TResult>(Expression<Func<T, TResult>> max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="where"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        TResult Max<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        TResult Max<TResult>(string tableName, Expression<Func<T, TResult>> max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        TResult Max<TResult>(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        TResult Max<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        TResult Max<TResult>(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> max);

        #endregion

        #region Count函数
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Count(Expression<Func<T, bool>> where);
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int Count(string tableName);
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Count(string tableName, Expression<Func<T, bool>> where);
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int Count(string storeName, string tableName);
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Count(string storeName, string tableName, Expression<Func<T, bool>> where);
        #endregion

        #region IsExist函数
        /// <summary>
        /// 是否存在，IsExist函数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        bool IsExist(Expression<Func<T, bool>> where);
        /// <summary>
        /// IsAny函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        bool IsExist(string tableName, Expression<Func<T, bool>> where);
        /// <summary>
        /// IsAny函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        bool IsExist(string storeName, string tableName, Expression<Func<T, bool>> where);
        #endregion

        #region 根据主键查询
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(long id);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T GetById(long id, string tableName);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T GetById(long id, string storeName, string tableName);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(string id);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T GetById(string id, string tableName);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T GetById(string id, string storeName, string tableName);

        #endregion

        #region 查询单条，多条会抛出异常
        /// <summary>
        /// 查询单条，多条会抛出异常
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T GetSingle(Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询单条，多条会抛出异常
        /// </summary>
        /// <param name="where"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T GetSingle(Expression<Func<T, bool>> where, string tableName);
        /// <summary>
        /// 查询单条，多条会抛出异常
        /// </summary>
        /// <param name="where"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T GetSingle(Expression<Func<T, bool>> where, string storeName, string tableName);

        #endregion

        #region 查询第一条
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T GetFirst(Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T GetFirst(string tableName);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        T GetFirst(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        T GetFirst(string tableName, Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T GetFirst(string storeName, string tableName);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        T GetFirst(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        T GetFirst(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        T GetFirst(string storeName, string tableName, Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        T GetFirst(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        T GetFirst(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        T GetFirst(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);

        #endregion

        #region 查询全部
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);

        #endregion

        #region 分页查询全部
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);

        #endregion

        #region 查询指定列
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having);
        #endregion

        #region 分页查询指定列

        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="select"></param>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, Expression<Func<T, TResult>> select, string tableName, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount);
        /// <summary>
        /// 分页查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount);
        #endregion

        #region 联表查询指定列，简写
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();

        #endregion

        #region 联表查询指定列，自定义
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new();

        #endregion

        #region 分页联表查询指定列，简写
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, string tableName, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，简写
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        #endregion

        #region 分页联表查询指定列，自定义

        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, string tableName, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        #endregion

        #region 分页三表联表查询指定列，自定义

        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, string tableName, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        /// <summary>
        /// 分页三表联表查询指定列，自定义
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="join"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new();
        #endregion

        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Update(T t, Expression<Func<T, object>> update, Expression<Func<T, bool>> where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="tableName"></param>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Update(T t, string tableName, Expression<Func<T, object>> update, Expression<Func<T, bool>> where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Update(T t, string storeName, string tableName, Expression<Func<T, object>> update, Expression<Func<T, bool>> where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Update(Expression<Func<T, T>> set, Expression<Func<T, bool>> where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Update(string tableName, Expression<Func<T, T>> set, Expression<Func<T, bool>> where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        int Update(string storeName, string tableName, Expression<Func<T, T>> set, Expression<Func<T, bool>> where);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(long id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        bool Delete(string tableName, long id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        bool Delete(string storeName, string tableName, long id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int DeleteReturnCommand(string storeName, string tableName, long id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int DeleteRange(string storeName, string tableName, IEnumerable<long> id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(string id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        bool Delete(string tableName, string id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        bool Delete(string storeName, string tableName, string id);

        /// <summary>
        /// Delete函数,返回行数结果
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int DeleteReturnCommand(string storeName, string tableName, string id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int DeleteRange(string storeName, string tableName, IEnumerable<string> id);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Delete(Expression<Func<T, bool>> where);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="where"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int Delete(string tableName, Expression<Func<T, bool>> where);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="where"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        int Delete(string storeName, string tableName, Expression<Func<T, bool>> where);
        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Insert(T t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Insert(string tableName, T t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        bool Insert(string storeName, string tableName, T t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        T InsertReturnEntity(T t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T InsertReturnEntity(string tableName, T t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        T InsertReturnEntity(string storeName, string tableName, T t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="t"></param>
        /// <param name="insertColumns"></param>
        /// <param name="ignoreColumns"></param>
        /// <returns></returns>
        int Insert(string storeName, string tableName, T t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="insertColumns"></param>
        /// <param name="ignoreColumns"></param>
        /// <returns></returns>
        T InsertReturnEntity(string storeName, string tableName, T t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="insertColumns"></param>
        /// <param name="ignoreColumns"></param>
        /// <returns></returns>
        int InsertRange(string storeName, string tableName, IEnumerable<T> t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns);
        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        int InsertRange(IEnumerable<T> t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        int InsertRange(string tableName, IEnumerable<T> t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        int InsertRange(string storeName, string tableName, IEnumerable<T> t);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <returns></returns>
        int InsertRange(IEnumerable<T> t, Expression<Func<T, object>> insertColumns);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <returns></returns>
        int InsertRange(string tableName, IEnumerable<T> t, Expression<Func<T, object>> insertColumns);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <returns></returns>
        int InsertRange(string storeName, string tableName, IEnumerable<T> t, Expression<Func<T, object>> insertColumns);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <param name="ignoreColumns">忽略列</param>
        /// <returns></returns>
        int InsertRange(IEnumerable<T> t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <param name="ignoreColumns">忽略列</param>
        /// <returns></returns>
        int InsertRange(string tableName, IEnumerable<T> t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>影响行数</returns>
        int ExecuteCommand(string storeName, string sql, object parameters);
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>影响行数</returns>
        int ExecuteCommand(string sql, object parameters);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>影响行数</returns>
        int ExecuteCommand(string storeName, string sql, params SqlSugar.SugarParameter[] parameters);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>影响行数</returns>
        int ExecuteCommand(string sql, params SqlSugar.SugarParameter[] parameters);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>影响行数</returns>
        int ExecuteCommand(string storeName, string sql, List<SqlSugar.SugarParameter> parameters);
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>影响行数</returns>
        int ExecuteCommand(string sql, List<SqlSugar.SugarParameter> parameters);

        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string storeName, string sql, object parameters);

        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string sql, object parameters);

        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string storeName, string sql, params SqlSugar.SugarParameter[] parameters);

        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string sql, params SqlSugar.SugarParameter[] parameters);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>影响行数</returns>
        List<TResult> SqlQuery<TResult>(string storeName, string sql, List<SqlSugar.SugarParameter> parameters);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>影响行数</returns>
        List<TResult> SqlQuery<TResult>(string sql, List<SqlSugar.SugarParameter> parameters);

        /// <summary>
        /// sql分页查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="totalCount">总数</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string storeName, string sql, int pageIndex, int pageSize, ref int totalCount, params SqlSugar.SugarParameter[] parameters) where TResult : class, new();

        /// <summary>
        /// sql分页查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="totalCount">总数</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string sql, int pageIndex, int pageSize, ref int totalCount, params SqlSugar.SugarParameter[] parameters) where TResult : class, new();

        /// <summary>
        /// sql分页查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="totalCount">总数</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string storeName, string sql, int pageIndex, int pageSize, ref int totalCount, object parameters) where TResult : class, new();

        /// <summary>
        /// sql分页查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="totalCount">总数</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string sql, int pageIndex, int pageSize, ref int totalCount, object parameters) where TResult : class, new();

        /// <summary>
        /// sql分页查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="totalCount">总数</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string storeName, string sql, int pageIndex, int pageSize, ref int totalCount, List<SqlSugar.SugarParameter> parameters) where TResult : class, new();

        /// <summary>
        /// sql分页查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="totalCount">总数</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        List<TResult> SqlQuery<TResult>(string sql, int pageIndex, int pageSize, ref int totalCount, List<SqlSugar.SugarParameter> parameters) where TResult : class, new();

        /// <summary>
        /// 使用事务
        /// </summary>
        /// <param name="action">执行委托</param>
        /// <returns></returns>
        SqlSugar.DbResult<bool> UseTran(Action action);

        /// <summary>
        /// 使用事务
        /// </summary>
        /// <param name="action">执行委托</param>
        /// <param name="errorCallBack">错误回调委托</param>
        /// <returns></returns>
        SqlSugar.DbResult<bool> UseTran(Action action, Action<Exception> errorCallBack);
    }
}