namespace DataAccess.Domain.Models;

public partial class PaymentTerm
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PaymentType { get; set; }
    public bool? Active { get; set; }
    public decimal? MinPayment { get; set; }
    public bool? IsMinCash { get; set; }
    public string? DueType { get; set; }
    public int? DueDays { get; set; }
    public decimal? Discount { get; set; }
    public decimal? Profit { get; set; }
    public Guid Rowguid { get; set; }
}
