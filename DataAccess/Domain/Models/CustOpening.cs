namespace DataAccess.Domain.Models;

public class CustOpening
{
    public decimal Id { get; set; }
    public decimal? BranchId { get; set; }
    public int? CustId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public string? Note { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? Total { get; set; }
    public int? CapitalId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? CustType { get; set; }
    public Guid Rowguid { get; set; }
}
