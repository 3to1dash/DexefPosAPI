namespace DataAccess.Domain.Models;

public class FixedAssetDailyDeprecateFile
{
    public long Id { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public long? AccountId { get; set; }
    public long? GroupId { get; set; }
    public string? FileType { get; set; }
    public string? OrginalFormat { get; set; }
    public byte[]? ThumImage { get; set; }
    public byte[]? FileContent { get; set; }
    public decimal? TaskId { get; set; }
    public string? Dealing { get; set; }
}
