using DataAccess.Infrastructure.Persistence;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using DataAccess.IDataAccess;

namespace DataAccess.DataAccess;

public class SoftDeleteMethods : ISoftDeleteMethods
{
    private readonly DxdbContext _dbContext;

    public SoftDeleteMethods(DxdbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public TEntity SoftDeleteSingle<TEntity>(TEntity entity) where TEntity : class
    {
        _dbContext.Set<TEntity>().Update(entity);
        return entity;
    }

    public IEnumerable<TEntity> SoftDeleteRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
    {
        _dbContext.Set<TEntity>().UpdateRange(entities);
        return entities;
    }

    public int SoftDeleteSingleOrRange<TEntity>(
        Expression<Func<TEntity, bool>> filterExpression,
        Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setPropertyCalls) where TEntity : class
    {
        return _dbContext.Set<TEntity>().Where(filterExpression).ExecuteUpdate(setPropertyCalls);
    }

    public async Task<int> SoftDeleteSingleOrRangeAsync<TEntity>(
        Expression<Func<TEntity, bool>> filterExpression, 
        Expression<Func<SetPropertyCalls<TEntity>, SetPropertyCalls<TEntity>>> setPropertyCalls) where TEntity : class
    {
        return await _dbContext.Set<TEntity>().Where(filterExpression).ExecuteUpdateAsync(setPropertyCalls).ConfigureAwait(false);
    }
}
