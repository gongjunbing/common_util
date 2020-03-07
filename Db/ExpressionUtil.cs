using System;
using System.Linq.Expressions;

namespace CommonUtil
{
    /// <summary>
    /// 表达式工具类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExpressionUtil<T> where T : class, new()
    {
        /// <summary>
        /// 
        /// </summary>
        Expression<Func<T, bool>> _exp = null;

        /// <summary>
        /// AND 条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T> And(Expression<Func<T, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, bool>>(Expression.AndAlso(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }

        /// <summary>
        /// IF成立则执行AND条件
        /// </summary>
        /// <param name="isAnd"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T> AndIF(bool isAnd, Expression<Func<T, bool>> exp)
        {
            if (isAnd)
                And(exp);
            return this;
        }

        /// <summary>
        /// OR条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T> Or(Expression<Func<T, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, bool>>(Expression.OrElse(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }

        /// <summary>
        /// IF成立则执行OR条件
        /// </summary>
        /// <param name="isOr"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T> OrIF(bool isOr, Expression<Func<T, bool>> exp)
        {
            if (isOr)
                Or(exp);
            return this;
        }

        /// <summary>
        /// 转换表达式
        /// </summary>
        /// <returns></returns>
        public Expression<Func<T, bool>> ToExpression()
        {
            if (_exp == null)
                _exp = it => true;
            return _exp;
        }
    }

    /// <summary>
    /// 表达式工具类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public class ExpressionUtil<T, T2> where T : class, new() where T2 : class, new()
    {
        Expression<Func<T, T2, bool>> _exp = null;

        /// <summary>
        /// AND条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2> And(Expression<Func<T, T2, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, bool>>(Expression.AndAlso(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }

        /// <summary>
        /// IF成立则执行AND条件
        /// </summary>
        /// <param name="isAnd"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2> AndIF(bool isAnd, Expression<Func<T, T2, bool>> exp)
        {
            if (isAnd)
                And(exp);
            return this;
        }
        /// <summary>
        /// OR条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2> Or(Expression<Func<T, T2, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, bool>>(Expression.OrElse(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行OR条件
        /// </summary>
        /// <param name="isOr"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2> OrIF(bool isOr, Expression<Func<T, T2, bool>> exp)
        {
            if (isOr)
                Or(exp);
            return this;
        }
        /// <summary>
        /// 转换表达式
        /// </summary>
        /// <returns></returns>
        public Expression<Func<T, T2, bool>> ToExpression()
        {
            if (_exp == null)
                _exp = (it, t2) => true;
            return _exp;
        }
    }
    /// <summary>
    /// 表达式工具类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public class ExpressionUtil<T, T2, T3> where T : class, new() where T2 : class, new() where T3 : class, new()
    {
        Expression<Func<T, T2, T3, bool>> _exp = null;
        /// <summary>
        /// AND条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3> And(Expression<Func<T, T2, T3, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, T3, bool>>(Expression.AndAlso(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行AND条件
        /// </summary>
        /// <param name="isAnd"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3> AndIF(bool isAnd, Expression<Func<T, T2, T3, bool>> exp)
        {
            if (isAnd)
                And(exp);
            return this;
        }
        /// <summary>
        /// OR条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3> Or(Expression<Func<T, T2, T3, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, T3, bool>>(Expression.OrElse(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行OR条件
        /// </summary>
        /// <param name="isOr"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3> OrIF(bool isOr, Expression<Func<T, T2, T3, bool>> exp)
        {
            if (isOr)
                Or(exp);
            return this;
        }
        /// <summary>
        /// 转换表达式
        /// </summary>
        /// <returns></returns>
        public Expression<Func<T, T2, T3, bool>> ToExpression()
        {
            if (_exp == null)
                _exp = (it, t2, t3) => true;
            return _exp;
        }
    }
    /// <summary>
    /// /表达式工具类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public class ExpressionUtil<T, T2, T3, T4> where T : class, new() where T2 : class, new() where T3 : class, new() where T4 : class, new()
    {
        Expression<Func<T, T2, T3, T4, bool>> _exp = null;
        /// <summary>
        /// AND条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4> And(Expression<Func<T, T2, T3, T4, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, T3, T4, bool>>(Expression.AndAlso(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行AND条件
        /// </summary>
        /// <param name="isAnd"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4> AndIF(bool isAnd, Expression<Func<T, T2, T3, T4, bool>> exp)
        {
            if (isAnd)
                And(exp);
            return this;
        }
        /// <summary>
        /// OR条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4> Or(Expression<Func<T, T2, T3, T4, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, T3, T4, bool>>(Expression.OrElse(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行OR条件
        /// </summary>
        /// <param name="isOr"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4> OrIF(bool isOr, Expression<Func<T, T2, T3, T4, bool>> exp)
        {
            if (isOr)
                Or(exp);
            return this;
        }
        /// <summary>
        /// 转换表达式
        /// </summary>
        /// <returns></returns>
        public Expression<Func<T, T2, T3, T4, bool>> ToExpression()
        {
            if (_exp == null)
                _exp = (it, t2, t3, t4) => true;
            return _exp;
        }
    }
    /// <summary>
    /// 表达式工具类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    public class ExpressionUtil<T, T2, T3, T4, T5> where T : class, new() where T2 : class, new() where T3 : class, new() where T4 : class, new() where T5 : class, new()
    {
        Expression<Func<T, T2, T3, T4, T5, bool>> _exp = null;
        /// <summary>
        /// AND条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4, T5> And(Expression<Func<T, T2, T3, T4, T5, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, T3, T4, T5, bool>>(Expression.AndAlso(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行AND条件
        /// </summary>
        /// <param name="isAnd"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4, T5> AndIF(bool isAnd, Expression<Func<T, T2, T3, T4, T5, bool>> exp)
        {
            if (isAnd)
                And(exp);
            return this;
        }
        /// <summary>
        /// OR条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4, T5> Or(Expression<Func<T, T2, T3, T4, T5, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, T3, T4, T5, bool>>(Expression.OrElse(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行OR条件
        /// </summary>
        /// <param name="isOr"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4, T5> OrIF(bool isOr, Expression<Func<T, T2, T3, T4, T5, bool>> exp)
        {
            if (isOr)
                Or(exp);
            return this;
        }
        /// <summary>
        /// 转换表达式
        /// </summary>
        /// <returns></returns>
        public Expression<Func<T, T2, T3, T4, T5, bool>> ToExpression()
        {
            if (_exp == null)
                _exp = (it, t2, t3, t4, T5) => true;
            return _exp;
        }
    }
    /// <summary>
    /// 表达式工具类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    /// <typeparam name="T5"></typeparam>
    /// <typeparam name="T6"></typeparam>
    public class ExpressionUtil<T, T2, T3, T4, T5, T6> where T : class, new() where T2 : class, new() where T3 : class, new() where T4 : class, new() where T5 : class, new() where T6 : class, new()
    {
        Expression<Func<T, T2, T3, T4, T5, T6, bool>> _exp = null;
        /// <summary>
        /// AND条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4, T5, T6> And(Expression<Func<T, T2, T3, T4, T5, T6, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, T3, T4, T5, T6, bool>>(Expression.AndAlso(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行AND条件
        /// </summary>
        /// <param name="isAnd"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4, T5, T6> AndIF(bool isAnd, Expression<Func<T, T2, T3, T4, T5, T6, bool>> exp)
        {
            if (isAnd)
                And(exp);
            return this;
        }
        /// <summary>
        /// OR条件
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4, T5, T6> Or(Expression<Func<T, T2, T3, T4, T5, T6, bool>> exp)
        {
            if (_exp == null)
                _exp = exp;
            else
                _exp = Expression.Lambda<Func<T, T2, T3, T4, T5, T6, bool>>(Expression.OrElse(_exp.Body, exp.Body), _exp.Parameters);
            return this;
        }
        /// <summary>
        /// IF成立则执行OR条件
        /// </summary>
        /// <param name="isOr"></param>
        /// <param name="exp"></param>
        /// <returns></returns>
        public ExpressionUtil<T, T2, T3, T4, T5, T6> OrIF(bool isOr, Expression<Func<T, T2, T3, T4, T5, T6, bool>> exp)
        {
            if (isOr)
                Or(exp);
            return this;
        }
        /// <summary>
        /// 转换表达式
        /// </summary>
        /// <returns></returns>
        public Expression<Func<T, T2, T3, T4, T5, T6, bool>> ToExpression()
        {
            if (_exp == null)
                _exp = (it, t2, t3, t4, T5, t6) => true;
            return _exp;
        }
    }
    /// <summary>
    /// 表达式工具类
    /// </summary>
    public class ExpressionUtil
    {
        /// <summary>
        /// 创建表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ExpressionUtil<T> Create<T>() where T : class, new()
        {
            return new ExpressionUtil<T>();
        }
        /// <summary>
        /// 创建表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <returns></returns>
        public static ExpressionUtil<T, T2> Create<T, T2>() where T : class, new() where T2 : class, new()
        {
            return new ExpressionUtil<T, T2>();
        }
        /// <summary>
        /// 创建表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <returns></returns>
        public static ExpressionUtil<T, T2, T3> Create<T, T2, T3>() where T : class, new() where T2 : class, new() where T3 : class, new()
        {
            return new ExpressionUtil<T, T2, T3>();
        }
        /// <summary>
        /// 创建表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <returns></returns>
        public static ExpressionUtil<T, T2, T3, T4> Create<T, T2, T3, T4>() where T : class, new() where T2 : class, new() where T3 : class, new() where T4 : class, new()
        {
            return new ExpressionUtil<T, T2, T3, T4>();
        }
        /// <summary>
        /// 创建表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <returns></returns>
        public static ExpressionUtil<T, T2, T3, T4, T5> Create<T, T2, T3, T4, T5>() where T : class, new() where T2 : class, new() where T3 : class, new() where T4 : class, new() where T5 : class, new()
        {
            return new ExpressionUtil<T, T2, T3, T4, T5>();
        }
        /// <summary>
        /// 创建表达式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <returns></returns>
        public static ExpressionUtil<T, T2, T3, T4, T5, T6> Create<T, T2, T3, T4, T5, T6>() where T : class, new() where T2 : class, new() where T3 : class, new() where T4 : class, new() where T5 : class, new() where T6 : class, new()
        {
            return new ExpressionUtil<T, T2, T3, T4, T5, T6>();
        }
    }
}
