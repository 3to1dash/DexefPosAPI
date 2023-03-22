namespace DataAccess.Domain.Models;

public class UserPaymentMethod
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? PaymentId { get; set; }
    public bool? IsDefault { get; set; }
    public bool? Deal { get; set; }
    public bool? SearchOnly { get; set; }
    public bool? TransferTo { get; set; }
    public string? ItemType { get; set; }
    public Guid Rowguid { get; set; }
}
