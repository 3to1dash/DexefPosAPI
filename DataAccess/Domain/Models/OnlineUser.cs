namespace DataAccess.Domain.Models;

public class OnlineUser
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public decimal? OnlineSupport { get; set; }
    public DateTime? LastLogIn { get; set; }
    public Guid Rowguid { get; set; }
}
