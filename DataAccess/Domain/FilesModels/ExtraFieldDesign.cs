namespace DataAccess.Domain.FilesModels;

public class ExtraFieldDesign
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public byte[]? FileContent { get; set; }

    public int? InvTypeId { get; set; }
}