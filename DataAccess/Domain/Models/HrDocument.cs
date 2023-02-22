namespace DataAccess.Domain.Models;

public partial class HrDocument
{
    public decimal Id { get; set; }
    public decimal? WorkId { get; set; }
    public string? Name { get; set; }
    public string? Num { get; set; }
    public DateTime? BeginDt { get; set; }
    public DateTime? EndDt { get; set; }
    public string? Title { get; set; }
    public byte[]? Image { get; set; }
    public Guid Rowguid { get; set; }
}
