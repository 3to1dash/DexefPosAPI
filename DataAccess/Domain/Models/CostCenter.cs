namespace DataAccess.Domain.Models;

public class CostCenter
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public short? Type { get; set; }
    public DateTime? Dt { get; set; }
    public decimal Num { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public bool? Active { get; set; }
    public decimal? Target { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public int? GroupId { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Begindebit { get; set; }
    public decimal? Begincredit { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Balance { get; set; }
    public decimal? LocalDebit { get; set; }
    public decimal? LocalCredit { get; set; }
    public decimal? LocalBalance { get; set; }
    public int? BranchId { get; set; }
    public string? Currency { get; set; }
    public Guid Rowguid { get; set; }
}