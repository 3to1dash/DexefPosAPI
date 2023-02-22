namespace DataAccess.Domain.Models;

public partial class CustInstallment
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Value { get; set; }
    public decimal? Extra { get; set; }
    public decimal? Total { get; set; }
    public decimal? Counts { get; set; }
    public bool? Ismonth { get; set; }
    public decimal? EveryDay { get; set; }
    public DateTime? DtStart { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? PayMonthly { get; set; }
    public decimal? PaidValue { get; set; }
    public Guid Rowguid { get; set; }
}
