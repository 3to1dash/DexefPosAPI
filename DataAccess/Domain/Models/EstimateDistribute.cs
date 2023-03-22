namespace DataAccess.Domain.Models;

public class EstimateDistribute
{
    public decimal Id { get; set; }
    public decimal? ShipId { get; set; }
    public decimal? EstimateId { get; set; }
    public decimal? Kindid { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public decimal? LocalPrice { get; set; }
    public decimal? Total { get; set; }
    public decimal? LocalTotal { get; set; }
    public decimal? Rate { get; set; }
    public Guid Rowguid { get; set; }
}
