using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.draw507.util
{
    public enum ORDER
    {
        ASC,
        DESC
    }

    public enum THENBY
    {
        ASC,
        DESC
    }

    public static class LINQExtensions
    {
        public static IQueryable<TSource> GetPage<TSource>(this IQueryable<TSource> source,
                                                         int pageNumber,
                                                         int pageSize)
        {
            return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        public static bool CaseInsensitiveContains(this string text, string value,
        StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }

        public static bool CaseInsensitiveContains(this string text, string value)
        {
            return text.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) >= 0;
        }

        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string orderByProperty,
                          ORDER order)
        {
            string command = order == ORDER.DESC ? "OrderByDescending" : "OrderBy";
            var type = typeof(TEntity);
            var property = type.GetProperty(orderByProperty);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType },
                                          source.Expression, Expression.Quote(orderByExpression));
            return source.Provider.CreateQuery<TEntity>(resultExpression);
        }

        public static IQueryable<TEntity> ThenBy<TEntity>(this IQueryable<TEntity> source, string orderByProperty,
                          THENBY order)
        {
            string command = order == THENBY.DESC ? "ThenByDescending" : "ThenBy";
            var type = typeof(TEntity);
            var property = type.GetProperty(orderByProperty);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType },
                                          source.Expression, Expression.Quote(orderByExpression));
            return source.Provider.CreateQuery<TEntity>(resultExpression);
        }

        public static IEnumerable<TSource> ExceptBy<TSource, TKey>(
            this IEnumerable<TSource> source,
            IEnumerable<TSource> other,
            Func<TSource, TKey> keySelector)
        {
            var set = new HashSet<TKey>(other.Select(keySelector));
            foreach (var item in source)
                if (set.Add(keySelector(item)))
                    yield return item;
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
