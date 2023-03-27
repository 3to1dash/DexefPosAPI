namespace DataAccess.Domain.Models;

public class RpsBank
{
    public decimal Id { get; set; }
    public string? Num { get; set; }
    public string? Arname { get; set; }
    public string? Branch { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public decimal Balance { get; set; }
}