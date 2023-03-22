namespace DataAccess.Domain.Models;

public class EstimateShipItem
{
    public int Id { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public int? EstimateId { get; set; }
    public DateTime? ShipDt { get; set; }
    public string? Name { get; set; }
    public decimal? Spent { get; set; }
    public bool? IsClosed { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
    public Guid Rowguid { get; set; }
}
