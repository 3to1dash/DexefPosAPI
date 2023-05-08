using Microsoft.EntityFrameworkCore;

namespace DataAccess.Infrastructure.Persistence;

public interface IDbContext : IDisposable
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    IQueryable<T> ExecuteRawSql<T>(string sql, object[] parameters);
}