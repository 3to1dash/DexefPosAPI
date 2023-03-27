namespace DataAccess.Domain.Models;

public class EticketUser
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? Name { get; set; }
    public string? WorkInCompany { get; set; }
    public string? ProvidorName { get; set; }
    public int? BranchId { get; set; }
    public int? ProvidorId { get; set; }
}