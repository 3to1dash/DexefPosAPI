namespace DataAccess.Domain.Models;

public partial class SalariesPay
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public decimal? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? RegNum { get; set; }
    public string? WorkIds { get; set; }
    public decimal? CalcId { get; set; }
    public decimal? Addition { get; set; }
    public decimal? Deduction { get; set; }
    public decimal? PaymentMethod { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? BankId { get; set; }
    public decimal? PedgeId { get; set; }
    public decimal? TreeId { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? Ship { get; set; }
    public bool? PaytoAll { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? Total { get; set; }
    public decimal? WorkCounts { get; set; }
    public Guid Rowguid { get; set; }
}
