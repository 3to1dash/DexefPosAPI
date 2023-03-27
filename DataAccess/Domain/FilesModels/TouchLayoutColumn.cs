namespace DataAccess.Domain.FilesModels;

public class TouchLayoutColumn
{
    public int Id { get; set; }

    public string? Tile { get; set; }

    public string? ColName { get; set; }

    public string? PropertyName { get; set; }

    public byte[]? Value { get; set; }
}