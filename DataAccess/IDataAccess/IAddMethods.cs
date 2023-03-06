namespace DataAccess.IDataAccess;

public interface IAddMethods
{
    TEntity AddSingle<TEntity>(TEntity entity) where TEntity : class;

    Task<TEntity> AddSingleAsync<TEntity>(
        TEntity entity,
        CancellationToken cancellationToken = default) where TEntity : class;

    IEnumerable<TEntity> AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;

    Task<IEnumerable<TEntity>> AddRangeAsync<TEntity>(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default) where TEntity : class;
}