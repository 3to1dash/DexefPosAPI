namespace DataAccess.Domain.Models;

public class RentOpt
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? AssetId { get; set; }
    public string? Name { get; set; }
    public int? Period { get; set; }
    public decimal? Rent { get; set; }
    public decimal? Discount { get; set; }
    public decimal? MinRent { get; set; }
    public decimal? MaxRent { get; set; }
    public decimal? Insurance { get; set; }
    public bool? IsInsurance { get; set; }
    public bool? RentEditable { get; set; }
    public bool? InsuranceEditable { get; set; }
    public Guid Rowguid { get; set; }
}
