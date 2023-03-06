namespace DataAccess.IDataAccess;

public interface IUpdateMethods
{
    TEntity UpdateSingle<TEntity>(TEntity entity) where TEntity : class;
    IEnumerable<TEntity> UpdateRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
}