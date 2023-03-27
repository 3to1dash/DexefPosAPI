namespace DataAccess.Domain.Models;

public class UsersLogEntry
{
    public long Id { get; set; }
    public long? LogInId { get; set; }
    public string? UserName { get; set; }
    public DateTime? Dt { get; set; }
    public bool? IsLogIn { get; set; }
    public string? IpAddress { get; set; }
    public string? Pcname { get; set; }
    public string? Location { get; set; }
    public Guid Rowguid { get; set; }
}