namespace DataAccess.Domain.Models;

public class CurrencyDiffEntry
{
    public decimal Id { get; set; }
    public int? AccountId { get; set; }
    public byte? Journal { get; set; }
    public bool? Iscredit { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? TaskId { get; set; }
    public Guid Rowguid { get; set; }
}