namespace DataAccess.Domain.Models;

public class UserDefaultAccount
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? UserName { get; set; }
    public int? StorageId { get; set; }
    public int? BankId { get; set; }
    public int? VisaId { get; set; }
    public int? PledgeId { get; set; }
    public int? StoreId { get; set; }
    public int? ToStoreId { get; set; }
    public string? Currency { get; set; }
}
