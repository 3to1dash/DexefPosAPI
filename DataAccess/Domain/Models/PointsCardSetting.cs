namespace DataAccess.Domain.Models;

public class PointsCardSetting
{
    public int Id { get; set; }
    public decimal? Minimum { get; set; }
    public decimal? Cost { get; set; }
    public decimal? Expire { get; set; }
    public decimal? NotUseExpire { get; set; }
    public decimal? ReActivePoint { get; set; }
    public decimal? Counts { get; set; }
    public bool? ConverPoint { get; set; }
    public decimal? DestroyPoint { get; set; }
    public bool? Serial { get; set; }
    public decimal? FirstCard { get; set; }
    public Guid Rowguid { get; set; }
}