using DataAccess.Domain.Models;
using DataAccess.IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class AccountMainData
{
    private readonly ILoadMethods _loadMethods;
    public AccountMainData(ILoadMethods loadMethods)
    {
        _loadMethods = loadMethods;
    }
    public decimal? GetAcountMainByBranchid(decimal branchid)
    {
      var RegNum = _loadMethods.LoadMultiple<Accountmain>(false, a => a.BranchId == branchid )
            .Select(e => (decimal)e.RegNum).DefaultIfEmpty().Max();
      return RegNum == 0 ? RegNum += 1 : RegNum ;
    }
}
