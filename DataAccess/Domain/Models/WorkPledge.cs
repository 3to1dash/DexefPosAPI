namespace DataAccess.Domain.Models;

public class WorkPledge
{
    public int Id { get; set; }
    public int? PledgeId { get; set; }
    public int? EmpId { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Remain { get; set; }
    public Guid Rowguid { get; set; }
}