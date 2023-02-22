namespace DataAccess.Domain.Models;

public partial class UserProperty
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public int? Lang { get; set; }
    public int? Color { get; set; }
    public bool? CashFlow { get; set; }
    public bool? SoundError { get; set; }
    public bool? SoundDone { get; set; }
    public bool? SoundAlarm { get; set; }
    public bool? AlarmSave { get; set; }
    public bool? UseEnter { get; set; }
    public bool? IsFake { get; set; }
    public Guid Rowguid { get; set; }
}
