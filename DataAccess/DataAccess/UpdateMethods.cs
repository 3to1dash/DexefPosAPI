using DataAccess.IDataAccess;
using DataAccess.Infrastructure.Persistence;

namespace DataAccess.DataAccess;

public class UpdateMethods : IUpdateMethods
{
    private readonly IDbContext _dbContext;

    public UpdateMethods(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public TEntity UpdateSingle<TEntity>(TEntity entity) where TEntity : class
    {
        _dbContext.Set<TEntity>().Update(entity);
        return entity;
    }

    public IEnumerable<TEntity> UpdateRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
    {
        _dbContext.Set<TEntity>().UpdateRange(entities);
        return entities;
    }
}