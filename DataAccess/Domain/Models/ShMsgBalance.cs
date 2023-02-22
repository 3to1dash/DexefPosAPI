namespace DataAccess.Domain.Models;

public partial class ShMsgBalance
{
    public decimal Id { get; set; }
    public decimal? MsgId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? Inbox { get; set; }
    public decimal? OutBox { get; set; }
    public decimal? ReturnedBox { get; set; }
    public decimal? MoneySold { get; set; }
    public decimal? MoneyRecieved { get; set; }
    public decimal? InQty { get; set; }
    public decimal? OutQty { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? RegNum { get; set; }
    public string? Name { get; set; }
    public Guid Rowguid { get; set; }
}
