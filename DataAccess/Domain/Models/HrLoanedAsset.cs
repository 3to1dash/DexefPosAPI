namespace DataAccess.Domain.Models;

public class HrLoanedAsset
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public string? Name { get; set; }
    public int? GroupId { get; set; }
    public string? Serial { get; set; }
    public DateTime? Dtloaned { get; set; }
    public DateTime? Dtreturned { get; set; }
    public decimal? AssetCost { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Note { get; set; }
}
