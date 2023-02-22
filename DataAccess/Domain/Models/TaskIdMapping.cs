namespace DataAccess.Domain.Models;

public partial class TaskIdMapping
{
    public int Id { get; set; }
    public decimal? OldTaskId { get; set; }
    public decimal? NewTaskId { get; set; }
    public string? Dealing { get; set; }
}
