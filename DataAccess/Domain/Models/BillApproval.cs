namespace DataAccess.Domain.Models;

public partial class BillApproval
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public string? Dealing { get; set; }
    public string? Ship { get; set; }
    public string? BillNum { get; set; }
    public string? WrittenBy { get; set; }
    public string? TargetUser { get; set; }
    public bool? Answer { get; set; }
    public string? AnswerUser { get; set; }
    public DateTime? AnswerDt { get; set; }
    public string? Comment { get; set; }
    public Guid Rowguid { get; set; }
}
