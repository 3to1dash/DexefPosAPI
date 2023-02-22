namespace DataAccess.Domain.Models;

public partial class InvoicesSetting
{
    public int Id { get; set; }
    public int? InvoiceId { get; set; }
    public bool? IsSale { get; set; }
    public string? TranCode { get; set; }
    public bool? IsAdd { get; set; }
}
