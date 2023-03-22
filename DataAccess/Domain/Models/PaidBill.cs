namespace DataAccess.Domain.Models;

public class PaidBill
{
    public decimal? Num { get; set; }
    public decimal? Regnum { get; set; }
    public decimal? Billindex { get; set; }
    public decimal? Billregnum { get; set; }
    public decimal? Billnum { get; set; }
    public Guid Rowguid { get; set; }
}
