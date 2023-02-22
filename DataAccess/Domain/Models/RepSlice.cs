namespace DataAccess.Domain.Models;

public partial class RepSlice
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? CalcType { get; set; }
    public bool? Active { get; set; }
    public bool? IsReturn { get; set; }
    public decimal? MinSlice { get; set; }
    public decimal? MaxSlice { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public int? SliceCount { get; set; }
    public int? AccountId { get; set; }
    public bool? IsVendor { get; set; }
    public Guid Rowguid { get; set; }
}
