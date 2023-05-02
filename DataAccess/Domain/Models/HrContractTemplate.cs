namespace DataAccess.Domain.Models;

public class HrContractTemplate
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
    public string? Note { get; set; }
    public bool? IsOpenContract { get; set; }
    public int? MaxMonths { get; set; }
    public int? PayScheduleId { get; set; }
    public int? WorkingPolicyId { get; set; }
    public int? DedcutionHourId { get; set; }
    public int? AdditionHourId { get; set; }
    public bool? Taxable { get; set; }
    public int? TaxId { get; set; }
    public bool? Insuranceable { get; set; }
    public int? InsuranceId { get; set; }
    public int? Productionable { get; set; }
    public int? ProductionId { get; set; }
}