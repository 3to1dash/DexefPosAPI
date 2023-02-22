namespace DataAccess.Domain.Models;

public partial class ReportCenter
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public bool? IsFolder { get; set; }
    public bool? IsManaged { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? TuName { get; set; }
    public string? RuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? CategoryId { get; set; }
    public int? CategoryOrder { get; set; }
    public int? VisibleOrder { get; set; }
    public bool? IsVisible { get; set; }
    public string? TableName { get; set; }
    public string? Tbl { get; set; }
    public string? TblEntry { get; set; }
    public int? Type { get; set; }
    public string? Tags { get; set; }
    public bool? IsDialog { get; set; }
    public string? Frm { get; set; }
    public string? Permission { get; set; }
    public bool? Hidden { get; set; }
}
