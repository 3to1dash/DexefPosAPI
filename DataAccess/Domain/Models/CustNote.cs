namespace DataAccess.Domain.Models;

public class CustNote
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Custid { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? CustType { get; set; }
    public decimal? BranchId { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}