namespace DataAccess.Domain.Models;

public partial class CustOverview
{
    public decimal? Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public DateTime? Dtbill { get; set; }
    public decimal? Numbill { get; set; }
    public decimal? Valbill { get; set; }
    public DateTime? Dtreciept { get; set; }
    public decimal? Numreciept { get; set; }
    public decimal? Valreciept { get; set; }
    public decimal? Counts { get; set; }
    public decimal? Balance { get; set; }
    public decimal? Nondeal { get; set; }
    public decimal? Custid { get; set; }
    public Guid Rowguid { get; set; }
}
