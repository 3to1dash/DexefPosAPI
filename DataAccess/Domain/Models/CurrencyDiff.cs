namespace DataAccess.Domain.Models;

public partial class CurrencyDiff
{
    public int Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public int? ProfitId { get; set; }
    public int? LossId { get; set; }
    public string? Ship { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Loss { get; set; }
    public decimal? Profit { get; set; }
    public int? Counts { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public Guid Rowguid { get; set; }
}
