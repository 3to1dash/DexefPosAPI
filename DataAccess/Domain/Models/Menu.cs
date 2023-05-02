namespace DataAccess.Domain.Models;

public class Menu
{
    public int Id { get; set; }
    public bool? ShowSeperate { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? Frm { get; set; }
    public string? Assembly { get; set; }
    public string? Tags { get; set; }
    public string? Permission { get; set; }
    public bool? IsDialog { get; set; }
    public bool? IsSearch { get; set; }
    public bool? Isexternal { get; set; }
    public string? ReFrm { get; set; }
    public bool? IsVisible { get; set; }
    public bool? IsParent { get; set; }
    public int? ParentId { get; set; }
    public int? VisibleIndex { get; set; }
    public bool? IsRtl { get; set; }
    public bool? IsiconOnly { get; set; }
    public string? FrName { get; set; }
    public string? TuName { get; set; }
    public string? RuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public bool? IsRpt { get; set; }
    public string? Xcolor { get; set; }
    public string? Ximage { get; set; }
    public int? Xsize { get; set; }
    public bool? IsCtrl { get; set; }
    public bool? IsShift { get; set; }
    public bool? IsAlt { get; set; }
    public string? ShortCut { get; set; }
    public string? HelpLink { get; set; }
    public bool? AppVisible { get; set; }
    public int? Width { get; set; }
    public string? UrName { get; set; }

    public virtual UserPermission? PermissionNavigation { get; set; }
}