using DataAccess.Domain.Models;
using DataAccess.IDataAccess;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data;

public class CompanyData
{
    private readonly ILoadMethods _loadMethods;

    public CompanyData(ILoadMethods loadMethods)
    {
        _loadMethods = loadMethods;
    }

    public Company GetCompany(string userName)
    {
        var userBranchesResource =
            _loadMethods
                .LoadSingle<UsersResource>(false, usr => usr.Module == "Branch" && usr.UserName == userName)
                ?.Ids ?? "";

        var company = _loadMethods.GetQueryable<Company>().Include(e => e.CurrencyTable).Include(e => e.CompanyBranches)
            .ThenInclude(e => e.KindStocks);
        switch (userBranchesResource)
        {
            case "*":
            case "":
            default:

                var branchesIds = userBranchesResource.Split(',').Select(int.Parse);
                //var w = company.Where(e => e.CompanyBranches.Where(r => branchesIds.Contains(r.Id)).Any());

                var w = company.FirstOrDefault(c => c.CompanyBranches.Any(b => branchesIds.Contains(b.Id)));
                break;
        }


        //if (userBranchesResource == null)
        //return new List<CompanyBranch>();

        //if (userBranchesResource == "*")
        //return _loadMethods.LoadMultiple<CompanyBranch>(false, b => b.Active == isActive);
        return new Company();
    }
}
