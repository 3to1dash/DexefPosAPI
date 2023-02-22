namespace DataAccess.Domain.Models;

public partial class BankDealing
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? Dafter { get; set; }
    public string? BillNum { get; set; }
    public string? Ship { get; set; }
    public DateTime? Dt { get; set; }
    public int? BankId { get; set; }
    public int? CapitalId { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public int? RegNum { get; set; }
    public bool? IsCredit { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public decimal? TaskId { get; set; }
    public Guid Rowguid { get; set; }
}
