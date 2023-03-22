namespace DataAccess.Domain.Models;

public class ShMsgSaleAlarm
{
    public decimal Id { get; set; }
    public decimal? MsgId { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? OutBox { get; set; }
    public decimal? OutMoney { get; set; }
    public decimal? InBox { get; set; }
    public decimal? InMoney { get; set; }
    public DateTime? ShipDue { get; set; }
    public string? MsgName { get; set; }
    public DateTime? Dt { get; set; }
    public bool? IsPaid { get; set; }
    public decimal? RegNum { get; set; }
    public string? BranchName { get; set; }
    public Guid Rowguid { get; set; }
}
