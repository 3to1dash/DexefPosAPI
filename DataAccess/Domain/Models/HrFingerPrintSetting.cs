namespace DataAccess.Domain.Models;

public class HrFingerPrintSetting
{
    public int Id { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public DateTime? Dt { get; set; }
    public string? Writtenby { get; set; }
    public bool? Active { get; set; }
    public string? ConnectMode { get; set; }
    public string? Ip { get; set; }
    public string? Port { get; set; }
    public string? RsPort { get; set; }
    public string? BaudRate { get; set; }
    public string? Incode { get; set; }
    public string? OutCode { get; set; }
}
