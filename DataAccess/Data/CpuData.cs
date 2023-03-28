using DataAccess.Domain.Models;
using DataAccess.IDataAccess;

namespace DataAccess.Data;
public class CpuData
{
    private readonly ILoadMethods _loadMethods;

    public CpuData(ILoadMethods loadMethods)
    {
        _loadMethods = loadMethods;
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
        _loadMethods.LoadMultiple<CurrentPc>(true).Add(pc);
    }

}
