namespace DataAccess.Domain.Models;

public partial class EmplContractTemplate
{
    public int Id { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? Writtenby { get; set; }
    public DateTime? Dt { get; set; }
    public bool? Active { get; set; }
    public int? ContractTypeId { get; set; }
    public int? AttendPolicyId { get; set; }
    public int? AbsenceDayId { get; set; }
    public int? ExtraDayId { get; set; }
    public int? ExtraHourId { get; set; }
    public int? DiscountHourId { get; set; }
    public int? DiscountAmountId { get; set; }
    public int? ExtraAmountId { get; set; }
    public bool? Taxable { get; set; }
    public int? TaxId { get; set; }
    public bool? Insuranceable { get; set; }
    public int? InsuranceId { get; set; }
    public bool? Productionable { get; set; }
    public int? ProductionId { get; set; }
    public bool? IsSalesRep { get; set; }
    public int? SalesRepSliceId { get; set; }
}
