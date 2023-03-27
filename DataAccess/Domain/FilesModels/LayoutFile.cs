namespace DataAccess.Domain.FilesModels;

public class LayoutFile
{
    public int Id { get; set; }

    public int? LayoutId { get; set; }

    public byte[]? DesignFile { get; set; }

    public string? DesignName { get; set; }
}