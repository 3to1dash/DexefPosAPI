using DataAccess.Domain.Models;
using DataAccess.IDataAccess;

namespace DataAccess.Data;
public class CpuData
{
    private readonly ILoadMethods _loadMethods;
    private readonly IAddMethods _addMethods;
    private readonly ISaveChangesMethods _saveChangesMethods;


    public CpuData(ILoadMethods loadMethods, IAddMethods addMethods, ISaveChangesMethods saveChangesMethods)
    {
        _loadMethods = loadMethods;
        _addMethods = addMethods;
        _saveChangesMethods = saveChangesMethods;
    }
    public int? GetPcNumber()
    {
        var pcNum = _loadMethods.LoadMultiple<CurrentPc>(true).MaxBy(c => c.Pcnumber).Pcnumber;
        return pcNum;
    }

    public void AddCpu(int cpuNum, string cpuName)
    {
        CurrentPc pc = new()
        {
            Pcnumber = cpuNum,
            PcName = cpuName
        };
        _addMethods.AddSingleAsync(pc);
        _saveChangesMethods.Save();
    }



}
