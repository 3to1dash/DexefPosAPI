namespace DataAccess.Domain.Models;

public class PointsCard
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? CustId { get; set; }
    public int CardNumber { get; set; }
    public string? CustMob { get; set; }
    public decimal? Amount { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public DateTime? IssueDt { get; set; }
    public DateTime? LastUse { get; set; }
    public int? ContantVia { get; set; }
    public int? AccountId { get; set; }
    public int? Payindex { get; set; }
    public int? CapltalId { get; set; }
    public bool? Active { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? Netpoints { get; set; }
    public int? InPoints { get; set; }
    public int? OutPoints { get; set; }
    public Guid Rowguid { get; set; }
}
