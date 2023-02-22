namespace DataAccess.Domain.Models;

public partial class TempError01
{
    public decimal Id { get; set; }
    public decimal? TaskId { get; set; }
    public int? Accountid { get; set; }
    public string Dealing { get; set; } = null!;
    public int AssignedId { get; set; }
}
