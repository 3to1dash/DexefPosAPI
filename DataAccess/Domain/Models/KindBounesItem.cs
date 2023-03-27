namespace DataAccess.Domain.Models;

public class KindBounesItem
{
    public decimal Id { get; set; }
    public int? BounesId { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public int? KindId { get; set; }
    public int? ItemId { get; set; }
    public string? Unite { get; set; }
    public Guid Rowguid { get; set; }
}