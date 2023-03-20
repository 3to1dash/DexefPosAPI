using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccess.Domain.Models;

public partial class CompanyBranch
{
    [NotMapped]
    private int? _companyId;
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

    public int? CompanyId
    {
        get => _companyId ?? 1;
        set => _companyId = value;
    }

    public string? TaxBranchId { get; set; }
    public string? ActivityId { get; set; }
    public string? PostalNumber { get; set; }
    public bool? IsMasterBranch { get; set; }
    public string? AppNumber { get; set; }
    public string? AdditionalNumber { get; set; }
    public string? Field { get; set; }
    public string? Tax { get; set; }
    public string? Trade { get; set; }
    public byte[]? Logo { get; set; }

    public virtual List<KindStock> KindStocks { get; set; }
    [JsonIgnore]
    public virtual Company? Company { get; set; }
    public virtual CurrencyTable? CountryNavigation { get; set; }
    public virtual List<TripAirLineCommission> TripAirLineCommissions { get; set; }
    public virtual List<TripCommission> TripCommissions { get; set; }
    public virtual List<TripContract> TripContracts { get; set; }
    public virtual List<TripIatum> TripIata { get; set; }
    public virtual List<TripTicket> TripTickets { get; set; }
    public virtual List<TripUser> TripUsers { get; set; }
}
