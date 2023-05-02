namespace DataAccess.Domain.Models;

public class ShSale
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? CustId { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? Value { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? BoxRegNum { get; set; }
    public Guid Rowguid { get; set; }
}