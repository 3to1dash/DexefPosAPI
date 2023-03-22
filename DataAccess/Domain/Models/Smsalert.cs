namespace DataAccess.Domain.Models;

public class Smsalert
{
    public int Id { get; set; }
    public int? Smsid { get; set; }
    public string? SettingId { get; set; }
    public decimal? SettingValue { get; set; }
    public string? MessageText { get; set; }
    public bool? ApplicationPolicy { get; set; }
    public bool? SendSetting { get; set; }
    public DateTime? Time { get; set; }
    public int? EverDay { get; set; }
    public string? WeekDay { get; set; }
    public int? SendType { get; set; }
}
