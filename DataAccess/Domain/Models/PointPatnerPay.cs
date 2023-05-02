namespace DataAccess.Domain.Models;

public class PointPatnerPay
{
    public int Id { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public int? PartnerId { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public decimal? PointsIn { get; set; }
    public decimal? PointsOut { get; set; }
    public decimal? Points { get; set; }
    public int? SliceId { get; set; }
    public decimal? PointsPerMoney { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
}