namespace DataAccess.Domain.Models;

public partial class RpsItemIndex
{
    public int Id { get; set; }
    public int KindId { get; set; }
    public string? Code { get; set; }
    public string? ItemName { get; set; }
    public bool? IsExp { get; set; }
    public int? Optkind { get; set; }
    public int? StoreId { get; set; }
    public decimal? TotalVal { get; set; }
    public decimal? Buy { get; set; }
    public decimal? Sale { get; set; }
    public int? VendorId { get; set; }
    public string? GroupName { get; set; }
    public string? Txt1 { get; set; }
    public string? Txt2 { get; set; }
    public string? Txt3 { get; set; }
    public string? Txt4 { get; set; }
    public string? Txt5 { get; set; }
    public string? Txt6 { get; set; }
    public string? Txt7 { get; set; }
    public string? Txt8 { get; set; }
}
