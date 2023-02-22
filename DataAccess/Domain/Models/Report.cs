namespace DataAccess.Domain.Models;

public partial class Report
{
    public int Id { get; set; }
    public bool? IsVisible { get; set; }
    public int? ParentId { get; set; }
    public string? TableName { get; set; }
    public string? Tbl { get; set; }
    public string? TblEntry { get; set; }
    public string? ArName { get; set; }
    public bool? IstopMenu { get; set; }
    public string? GrpId { get; set; }
    public int? GrpOrder { get; set; }
    public int? Type { get; set; }
    public string? Tags { get; set; }
    public bool? IsDialog { get; set; }
    public string? Frm { get; set; }
    public string? Permission { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? TuName { get; set; }
    public string? RuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public int? VisibleIndex { get; set; }
    public bool? IsCtrl { get; set; }
    public bool? IsShift { get; set; }
    public bool? IsAlt { get; set; }
    public string? ShortCut { get; set; }
    public string? Ximage { get; set; }
    public string? Xcolor { get; set; }

    public virtual UserPermission? PermissionNavigation { get; set; }
}
