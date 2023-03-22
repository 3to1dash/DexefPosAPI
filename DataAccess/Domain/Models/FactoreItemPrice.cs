namespace DataAccess.Domain.Models;

public class FactoreItemPrice
{
    public decimal Id { get; set; }
    public decimal? StageId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? KindId { get; set; }
    public decimal? Price { get; set; }
    public decimal? Value { get; set; }
    public string? Unite { get; set; }
    public Guid Rowguid { get; set; }
}
