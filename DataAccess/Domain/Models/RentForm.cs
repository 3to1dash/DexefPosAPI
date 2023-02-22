namespace DataAccess.Domain.Models;

public partial class RentForm
{
    public int? Id { get; set; }
    public int? BranchId { get; set; }
    public bool? ForRent { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public int? AssetId { get; set; }
    public int? RentOpt { get; set; }
    public Guid Rowguid { get; set; }
}
