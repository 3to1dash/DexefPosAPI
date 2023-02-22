namespace DataAccess.Domain.Models;

public partial class Foodtemp
{
    public decimal Id { get; set; }
    public decimal? Kindid { get; set; }
    public string? Kind { get; set; }
    public decimal? Valunite { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public string? Type { get; set; }
    public Guid Rowguid { get; set; }
}
