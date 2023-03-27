namespace DataAccess.Domain.Models;

public class TripGd
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Name { get; set; }
    public bool? IslowCost { get; set; }
    public int? IataId { get; set; }
    public int? AirLineId { get; set; }
    public int? CustId { get; set; }
    public bool? LoadTickets { get; set; }
    public string? FileExe { get; set; }
    public string? FilePath { get; set; }
    public int? ReadEvery { get; set; }
    public string? Gdstype { get; set; }
    public bool? SetInAccounts { get; set; }
    public string? Notes { get; set; }
    public Guid Rowguid { get; set; }
    public bool? IsCommIncludeTax { get; set; }
    public bool? IsaddCommission { get; set; }

    public virtual List<TripContract> TripContracts { get; set; }
    public virtual List<TripTicket> TripTickets { get; set; }
    public virtual List<TripUser> TripUsers { get; set; }
}