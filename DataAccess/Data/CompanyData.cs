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

    public List<Company> GetCompanies(string userName)
    {
        var userBranchesResource =
            _loadMethods
                .LoadSingle<UsersResource>(false, usr => usr.Module == "Branch" && usr.UserName == userName)
                ?.Ids ?? "";

        var companiesWithCurrencies = _loadMethods.GetQueryable<Company>()
            .Include(e => e.CurrencyTable).ToList();

        var branchesWithStores = _loadMethods.GetQueryable<CompanyBranch>()
            .Include(e => e.KindStocks).ToList();

        switch (userBranchesResource)
        {
            case "*":
            case "":
                var AllCompaniesQueryable = from company in companiesWithCurrencies
                    join branch in branchesWithStores on company.Id equals branch.CompanyId into gj
                    let a = gj.DefaultIfEmpty()
                    select new Company
                    {
                        Id = company.Id,
                        Name = company.Name,
                        Field = company.Field,
                        Phone = company.Phone,
                        CurrencyTable = company.CurrencyTable,
                        CompanyBranches = a.ToList()
                    };

                return AllCompaniesQueryable.ToList();
            default:
                var branchesIds = userBranchesResource.Split(',').Select(int.Parse);

                var companiesQueryable = from company in companiesWithCurrencies
                    join branch in branchesWithStores.Where(b => branchesIds.Contains(b.Id)) on company.Id equals branch
                        .CompanyId into gj
                    let a = gj.DefaultIfEmpty()
                    select new Company
                    {
                        Id = company.Id,
                        Name = company.Name,
                        Field = company.Field,
                        Phone = company.Phone,
                        CurrencyTable = company.CurrencyTable,
                        CompanyBranches = a.ToList()
                    };

                return companiesQueryable.ToList();
        }
    }
}