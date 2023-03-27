namespace DataAccess.Domain.FilesModels;

public class ReportTemplate
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? IsDefault { get; set; }

    public bool? ForAllUsers { get; set; }

    public string? WrittenBy { get; set; }

    public int? ItemsCount { get; set; }
}