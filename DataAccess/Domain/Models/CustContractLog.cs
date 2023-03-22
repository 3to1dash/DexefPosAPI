namespace DataAccess.Domain.Models;

public class CustContractLog
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public int? ContractId { get; set; }
    public int? CustId { get; set; }
    public int? AccountId { get; set; }
    public int? CapitalId { get; set; }
    public int? RowId { get; set; }
    public int? TaxId { get; set; }
    public int? CostId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Amount { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? ContractDt { get; set; }
    public decimal? ParentTaskId { get; set; }
    public bool? IsPaid { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public decimal? PaidTaskId { get; set; }
    public Guid Rowguid { get; set; }
}
