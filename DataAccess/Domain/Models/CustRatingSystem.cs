namespace DataAccess.Domain.Models;

public partial class CustRatingSystem
{
    public decimal Id { get; set; }
    public string? ItemType { get; set; }
    public decimal? Level1 { get; set; }
    public decimal? Level2 { get; set; }
    public decimal? Level3 { get; set; }
    public decimal? Level4 { get; set; }
    public decimal? Level5 { get; set; }
    public Guid Rowguid { get; set; }
}
