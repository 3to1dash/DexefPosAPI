namespace DataAccess.Domain.Models;

public class WooOrderRefundLine
{
    public decimal Id { get; set; }
    public string Reason { get; set; } = null!;
    public decimal? Total { get; set; }
    public decimal? WooOrderid { get; set; }

    public virtual WooOrder? WooOrder { get; set; }
}