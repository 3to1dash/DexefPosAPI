using System.Globalization;
using DataAccess.Domain.Models;
using DataAccess.IDataAccess;

namespace DataAccess.Data;

public class BasicData
{
    private readonly ILoadMethods _loadMethods;
    private readonly IAddMethods _addMethods;
    private readonly ISaveChangesMethods _saveChangesMethods;

    public BasicData(
        ILoadMethods loadMethods,
        IAddMethods addMethods,
        ISaveChangesMethods saveChangesMethods)
    {
        _loadMethods = loadMethods;
        _addMethods = addMethods;
        _saveChangesMethods = saveChangesMethods;
    }

    public async Task<double?> GetTaskIdByCpu(int cpu)
    {
        var bid = 86 + cpu;

        var num = _loadMethods.LoadMultiple<TaskHistory>(true, h => h.Cpu == cpu).Select(n =>
                long.Parse(
                    $"{n.TaskId:0.################################################################}".Split('.')[1]))
            .DefaultIfEmpty().Max();

        var mostRightDigit = (int) (num % 10);
        if (mostRightDigit == 9) num += 2;
        else num += 1;

        var taskId = (num / Math.Pow(10.0, num.ToString(CultureInfo.CurrentCulture).Length)) + bid;

        var taskHistory = new TaskHistory {Cpu = cpu, Num = null, TaskId = (decimal) taskId};

        _addMethods.AddSingle(taskHistory);

        try
        {
            var _ = await _saveChangesMethods.Save();
            return taskId;
        }
        catch (Exception)
        {
            return null;
        }
    }
}