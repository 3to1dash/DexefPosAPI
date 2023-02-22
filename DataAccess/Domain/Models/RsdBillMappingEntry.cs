namespace DataAccess.Domain.Models;

public partial class RsdBillMappingEntry
{
    public int Id { get; set; }
    public int? MappingId { get; set; }
    public int? ItemId { get; set; }
    public string? Code { get; set; }
    public DateTime? ExprDt { get; set; }
    public string? BatchNumber { get; set; }
    public string? Sn { get; set; }
    public string? Error { get; set; }
    public string? ErrorCode { get; set; }
}
