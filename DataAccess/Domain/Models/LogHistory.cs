namespace DataAccess.Domain.Models;

public class LogHistory
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public bool? LogIn { get; set; }
    public bool? LogOut { get; set; }
    public DateTime? Dt { get; set; }
    public Guid Rowguid { get; set; }
}