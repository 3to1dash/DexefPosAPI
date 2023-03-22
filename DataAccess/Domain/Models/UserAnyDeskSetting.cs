namespace DataAccess.Domain.Models;

public class UserAnyDeskSetting
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public string? Ip { get; set; }
    public string? Password { get; set; }

    public virtual User? UserNameNavigation { get; set; }
}
