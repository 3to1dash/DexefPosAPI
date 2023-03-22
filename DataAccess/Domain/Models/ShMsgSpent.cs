namespace DataAccess.Domain.Models;

public class ShMsgSpent
{
    public decimal Id { get; set; }
    public decimal? MsgId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Value { get; set; }
    public decimal? RegNum { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? Ship { get; set; }
    public string? MsgName { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
