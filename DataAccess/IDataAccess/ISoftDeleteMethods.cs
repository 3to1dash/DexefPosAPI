using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace DataAccess.IDataAccess;

public interface ISoftDeleteMethods
{
    TEntity SoftDeleteSingle<TEntity>(TEntity entity) where TEntity : class;
    IEnumerable<TEntity> SoftDeleteRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;

    int SoftDeleteSingleOrRange<TEntity>(
        Expression<Func<TEntity, bool>> filterExpression,
        Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setPropertyCalls) where TEntity : class;

    Task<int> SoftDeleteSingleOrRangeAsync<TEntity>(
        Expression<Func<TEntity, bool>> filterExpression,
        Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setPropertyCalls) where TEntity : class;
}