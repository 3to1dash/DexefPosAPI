namespace DataAccess.Domain.Models;

public class PointsSetting
{
    public int Id { get; set; }
    public bool? CalcByAmount { get; set; }
    public decimal? AmountPoint { get; set; }
    public bool? CalcByItem { get; set; }
    public bool? CalcByItemIsqty { get; set; }
    public bool? CalcByVisits { get; set; }
    public decimal? Visitspoint { get; set; }
    public bool? ReplaceByAmount { get; set; }
    public decimal? ReplaceAmount { get; set; }
    public bool? ReplaceBySlice { get; set; }
    public bool? ReplaceByFreeItem { get; set; }
    public bool? ReplaceByDiscountItem { get; set; }
    public bool? ReplaceByCust { get; set; }
    public Guid Rowguid { get; set; }
}
