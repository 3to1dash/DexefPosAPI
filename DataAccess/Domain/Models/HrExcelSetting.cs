namespace DataAccess.Domain.Models;

public class HrExcelSetting
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
    public string? Writtenby { get; set; }
    public DateTime? Dt { get; set; }
    public bool? Active { get; set; }
    public bool? IsDefault { get; set; }
    public string? ColEmpNum { get; set; }
    public string? ColDt { get; set; }
    public string? ColDealing { get; set; }
    public string? InCode { get; set; }
    public string? OutCode { get; set; }
}