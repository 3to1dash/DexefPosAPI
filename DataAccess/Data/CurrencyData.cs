using DataAccess.Domain.Models;
using DataAccess.IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class CurrencyData
{
    private readonly ILoadMethods _loadMethods;
    public CurrencyData(ILoadMethods loadMethods)
    {
        _loadMethods = loadMethods;
    }

    public List<Currency>? GetCurrencies()
    {
        var quary = _loadMethods.LoadMultiple<Currency>(false);
        return quary.ToList();
    }

    public Currency? GetSearchedCurrency(string income)
    {
        return _loadMethods.LoadSingle<Currency>(
            false,c => c.Name.Contains(income));
    }
}

