namespace DataAccess.Domain.Models;

public partial class RTable
{
    public decimal Id { get; set; }
    public int? FloorId { get; set; }
    public int? Num { get; set; }
    public bool? IsBusy { get; set; }
    public decimal? Total { get; set; }
    public decimal? RegNum { get; set; }
    public bool? IsReserved { get; set; }
    public decimal? Link { get; set; }
    public bool? IsLink { get; set; }
    public Guid Rowguid { get; set; }
}
