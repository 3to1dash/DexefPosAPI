using DataAccess.Domain.Models;
using DataAccess.IDataAccess;

namespace DataAccess.Data;

public class UsersData
{
    private readonly ILoadMethods _loadMethods;

    public UsersData(ILoadMethods loadMethods)
	{
        _loadMethods = loadMethods;
    }

    public List<User> GetAllUsers()
    {
        return _loadMethods.LoadMultiple<User>(true, e => e.Type == "SA");
    }

    public User? GetUserByUserName(string userName)
    {
        return _loadMethods.LoadSingle<User>(asNoTracking: true, e => e.Name == userName);
    }

    public UsersResource? GetUserResourceByModule(string userName, string module)
    {
        var userResources = _loadMethods.LoadSingle<UsersResource>(
            asNoTracking: true,
            u => u.UserName == userName && u.Module == module);

        return userResources;
    }
}
