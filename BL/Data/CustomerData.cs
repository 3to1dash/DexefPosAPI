using DataAccess.Domain.Models;
using DataAccess.IDataAccess;

namespace BL.Data;

public class CustomerData
{
    private readonly IAddMethods _addMethods;
    private readonly ILoadMethods _loadMethods;
    private readonly ISaveChangesMethods _saveChangesMethods;
    private readonly BasicData _basicData;
    private readonly BranchesData _branchesData;

    public CustomerData(
        IAddMethods addMethods,
        ILoadMethods loadMethods,
        ISaveChangesMethods saveChangesMethods,
        BasicData basicData,
        BranchesData branchesData)
    {
        _addMethods = addMethods;
        _loadMethods = loadMethods;
        _saveChangesMethods = saveChangesMethods;
        _basicData = basicData;
        _branchesData = branchesData;
    }

    public async Task<int> SaveCustomer(Cust customer, int cpu, string operand)
    {
        try
        {
            customer.Accountid = _loadMethods.LoadSingle<AccountOperand>(false, e => e.Operand == operand)?.AccountId;
            customer.CustIndex = _loadMethods.GetQueryable<Cust>().Max(e => e.CustIndex) + 1 ?? 1;
            customer.TaskId = await _basicData.GetTaskIdByCpu(cpu);
            customer.RegNum = _branchesData.GetAccountMainMaxRegNum(customer.BranchId);
            customer.Isdebit = true;

            _addMethods.AddSingle(customer);
            await _saveChangesMethods.Save();
            return customer.Id;
        }
        catch (Exception)
        {
            return 0;
        }
    }

    public IEnumerable<Cust> GetCustomers(int branchId, string kind, string oldId, int offset = 0, int page = 15)
    {
        var customers = _loadMethods.GetQueryable<Cust>();
        var taxes = _loadMethods.GetQueryable<Taxes>();

        var oldIds = oldId.Split(',').Select(int.Parse).ToArray();

        try
        {
            var customer = (
                from cl in customers
                join cr in customers on cl.ParentId equals cr.Id into clr
                from g in clr.DefaultIfEmpty()
                join t in taxes on cl.Tax equals t.Id into clt
                from t in clt.DefaultIfEmpty()
                orderby cl.Name
                where cl.Active == true && cl.TypeIndex == 0
                                        && (cl.ShowInAll == true || cl.BranchId == branchId)
                                        && cl.Kind == kind
                                        && !oldIds.Contains(cl.Id)
                select new Cust
                {
                    Id = cl.Id,
                    Num = cl.Num,
                    Name = cl.Name,
                    GrpName = g.Name,
                    FirstName = cl.FirstName,
                    TotalBalance = cl.Debit - cl.Credit,
                    Costid = cl.Costid,
                    Currency = cl.Currency,
                    CashDiscount = cl.CashDiscount,
                    GroupDiscount = cl.GroupDiscount,
                    Tax = cl.Tax,
                    Prefix = cl.Prefix,
                    Person = cl.Person,
                    Phone1 = cl.Phone1,
                    Phone2 = cl.Phone2,
                    Phone3 = cl.Phone3,
                    Adress = cl.Adress,
                    PriceLevel = cl.PriceLevel,
                    Kind = cl.Kind,
                    ShowInAll = cl.ShowInAll,
                    TypeIndex = cl.TypeIndex,
                    BranchId = cl.BranchId,
                    DefaultCash = cl.DefaultCash,
                    RepId = cl.RepId,
                    CreditLimit = cl.CreditLimit,
                    Taxable = cl.Taxable,
                    TaxPerc = t.PurchaseTax ?? 0,
                    TaxName = t.Name
                })
                .Skip(offset)
                .Take(page);

            return customer.ToList();
        }
        catch (Exception e)
        {
            return new List<Cust>();
        }
    }
}