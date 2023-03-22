namespace DataAccess.Domain.Models;

public class InstallmentLog
{
    public decimal Id { get; set; }
    public decimal? InstallmentId { get; set; }
    public decimal? Paid { get; set; }
    public decimal? PaidTaskId { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? TaxAmount { get; set; }
    public int? CustId { get; set; }
    public bool? IsCredit { get; set; }
    public int? UnEarnAccountId { get; set; }
    public int? EarnAccountId { get; set; }
    public Guid Rowguid { get; set; }
}
