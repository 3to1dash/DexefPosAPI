using DataAccess.Domain.Models;
using DataAccess.IDataAccess;

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
}
