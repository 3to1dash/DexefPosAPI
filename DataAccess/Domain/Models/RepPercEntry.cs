namespace DataAccess.Domain.Models;

public class RepPercEntry
{
    public int Id { get; set; }
    public int? RepPercId { get; set; }
    public int? RepId { get; set; }
    public int? SliceId { get; set; }
    public int? Counts { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public decimal? Sales { get; set; }
    public decimal? ReSales { get; set; }
    public decimal? NetAmount { get; set; }
    public string? SliceName { get; set; }
    public decimal? RepPerc { get; set; }
    public decimal? RepAmount { get; set; }
    public int? SliceAccountId { get; set; }
    public int? WorkId { get; set; }
    public int? WorkAccountId { get; set; }
    public bool? IsDone { get; set; }
    public string? RepType { get; set; }
    public bool? IsCredit { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public Guid Rowguid { get; set; }
}
