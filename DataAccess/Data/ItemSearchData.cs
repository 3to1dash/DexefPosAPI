using DataAccess.Domain.Models;
using DataAccess.IDataAccess;
using DataAccess.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class ItemSearchData
{
    private readonly ILoadMethods _loadMethods;
    public ItemSearchData(ILoadMethods loadMethods)
    {
        _loadMethods = loadMethods;
    }

    public List<ItemSearch> GetAllItemSearch(int store_id,int groupid, string OldId, int page)
    {
        int num;
        int.TryParse(OldId, out num);
        var asd = _loadMethods.LoadMultiple<ItemSearch>
            ( false, i =>
              (i.Optkind == 0 || i.Optkind == 2 || i.Optkind == 3) &&
              i.StoreId == store_id &&
              i.ParentId == groupid &&
              i.Id != num
            )
            .OrderByDescending(i=>i.ArName)
            .ToList(); 
        return asd;
    }
}

