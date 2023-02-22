namespace DataAccess.Domain.Models;

public partial class UsersLog
{
    public long Id { get; set; }
    public string? UserName { get; set; }
    public bool? LogIn { get; set; }
    public bool? LogOut { get; set; }
    public DateTime? LogInTime { get; set; }
    public DateTime? LogOutTime { get; set; }
    public string? Ipaddress { get; set; }
    public string? Address { get; set; }
    public Guid Rowguid { get; set; }

    public virtual User? UserNameNavigation { get; set; }
}
