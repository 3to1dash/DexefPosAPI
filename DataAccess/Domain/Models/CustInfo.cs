namespace DataAccess.Domain.Models;

public partial class CustInfo
{
    public decimal? Id { get; set; }
    public string? Name { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Adress { get; set; }
    public Guid Rowguid { get; set; }
}
