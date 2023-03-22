namespace DataAccess.Domain.Models;

public class RpsAccount
{
    public int Id { get; set; }
    public decimal? Num { get; set; }
    public string? ArName { get; set; }
    public int? ParentId { get; set; }
    public string? Operands { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public decimal Balance { get; set; }
}
