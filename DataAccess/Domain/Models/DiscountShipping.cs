namespace DataAccess.Domain.Models;

public partial class DiscountShipping
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? BranchId { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsAdd { get; set; }
    public string? CalcType { get; set; }
    public decimal? Value { get; set; }
    public int? AccountId { get; set; }
    public bool? IsPerc { get; set; }
    public bool? Editable { get; set; }
    public bool? MustDriver { get; set; }
    public bool? MustCar { get; set; }
    public bool? MustAddress { get; set; }
    public bool? IsCust { get; set; }
    public string? Img { get; set; }
    public string? ButtonImage { get; set; }
    public Guid Rowguid { get; set; }
}
