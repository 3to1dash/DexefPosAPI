namespace DataAccess.IDataAccess;

public interface ISaveChangesMethods
{
    Task<int> Save();
}