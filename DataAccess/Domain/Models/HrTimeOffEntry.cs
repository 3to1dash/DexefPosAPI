namespace DataAccess.Domain.Models;

public class HrTimeOffEntry
{
    public int Id { get; set; }
    public int? TimeOffId { get; set; }
    public decimal? FromAmount { get; set; }
    public decimal? ToAmount { get; set; }
    public decimal? Amount { get; set; }
    public decimal? BasicAmountPerc { get; set; }
    public decimal? ChangedAmountPerc { get; set; }
    public Guid Rowguid { get; set; }
}