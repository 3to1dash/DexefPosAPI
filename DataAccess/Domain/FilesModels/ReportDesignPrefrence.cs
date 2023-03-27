namespace DataAccess.Domain.FilesModels;

public class ReportDesignPrefrence
{
    public int Id { get; set; }

    public int? ReportId { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }
}