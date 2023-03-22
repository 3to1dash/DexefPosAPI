namespace DataAccess.Domain.Models;

public class UserDefaultInvoice
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? Name { get; set; }
    public string? Tags { get; set; }
    public int? Value { get; set; }
    public Guid Rowguid { get; set; }
}
