namespace DataAccess.Domain.Models;

public partial class Pledge
{
    public int Id { get; set; }
    public decimal? Num { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Workid { get; set; }
    public bool? Active { get; set; }
    public string? Note { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public decimal Balance { get; set; }
    public decimal LocalDebit { get; set; }
    public decimal LocalCredit { get; set; }
    public decimal LocalBalance { get; set; }
    public int? BranchId { get; set; }
    public int? Accountid { get; set; }
    public int? CapitalId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? OpeningBalance { get; set; }
    public decimal? OpeningRegNum { get; set; }
    public decimal? OpeningTotal { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
}
