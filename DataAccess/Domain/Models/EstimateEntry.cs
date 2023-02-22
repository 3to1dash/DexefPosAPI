namespace DataAccess.Domain.Models;

public partial class EstimateEntry
{
    public int Id { get; set; }
    public int? EstimateId { get; set; }
    public string? Code { get; set; }
    public int? KindId { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public decimal? UsedQty { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? LocalPrice { get; set; }
    public decimal? LocalTotal { get; set; }
}
