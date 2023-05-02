namespace DataAccess.Domain.FilesModels;

public class TouchLayout
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public byte[]? FileContent { get; set; }

    public byte[]? Tiles { get; set; }

    public bool? IsDefault { get; set; }
}