using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace CommonUtil
{
    /// <summary>
    ///  数据库操作扩展
    /// </summary>
    public abstract class DbSet<T> : DbContext, IDbSet<T> where T : class, new()
    {
        #region Avg函数
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        public virtual TResult Avg<TResult>(Expression<Func<T, TResult>> avg) => Avg(null, null, null, avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="where">where函数表达式</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        public virtual TResult Avg<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> avg) => Avg(null, null, where, avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="tableName">表名</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        public virtual TResult Avg<TResult>(string tableName, Expression<Func<T, TResult>> avg) => Avg(null, null, null, avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="tableName">表名</param>
        /// <param name="where">where函数表达式</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        public virtual TResult Avg<TResult>(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> avg) => Avg(null, tableName, where, avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="tableName">表名</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        public virtual TResult Avg<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> avg) => Avg(storeName, tableName, null, avg);
        /// <summary>
        /// Avg函数
        /// </summary>
        /// <typeparam name="TResult">返回值</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="tableName">表名</param>
        /// <param name="where">where函数表达式</param>
        /// <param name="avg">avg函数表达式</param>
        /// <returns></returns>
        public virtual TResult Avg<TResult>(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> avg)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            return queryable.Avg(avg);
        }

        #endregion

        #region Sum函数
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="where"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public virtual TResult Sum<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> sum) => Sum(null, null, where, sum);
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public virtual TResult Sum<TResult>(string tableName, Expression<Func<T, TResult>> sum) => Sum(null, tableName, null, sum);
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public virtual TResult Sum<TResult>(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> sum) => Sum(null, tableName, where, sum);
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public virtual TResult Sum<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> sum) => Sum(storeName, tableName, null, sum);
        /// <summary>
        /// Sum函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public virtual TResult Sum<TResult>(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> sum)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            return queryable.Sum(sum);
        }

        #endregion

        #region Min函数
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="min"></param>
        /// <returns></returns>
        public virtual TResult Min<TResult>(Expression<Func<T, TResult>> min) => Min(null, null, null, min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="where"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public virtual TResult Min<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> min) => Min(null, null, where, min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public virtual TResult Min<TResult>(string tableName, Expression<Func<T, TResult>> min) => Min(null, tableName, null, min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public virtual TResult Min<TResult>(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> min) => Min(null, tableName, where, min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public virtual TResult Min<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> min) => Min(storeName, tableName, null, min);
        /// <summary>
        /// Min函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public virtual TResult Min<TResult>(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> min)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            return queryable.Min(min);
        }

        #endregion

        #region Max函数
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="max"></param>
        /// <returns></returns>
        public virtual TResult Max<TResult>(Expression<Func<T, TResult>> max) => Max(null, null, null, max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="where"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public virtual TResult Max<TResult>(Expression<Func<T, bool>> where, Expression<Func<T, TResult>> max) => Max(null, null, where, max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public virtual TResult Max<TResult>(string tableName, Expression<Func<T, TResult>> max) => Max(null, tableName, null, max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public virtual TResult Max<TResult>(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> max) => Max(null, tableName, where, max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public virtual TResult Max<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> max) => Max(storeName, tableName, null, max);
        /// <summary>
        /// Max函数
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public virtual TResult Max<TResult>(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, TResult>> max)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            return queryable.Max(max);
        }

        #endregion

        #region Count函数
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Count(Expression<Func<T, bool>> where) => Count(null, null, where);
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual int Count(string tableName) => Count(null, tableName, null);
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Count(string tableName, Expression<Func<T, bool>> where) => Count(null, tableName, where);
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual int Count(string storeName, string tableName) => Count(storeName, tableName, null);
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Count(string storeName, string tableName, Expression<Func<T, bool>> where)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            return queryable.Count();
        }
        #endregion

        #region IsExist函数
        /// <summary>
        /// 是否存在，IsExist函数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual bool IsExist(Expression<Func<T, bool>> where) => IsExist(null, null, where);
        /// <summary>
        /// IsAny函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual bool IsExist(string tableName, Expression<Func<T, bool>> where) => IsExist(null, tableName, where);
        /// <summary>
        /// IsAny函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual bool IsExist(string storeName, string tableName, Expression<Func<T, bool>> where)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            return queryable.Any();
        }
        #endregion

        #region 根据主键查询
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetById(long id) => GetById(id, null, null);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T GetById(long id, string tableName) => GetById(id, null, tableName);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T GetById(long id, string storeName, string tableName)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            return queryable.InSingle(id);
        }
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetById(string id) => GetById(id, null, null);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T GetById(string id, string tableName) => GetById(id, null, tableName);
        /// <summary>
        /// 根据主键查询
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T GetById(string id, string storeName, string tableName)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            return queryable.InSingle(id);
        }

        #endregion

        #region 查询单条，多条会抛出异常
        /// <summary>
        /// 查询单条，多条会抛出异常
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T GetSingle(Expression<Func<T, bool>> where) => GetSingle(where, null, null);
        /// <summary>
        /// 查询单条，多条会抛出异常
        /// </summary>
        /// <param name="where"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T GetSingle(Expression<Func<T, bool>> where, string tableName) => GetSingle(where, null, tableName);
        /// <summary>
        /// 查询单条，多条会抛出异常
        /// </summary>
        /// <param name="where"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T GetSingle(Expression<Func<T, bool>> where, string storeName, string tableName)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            return queryable.Single(where);
        }

        #endregion

        #region 查询第一条
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T GetFirst(Expression<Func<T, bool>> where) => GetFirst(null, null, where, null, null);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T GetFirst(string tableName) => GetFirst(null, tableName, null, null, null);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual T GetFirst(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => GetFirst(null, null, null, order, orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T GetFirst(string tableName, Expression<Func<T, bool>> where) => GetFirst(null, tableName, where, null, null);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T GetFirst(string storeName, string tableName) => GetFirst(storeName, tableName, null, null, null);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual T GetFirst(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => GetFirst(null, null, where, order, orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual T GetFirst(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => GetFirst(null, tableName, null, order, orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual T GetFirst(string storeName, string tableName, Expression<Func<T, bool>> where) => GetFirst(storeName, tableName, where, null, null);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual T GetFirst(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => GetFirst(null, tableName, where, order, orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual T GetFirst(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => GetFirst(storeName, tableName, null, order, orderBy);
        /// <summary>
        /// 查询第一条
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual T GetFirst(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            return queryable.First();
        }

        #endregion

        #region 查询全部
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, object>> groupBy) => ListGet(null, null, null, null, null, groupBy, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, bool>> where) => ListGet(null, tableName: null, where: where, order: null, orderBy: null, groupBy: null, having: null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName) => ListGet(null, tableName, null, null, null, null, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, null, null, null, null, groupBy, having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy) => ListGet(null, null, where, order: null, orderBy: null, groupBy: groupBy, having: null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, null, null, null, groupBy, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(null, null, null, order, orderBy, null, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, bool>> where) => ListGet(null, tableName: tableName, where: where, order: null, orderBy: null, groupBy: null, having: null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName) => ListGet(storeName, tableName, null, null, null, null, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, null, null, null, groupBy, having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, where, order: null, orderBy: null, groupBy: groupBy, having: null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, null, null, null, groupBy, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(null, null, where, order, orderBy, null, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(null, tableName, null, order, orderBy, null, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where) => ListGet(storeName, tableName: tableName, where: where, order: null, orderBy: null, groupBy: null, having: null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, null, null, order, orderBy, groupBy, having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, where, order: null, orderBy: null, groupBy: groupBy, having: having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(storeName, tableName, null, null, null, groupBy, having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(null, null, where, order, orderBy, groupBy, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, null, order, orderBy, groupBy, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, where, order: null, orderBy: null, groupBy: groupBy, having: null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(null, tableName, where, order, orderBy, null, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(storeName, tableName, null, order, orderBy, null, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, null, where, order, orderBy, groupBy, having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, null, order, orderBy, groupBy, having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(storeName, tableName, where, order: null, orderBy: null, groupBy: groupBy, having: having);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, where, order, orderBy, groupBy, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, null, order, orderBy, groupBy, null);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(storeName, tableName, where, order, orderBy, null, null);
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
        public virtual List<T> ListGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, where, order, orderBy, groupBy, having);
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
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(storeName, tableName, null, order, orderBy, groupBy, having);
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
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, where, order, orderBy, groupBy, null);
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
        public virtual List<T> ListGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.ToList();
        }

        #endregion

        #region 分页查询全部
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName: null, tableName: null, where: where, order: null, orderBy: null, groupBy: null, having: null, pageIndex: pageIndex, pageSize: pageSize, totalCount: ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(string tableName, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName: null, tableName: tableName, where: where, order: null, orderBy: null, groupBy: null, having: null, pageIndex: pageIndex, pageSize: pageSize, totalCount: ref totalCount);
        /// <summary>
        /// 分页查询全部
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public virtual List<T> ListPageGet(string storeName, string tableName, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName: storeName, tableName: tableName, where: where, order: null, orderBy: null, groupBy: null, having: null, pageIndex: pageIndex, pageSize: pageSize, totalCount: ref totalCount);
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
        public virtual List<T> ListPageGet(Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, null, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(null, tableName, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet(storeName, tableName, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<T> ListPageGet(string storeName, string tableName, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.ToPageList(pageIndex, pageSize, ref totalCount);
        }

        #endregion

        #region 查询指定列
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy) => ListGet(null, null, select, null, null, null, groupBy, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where) => ListGet(null, null, select, where, null, null, null, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select) => ListGet(null, tableName, select, null, null, null, null, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, null, select, null, null, null, groupBy, having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy) => ListGet(null, null, select, where, null, null, groupBy, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, select, null, null, null, groupBy, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(null, null, select, null, order, orderBy, null, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="orderField"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, string orderField) => ListGet(null, null, select, null, orderField, null, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where) => ListGet(null, tableName, select, where, null, null, null, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select) => ListGet(storeName, tableName, select, null, null, null, null, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, select, null, null, null, groupBy, having);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, select, where, null, null, groupBy, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, select, null, null, null, groupBy, null);
        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(null, null, select, where, order, orderBy, null, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField) => ListGet(null, null, select, where, orderField, null, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="order"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(null, tableName, select, null, order, orderBy, null, null);


        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="orderField"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, string orderField) => ListGet(null, tableName, select, null, orderField, null, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where) => ListGet(storeName, tableName, select, where, null, null, null, null);
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
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, null, select, null, order, orderBy, groupBy, having);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, string orderField, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, null, select, null, orderField, groupBy, having);

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
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, select, where, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(storeName, tableName, select, null, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(null, null, select, where, order, orderBy, groupBy, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField, Expression<Func<T, object>> groupBy) => ListGet(null, null, select, where, orderField, groupBy, null);

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
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, select, null, order, orderBy, groupBy, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, string orderField, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, select, null, orderField, groupBy, null);

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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, select, where, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(null, tableName, select, where, order, orderBy, null, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField) => ListGet(null, tableName, select, where, orderField, null, null);

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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(storeName, tableName, select, null, order, orderBy, null, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="orderField"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, string orderField) => ListGet(storeName, tableName, select, null, orderField, null, null);

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
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, null, select, where, order, orderBy, groupBy, having);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, null, select, where, orderField, groupBy, having);

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
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, select, null, order, orderBy, groupBy, having);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, string orderField, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, select, null, orderField, groupBy, having);

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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(storeName, tableName, select, where, null, null, groupBy, having);

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
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, select, where, order, orderBy, groupBy, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField, Expression<Func<T, object>> groupBy) => ListGet(null, tableName, select, where, orderField, groupBy, null);

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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, select, null, order, orderBy, groupBy, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, string orderField, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, select, null, orderField, groupBy, null);


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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy) => ListGet(storeName, tableName, select, where, order, orderBy, null, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField) => ListGet(storeName, tableName, select, where, orderField, null, null);

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
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, select, where, order, orderBy, groupBy, having);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(null, tableName, select, where, orderField, groupBy, having);


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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(storeName, tableName, select, null, order, orderBy, groupBy, having);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, string orderField, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having) => ListGet(storeName, tableName, select, null, orderField, groupBy, having);


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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, select, where, order, orderBy, groupBy, null);

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField, Expression<Func<T, object>> groupBy) => ListGet(storeName, tableName, select, where, orderField, groupBy, null);

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
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.Select(select).ToList();
        }

        /// <summary>
        /// 查询指定列
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderField"></param>
        /// <param name="groupBy"></param>
        /// <param name="having"></param>
        /// <returns></returns>
        public virtual List<TResult> ListGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, string orderField, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (!orderField.IsNullOrEmpty())
            {
                queryable = queryable.OrderBy(orderField);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.Select(select).ToList();
        }

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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, Expression<Func<T, TResult>> select, string tableName, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, null, select, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(null, tableName, select, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) => ListPageGet<TResult>(storeName, tableName, select, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<TResult>(string storeName, string tableName, Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Expression<Func<T, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T, object>> groupBy, Expression<Func<T, bool>> having, int pageIndex, int pageSize, ref int totalCount)
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.Select(select).ToPageList(pageIndex, pageSize, ref totalCount);
        }

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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, null, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, null, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, null, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, null, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new()
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable(join);

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.Select(select).ToList();
        }

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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, null, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, null, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, null, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, null, null, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, null, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, null, null, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, null, select, join, where, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, null, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, null, null, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, order, orderBy, null, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(null, tableName, select, join, where, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, null, order, orderBy, groupBy, having);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy) where T1 : class, new() where T2 : class, new() => ListGet(storeName, tableName, select, join, where, order, orderBy, groupBy, null);
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
        public virtual List<TResult> ListGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having) where T1 : class, new() where T2 : class, new()
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable(join);

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.Select(select).ToList();
        }

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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, string tableName, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, bool>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new()
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable(join);

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.Select(select).ToPageList(pageIndex, pageSize, ref totalCount);

        }

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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, string tableName, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, null, select, join, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(null, tableName, select, join, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, TResult>(storeName, tableName, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, TResult>(string storeName, string tableName, Expression<Func<T1, T2, TResult>> select, Expression<Func<T1, T2, object[]>> join, Expression<Func<T1, T2, bool>> where, Expression<Func<T1, T2, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, object>> groupBy, Expression<Func<T1, T2, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new()
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable(join);

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.Select(select).ToPageList(pageIndex, pageSize, ref totalCount);
        }
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, string tableName, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, null, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, null, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, where, null, null, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, null, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, where, null, null, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, null, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, null, select, join, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, where, null, null, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, null, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, where, order, orderBy, null, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(null, tableName, select, join, where, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, null, order, orderBy, groupBy, having, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new() => ListPageGet<T1, T2, T3, TResult>(storeName, tableName, select, join, where, order, orderBy, groupBy, null, pageIndex, pageSize, ref totalCount);
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
        public virtual List<TResult> ListPageGet<T1, T2, T3, TResult>(string storeName, string tableName, Expression<Func<T1, T2, T3, TResult>> select, Expression<Func<T1, T2, T3, object[]>> join, Expression<Func<T1, T2, T3, bool>> where, Expression<Func<T1, T2, T3, object>> order, DbEnum.OrderType? orderBy, Expression<Func<T1, T2, T3, object>> groupBy, Expression<Func<T1, T2, T3, bool>> having, int pageIndex, int pageSize, ref int totalCount) where T1 : class, new() where T2 : class, new()
        {
            ChangeDatabaseIf(storeName);

            var queryable = Db.Queryable(join);

            if (!tableName.IsNullOrEmpty())
            {
                queryable = queryable.AS(tableName);
            }

            if (where != null)
            {
                queryable = queryable.Where(where);
            }

            if (order != null)
            {
                queryable = orderBy.HasValue ? queryable.OrderBy(order, (SqlSugar.OrderByType)orderBy) : queryable.OrderBy(order);
            }

            if (groupBy != null)
            {
                queryable = queryable.GroupBy(groupBy);
            }

            if (having != null)
            {
                queryable = queryable.Having(having);
            }

            return queryable.Select(select).ToPageList(pageIndex, pageSize, ref totalCount);
        }

        #endregion

        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Update(T t, Expression<Func<T, object>> update, Expression<Func<T, bool>> where) => Update(t, null, null, update, where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="tableName"></param>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Update(T t, string tableName, Expression<Func<T, object>> update, Expression<Func<T, bool>> where) => Update(t, null, tableName, update, where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="update"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Update(T t, string storeName, string tableName, Expression<Func<T, object>> update, Expression<Func<T, bool>> where)
        {
            ChangeDatabaseIf(storeName);

            var updateable = Db.Updateable(t);

            if (!tableName.IsNullOrEmpty())
            {
                updateable = updateable.AS(tableName);
            }

            if (update != null)
            {
                updateable = updateable.UpdateColumns(update);
            }

            if (where != null)
            {
                updateable = updateable.Where(where);
            }

            return updateable.ExecuteCommand();
        }
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Update(Expression<Func<T, T>> set, Expression<Func<T, bool>> where) => Update(null, null, set, where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Update(string tableName, Expression<Func<T, T>> set, Expression<Func<T, bool>> where) => Update(null, tableName, set, where);
        /// <summary>
        /// Update函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="set"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Update(string storeName, string tableName, Expression<Func<T, T>> set, Expression<Func<T, bool>> where)
        {
            ChangeDatabaseIf(storeName);

            var updateable = Db.Updateable<T>().SetColumns(set);

            if (!tableName.IsNullOrEmpty())
            {
                updateable = updateable.AS(tableName);
            }

            if (where != null)
            {
                updateable = updateable.Where(where);
            }

            return updateable.ExecuteCommand();
        }

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual bool Delete(long id) => DeleteReturnCommand(null, null, id) > 0;

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual bool Delete(string tableName, long id) => DeleteReturnCommand(null, tableName, id) > 0;

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual bool Delete(string storeName, string tableName, long id) => DeleteReturnCommand(storeName, tableName, id) > 0;

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual int DeleteReturnCommand(string storeName, string tableName, long id)
        {
            ChangeDatabaseIf(storeName);

            var deleteable = Db.Deleteable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                deleteable = deleteable.AS(tableName);
            }

            return deleteable.In(id).ExecuteCommand();
        }

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual int DeleteRange(string storeName, string tableName, IEnumerable<long> id)
        {
            ChangeDatabaseIf(storeName);

            var deleteable = Db.Deleteable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                deleteable = deleteable.AS(tableName);
            }

            return deleteable.In(id.ToList()).ExecuteCommand();
        }

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual bool Delete(string id) => DeleteReturnCommand(id, null, null) > 0;

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual bool Delete(string tableName, string id) => DeleteReturnCommand(null, tableName, id) > 0;

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual bool Delete(string storeName, string tableName, string id) => DeleteReturnCommand(storeName, tableName, id) > 0;

        /// <summary>
        /// Delete函数,返回行数结果
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual int DeleteReturnCommand(string storeName, string tableName, string id)
        {
            ChangeDatabaseIf(storeName);

            var deleteable = Db.Deleteable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                deleteable = deleteable.AS(tableName);
            }

            return deleteable.In(id).ExecuteCommand();
        }

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="id"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual int DeleteRange(string storeName, string tableName, IEnumerable<string> id)
        {
            ChangeDatabaseIf(storeName);

            var deleteable = Db.Deleteable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                deleteable = deleteable.AS(tableName);
            }

            return deleteable.In(id.ToList()).ExecuteCommand();
        }

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual int Delete(Expression<Func<T, bool>> where) => Delete(null, null, where);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="where"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual int Delete(string tableName, Expression<Func<T, bool>> where) => Delete(null, tableName, where);

        /// <summary>
        /// Delete函数
        /// </summary>
        /// <param name="where"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual int Delete(string storeName, string tableName, Expression<Func<T, bool>> where)
        {
            ChangeDatabaseIf(storeName);

            var deleteable = Db.Deleteable<T>();

            if (!tableName.IsNullOrEmpty())
            {
                deleteable = deleteable.AS(tableName);
            }

            return deleteable.Where(where).ExecuteCommand();
        }

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Insert(T t) => Insert(null, null, t, null, null) > 0;

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Insert(string tableName, T t) => Insert(null, tableName, t, null, null) > 0;

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual bool Insert(string storeName, string tableName, T t) => Insert(storeName, tableName, t, null, null) > 0;

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual T InsertReturnEntity(T t) => InsertReturnEntity(null, null, t, null, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T InsertReturnEntity(string tableName, T t) => InsertReturnEntity(null, tableName, t, null, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public virtual T InsertReturnEntity(string storeName, string tableName, T t) => InsertReturnEntity(storeName, tableName, t, null, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="t"></param>
        /// <param name="insertColumns"></param>
        /// <param name="ignoreColumns"></param>
        /// <returns></returns>
        public virtual int Insert(string storeName, string tableName, T t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns)
        {
            ChangeDatabaseIf(storeName);

            var insertable = Db.Insertable(t);

            if (!tableName.IsNullOrEmpty())
            {
                insertable = insertable.AS(tableName);
            }


            if (insertColumns != null)
            {
                insertable = insertable.InsertColumns(insertColumns);
            }

            if (ignoreColumns != null)
            {
                insertable = insertable.IgnoreColumns(ignoreColumns);
            }
            else
            {
                insertable = insertable.IgnoreColumns(true);
            }

            return insertable.ExecuteCommand();
        }

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="insertColumns"></param>
        /// <param name="ignoreColumns"></param>
        /// <returns></returns>
        public virtual T InsertReturnEntity(string storeName, string tableName, T t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns)
        {
            ChangeDatabaseIf(storeName);
            var insertable = Db.Insertable(t);

            if (!tableName.IsNullOrEmpty())
            {
                insertable = insertable.AS(tableName);
            }


            if (insertColumns != null)
            {
                insertable = insertable.InsertColumns(insertColumns);
            }

            if (ignoreColumns != null)
            {
                insertable = insertable.IgnoreColumns(ignoreColumns);
            }
            else
            {
                insertable = insertable.IgnoreColumns(true);
            }

            return insertable.ExecuteReturnEntity();
        }

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t"></param>
        /// <param name="storeName"></param>
        /// <param name="tableName"></param>
        /// <param name="insertColumns"></param>
        /// <param name="ignoreColumns"></param>
        /// <returns></returns>
        public virtual int InsertRange(string storeName, string tableName, IEnumerable<T> t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns)
        {
            ChangeDatabaseIf(storeName);

            var insertable = Db.Insertable(t.ToList());

            if (!tableName.IsNullOrEmpty())
            {
                insertable = insertable.AS(tableName);
            }

            if (insertColumns != null)
            {
                insertable = insertable.InsertColumns(insertColumns);
            }

            if (ignoreColumns != null)
            {
                insertable = insertable.IgnoreColumns(ignoreColumns);
            }

            return insertable.ExecuteCommand();
        }

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        public virtual int InsertRange(IEnumerable<T> t) => InsertRange(null, null, t, null, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        public virtual int InsertRange(string tableName, IEnumerable<T> t) => InsertRange(null, tableName, t, null, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <returns></returns>
        public virtual int InsertRange(string storeName, string tableName, IEnumerable<T> t) => InsertRange(storeName, tableName, t, null, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <returns></returns>
        public virtual int InsertRange(IEnumerable<T> t, Expression<Func<T, object>> insertColumns) => InsertRange(null, null, t, insertColumns, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <returns></returns>
        public virtual int InsertRange(string tableName, IEnumerable<T> t, Expression<Func<T, object>> insertColumns) => InsertRange(null, tableName, t, insertColumns, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <returns></returns>
        public virtual int InsertRange(string storeName, string tableName, IEnumerable<T> t, Expression<Func<T, object>> insertColumns) => InsertRange(storeName, tableName, t, insertColumns, null);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <param name="ignoreColumns">忽略列</param>
        /// <returns></returns>
        public virtual int InsertRange(IEnumerable<T> t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns) => InsertRange(null, null, t, insertColumns, ignoreColumns);

        /// <summary>
        /// Insert函数
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="t">实体集合</param>
        /// <param name="insertColumns">插入列</param>
        /// <param name="ignoreColumns">忽略列</param>
        /// <returns></returns>
        public virtual int InsertRange(string tableName, IEnumerable<T> t, Expression<Func<T, object>> insertColumns, Expression<Func<T, object>> ignoreColumns) => InsertRange(null, tableName, t, insertColumns, ignoreColumns);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>影响行数</returns>
        public virtual int ExecuteCommand(string storeName, string sql, object parameters)
        {
            ChangeDatabaseIf(storeName);

            return Db.Ado.ExecuteCommand(sql, parameters);
        }

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>影响行数</returns>
        public virtual int ExecuteCommand(string sql, object parameters) => ExecuteCommand(null, sql, parameters);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>影响行数</returns>
        public virtual int ExecuteCommand(string storeName, string sql, params SqlSugar.SugarParameter[] parameters)
        {
            ChangeDatabaseIf(storeName);

            return Db.Ado.ExecuteCommand(sql, parameters);
        }

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>影响行数</returns>
        public virtual int ExecuteCommand(string sql, params SqlSugar.SugarParameter[] parameters) => ExecuteCommand(null, sql, parameters);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>影响行数</returns>
        public virtual int ExecuteCommand(string storeName, string sql, List<SqlSugar.SugarParameter> parameters)
        {
            ChangeDatabaseIf(storeName);

            return Db.Ado.ExecuteCommand(sql, parameters);
        }

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>影响行数</returns>
        public virtual int ExecuteCommand(string sql, List<SqlSugar.SugarParameter> parameters) => ExecuteCommand(null, sql, parameters);

        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        public virtual List<TResult> SqlQuery<TResult>(string storeName, string sql, object parameters)
        {
            ChangeDatabaseIf(storeName);

            return Db.Ado.SqlQuery<TResult>(sql, parameters);
        }

        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>结果类型集合</returns>
        public virtual List<TResult> SqlQuery<TResult>(string sql, object parameters) => SqlQuery<TResult>(null, sql, parameters);

        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>结果类型集合</returns>
        public virtual List<TResult> SqlQuery<TResult>(string storeName, string sql, params SqlSugar.SugarParameter[] parameters)
        {
            ChangeDatabaseIf(storeName);

            return Db.Ado.SqlQuery<TResult>(sql, parameters);
        }

        /// <summary>
        /// sql查询
        /// </summary>
        /// <typeparam name="TResult">结果类型</typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">可变参数</param>
        /// <returns>结果类型集合</returns>
        public virtual List<TResult> SqlQuery<TResult>(string sql, params SqlSugar.SugarParameter[] parameters) => SqlQuery<TResult>(null, sql, parameters);

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="storeName">库名</param>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>影响行数</returns>
        public virtual List<TResult> SqlQuery<TResult>(string storeName, string sql, List<SqlSugar.SugarParameter> parameters)
        {
            ChangeDatabaseIf(storeName);

            return Db.Ado.SqlQuery<TResult>(sql, parameters);
        }

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>影响行数</returns>
        public virtual List<TResult> SqlQuery<TResult>(string sql, List<SqlSugar.SugarParameter> parameters) => SqlQuery<TResult>(null, sql, parameters);

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
        public virtual List<TResult> SqlQuery<TResult>(string storeName, string sql, int pageIndex, int pageSize, ref int totalCount, params SqlSugar.SugarParameter[] parameters) where TResult : class, new()
        {
            ChangeDatabaseIf(storeName);

            return Db.SqlQueryable<TResult>(sql).AddParameters(parameters).ToPageList(pageIndex, pageSize, ref totalCount);
        }

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
        public virtual List<TResult> SqlQuery<TResult>(string sql, int pageIndex, int pageSize, ref int totalCount, params SqlSugar.SugarParameter[] parameters) where TResult : class, new()
            => SqlQuery<TResult>(null, sql, pageIndex, pageSize, ref totalCount, parameters);

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
        public virtual List<TResult> SqlQuery<TResult>(string storeName, string sql, int pageIndex, int pageSize, ref int totalCount, object parameters) where TResult : class, new()
        {
            ChangeDatabaseIf(storeName);

            return Db.SqlQueryable<TResult>(sql).AddParameters(parameters).ToPageList(pageIndex, pageSize, ref totalCount);
        }

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
        public virtual List<TResult> SqlQuery<TResult>(string sql, int pageIndex, int pageSize, ref int totalCount, object parameters) where TResult : class, new()
             => SqlQuery<TResult>(null, sql, pageIndex, pageSize, ref totalCount, parameters);

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
        public virtual List<TResult> SqlQuery<TResult>(string storeName, string sql, int pageIndex, int pageSize, ref int totalCount, List<SqlSugar.SugarParameter> parameters) where TResult : class, new()
        {
            ChangeDatabaseIf(storeName);

            return Db.SqlQueryable<TResult>(sql).AddParameters(parameters).ToPageList(pageIndex, pageSize, ref totalCount);
        }

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
        public virtual List<TResult> SqlQuery<TResult>(string sql, int pageIndex, int pageSize, ref int totalCount, List<SqlSugar.SugarParameter> parameters) where TResult : class, new()
            => SqlQuery<TResult>(null, sql, pageIndex, pageSize, ref totalCount, parameters);

        /// <summary>
        /// 使用事务
        /// </summary>
        /// <param name="action">执行委托</param>
        /// <returns></returns>
        public virtual SqlSugar.DbResult<bool> UseTran(Action action) => UseTran(action, null);

        /// <summary>
        /// 使用事务
        /// </summary>
        /// <param name="action">执行委托</param>
        /// <param name="errorCallBack">错误回调委托</param>
        /// <returns></returns>
        public virtual SqlSugar.DbResult<bool> UseTran(Action action, Action<Exception> errorCallBack)
        {
            var result = new SqlSugar.DbResult<bool>();
            try
            {
                Db.BeginTran();

                action?.Invoke();

                Db.CommitTran();
                result.Data = result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.ErrorException = ex;
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;

                Db.RollbackTran();

                errorCallBack?.Invoke(ex);
            }
            return result;
        }

        private void ChangeDatabaseIf(string storeName)
        {
            if (!storeName.IsNullOrEmpty())
            {
                Db.ChangeDatabase(storeName);
            }
        }


        private void UnitTest()
        {
            //参数化执行SQL 三种写法
            //第一种
            int command1 = ExecuteCommand("select * from \"order\" where @id>0  or name=@name", new { id = 1, name = "2" });

            //第二种
            var p1 = new SqlSugar.SugarParameter("@id", 1);
            var p2 = new SqlSugar.SugarParameter("@name", "2");
            int command2 = ExecuteCommand("select * from \"order\" where @id>0  or name=@name", p1, p2);

            //第三种
            var pList = new List<SqlSugar.SugarParameter>()
            {
                new SqlSugar.SugarParameter("@id", 1),
                new SqlSugar.SugarParameter("@name", "2")
            };
            int command3 = ExecuteCommand("select * from \"order\" where @id>0  or name=@name", pList);

            //SQL参数化查询 三种写法
            //第一种
            //List<Order> orderList1 = SqlQuery<Order>("select * from \"order\" where @id>0  or name=@name", new { id = 1, name = "2" });
            var idList1 = SqlQuery<dynamic>("select id from \"order\" where @id>0  or name=@name", new { id = 1, name = "2" });

            //第二种
            var p3 = new SqlSugar.SugarParameter("@id", 1);
            var p4 = new SqlSugar.SugarParameter("@name", "2");
            //List<Order> orderList2 = SqlQuery<Order>("select * from \"order\" where @id>0  or name=@name", p3, p4);
            var idList2 = SqlQuery<dynamic>("select id from \"order\" where @id>0  or name=@name", p3, p4);

            //第三种
            var queryParamList = new List<SqlSugar.SugarParameter>()
            {
                new SqlSugar.SugarParameter("@id", 1),
                new SqlSugar.SugarParameter("@name", "2")
            };
            //List<Order> orderList3 = SqlQuery<Order>("select * from \"order\" where @id>0  or name=@name", queryParamList);
            var idList3 = SqlQuery<dynamic>("select id from \"order\" where @id>0  or name=@name", queryParamList);

            //分页查询 返回动态类型
            int totalCount = 0;
            var pageList1 = SqlQuery<dynamic>("select id from order", 1, 10, ref totalCount);

            //分页查询 返回指定类型
            //var pageList2 = SqlQuery<ViewModel>("select id from order", 1, 10, ref totalCount);
        }

    }
}
