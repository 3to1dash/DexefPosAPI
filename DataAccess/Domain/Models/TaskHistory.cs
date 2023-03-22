namespace DataAccess.Domain.Models;

public class TaskHistory
{
    public decimal TaskId { get; set; }
    public decimal? Num { get; set; }
    public int? Cpu { get; set; }
    public Guid Rowguid { get; set; }
}
