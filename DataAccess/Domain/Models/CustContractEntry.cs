namespace DataAccess.Domain.Models;

public class CustContractEntry
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? ContractId { get; set; }
    public int? CustId { get; set; }
    public int? RowId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public bool? IsPaid { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public bool? Runing { get; set; }
    public decimal? TaskId { get; set; }
    public DateTime? PaidDt { get; set; }
    public Guid Rowguid { get; set; }
}