namespace DataAccess.Domain.Models;

public partial class EstimateDealing
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? EstimateId { get; set; }
    public decimal? SpentId { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? ShipId { get; set; }
    public bool? Isship { get; set; }
    public string? Ship { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Value { get; set; }
    public decimal? PayType { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? Total { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? WorkRegNum { get; set; }
    public decimal? Costid { get; set; }
    public Guid Rowguid { get; set; }
}
