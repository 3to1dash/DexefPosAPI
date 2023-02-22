namespace DataAccess.Domain.Models;

public partial class ShDailyBox
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? CustId { get; set; }
    public string? Dealing { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Price { get; set; }
    public decimal? Rent { get; set; }
    public decimal? MsgId { get; set; }
    public decimal? InBox { get; set; }
    public decimal? InBoxRent { get; set; }
    public decimal? InBoxSum { get; set; }
    public decimal? InTotalBox { get; set; }
    public decimal? InTotalBoxRent { get; set; }
    public decimal? InTotal { get; set; }
    public decimal? OutBox { get; set; }
    public decimal? OutBoxRent { get; set; }
    public decimal? OutBoxSum { get; set; }
    public decimal? OutTotalBox { get; set; }
    public decimal? OutTotalBoxRent { get; set; }
    public decimal? OutTotal { get; set; }
    public decimal? RegNum { get; set; }
    public string? WrittenBy { get; set; }
    public string? Ship { get; set; }
    public string? Note { get; set; }
    public decimal? BillTotal { get; set; }
    public decimal? BillPaid { get; set; }
    public decimal? BillRemain { get; set; }
    public decimal? Branchid { get; set; }
    public string? Type { get; set; }
    public Guid Rowguid { get; set; }
}
