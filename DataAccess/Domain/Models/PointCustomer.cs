namespace DataAccess.Domain.Models;

public class PointCustomer
{
    public int Id { get; set; }
    public int? CustId { get; set; }
    public int? CardId { get; set; }
    public decimal? TotalPoint { get; set; }
    public decimal InPoint { get; set; }
    public decimal? OutPoint { get; set; }
    public decimal? Balance { get; set; }
    public Guid Rowguid { get; set; }
}
