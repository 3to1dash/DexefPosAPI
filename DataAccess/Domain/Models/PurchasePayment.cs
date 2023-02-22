namespace DataAccess.Domain.Models;

public partial class PurchasePayment
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public DateTime? Dt { get; set; }
    public byte? PaymentId { get; set; }
    public int? AccountId { get; set; }
    public string? Name { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Total { get; set; }
    public string? InvoiceCurrency { get; set; }
    public decimal? InvoiceRate { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public string? Dealing { get; set; }
    public decimal? PayTaskId { get; set; }
    public decimal? RecievedMoney { get; set; }
    public decimal? TotalRecievedMoney { get; set; }
    public decimal? RemainMoney { get; set; }
    public decimal? ReturnedMoney { get; set; }
    public Guid Rowguid { get; set; }
}
