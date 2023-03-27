namespace DataAccess.Domain.Models;

public class ReportTableDatum
{
    public decimal Id { get; set; }
    public decimal? FileId { get; set; }
    public string? GrpName { get; set; }
    public string? GetTable { get; set; }
    public string? Tablename { get; set; }
    public string? Dealing { get; set; }
    public string? DealingEn { get; set; }
    public string? FileName { get; set; }
    public string? DisplayName { get; set; }
    public string? DisplayNameEn { get; set; }
    public decimal? PrintCopy { get; set; }
    public bool? Isdefault { get; set; }
    public int? Orders { get; set; }
    public string? Type { get; set; }
    public decimal? PaperIndex { get; set; }
    public Guid Rowguid { get; set; }
}