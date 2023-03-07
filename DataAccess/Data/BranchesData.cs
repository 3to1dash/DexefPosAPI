using DataAccess.Domain.Models;
using DataAccess.IDataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;
public class BranchesData
{
    private readonly ILoadMethods _loadMethods;

    public BranchesData(ILoadMethods loadMethods)
    {
        _loadMethods = loadMethods;
    }

    public List<CompanyBranch> GetBranches(bool isActive)
    {
        var branches = _loadMethods.LoadMultiple<CompanyBranch>(asNoTracking: true, b => b.Active == isActive);

        return branches;
    }

    public List<CompanyBranch> GetUserBranches(bool isActive, string userName)
    {
        var userType = _loadMethods.LoadSingle<User>(false, u => u.Name == userName)?.Type;

        switch (userType)
        {
            case "SA":
            case "ReadOnly":
                return _loadMethods.LoadMultiple<CompanyBranch>(false, b => b.Active == isActive);
            default:
                var userBranchesResource =
                    _loadMethods.LoadSingle<UsersResource>(false, usr => usr.Module == "Branch")?.Ids;

                if (userBranchesResource == null) 
                    return new List<CompanyBranch>();

                if (userBranchesResource == "*")
                    return _loadMethods.LoadMultiple<CompanyBranch>(false, b => b.Active == isActive);

                var branchesIds = userBranchesResource.Split(',').Select(int.Parse);

                return _loadMethods.LoadMultiple<CompanyBranch>(false, b => b.Active == isActive && branchesIds.Contains(b.Id));
        }
    }

    public List<KindStock> GetBranchesStores(bool isActive, string userName, string[] branchesList)
    {
        var userType = _loadMethods.LoadSingle<User>(false, u => u.Name == userName)?.Type;
        var branchesIds = branchesList.Select(int.Parse);
        var stores = _loadMethods.GetQueryable<CompanyBranch>().Where(b => b.Active == isActive && branchesIds.Contains(b.Id)).Include(b => b.KindStocks).SelectMany(b => b.KindStocks);

        switch (userType)
        {
            case "SA":
            case "ReadOnly":
            case "BA":
                return stores.ToList();
            default:
                var userStoresResource =
                    _loadMethods.LoadSingle<UsersResource>(false, usr => usr.Module == "Stores")?.Ids;

                if (userStoresResource == null) 
                    return new List<KindStock>();

                if (userStoresResource == "*")
                    return stores.ToList();

                var storesIds = userStoresResource.Split(',').Select(int.Parse);

                return stores.Where(s => storesIds.Contains(s.Id)).ToList();
        }
    }
}
