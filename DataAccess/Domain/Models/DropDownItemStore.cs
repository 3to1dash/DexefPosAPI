namespace DataAccess.Domain.Models;

public partial class DropDownItemStore
{
    public int Id { get; set; }
    public int? KindId { get; set; }
    public string? Code { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? RuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? TuName { get; set; }
    public string? UrName { get; set; }
    public bool? IsExp { get; set; }
    public int? Optkind { get; set; }
    public int? StoreId { get; set; }
    public decimal? TotalVal { get; set; }
}
