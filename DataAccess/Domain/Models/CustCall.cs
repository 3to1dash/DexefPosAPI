namespace DataAccess.Domain.Models;

public partial class CustCall
{
    public int Id { get; set; }
    public int? CustId { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public string? CallType { get; set; }
    public string? CallNumber { get; set; }
    public string? CallState { get; set; }
    public string? CallReson { get; set; }
    public string? Notes { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}
