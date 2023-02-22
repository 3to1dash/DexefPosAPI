namespace DataAccess.Domain.Models;

public partial class CustRating
{
    public decimal Id { get; set; }
    public bool? IsCust { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public short? Important { get; set; }
    public decimal? Level1 { get; set; }
    public decimal? Level21 { get; set; }
    public decimal? Level22 { get; set; }
    public decimal? Level31 { get; set; }
    public decimal? Level32 { get; set; }
    public decimal? Level41 { get; set; }
    public decimal? Level42 { get; set; }
    public decimal? Level5 { get; set; }
    public Guid Rowguid { get; set; }
}
