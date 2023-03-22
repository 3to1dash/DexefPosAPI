namespace DataAccess.Domain.Models;

public class CustImage
{
    public decimal Id { get; set; }
    public int? CustId { get; set; }
    public byte[]? Photo { get; set; }
    public Guid Rowguid { get; set; }
}
