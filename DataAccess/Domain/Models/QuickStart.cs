namespace DataAccess.Domain.Models;

public partial class QuickStart
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string? AppName { get; set; }
    public string? ArName { get; set; }
    public string? ArDesc { get; set; }
    public string? Assembly { get; set; }
    public string? Frm { get; set; }
    public bool? IsCtl { get; set; }
    public bool IssearchCtrl { get; set; }
    public string? FrmSearch { get; set; }
    public int? VisibleOrder { get; set; }
    public bool? Done { get; set; }
    public string? Tags { get; set; }
    public string? Permission { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
}
