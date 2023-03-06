using DataAccess.IDataAccess;
using DataAccess.Infrastructure.Persistence;

namespace DataAccess.DataAccess;

public class AddMethods : IAddMethods
{
    private readonly DxdbContext _dbContext;

    public AddMethods(DxdbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public TEntity AddSingle<TEntity>(TEntity entity) where TEntity : class
    {
        _dbContext.Set<TEntity>().Add(entity);
        return entity;
    }

    public async Task<TEntity> AddSingleAsync<TEntity>(
        TEntity entity, 
        CancellationToken cancellationToken = default) where TEntity : class
    {
        await _dbContext.Set<TEntity>().AddAsync(entity, cancellationToken).ConfigureAwait(false);
        return entity;
    }

    public IEnumerable<TEntity> AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
    {
        _dbContext.Set<TEntity>().AddRange(entities);
        return entities;
    }

    public async Task<IEnumerable<TEntity>> AddRangeAsync<TEntity>(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default) where TEntity : class
    {
        await _dbContext.Set<TEntity>().AddRangeAsync(entities, cancellationToken).ConfigureAwait(false);
        return entities;
    }
}