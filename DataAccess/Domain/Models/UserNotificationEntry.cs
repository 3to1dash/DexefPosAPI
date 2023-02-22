namespace DataAccess.Domain.Models;

public partial class UserNotificationEntry
{
    public long Id { get; set; }
    public int? NotificationId { get; set; }
    public string? FiedName { get; set; }
    public string? AlarmType { get; set; }
    public string? EditorType { get; set; }
    public bool? YesNo { get; set; }
    public int? Int { get; set; }
    public decimal? Qty { get; set; }
    public DateTime? Dt { get; set; }
    public bool? IsMulti { get; set; }
    public decimal? SecondQty { get; set; }
    public Guid Rowguid { get; set; }

    public virtual UserNotification? Notification { get; set; }
}
