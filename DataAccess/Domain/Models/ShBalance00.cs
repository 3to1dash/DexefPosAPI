namespace DataAccess.Domain.Models;

public partial class ShBalance00
{
    public decimal Id { get; set; }
    public decimal? CustId { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? InBox { get; set; }
    public decimal? InBoxRent { get; set; }
    public decimal? OutBox { get; set; }
    public decimal? OutBoxRent { get; set; }
    public decimal? Balance { get; set; }
    public decimal? InTotalBox { get; set; }
    public decimal? OutTotalBox { get; set; }
    public decimal? BoxSum { get; set; }
    public Guid Rowguid { get; set; }
}
