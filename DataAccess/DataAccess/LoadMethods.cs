using DataAccess.IDataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using DataAccess.Infrastructure.Persistence;

namespace DataAccess.DataAccess;

public class LoadMethods : ILoadMethods
{
    private readonly DxdbContext _dbContext;

    public LoadMethods(DxdbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public TEntity? LoadSingle<TEntity>(bool asNoTracking) where TEntity : class
    {
        return FindQueryable<TEntity>(asNoTracking)
            .FirstOrDefault();
    }

    public TEntity? LoadSingle<TEntity>(
        bool asNoTracking,
        Expression<Func<TEntity, bool>> filterExpression) where TEntity : class
    {
        return FindQueryable<TEntity>(asNoTracking)
            .FirstOrDefault(filterExpression);
    }

    public async Task<TEntity?> LoadSingleAsync<TEntity>(
        bool asNoTracking,
        CancellationToken cancellationToken = default) where TEntity : class
    {
        return await FindQueryable<TEntity>(asNoTracking)
            .FirstOrDefaultAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<TEntity?> LoadSingleAsync<TEntity>(
        bool asNoTracking,
        Expression<Func<TEntity, bool>> filterExpression,
        CancellationToken cancellationToken = default) where TEntity : class
    {
        return await FindQueryable<TEntity>(asNoTracking)
            .FirstOrDefaultAsync(filterExpression, cancellationToken).ConfigureAwait(false);
    }

    public List<TEntity> LoadMultiple<TEntity>(bool asNoTracking) where TEntity : class
    {
        return FindQueryable<TEntity>(asNoTracking).ToList();
    }

    public List<TEntity> LoadMultiple<TEntity>(
        bool asNoTracking,
        Expression<Func<TEntity, bool>> whereExpression) where TEntity : class
    {
        return FindQueryable<TEntity>(asNoTracking)
            .Where(whereExpression).ToList();
    }

    public async Task<List<TEntity>> LoadMultipleAsync<TEntity>(
        bool asNoTracking,
        CancellationToken cancellationToken = default) where TEntity : class
    {
        return await FindQueryable<TEntity>(asNoTracking)
            .ToListAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<List<TEntity>> LoadMultipleAsync<TEntity>(
        bool asNoTracking,
        Expression<Func<TEntity, bool>> whereExpression,
        CancellationToken cancellationToken = default) where TEntity : class
    {
        return await FindQueryable<TEntity>(asNoTracking)
            .Where(whereExpression).ToListAsync(cancellationToken).ConfigureAwait(false);
    }

    public IQueryable<TEntity> GetQueryable<TEntity>() where TEntity : class
    {
        return _dbContext.Set<TEntity>().AsQueryable();
    }

    private IQueryable<TEntity> FindQueryable<TEntity>(bool asNoTracking) where TEntity : class
    {
        var queryable = GetQueryable<TEntity>();
        if (asNoTracking)
        {
            queryable = queryable.AsNoTracking();
        }
        return queryable;
    }
}
