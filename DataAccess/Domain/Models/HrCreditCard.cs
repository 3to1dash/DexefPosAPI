namespace DataAccess.Domain.Models;

public class HrCreditCard
{
    public int Id { get; set; }
    public int? EmplId { get; set; }
    public int? CardId { get; set; }
    public int? CardNum { get; set; }
    public DateTime? DtExpiration { get; set; }
    public decimal? Limit { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Note { get; set; }
}
