namespace DataAccess.Domain.Models;

public class TripUser
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Name { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public int? CustIndex { get; set; }
    public int? CustId { get; set; }
    public int? TripGdsId { get; set; }
    public string? Phone { get; set; }
    public string? Mobile { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public string? Email { get; set; }
    public int? ComId { get; set; }
    public bool? CommissionIncludeTaxes { get; set; }
    public Guid Rowguid { get; set; }
    public string? OfficeidCode { get; set; }

    public virtual CompanyBranch? Branch { get; set; }
    public virtual Cust? Cust { get; set; }
    public virtual TripGd? TripGds { get; set; }
    public virtual List<TripTicket> TripTickets { get; set; }
}
