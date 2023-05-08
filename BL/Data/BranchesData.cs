using DataAccess.Domain.Models;
using DataAccess.IDataAccess;
using Microsoft.EntityFrameworkCore;

namespace BL.Data;

public class BranchesData
{
    private readonly ILoadMethods _loadMethods;

    public BranchesData(ILoadMethods loadMethods)
    {
        _loadMethods = loadMethods;
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
                    _loadMethods
                        .LoadSingle<UsersResource>(false, usr => usr.Module == "Branch" && usr.UserName == userName)
                        ?.Ids;

                if (userBranchesResource == null)
                    return new List<CompanyBranch>();

                if (userBranchesResource == "*")
                    return _loadMethods.LoadMultiple<CompanyBranch>(false, b => b.Active == isActive);

                var branchesIds = userBranchesResource.Split(',').Select(int.Parse);

                return _loadMethods.LoadMultiple<CompanyBranch>(false,
                    b => b.Active == isActive && branchesIds.Contains(b.Id));
        }
    }

    public List<KindStock> GetBranchesStores(bool isActive, string userName, string branchesList)
    {
        var userType = _loadMethods.LoadSingle<User>(false, u => u.Name == userName)?.Type;
        var branchesIds = branchesList.Split(',').Select(int.Parse);

        var stores = _loadMethods.GetQueryable<KindStock>()
            .Include(b => b.CompanyBranch)
            .Where(e => branchesIds.Any(i => i == e.CompanyBranch.Id));

        switch (userType)
        {
            case "SA":
            case "ReadOnly":
            case "BA":
                return stores.ToList();
            default:
                var userStoresResource =
                    _loadMethods
                        .LoadSingle<UsersResource>(false, usr => usr.Module == "Stores" && usr.UserName == userName)
                        ?.Ids;

                if (userStoresResource == null)
                    return new List<KindStock>();

                if (userStoresResource == "*")
                    return stores.ToList();

                var storesIds = userStoresResource.Split(',').Select(int.Parse);

                return stores.Where(s => storesIds.Contains(s.Id)).ToList();
        }
    }

    public List<Taxes> GetTaxes(bool isActive)
    {
        return _loadMethods.LoadMultiple<Taxes>(true, t => t.Active == isActive).ToList();
    }

    public int GetAccountMainMaxRegNum(int? branchId)
    {
        var num = _loadMethods.GetQueryable<Accountmain>().Where(a => a.BranchId == branchId)
            .OrderByDescending(a => a.RegNum).FirstOrDefault()?.RegNum;

        if (num is null) return 0 + 1;

        return (int)num + 1;
    }

    public bool LoadPrefix(string dealing, int branchId, int cpu, DateTime dtNow, out string? prefix, out int? startNumber)
    {
        var invoicePrefix = _loadMethods.LoadSingle<InvoicePrefix>(false, i => i.Dealing == dealing && i.BranchId == branchId);

        if (invoicePrefix == null)
        {
            prefix = string.Empty;
            startNumber = 1;
            return false;
        }

        return GetNormalPrefixNumber(invoicePrefix, cpu, dtNow, out prefix, out startNumber);
    }

    public void GetBillNumber(int branchId, string? table, string? prefix, int? startNumberingFrom, out int? number, out int billNumber, bool isBill = true)
    {
        if (table == null)
        {
            number = 1;
            billNumber = 1;
            return;
        }

        if (branchId == 0)
        {
            number = 1;
            billNumber = 1;
            return;
        }

        int? iNum;
        int num;
        int billIndex = 0;

        string sqlQuery;
        if (isBill)
        {
            sqlQuery =
                @$"SELECT Isnull(Max(num), 0) num,
                            (SELECT Isnull(Max(bill_index), 0) Bill_index
                            FROM {0}
                            WHERE branchid = {1}) Bill_index
                        FROM {0}
                        WHERE prefix = {2} AND branchid = {1} AND Isnull(deleted, 0) = 0 AND Isnull(updated, 0) = 0";
        }
        else
        {
            sqlQuery = $"SELECT Isnull(Max(num), 0) num FROM {0} WHERE dafter = {2} AND branchid = {1}";
        }

        try
        {
            num = _loadMethods.ExecuteRawSql<int>(sqlQuery, new object[] { table, branchId, prefix }).First();
        }
        catch (Exception)
        {
            number = 0;
            billNumber = 0;
            return;
        }

        if (isBill) billIndex = num + 1;

        if (num >= startNumberingFrom) iNum = num + 1;
        else iNum = startNumberingFrom;

        number = iNum;
        billNumber = billIndex;
    }

    private static bool GetNormalPrefixNumber(
        InvoicePrefix invoicePrefix, int cpu, DateTime dateNow,
        out string? prefix, out int? startNumber)
    {
        if (invoicePrefix.AutoNumber == false)
        {
            prefix = string.Empty;
            startNumber = invoicePrefix.StartFrom;
            return false;
        }

        if (invoicePrefix.UseCpu == false)
        {
            if (invoicePrefix.StartEveryDay == false)
            {
                prefix = invoicePrefix.Prefix;
                startNumber = invoicePrefix.StartFrom;
                return true;
            }

            if (invoicePrefix.StartEveryDay == true)
            {
                var branchPrefix = invoicePrefix.Prefix + dateNow.Year.ToString("yy") + dateNow.DayOfYear;
                prefix = branchPrefix;
                startNumber = invoicePrefix.StartFrom;
                return true;
            }
        }
        else if (invoicePrefix.UseCpu == true)
        {
            if (invoicePrefix.StartEveryDay == false)
            {
                var branchPrefix = invoicePrefix.Prefix + cpu;
                prefix = branchPrefix;
                startNumber = invoicePrefix.StartFrom;
                return true;
            }

            if (invoicePrefix.StartEveryDay == true)
            {
                var branchPrefix = invoicePrefix.Prefix + dateNow.ToString("yy") + dateNow.DayOfYear + cpu;
                prefix = branchPrefix;
                startNumber = invoicePrefix.StartFrom;
                return true;
            }
        }

        prefix = string.Empty;
        startNumber = invoicePrefix.StartFrom;
        return true;
    }
}