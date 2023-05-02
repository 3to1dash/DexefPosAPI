using DataAccess.IDataAccess;
using DataAccess.Infrastructure.Persistence;

namespace DataAccess.DataAccess;

public class SaveChangesMethods : ISaveChangesMethods
{
    private readonly DxdbContext _dbContext;

    public SaveChangesMethods(DxdbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> Save()
    {
        return await _dbContext.SaveChangesAsync();
    }
}