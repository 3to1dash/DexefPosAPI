namespace DataAccess.Domain.Models;

public class UserAttention
{
    public decimal Id { get; set; }
    public string? UserName { get; set; }
    public string? Permission { get; set; }
    public bool? IsShown { get; set; }
    public decimal? Value { get; set; }
    public Guid Rowguid { get; set; }
}