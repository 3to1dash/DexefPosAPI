namespace DataAccess.Domain.Models;

public partial class KindBounesEntry
{
    public int Id { get; set; }
    public int? BounesId { get; set; }
    public decimal Amount { get; set; }
    public decimal? Discount { get; set; }
}
