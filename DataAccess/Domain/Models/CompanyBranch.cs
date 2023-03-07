using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain.Models;

public partial class CompanyBranch
{
    public CompanyBranch()
    {
        TripAirLineCommissions = new HashSet<TripAirLineCommission>();
        TripCommissions = new HashSet<TripCommission>();
        TripContracts = new HashSet<TripContract>();
        TripIata = new HashSet<TripIatum>();
        TripTickets = new HashSet<TripTicket>();
        TripUsers = new HashSet<TripUser>();
    }

    public int Id { get; set; }
    public string Num { get; set; } = null!;
    public string? Name { get; set; }
    public string? Mobile1 { get; set; }
    public string? Mobile2 { get; set; }
    public string? Mobile3 { get; set; }
    public bool? Active { get; set; }
    public string? Currency { get; set; }
    public decimal? Val1 { get; set; }
    public decimal? Val2 { get; set; }
    public int? CostId { get; set; }
    public string? PurchaseCycle { get; set; }
    public bool? PurchaseReview { get; set; }
    public string? SaleCycle { get; set; }
    public bool? SaleReview { get; set; }
    public string? TransferCycle { get; set; }
    public Guid Rowguid { get; set; }
    public decimal? CountryId { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Subcurrency { get; set; }
    public string? BuildingNumber { get; set; }
    public string? Governorate { get; set; }
    public string? Landmark { get; set; }
    public string? Mail { get; set; }
    public int? ReportTemplateId { get; set; }
    public int? CompanyId { get; set; }
    public string? TaxBranchId { get; set; }
    public string? ActivityId { get; set; }
    [NotMapped]
    public List<KindStock> KindStocks { get; set; }
    //[NotMapped]
    //public string? PostalNumber { get; set; }
    //[NotMapped]
    //public bool? IsMasterBranch { get; set; }
    //[NotMapped]
    //public string? AppNumber { get; set; }
    //[NotMapped]
    //public string? AdditionalNumber { get; set; }
    //[NotMapped]
    //public string? Field { get; set; }
    //[NotMapped]
    //public string? Tax { get; set; }
    //[NotMapped]
    //public string? Trade { get; set; }
    //[NotMapped]
    //public byte[]? Logo { get; set; }

    public virtual Company? Company { get; set; }
    public virtual CurrencyTable? CountryNavigation { get; set; }
    public virtual ICollection<TripAirLineCommission> TripAirLineCommissions { get; set; }
    public virtual ICollection<TripCommission> TripCommissions { get; set; }
    public virtual ICollection<TripContract> TripContracts { get; set; }
    public virtual ICollection<TripIatum> TripIata { get; set; }
    public virtual ICollection<TripTicket> TripTickets { get; set; }
    public virtual ICollection<TripUser> TripUsers { get; set; }
}
