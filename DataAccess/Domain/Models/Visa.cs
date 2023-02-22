namespace DataAccess.Domain.Models;

public partial class Visa
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public string? Num { get; set; }
    public decimal? Perc { get; set; }
    public int? BankId { get; set; }
    public bool? Active { get; set; }
    public int? DiscountId { get; set; }
    public int? BranchId { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Balance { get; set; }
    public decimal? LocalDebit { get; set; }
    public decimal? LocalCredit { get; set; }
    public decimal? LocalBalance { get; set; }
    public decimal? MaxNum { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public int? AccountId { get; set; }
    public int? CapitalId { get; set; }
    public int? TaxId { get; set; }
    public decimal? OpeningBalance { get; set; }
    public decimal? OpeningRegNum { get; set; }
    public decimal? OpeningTotal { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? Dt { get; set; }
    public Guid Rowguid { get; set; }
}
