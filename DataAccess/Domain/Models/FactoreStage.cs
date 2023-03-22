namespace DataAccess.Domain.Models;

public class FactoreStage
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public bool? IsProdctuion { get; set; }
    public bool? InCompany { get; set; }
    public decimal? CustId { get; set; }
    public decimal? Halek { get; set; }
    public bool? IsChangeType { get; set; }
    public decimal? Branchid { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? HalekId { get; set; }
    public decimal? SpentId { get; set; }
    public decimal? CostId { get; set; }
    public bool? IsGroup { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Balance { get; set; }
    public Guid Rowguid { get; set; }
}
