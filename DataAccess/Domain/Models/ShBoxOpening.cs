namespace DataAccess.Domain.Models;

public partial class ShBoxOpening
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public bool? IsCust { get; set; }
    public bool? Isvendor { get; set; }
    public bool? IsBranch { get; set; }
    public bool? IsStore { get; set; }
    public decimal? CustId { get; set; }
    public decimal? Value { get; set; }
    public decimal? Box { get; set; }
    public decimal? BoxRent { get; set; }
    public decimal? Rent { get; set; }
    public decimal? DiffPrice { get; set; }
    public decimal? BoxSum { get; set; }
    public decimal? TotalBox { get; set; }
    public decimal? TotalBoxRent { get; set; }
    public decimal? Total { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? CapitalId { get; set; }
    public decimal? RegNum { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? Ship { get; set; }
    public decimal? Balance { get; set; }
    public Guid Rowguid { get; set; }
}
