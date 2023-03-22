namespace DataAccess.Domain.Models;

public class Account
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public int? RootId { get; set; }
    public decimal? Num { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public bool? Isparent { get; set; }
    public string? Currency { get; set; }
    public string? Operands { get; set; }
    public int? TypeId { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public decimal Balance { get; set; }
    public DateTime? Dt { get; set; }
    public string? Note { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? Sign { get; set; }
    public decimal? CostType { get; set; }
    public decimal LocalDebit { get; set; }
    public decimal LocalCredit { get; set; }
    public decimal LocalBalance { get; set; }
    public int? ImageIndex { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
