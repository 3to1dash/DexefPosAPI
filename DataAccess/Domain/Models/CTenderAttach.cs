namespace DataAccess.Domain.Models;

public class CTenderAttach
{
    public decimal Id { get; set; }
    public decimal? TenderId { get; set; }
    public string? Folder { get; set; }
    public string? FileId { get; set; }
    public Guid Rowguid { get; set; }
}