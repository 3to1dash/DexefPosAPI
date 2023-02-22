namespace DataAccess.Domain.Models;

public partial class EstimateShip
{
    public int Id { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public string? Dthijri { get; set; }
    public string? Num { get; set; }
    public string? Dafter { get; set; }
    public int? BillNum { get; set; }
    public int? EstimateId { get; set; }
    public DateTime? ShipDt { get; set; }
    public string? Name { get; set; }
    public int? CompanyShippingId { get; set; }
    public DateTime? DtArrival { get; set; }
    public int? Waybill { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? ItemCount { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdateBy { get; set; }
}
