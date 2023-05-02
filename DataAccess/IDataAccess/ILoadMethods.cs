using System.Linq.Expressions;

namespace DataAccess.IDataAccess;

public interface ILoadMethods
{
    IQueryable<TEntity> GetQueryable<TEntity>() where TEntity : class;
    List<TEntity> LoadMultiple<TEntity>(bool asNoTracking) where TEntity : class;

    List<TEntity> LoadMultiple<TEntity>(bool asNoTracking, Expression<Func<TEntity, bool>> whereExpression)
        where TEntity : class;

    Task<List<TEntity>> LoadMultipleAsync<TEntity>(bool asNoTracking, CancellationToken cancellationToken = default)
        where TEntity : class;

    Task<List<TEntity>> LoadMultipleAsync<TEntity>(bool asNoTracking, Expression<Func<TEntity, bool>> whereExpression,
        CancellationToken cancellationToken = default) where TEntity : class;

    TEntity? LoadSingle<TEntity>(bool asNoTracking) where TEntity : class;

    TEntity? LoadSingle<TEntity>(bool asNoTracking, Expression<Func<TEntity, bool>> filterExpression)
        where TEntity : class;

    Task<TEntity?> LoadSingleAsync<TEntity>(bool asNoTracking, CancellationToken cancellationToken = default)
        where TEntity : class;

    Task<TEntity?> LoadSingleAsync<TEntity>(bool asNoTracking, Expression<Func<TEntity, bool>> filterExpression,
        CancellationToken cancellationToken = default) where TEntity : class;
}