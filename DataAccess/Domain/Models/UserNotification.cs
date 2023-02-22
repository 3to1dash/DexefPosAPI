namespace DataAccess.Domain.Models;

public partial class UserNotification
{
    public UserNotification()
    {
        UserNotificationEntries = new HashSet<UserNotificationEntry>();
        Users = new HashSet<User>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? UseStores { get; set; }
    public bool? UseCust { get; set; }
    public bool? UsePurchase { get; set; }
    public bool? UseSale { get; set; }
    public bool? UseAccounts { get; set; }
    public bool? UseHr { get; set; }
    public Guid Rowguid { get; set; }

    public virtual ICollection<UserNotificationEntry> UserNotificationEntries { get; set; }
    public virtual ICollection<User> Users { get; set; }
}
