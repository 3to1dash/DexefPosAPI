namespace DataAccess.Domain.Models;

public class RentAsset
{
    public int Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public int? ParentId { get; set; }
    public int? AssetOwn { get; set; }
    public int? CostId { get; set; }
    public int? IncomeId { get; set; }
    public int? SpendId { get; set; }
    public int? BranchId { get; set; }
    public bool? Active { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
    public DateTime? Dt { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}