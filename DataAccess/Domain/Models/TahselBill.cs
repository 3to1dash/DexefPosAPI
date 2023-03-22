namespace DataAccess.Domain.Models;

public class TahselBill
{
    public decimal Id { get; set; }
    public decimal? Billid { get; set; }
    public decimal? Cashid { get; set; }
    public Guid Rowguid { get; set; }
}
