namespace DataAccess.Domain.Models;

public partial class PotDemo
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Custid { get; set; }
    public string? Mail { get; set; }
    public string? WrittenBy { get; set; }
    public string? Type { get; set; }
    public Guid Rowguid { get; set; }
}
