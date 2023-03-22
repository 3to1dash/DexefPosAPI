namespace DataAccess.Domain.Models;

public class Bank
{
    public decimal Id { get; set; }
    public string? Arname { get; set; }
    public string? Branch { get; set; }
    public string? Num { get; set; }
    public decimal Credit { get; set; }
    public decimal Debit { get; set; }
    public decimal Balance { get; set; }
    public decimal LocalDebit { get; set; }
    public decimal LocalCredit { get; set; }
    public decimal LocalBalance { get; set; }
    public DateTime? Dt { get; set; }
    public string? Adress { get; set; }
    public string? Phone3 { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? AccountType { get; set; }
    public string? Mail { get; set; }
    public bool? Active { get; set; }
    public int? AccountId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Value { get; set; }
    public int? CapitalId { get; set; }
    public int? RegNum { get; set; }
    public decimal? Total { get; set; }
    public bool? IsCredit { get; set; }
    public int? BranchId { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
}
