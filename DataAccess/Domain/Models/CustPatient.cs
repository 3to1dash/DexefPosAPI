namespace DataAccess.Domain.Models;

public partial class CustPatient
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Custid { get; set; }
    public string? Type { get; set; }
    public string? Name { get; set; }
    public string? Sex { get; set; }
    public string? Year { get; set; }
    public string? Month { get; set; }
    public string? Phone { get; set; }
    public string? Adress { get; set; }
    public decimal? Regnum { get; set; }
    public decimal? Runnum { get; set; }
    public Guid Rowguid { get; set; }
}
