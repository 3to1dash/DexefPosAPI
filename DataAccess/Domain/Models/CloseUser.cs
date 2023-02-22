namespace DataAccess.Domain.Models;

public partial class CloseUser
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Branchid { get; set; }
    public decimal? Cpu { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? Value { get; set; }
    public string? Note { get; set; }
    public decimal? Diff { get; set; }
    public decimal? ToStorageId { get; set; }
    public Guid Rowguid { get; set; }
}
