namespace DataAccess.Domain.Models;

public partial class UserSetting
{
    public decimal Id { get; set; }
    public string? UserName { get; set; }
    public bool? ConfirmSave { get; set; }
    public bool? ConfirmEdit { get; set; }
    public bool? IsSuccessSound { get; set; }
    public bool? IsUpdateSound { get; set; }
    public bool? IsDeleteSound { get; set; }
    public bool? IsExitSound { get; set; }
    public bool? IsErrorSound { get; set; }
    public bool? IsAlarmSound { get; set; }
    public string? SuccessSound { get; set; }
    public string? UpdateSound { get; set; }
    public string? DeleteSound { get; set; }
    public string? ExitSound { get; set; }
    public string? ErrorSound { get; set; }
    public string? AlarmSound { get; set; }
    public byte[]? BackImage { get; set; }
    public bool? PrintAfterSave { get; set; }
    public bool? PreviewAfterSave { get; set; }
    public int? ShowGridSummary { get; set; }
    public int? UseEnterKey { get; set; }
    public Guid Rowguid { get; set; }
}
