namespace DataAccess.Domain.FilesModels;

public class ViewDesign
{
    public long Id { get; set; }

    public string? FrmName { get; set; }

    public string? Dealing { get; set; }

    public string? DesignName { get; set; }

    public byte[]? DesignFile { get; set; }

    public string? WrittenBy { get; set; }

    public string? TableName { get; set; }

    public bool? IsDefault { get; set; }
}