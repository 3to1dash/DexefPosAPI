namespace DataAccess.Domain.Models;

public partial class WorkFile
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public string? Name { get; set; }
    public byte[]? MyFile { get; set; }
    public string? Note { get; set; }
    public string? Temp { get; set; }
    public Guid Rowguid { get; set; }
}
