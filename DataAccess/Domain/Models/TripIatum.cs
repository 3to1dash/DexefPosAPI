namespace DataAccess.Domain.Models;

public class TripIatum
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Num { get; set; }
    public string? Name { get; set; }
    public int? CustId { get; set; }
    public int? PayEvey { get; set; }
    public int? AlarmDays { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string? Notes { get; set; }
    public Guid Rowguid { get; set; }

    public virtual CompanyBranch? Branch { get; set; }
    public virtual Cust? Cust { get; set; }
}
