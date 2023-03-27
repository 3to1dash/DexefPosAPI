namespace DataAccess.Domain.FilesModels;

public class ReportDesign
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? ReportName { get; set; }

    public string? WrittenBy { get; set; }

    public bool? IsParent { get; set; }

    public int? Copies { get; set; }

    public string? Size { get; set; }

    public bool? IsDefault { get; set; }

    public string? Printer { get; set; }

    public byte[]? FileContent { get; set; }

    public DateTime? LstUpdate { get; set; }

    public string? TransactionName { get; set; }

    public string? ReportType { get; set; }

    public int? TemplateId { get; set; }

    public int? GroupId { get; set; }

    public byte[]? FileThumbnail { get; set; }

    public bool? IsSub { get; set; }
}