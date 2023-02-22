namespace DataAccess.Domain.Models;

public partial class UsersResource
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? Module { get; set; }
    public string? Ids { get; set; }
    public string? Strings { get; set; }
    public Guid Rowguid { get; set; }
}
