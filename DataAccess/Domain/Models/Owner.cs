namespace DataAccess.Domain.Models;

public partial class Owner
{
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Phone { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Adress { get; set; }
    public decimal? Raseed { get; set; }
    public decimal? Firstraseed { get; set; }
    public decimal? Share { get; set; }
    public Guid Rowguid { get; set; }
}
