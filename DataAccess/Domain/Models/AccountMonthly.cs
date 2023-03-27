namespace DataAccess.Domain.Models;

public class AccountMonthly
{
    public int Id { get; set; }
    public string? AccountNumber { get; set; }
    public string AccountName { get; set; } = null!;
    public string? Currency { get; set; }
    public DateTime? Date { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? LocalDebit { get; set; }
    public decimal? LocalCredit { get; set; }
}