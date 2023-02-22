namespace DataAccess.Domain.Models;

public partial class CTender
{
    public decimal Id { get; set; }
    public decimal? OrderId { get; set; }
    public string? Num { get; set; }
    public string? Name { get; set; }
    public decimal? CustId { get; set; }
    public bool? Active { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? DtStart { get; set; }
    public DateTime? DtEnd { get; set; }
    public decimal? Type { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Address { get; set; }
    public string? Note { get; set; }
    public string? Name1 { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? Job1 { get; set; }
    public string? Job2 { get; set; }
    public string? Job3 { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public string? Phone3 { get; set; }
    public decimal? Value { get; set; }
    public int? PayType { get; set; }
    public decimal? ToAccountId { get; set; }
    public decimal? AccountId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? Total { get; set; }
    public decimal? WorkRegNum { get; set; }
    public string? MyDataBase { get; set; }
    public Guid Rowguid { get; set; }
}
