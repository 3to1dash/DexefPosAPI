namespace DataAccess.Domain.Models;

public partial class BatchNumberTransferResult
{
    public int Id { get; set; }
    public int? RowId { get; set; }
    public string? TempSerial { get; set; }
    public decimal? TaskId { get; set; }
    public Guid Rowguid { get; set; }
}
