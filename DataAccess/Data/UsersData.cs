using DataAccess.Domain.Models;
using DataAccess.Helpers;
using DataAccess.IDataAccess;
using System.Security.Cryptography;

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

    public bool UserVerify(string userName, string password)
    {
        var user = GetUserByUserName(userName);
        if (user == null)
            return false;

        try
        {
            var md5Hash = MD5.Create();
            return MD5UserPasswordVerification.VerifyMd5Hash(md5Hash, password, user.Passward ?? "") &&
                   password != user.Passward;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public IEnumerable<UsersPrivilegesEntry> GetUsersPrivileges(string userName)
    {
        var user = _loadMethods.GetQueryable<User>().Where(u => u.Name == userName);
        var privilegeEntries = _loadMethods.GetQueryable<UsersPrivilegesEntry>();

        var usersPrivileges = user.Join(privilegeEntries, u => u.PrivilegeId, p => p.PrivilegeId, (_, entry) => entry);

        return usersPrivileges;
    }

    public UsersPrivilege? GetPermissionLastUpdate(string userName)
    {
        var user = GetUserByUserName(userName);
        if (user == null) return null;

        var usersPermissions = _loadMethods.LoadMultiple<UsersPrivilege>(false);

        var permissionLastUpdated = usersPermissions.FirstOrDefault(p => p.Id == user.PrivilegeId);
        return permissionLastUpdated;
    }
}