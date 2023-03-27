namespace DataAccess.Domain.Models;

public class UserStore
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? StoreId { get; set; }
    public bool? Isread { get; set; }
    public bool? Issearch { get; set; }
    public bool? Isdefault { get; set; }
    public bool? TransferTo { get; set; }
    public Guid Rowguid { get; set; }
}